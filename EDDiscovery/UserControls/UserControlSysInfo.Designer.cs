﻿/*
 * Copyright © 2016 - 2017 EDDiscovery development team
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
namespace EDDiscovery.UserControls
{
    partial class UserControlSysInfo
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripNotes = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxBody = new ExtendedControls.TextBoxBorder();
            this.labelBodyName = new System.Windows.Forms.Label();
            this.textBoxX = new ExtendedControls.TextBoxBorder();
            this.textBoxY = new ExtendedControls.TextBoxBorder();
            this.labelX = new System.Windows.Forms.Label();
            this.labelY = new System.Windows.Forms.Label();
            this.textBoxZ = new ExtendedControls.TextBoxBorder();
            this.label_Z = new System.Windows.Forms.Label();
            this.textBoxVisits = new ExtendedControls.TextBoxBorder();
            this.labelVisits = new System.Windows.Forms.Label();
            this.labelAllegiance = new System.Windows.Forms.Label();
            this.labelEconomy = new System.Windows.Forms.Label();
            this.textBoxAllegiance = new ExtendedControls.TextBoxBorder();
            this.textBoxGovernment = new ExtendedControls.TextBoxBorder();
            this.labelGov = new System.Windows.Forms.Label();
            this.labelState = new System.Windows.Forms.Label();
            this.textBoxEconomy = new ExtendedControls.TextBoxBorder();
            this.textBoxState = new ExtendedControls.TextBoxBorder();
            this.buttonEDDB = new ExtendedControls.DrawnPanel();
            this.buttonRoss = new ExtendedControls.DrawnPanel();
            this.textBoxHomeDist = new ExtendedControls.TextBoxBorder();
            this.labelHomeSystem = new System.Windows.Forms.Label();
            this.buttonEDSM = new ExtendedControls.DrawnPanel();
            this.textBoxSolDist = new ExtendedControls.TextBoxBorder();
            this.labelSolDist = new System.Windows.Forms.Label();
            this.toolTipEddb = new System.Windows.Forms.ToolTip(this.components);
            this.labelNote = new System.Windows.Forms.Label();
            this.richTextBoxNote = new ExtendedControls.RichTextBoxScroll();
            this.labelTarget = new System.Windows.Forms.Label();
            this.buttonEDSMTarget = new ExtendedControls.DrawnPanel();
            this.textBoxTarget = new ExtendedControls.AutoCompleteTextBox();
            this.textBoxTargetDist = new ExtendedControls.TextBoxBorder();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.textBoxSystem = new ExtendedControls.TextBoxBorder();
            this.labelSysName = new System.Windows.Forms.Label();
            this.toolStripBody = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSystem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTarget = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripEDSMDownLine = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripEDSM = new System.Windows.Forms.ToolStripMenuItem();
            this.labelOpen = new System.Windows.Forms.Label();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSystem,
            this.toolStripBody,
            this.toolStripNotes,
            this.toolStripTarget,
            this.toolStripEDSM,
            this.toolStripEDSMDownLine});
            this.contextMenuStrip.Name = "contextMenuStrip1";
            this.contextMenuStrip.Size = new System.Drawing.Size(236, 136);
            // 
            // toolStripNotes
            // 
            this.toolStripNotes.Checked = true;
            this.toolStripNotes.CheckOnClick = true;
            this.toolStripNotes.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripNotes.Name = "toolStripNotes";
            this.toolStripNotes.Size = new System.Drawing.Size(235, 22);
            this.toolStripNotes.Text = "Enable Notes";
            this.toolStripNotes.Click += new System.EventHandler(this.toolStripNotes_Click);
            // 
            // textBoxBody
            // 
            this.textBoxBody.BorderColor = System.Drawing.Color.Transparent;
            this.textBoxBody.BorderColorScaling = 0.5F;
            this.textBoxBody.Location = new System.Drawing.Point(52, 51);
            this.textBoxBody.Name = "textBoxBody";
            this.textBoxBody.ReadOnly = true;
            this.textBoxBody.Size = new System.Drawing.Size(152, 20);
            this.textBoxBody.TabIndex = 3;
            this.textBoxBody.TabStop = false;
            // 
            // labelBodyName
            // 
            this.labelBodyName.AutoSize = true;
            this.labelBodyName.Location = new System.Drawing.Point(3, 53);
            this.labelBodyName.Name = "labelBodyName";
            this.labelBodyName.Size = new System.Drawing.Size(31, 13);
            this.labelBodyName.TabIndex = 3;
            this.labelBodyName.Text = "Body";
            // 
            // textBoxX
            // 
            this.textBoxX.BorderColor = System.Drawing.Color.Transparent;
            this.textBoxX.BorderColorScaling = 0.5F;
            this.textBoxX.Location = new System.Drawing.Point(52, 75);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.ReadOnly = true;
            this.textBoxX.Size = new System.Drawing.Size(67, 20);
            this.textBoxX.TabIndex = 8;
            this.textBoxX.TabStop = false;
            // 
            // textBoxY
            // 
            this.textBoxY.BorderColor = System.Drawing.Color.Transparent;
            this.textBoxY.BorderColorScaling = 0.5F;
            this.textBoxY.Location = new System.Drawing.Point(52, 93);
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.ReadOnly = true;
            this.textBoxY.Size = new System.Drawing.Size(67, 20);
            this.textBoxY.TabIndex = 12;
            this.textBoxY.TabStop = false;
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Location = new System.Drawing.Point(32, 75);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(14, 13);
            this.labelX.TabIndex = 7;
            this.labelX.Text = "X";
            this.labelX.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelY
            // 
            this.labelY.AutoSize = true;
            this.labelY.ForeColor = System.Drawing.Color.Black;
            this.labelY.Location = new System.Drawing.Point(32, 93);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(14, 13);
            this.labelY.TabIndex = 11;
            this.labelY.Text = "Y";
            this.labelY.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBoxZ
            // 
            this.textBoxZ.BorderColor = System.Drawing.Color.Transparent;
            this.textBoxZ.BorderColorScaling = 0.5F;
            this.textBoxZ.Location = new System.Drawing.Point(52, 111);
            this.textBoxZ.Name = "textBoxZ";
            this.textBoxZ.ReadOnly = true;
            this.textBoxZ.Size = new System.Drawing.Size(67, 20);
            this.textBoxZ.TabIndex = 0;
            this.textBoxZ.TabStop = false;
            // 
            // label_Z
            // 
            this.label_Z.AutoSize = true;
            this.label_Z.Location = new System.Drawing.Point(32, 111);
            this.label_Z.Name = "label_Z";
            this.label_Z.Size = new System.Drawing.Size(14, 13);
            this.label_Z.TabIndex = 19;
            this.label_Z.Text = "Z";
            this.label_Z.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBoxVisits
            // 
            this.textBoxVisits.BorderColor = System.Drawing.Color.Transparent;
            this.textBoxVisits.BorderColorScaling = 0.5F;
            this.textBoxVisits.Location = new System.Drawing.Point(188, 75);
            this.textBoxVisits.Name = "textBoxVisits";
            this.textBoxVisits.ReadOnly = true;
            this.textBoxVisits.Size = new System.Drawing.Size(66, 20);
            this.textBoxVisits.TabIndex = 10;
            this.textBoxVisits.TabStop = false;
            // 
            // labelVisits
            // 
            this.labelVisits.AutoSize = true;
            this.labelVisits.Location = new System.Drawing.Point(147, 75);
            this.labelVisits.Name = "labelVisits";
            this.labelVisits.Size = new System.Drawing.Size(31, 13);
            this.labelVisits.TabIndex = 9;
            this.labelVisits.Text = "Visits";
            this.labelVisits.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelAllegiance
            // 
            this.labelAllegiance.AutoSize = true;
            this.labelAllegiance.Location = new System.Drawing.Point(122, 93);
            this.labelAllegiance.Name = "labelAllegiance";
            this.labelAllegiance.Size = new System.Drawing.Size(56, 13);
            this.labelAllegiance.TabIndex = 13;
            this.labelAllegiance.Text = "Allegiance";
            this.labelAllegiance.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelEconomy
            // 
            this.labelEconomy.AutoSize = true;
            this.labelEconomy.Location = new System.Drawing.Point(127, 111);
            this.labelEconomy.Name = "labelEconomy";
            this.labelEconomy.Size = new System.Drawing.Size(51, 13);
            this.labelEconomy.TabIndex = 34;
            this.labelEconomy.Text = "Economy";
            this.labelEconomy.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBoxAllegiance
            // 
            this.textBoxAllegiance.BorderColor = System.Drawing.Color.Transparent;
            this.textBoxAllegiance.BorderColorScaling = 0.5F;
            this.textBoxAllegiance.Location = new System.Drawing.Point(188, 93);
            this.textBoxAllegiance.Name = "textBoxAllegiance";
            this.textBoxAllegiance.ReadOnly = true;
            this.textBoxAllegiance.Size = new System.Drawing.Size(66, 20);
            this.textBoxAllegiance.TabIndex = 14;
            this.textBoxAllegiance.TabStop = false;
            // 
            // textBoxGovernment
            // 
            this.textBoxGovernment.BorderColor = System.Drawing.Color.Transparent;
            this.textBoxGovernment.BorderColorScaling = 0.5F;
            this.textBoxGovernment.Location = new System.Drawing.Point(188, 147);
            this.textBoxGovernment.Name = "textBoxGovernment";
            this.textBoxGovernment.ReadOnly = true;
            this.textBoxGovernment.Size = new System.Drawing.Size(66, 20);
            this.textBoxGovernment.TabIndex = 35;
            this.textBoxGovernment.TabStop = false;
            // 
            // labelGov
            // 
            this.labelGov.AutoSize = true;
            this.labelGov.Location = new System.Drawing.Point(151, 147);
            this.labelGov.Name = "labelGov";
            this.labelGov.Size = new System.Drawing.Size(27, 13);
            this.labelGov.TabIndex = 36;
            this.labelGov.Text = "Gov";
            this.labelGov.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelState
            // 
            this.labelState.AutoSize = true;
            this.labelState.Location = new System.Drawing.Point(146, 129);
            this.labelState.Name = "labelState";
            this.labelState.Size = new System.Drawing.Size(32, 13);
            this.labelState.TabIndex = 38;
            this.labelState.Text = "State";
            this.labelState.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBoxEconomy
            // 
            this.textBoxEconomy.BorderColor = System.Drawing.Color.Transparent;
            this.textBoxEconomy.BorderColorScaling = 0.5F;
            this.textBoxEconomy.Location = new System.Drawing.Point(188, 111);
            this.textBoxEconomy.Name = "textBoxEconomy";
            this.textBoxEconomy.ReadOnly = true;
            this.textBoxEconomy.Size = new System.Drawing.Size(66, 20);
            this.textBoxEconomy.TabIndex = 33;
            this.textBoxEconomy.TabStop = false;
            // 
            // textBoxState
            // 
            this.textBoxState.BorderColor = System.Drawing.Color.Transparent;
            this.textBoxState.BorderColorScaling = 0.5F;
            this.textBoxState.Location = new System.Drawing.Point(188, 129);
            this.textBoxState.Name = "textBoxState";
            this.textBoxState.ReadOnly = true;
            this.textBoxState.Size = new System.Drawing.Size(66, 20);
            this.textBoxState.TabIndex = 37;
            this.textBoxState.TabStop = false;
            // 
            // buttonEDDB
            // 
            this.buttonEDDB.BackColor = System.Drawing.SystemColors.Control;
            this.buttonEDDB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEDDB.DrawnImage = null;
            this.buttonEDDB.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonEDDB.ImageSelected = ExtendedControls.DrawnPanel.ImageType.EDDB;
            this.buttonEDDB.ImageText = null;
            this.buttonEDDB.Location = new System.Drawing.Point(97, 27);
            this.buttonEDDB.MarginSize = 0;
            this.buttonEDDB.MouseOverColor = System.Drawing.Color.White;
            this.buttonEDDB.MouseSelectedColor = System.Drawing.Color.Green;
            this.buttonEDDB.MouseSelectedColorEnable = true;
            this.buttonEDDB.Name = "buttonEDDB";
            this.buttonEDDB.Size = new System.Drawing.Size(20, 20);
            this.buttonEDDB.TabIndex = 5;
            this.toolTipEddb.SetToolTip(this.buttonEDDB, "Click to show system in EDDB");
            this.buttonEDDB.Click += new System.EventHandler(this.buttonEDDB_Click);
            // 
            // buttonRoss
            // 
            this.buttonRoss.BackColor = System.Drawing.SystemColors.ControlText;
            this.buttonRoss.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRoss.DrawnImage = null;
            this.buttonRoss.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonRoss.ImageSelected = ExtendedControls.DrawnPanel.ImageType.Ross;
            this.buttonRoss.ImageText = null;
            this.buttonRoss.Location = new System.Drawing.Point(120, 27);
            this.buttonRoss.MarginSize = 0;
            this.buttonRoss.MouseOverColor = System.Drawing.Color.White;
            this.buttonRoss.MouseSelectedColor = System.Drawing.Color.Green;
            this.buttonRoss.MouseSelectedColorEnable = true;
            this.buttonRoss.Name = "buttonRoss";
            this.buttonRoss.Size = new System.Drawing.Size(20, 20);
            this.buttonRoss.TabIndex = 6;
            this.toolTipEddb.SetToolTip(this.buttonRoss, "Click to edit system in Ross");
            this.buttonRoss.Click += new System.EventHandler(this.buttonRoss_Click);
            // 
            // textBoxHomeDist
            // 
            this.textBoxHomeDist.BorderColor = System.Drawing.Color.Transparent;
            this.textBoxHomeDist.BorderColorScaling = 0.5F;
            this.textBoxHomeDist.Location = new System.Drawing.Point(52, 129);
            this.textBoxHomeDist.Name = "textBoxHomeDist";
            this.textBoxHomeDist.ReadOnly = true;
            this.textBoxHomeDist.Size = new System.Drawing.Size(67, 20);
            this.textBoxHomeDist.TabIndex = 42;
            this.textBoxHomeDist.TabStop = false;
            this.toolTipEddb.SetToolTip(this.textBoxHomeDist, "Distance to home system");
            // 
            // labelHomeSystem
            // 
            this.labelHomeSystem.AutoSize = true;
            this.labelHomeSystem.Location = new System.Drawing.Point(3, 129);
            this.labelHomeSystem.Name = "labelHomeSystem";
            this.labelHomeSystem.Size = new System.Drawing.Size(35, 13);
            this.labelHomeSystem.TabIndex = 43;
            this.labelHomeSystem.Text = "Home";
            this.labelHomeSystem.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // buttonEDSM
            // 
            this.buttonEDSM.DrawnImage = null;
            this.buttonEDSM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEDSM.ImageSelected = ExtendedControls.DrawnPanel.ImageType.InverseText;
            this.buttonEDSM.ImageText = "EDSM";
            this.buttonEDSM.Location = new System.Drawing.Point(53, 27);
            this.buttonEDSM.MarginSize = 0;
            this.buttonEDSM.MouseOverColor = System.Drawing.Color.White;
            this.buttonEDSM.MouseSelectedColor = System.Drawing.Color.Green;
            this.buttonEDSM.MouseSelectedColorEnable = true;
            this.buttonEDSM.Name = "buttonEDSM";
            this.buttonEDSM.Size = new System.Drawing.Size(44, 20);
            this.buttonEDSM.TabIndex = 4;
            this.toolTipEddb.SetToolTip(this.buttonEDSM, "Click to show system on EDSM");
            this.buttonEDSM.Click += new System.EventHandler(this.buttonEDSM_Click);
            // 
            // textBoxSolDist
            // 
            this.textBoxSolDist.BorderColor = System.Drawing.Color.Transparent;
            this.textBoxSolDist.BorderColorScaling = 0.5F;
            this.textBoxSolDist.Location = new System.Drawing.Point(52, 147);
            this.textBoxSolDist.Name = "textBoxSolDist";
            this.textBoxSolDist.ReadOnly = true;
            this.textBoxSolDist.Size = new System.Drawing.Size(67, 20);
            this.textBoxSolDist.TabIndex = 44;
            this.textBoxSolDist.TabStop = false;
            this.toolTipEddb.SetToolTip(this.textBoxSolDist, "Distance to Sol");
            // 
            // labelSolDist
            // 
            this.labelSolDist.AutoSize = true;
            this.labelSolDist.Location = new System.Drawing.Point(4, 147);
            this.labelSolDist.Name = "labelSolDist";
            this.labelSolDist.Size = new System.Drawing.Size(22, 13);
            this.labelSolDist.TabIndex = 45;
            this.labelSolDist.Text = "Sol";
            this.labelSolDist.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // toolTipEddb
            // 
            this.toolTipEddb.ShowAlways = true;
            // 
            // labelNote
            // 
            this.labelNote.AutoSize = true;
            this.labelNote.Location = new System.Drawing.Point(3, 175);
            this.labelNote.Name = "labelNote";
            this.labelNote.Size = new System.Drawing.Size(30, 13);
            this.labelNote.TabIndex = 28;
            this.labelNote.Text = "Note";
            this.toolTipEddb.SetToolTip(this.labelNote, "Enter a note against the currently selected entry");
            // 
            // richTextBoxNote
            // 
            this.richTextBoxNote.BorderColor = System.Drawing.Color.Transparent;
            this.richTextBoxNote.BorderColorScaling = 0.5F;
            this.richTextBoxNote.HideScrollBar = true;
            this.richTextBoxNote.Location = new System.Drawing.Point(52, 175);
            this.richTextBoxNote.Name = "richTextBoxNote";
            this.richTextBoxNote.ScrollBarWidth = 20;
            this.richTextBoxNote.ShowLineCount = false;
            this.richTextBoxNote.Size = new System.Drawing.Size(277, 50);
            this.richTextBoxNote.TabIndex = 0;
            this.richTextBoxNote.TextBoxChanged += new ExtendedControls.RichTextBoxScroll.OnTextBoxChanged(this.richTextBoxNote_TextBoxChanged);
            this.richTextBoxNote.Leave += new System.EventHandler(this.richTextBoxNote_Leave);
            // 
            // labelTarget
            // 
            this.labelTarget.AutoSize = true;
            this.labelTarget.Location = new System.Drawing.Point(2, 238);
            this.labelTarget.Name = "labelTarget";
            this.labelTarget.Size = new System.Drawing.Size(38, 13);
            this.labelTarget.TabIndex = 16;
            this.labelTarget.Text = "Target";
            // 
            // buttonEDSMTarget
            // 
            this.buttonEDSMTarget.DrawnImage = null;
            this.buttonEDSMTarget.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEDSMTarget.ImageSelected = ExtendedControls.DrawnPanel.ImageType.InverseText;
            this.buttonEDSMTarget.ImageText = "EDSM";
            this.buttonEDSMTarget.Location = new System.Drawing.Point(278, 235);
            this.buttonEDSMTarget.MarginSize = 0;
            this.buttonEDSMTarget.MouseOverColor = System.Drawing.Color.White;
            this.buttonEDSMTarget.MouseSelectedColor = System.Drawing.Color.Green;
            this.buttonEDSMTarget.MouseSelectedColorEnable = true;
            this.buttonEDSMTarget.Name = "buttonEDSMTarget";
            this.buttonEDSMTarget.Size = new System.Drawing.Size(44, 20);
            this.buttonEDSMTarget.TabIndex = 23;
            this.buttonEDSMTarget.Click += new System.EventHandler(this.buttonEDSMTarget_Click);
            // 
            // textBoxTarget
            // 
            this.textBoxTarget.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBoxTarget.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxTarget.BorderColor = System.Drawing.Color.Transparent;
            this.textBoxTarget.BorderColorScaling = 0.5F;
            this.textBoxTarget.DropDownBackgroundColor = System.Drawing.Color.Gray;
            this.textBoxTarget.DropDownBorderColor = System.Drawing.Color.Green;
            this.textBoxTarget.DropDownHeight = 200;
            this.textBoxTarget.DropDownItemHeight = 20;
            this.textBoxTarget.DropDownMouseOverBackgroundColor = System.Drawing.Color.Red;
            this.textBoxTarget.DropDownScrollBarButtonColor = System.Drawing.Color.LightGray;
            this.textBoxTarget.DropDownScrollBarColor = System.Drawing.Color.LightGray;
            this.textBoxTarget.DropDownWidth = 0;
            this.textBoxTarget.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.textBoxTarget.Location = new System.Drawing.Point(53, 235);
            this.textBoxTarget.Name = "textBoxTarget";
            this.textBoxTarget.Size = new System.Drawing.Size(151, 20);
            this.textBoxTarget.TabIndex = 15;
            this.textBoxTarget.TabStop = false;
            this.toolTip1.SetToolTip(this.textBoxTarget, "Sets the target");
            this.textBoxTarget.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxTarget_KeyUp);
            // 
            // textBoxTargetDist
            // 
            this.textBoxTargetDist.BorderColor = System.Drawing.Color.Transparent;
            this.textBoxTargetDist.BorderColorScaling = 0.5F;
            this.textBoxTargetDist.Location = new System.Drawing.Point(210, 235);
            this.textBoxTargetDist.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.textBoxTargetDist.Name = "textBoxTargetDist";
            this.textBoxTargetDist.ReadOnly = true;
            this.textBoxTargetDist.Size = new System.Drawing.Size(62, 20);
            this.textBoxTargetDist.TabIndex = 15;
            this.textBoxTargetDist.TabStop = false;
            this.toolTip1.SetToolTip(this.textBoxTargetDist, "Distance to target");
            // 
            // toolTip1
            // 
            this.toolTip1.ShowAlways = true;
            // 
            // textBoxSystem
            // 
            this.textBoxSystem.BorderColor = System.Drawing.Color.Transparent;
            this.textBoxSystem.BorderColorScaling = 0.5F;
            this.textBoxSystem.Location = new System.Drawing.Point(52, 3);
            this.textBoxSystem.Name = "textBoxSystem";
            this.textBoxSystem.ReadOnly = true;
            this.textBoxSystem.Size = new System.Drawing.Size(152, 20);
            this.textBoxSystem.TabIndex = 1;
            this.textBoxSystem.TabStop = false;
            // 
            // labelSysName
            // 
            this.labelSysName.AutoSize = true;
            this.labelSysName.Location = new System.Drawing.Point(4, 6);
            this.labelSysName.Name = "labelSysName";
            this.labelSysName.Size = new System.Drawing.Size(41, 13);
            this.labelSysName.TabIndex = 4;
            this.labelSysName.Text = "System";
            // 
            // toolStripBody
            // 
            this.toolStripBody.Checked = true;
            this.toolStripBody.CheckOnClick = true;
            this.toolStripBody.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripBody.Name = "toolStripBody";
            this.toolStripBody.Size = new System.Drawing.Size(235, 22);
            this.toolStripBody.Text = "Enable Body Name";
            this.toolStripBody.Click += new System.EventHandler(this.toolStripBody_Click);
            // 
            // toolStripSystem
            // 
            this.toolStripSystem.Checked = true;
            this.toolStripSystem.CheckOnClick = true;
            this.toolStripSystem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripSystem.Name = "toolStripSystem";
            this.toolStripSystem.Size = new System.Drawing.Size(235, 22);
            this.toolStripSystem.Text = "Enable System Name";
            this.toolStripSystem.Click += new System.EventHandler(this.toolStripSystem_Click);
            // 
            // toolStripTarget
            // 
            this.toolStripTarget.Checked = true;
            this.toolStripTarget.CheckOnClick = true;
            this.toolStripTarget.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripTarget.Name = "toolStripTarget";
            this.toolStripTarget.Size = new System.Drawing.Size(235, 22);
            this.toolStripTarget.Text = "Enable Target";
            this.toolStripTarget.Click += new System.EventHandler(this.toolStripTarget_Click);
            // 
            // toolStripEDSMDownLine
            // 
            this.toolStripEDSMDownLine.Checked = true;
            this.toolStripEDSMDownLine.CheckOnClick = true;
            this.toolStripEDSMDownLine.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripEDSMDownLine.Name = "toolStripEDSMDownLine";
            this.toolStripEDSMDownLine.Size = new System.Drawing.Size(235, 22);
            this.toolStripEDSMDownLine.Text = "EDSM buttons on separate line";
            this.toolStripEDSMDownLine.Click += new System.EventHandler(this.toolStripEDSMButtons_Click);
            // 
            // toolStripEDSM
            // 
            this.toolStripEDSM.Checked = true;
            this.toolStripEDSM.CheckOnClick = true;
            this.toolStripEDSM.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripEDSM.Name = "toolStripEDSM";
            this.toolStripEDSM.Size = new System.Drawing.Size(235, 22);
            this.toolStripEDSM.Text = "Enable EDSM Buttons";
            this.toolStripEDSM.Click += new System.EventHandler(this.toolStripEDSM_Click);
            // 
            // labelOpen
            // 
            this.labelOpen.AutoSize = true;
            this.labelOpen.Location = new System.Drawing.Point(4, 27);
            this.labelOpen.Name = "labelOpen";
            this.labelOpen.Size = new System.Drawing.Size(33, 13);
            this.labelOpen.TabIndex = 3;
            this.labelOpen.Text = "Open";
            // 
            // UserControlSysInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ContextMenuStrip = this.contextMenuStrip;
            this.Controls.Add(this.labelSysName);
            this.Controls.Add(this.textBoxSystem);
            this.Controls.Add(this.labelOpen);
            this.Controls.Add(this.buttonEDSM);
            this.Controls.Add(this.buttonEDDB);
            this.Controls.Add(this.buttonRoss);
            this.Controls.Add(this.labelBodyName);
            this.Controls.Add(this.textBoxBody);
            this.Controls.Add(this.labelX);
            this.Controls.Add(this.textBoxX);
            this.Controls.Add(this.labelY);
            this.Controls.Add(this.textBoxY);
            this.Controls.Add(this.label_Z);
            this.Controls.Add(this.textBoxZ);
            this.Controls.Add(this.labelHomeSystem);
            this.Controls.Add(this.textBoxHomeDist);
            this.Controls.Add(this.labelSolDist);
            this.Controls.Add(this.textBoxSolDist);
            this.Controls.Add(this.labelVisits);
            this.Controls.Add(this.textBoxVisits);
            this.Controls.Add(this.labelAllegiance);
            this.Controls.Add(this.textBoxAllegiance);
            this.Controls.Add(this.labelEconomy);
            this.Controls.Add(this.textBoxEconomy);
            this.Controls.Add(this.labelState);
            this.Controls.Add(this.textBoxState);
            this.Controls.Add(this.labelGov);
            this.Controls.Add(this.textBoxGovernment);
            this.Controls.Add(this.labelNote);
            this.Controls.Add(this.richTextBoxNote);
            this.Controls.Add(this.labelTarget);
            this.Controls.Add(this.textBoxTarget);
            this.Controls.Add(this.textBoxTargetDist);
            this.Controls.Add(this.buttonEDSMTarget);
            this.Name = "UserControlSysInfo";
            this.Size = new System.Drawing.Size(393, 294);
            this.Resize += new System.EventHandler(this.UserControlSysInfo_Resize);
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private ExtendedControls.TextBoxBorder textBoxBody;
        private System.Windows.Forms.Label labelBodyName;
        private ExtendedControls.TextBoxBorder textBoxX;
        private ExtendedControls.TextBoxBorder textBoxY;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.Label labelY;
        private ExtendedControls.TextBoxBorder textBoxZ;
        private System.Windows.Forms.Label label_Z;
        private ExtendedControls.TextBoxBorder textBoxVisits;
        private System.Windows.Forms.Label labelVisits;
        private System.Windows.Forms.Label labelAllegiance;
        private System.Windows.Forms.Label labelEconomy;
        private ExtendedControls.TextBoxBorder textBoxAllegiance;
        private ExtendedControls.TextBoxBorder textBoxGovernment;
        private System.Windows.Forms.Label labelGov;
        private System.Windows.Forms.Label labelState;
        private ExtendedControls.TextBoxBorder textBoxEconomy;
        private ExtendedControls.TextBoxBorder textBoxState;
        private ExtendedControls.DrawnPanel buttonEDDB;
        private System.Windows.Forms.ToolTip toolTipEddb;
        private ExtendedControls.DrawnPanel buttonRoss;
        private ExtendedControls.TextBoxBorder textBoxHomeDist;
        private System.Windows.Forms.Label labelHomeSystem;
        private ExtendedControls.DrawnPanel buttonEDSM;
        private ExtendedControls.TextBoxBorder textBoxSolDist;
        private System.Windows.Forms.Label labelSolDist;
        private ExtendedControls.RichTextBoxScroll richTextBoxNote;
        private System.Windows.Forms.Label labelNote;
        private System.Windows.Forms.Label labelTarget;
        private ExtendedControls.DrawnPanel buttonEDSMTarget;
        private ExtendedControls.AutoCompleteTextBox textBoxTarget;
        private System.Windows.Forms.ToolTip toolTip1;
        private ExtendedControls.TextBoxBorder textBoxTargetDist;
        private ExtendedControls.TextBoxBorder textBoxSystem;
        private System.Windows.Forms.Label labelSysName;
        private System.Windows.Forms.ToolStripMenuItem toolStripNotes;
        private System.Windows.Forms.ToolStripMenuItem toolStripSystem;
        private System.Windows.Forms.ToolStripMenuItem toolStripBody;
        private System.Windows.Forms.ToolStripMenuItem toolStripTarget;
        private System.Windows.Forms.ToolStripMenuItem toolStripEDSMDownLine;
        private System.Windows.Forms.ToolStripMenuItem toolStripEDSM;
        private System.Windows.Forms.Label labelOpen;
    }
}