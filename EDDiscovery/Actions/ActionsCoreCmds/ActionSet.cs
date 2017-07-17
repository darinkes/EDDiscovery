﻿/*
 * Copyright © 2017 EDDiscovery development team
 *
 * Licensed under the Apache License, Version 2.0 (the "License"); you may not use this
 * file except in compliance with the License. You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 * 
 * Unless required by applicable law or agreed to in writing, software distributed under
 * the License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF
 * ANY KIND, either express or implied. See the License for the specific language
 * governing permissions and limitations under the License.
 * 
 * EDDiscovery is not affiliated with Frontier Developments plc.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDDiscovery.Actions
{
    public class ActionSetLetBase : Action
    {
        protected bool FromString(string ud, out ConditionVariables vars, out Dictionary<string, string> operations)
        {
            vars = new ConditionVariables();
            operations = new Dictionary<string, string>();
            StringParser p = new StringParser(ud);
            return vars.FromString(p, ConditionVariables.FromMode.MultiEntryComma, altops:operations);
        }

        protected string ToString(ConditionVariables vars, Dictionary<string, string> operations)
        {
            return vars.ToString(operations, " ");
        }

        public bool ConfigurationMenu(Form parent, EDDiscoveryForm discoveryform, List<string> eventvars, bool allowaddv , bool allownoexpandv)
        {
            ConditionVariables av;
            Dictionary<string, string> operations;
            FromString(userdata, out av, out operations);

            ConditionVariablesForm avf = new ConditionVariablesForm();
            avf.Init("Variable list:", discoveryform.theme, av, showone: true, allowadd: allowaddv, allownoexpand: allownoexpandv, altops:operations);

            if (avf.ShowDialog(parent.FindForm()) == DialogResult.OK)
            {
                userdata = ToString(avf.result,avf.result_altops);
                return true;
            }
            else
                return false;
        }

        public override string VerifyActionCorrect()
        {
            ConditionVariables av;
            Dictionary<string, string> operations;
            bool ok = FromString(userdata, out av ,out operations);

            System.Diagnostics.Debug.Assert(ok == false || operations.Count == av.Count);

            if ( ok )
                userdata = ToString(av,operations);        // normalise them..

            return ok ? null : "Variable command not in correct format";
        }


        ConditionVariables av;
        Dictionary<string, string> operations;

        public bool ExecuteAction(ActionProgramRun ap, bool setit, bool globalit =false, bool persistentit =false, bool staticit = false )
        {
            if (av == null)
                FromString(userdata, out av, out operations);

            foreach (string key in av.NameEnumuerable)
            {
                string keyname = key;

                if (keyname.Contains("%"))
                {
                    if (ap.functions.ExpandString(key, out keyname) == ConditionFunctions.ExpandResult.Failed)
                    {
                        ap.ReportError(keyname);
                        break;
                    }
                }

                string res;

                if (operations[key].Contains("$"))
                    res = av[key];
                else if (ap.functions.ExpandString(av[key], out res) == ConditionFunctions.ExpandResult.Failed)       //Expand out.. and if no errors
                {
                    ap.ReportError(res);
                    break;
                }

                if (setit)
                {
                    if (operations[key].Contains("+") && ap.VarExist(keyname))
                        res = ap[keyname] + res;
                }
                else
                {
                    if (!res.Eval(out res))
                    {
                        ap.ReportError("Let " + res);
                        break;
                    }
                }

                //System.Diagnostics.Debug.WriteLine("Var " + keyname + "=" + res + "  :" + globalit + ":" + persistentit);
                ap[keyname] = res;

                if (globalit)
                    ap.actioncontroller.SetNonPersistentGlobal(keyname, res);

                if (persistentit )
                    ap.actioncontroller.SetPeristentGlobal(keyname, res);

                if (staticit )
                    ap.actionfile.SetFileVariable(keyname, res);
            }

            if (av.Count == 0)
                ap.ReportError("No variable name given in variable assignment");

            return true;
        }
    }

    public class ActionSet : ActionSetLetBase
    {
        public override bool ConfigurationMenu(Form parent, EDDiscoveryForm discoveryform, List<string> eventvars)
        {
            return base.ConfigurationMenu(parent, discoveryform, eventvars, true, true);
        }

        public override bool ExecuteAction(ActionProgramRun ap)
        {
            return ExecuteAction(ap, true);
        }
    }

    public class ActionGlobal : ActionSetLetBase
    {
        public override bool ConfigurationMenu(Form parent, EDDiscoveryForm discoveryform, List<string> eventvars)
        {
            return base.ConfigurationMenu(parent, discoveryform, eventvars, true, true);
        }

        public override bool ExecuteAction(ActionProgramRun ap)
        {
            return ExecuteAction(ap, true, globalit:true);
        }
    }

    public class ActionLet : ActionSetLetBase
    {
        public override bool ConfigurationMenu(Form parent, EDDiscoveryForm discoveryform, List<string> eventvars)
        {
            return base.ConfigurationMenu(parent, discoveryform, eventvars, false, true);
        }

        public override bool ExecuteAction(ActionProgramRun ap)
        {
            return ExecuteAction(ap, false);
        }
    }

    public class ActionGlobalLet : ActionSetLetBase
    {
        public override bool ConfigurationMenu(Form parent, EDDiscoveryForm discoveryform, List<string> eventvars)
        {
            return base.ConfigurationMenu(parent, discoveryform, eventvars, false, true);
        }

        public override bool ExecuteAction(ActionProgramRun ap)
        {
            return ExecuteAction(ap, false, globalit:true);
        }
    }

    public class ActionPersistentGlobal : ActionSetLetBase
    {
        public override bool ConfigurationMenu(Form parent, EDDiscoveryForm discoveryform, List<string> eventvars)
        {
            return base.ConfigurationMenu(parent, discoveryform, eventvars, true, true);
        }

        public override bool ExecuteAction(ActionProgramRun ap)
        {
            return ExecuteAction(ap, true, persistentit: true);
        }
    }

    public class ActionStatic : ActionSetLetBase
    {
        public override bool ConfigurationMenu(Form parent, EDDiscoveryForm discoveryform, List<string> eventvars)
        {
            return base.ConfigurationMenu(parent, discoveryform, eventvars, true, true);
        }

        public override bool ExecuteAction(ActionProgramRun ap)
        {
            return ExecuteAction(ap, true, staticit: true);
        }
    }

    public class ActionDeleteVariable: Action
    {
        public override bool AllowDirectEditingOfUserData { get { return true; } }

        public override bool ConfigurationMenu(Form parent, EDDiscoveryForm discoveryform, List<string> eventvars)
        {
            string promptValue = Forms.PromptSingleLine.ShowDialog(parent, "Variable name", UserData, "Configure DeleteVariable Command");
            if (promptValue != null)
            {
                userdata = promptValue;
            }

            return (promptValue != null);
        }

        public override bool ExecuteAction(ActionProgramRun ap)
        {
            string res;
            if (ap.functions.ExpandString(UserData,  out res) != ConditionFunctions.ExpandResult.Failed)
            {
                StringParser p = new StringParser(res);

                string v;
                while ((v = p.NextWord(", ")) != null)
                {
                    ap.actioncontroller.DeleteVariable(v);
                    ap.actionfile.DeleteFileVariable(v);
                    ap.DeleteVar(v);
                    p.IsCharMoveOn(',');
                }
            }
            else
                ap.ReportError(res);

            return true;
        }
    }

    public class ActionExpr: Action
    {
        public override bool AllowDirectEditingOfUserData { get { return true; } }

        public override bool ConfigurationMenu(Form parent, EDDiscoveryForm discoveryform, List<string> eventvars)
        {
            string promptValue = Forms.PromptSingleLine.ShowDialog(parent, "Expression", UserData, "Configure Function Expression");
            if (promptValue != null)
            {
                userdata = promptValue;
            }

            return (promptValue != null);
        }

        public override bool ExecuteAction(ActionProgramRun ap)
        {
            string res;
            if (ap.functions.ExpandString(UserData, out res) != ConditionFunctions.ExpandResult.Failed)
            {
                ap["Result"] = res;
            }
            else
                ap.ReportError(res);

            return true;
        }
    }
}