﻿// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++ and C#: http://www.viva64.com
namespace SimulationObject.Real.Calculator
{
    partial class SetupForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox_Operation = new System.Windows.Forms.ComboBox();
            this.label_Operation = new System.Windows.Forms.Label();
            this.label_In2 = new System.Windows.Forms.Label();
            this.label_In1 = new System.Windows.Forms.Label();
            this.label_Value = new System.Windows.Forms.Label();
            this.itemEditBox_Value = new Utils.SpecialControls.ItemEditBox();
            this.itemEditBox_In2 = new Utils.SpecialControls.ItemEditBox();
            this.itemEditBox_In1 = new Utils.SpecialControls.ItemEditBox();
            this.okCancelButton = new Utils.SpecialControls.OKCancelButton();
            this.SuspendLayout();
            // 
            // comboBox_Operation
            // 
            this.comboBox_Operation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Operation.FormattingEnabled = true;
            this.comboBox_Operation.Location = new System.Drawing.Point(121, 80);
            this.comboBox_Operation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_Operation.Name = "comboBox_Operation";
            this.comboBox_Operation.Size = new System.Drawing.Size(188, 24);
            this.comboBox_Operation.TabIndex = 2;
            // 
            // label_Operation
            // 
            this.label_Operation.AutoSize = true;
            this.label_Operation.Location = new System.Drawing.Point(47, 85);
            this.label_Operation.Name = "label_Operation";
            this.label_Operation.Size = new System.Drawing.Size(75, 17);
            this.label_Operation.TabIndex = 41;
            this.label_Operation.Text = "Operation:";
            // 
            // label_In2
            // 
            this.label_In2.AutoSize = true;
            this.label_In2.Location = new System.Drawing.Point(7, 52);
            this.label_In2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_In2.Name = "label_In2";
            this.label_In2.Size = new System.Drawing.Size(55, 17);
            this.label_In2.TabIndex = 40;
            this.label_In2.Text = "Input 2:";
            // 
            // label_In1
            // 
            this.label_In1.AutoSize = true;
            this.label_In1.Location = new System.Drawing.Point(7, 16);
            this.label_In1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_In1.Name = "label_In1";
            this.label_In1.Size = new System.Drawing.Size(55, 17);
            this.label_In1.TabIndex = 39;
            this.label_In1.Text = "Input 1:";
            // 
            // label_Value
            // 
            this.label_Value.AutoSize = true;
            this.label_Value.Location = new System.Drawing.Point(15, 118);
            this.label_Value.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Value.Name = "label_Value";
            this.label_Value.Size = new System.Drawing.Size(48, 17);
            this.label_Value.TabIndex = 38;
            this.label_Value.Text = "Value:";
            // 
            // itemEditBox_Value
            // 
            this.itemEditBox_Value.ItemName = "";
            this.itemEditBox_Value.ItemRequirements = "Real, Write, Required";
            this.itemEditBox_Value.ItemToolTip = "";
            this.itemEditBox_Value.Location = new System.Drawing.Point(68, 111);
            this.itemEditBox_Value.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.itemEditBox_Value.Name = "itemEditBox_Value";
            this.itemEditBox_Value.Size = new System.Drawing.Size(283, 30);
            this.itemEditBox_Value.TabIndex = 3;
            this.itemEditBox_Value.ButtonClick += new System.EventHandler(this.ItemButtonClick);
            // 
            // itemEditBox_In2
            // 
            this.itemEditBox_In2.ItemName = "";
            this.itemEditBox_In2.ItemRequirements = "Real, Read";
            this.itemEditBox_In2.ItemToolTip = "";
            this.itemEditBox_In2.Location = new System.Drawing.Point(68, 44);
            this.itemEditBox_In2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.itemEditBox_In2.Name = "itemEditBox_In2";
            this.itemEditBox_In2.Size = new System.Drawing.Size(283, 30);
            this.itemEditBox_In2.TabIndex = 1;
            this.itemEditBox_In2.ButtonClick += new System.EventHandler(this.ItemButtonClick);
            // 
            // itemEditBox_In1
            // 
            this.itemEditBox_In1.ItemName = "";
            this.itemEditBox_In1.ItemRequirements = "Real, Read, Required";
            this.itemEditBox_In1.ItemToolTip = "";
            this.itemEditBox_In1.Location = new System.Drawing.Point(68, 9);
            this.itemEditBox_In1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.itemEditBox_In1.Name = "itemEditBox_In1";
            this.itemEditBox_In1.Size = new System.Drawing.Size(283, 30);
            this.itemEditBox_In1.TabIndex = 0;
            this.itemEditBox_In1.ButtonClick += new System.EventHandler(this.ItemButtonClick);
            // 
            // okCancelButton
            // 
            this.okCancelButton.Location = new System.Drawing.Point(86, 152);
            this.okCancelButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.okCancelButton.MaximumSize = new System.Drawing.Size(188, 33);
            this.okCancelButton.MinimumSize = new System.Drawing.Size(188, 33);
            this.okCancelButton.Name = "okCancelButton";
            this.okCancelButton.Size = new System.Drawing.Size(188, 33);
            this.okCancelButton.TabIndex = 4;
            this.okCancelButton.ButtonClick += new System.EventHandler(this.okCancelButton_ButtonClick);
            // 
            // SetupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 186);
            this.ControlBox = false;
            this.Controls.Add(this.itemEditBox_Value);
            this.Controls.Add(this.itemEditBox_In2);
            this.Controls.Add(this.itemEditBox_In1);
            this.Controls.Add(this.comboBox_Operation);
            this.Controls.Add(this.label_Operation);
            this.Controls.Add(this.label_In2);
            this.Controls.Add(this.label_In1);
            this.Controls.Add(this.label_Value);
            this.Controls.Add(this.okCancelButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SetupForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Real.Calculator";
            this.Load += new System.EventHandler(this.SetupForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SetupForm_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Utils.SpecialControls.OKCancelButton okCancelButton;
        private Utils.SpecialControls.ItemEditBox itemEditBox_Value;
        private Utils.SpecialControls.ItemEditBox itemEditBox_In2;
        private Utils.SpecialControls.ItemEditBox itemEditBox_In1;
        private System.Windows.Forms.ComboBox comboBox_Operation;
        private System.Windows.Forms.Label label_Operation;
        private System.Windows.Forms.Label label_In2;
        private System.Windows.Forms.Label label_In1;
        private System.Windows.Forms.Label label_Value;
    }
}