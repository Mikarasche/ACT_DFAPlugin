﻿namespace Qitana.DFAPlugin
{
    partial class DFATraceWindow
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
            this.textBox_Messages = new System.Windows.Forms.TextBox();
            this.checkBox_Filter = new System.Windows.Forms.CheckBox();
            this.textBox_Filtered = new System.Windows.Forms.TextBox();
            this.button_ClearMessages = new System.Windows.Forms.Button();
            this.button_ClearFilter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_SaveMessage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_Messages
            // 
            this.textBox_Messages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Messages.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_Messages.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Messages.Location = new System.Drawing.Point(13, 32);
            this.textBox_Messages.MaxLength = 0;
            this.textBox_Messages.Multiline = true;
            this.textBox_Messages.Name = "textBox_Messages";
            this.textBox_Messages.ReadOnly = true;
            this.textBox_Messages.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_Messages.Size = new System.Drawing.Size(687, 378);
            this.textBox_Messages.TabIndex = 0;
            this.textBox_Messages.WordWrap = false;
            // 
            // checkBox_Filter
            // 
            this.checkBox_Filter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox_Filter.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox_Filter.Location = new System.Drawing.Point(582, 416);
            this.checkBox_Filter.Name = "checkBox_Filter";
            this.checkBox_Filter.Size = new System.Drawing.Size(100, 22);
            this.checkBox_Filter.TabIndex = 4;
            this.checkBox_Filter.Text = "Start Filter";
            this.checkBox_Filter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox_Filter.UseVisualStyleBackColor = true;
            this.checkBox_Filter.CheckedChanged += new System.EventHandler(this.checkBox_Filter_CheckedChanged);
            // 
            // textBox_Filtered
            // 
            this.textBox_Filtered.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Filtered.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_Filtered.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Filtered.Location = new System.Drawing.Point(706, 32);
            this.textBox_Filtered.MaxLength = 0;
            this.textBox_Filtered.Multiline = true;
            this.textBox_Filtered.Name = "textBox_Filtered";
            this.textBox_Filtered.ReadOnly = true;
            this.textBox_Filtered.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_Filtered.Size = new System.Drawing.Size(82, 378);
            this.textBox_Filtered.TabIndex = 1;
            this.textBox_Filtered.WordWrap = false;
            // 
            // button_ClearMessages
            // 
            this.button_ClearMessages.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_ClearMessages.Location = new System.Drawing.Point(12, 415);
            this.button_ClearMessages.Name = "button_ClearMessages";
            this.button_ClearMessages.Size = new System.Drawing.Size(140, 23);
            this.button_ClearMessages.TabIndex = 2;
            this.button_ClearMessages.Text = "Clear Messages";
            this.button_ClearMessages.UseVisualStyleBackColor = true;
            this.button_ClearMessages.Click += new System.EventHandler(this.button_ClearMessages_Click);
            // 
            // button_ClearFilter
            // 
            this.button_ClearFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_ClearFilter.Location = new System.Drawing.Point(688, 415);
            this.button_ClearFilter.Name = "button_ClearFilter";
            this.button_ClearFilter.Size = new System.Drawing.Size(100, 23);
            this.button_ClearFilter.TabIndex = 5;
            this.button_ClearFilter.Text = "Clear Filter";
            this.button_ClearFilter.UseVisualStyleBackColor = true;
            this.button_ClearFilter.Click += new System.EventHandler(this.button_ClearFilter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "Messages";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(686, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "Filter";
            // 
            // button_SaveMessage
            // 
            this.button_SaveMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_SaveMessage.Location = new System.Drawing.Point(466, 415);
            this.button_SaveMessage.Name = "button_SaveMessage";
            this.button_SaveMessage.Size = new System.Drawing.Size(110, 23);
            this.button_SaveMessage.TabIndex = 3;
            this.button_SaveMessage.Text = "Save Messages";
            this.button_SaveMessage.UseVisualStyleBackColor = true;
            this.button_SaveMessage.Click += new System.EventHandler(this.button_SaveMessage_Click);
            // 
            // DFATraceWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_SaveMessage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_ClearFilter);
            this.Controls.Add(this.button_ClearMessages);
            this.Controls.Add(this.textBox_Filtered);
            this.Controls.Add(this.checkBox_Filter);
            this.Controls.Add(this.textBox_Messages);
            this.Name = "DFATraceWindow";
            this.Text = "DFATraceWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Messages;
        private System.Windows.Forms.CheckBox checkBox_Filter;
        private System.Windows.Forms.TextBox textBox_Filtered;
        private System.Windows.Forms.Button button_ClearMessages;
        private System.Windows.Forms.Button button_ClearFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_SaveMessage;
    }
}