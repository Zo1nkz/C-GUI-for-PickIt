﻿namespace C__GUI_with_Pickit
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtHexFilePath = new System.Windows.Forms.TextBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(334, 145);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 98);
            this.button1.TabIndex = 0;
            this.button1.Text = "Import";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtHexFilePath
            // 
            this.txtHexFilePath.Location = new System.Drawing.Point(266, 49);
            this.txtHexFilePath.Multiline = true;
            this.txtHexFilePath.Name = "txtHexFilePath";
            this.txtHexFilePath.Size = new System.Drawing.Size(270, 51);
            this.txtHexFilePath.TabIndex = 1;
            this.txtHexFilePath.Text = "Insert path to pickit device";
            this.txtHexFilePath.TextChanged += new System.EventHandler(this.txtHexFilePath_TextChanged);
            this.txtHexFilePath.Enter += new System.EventHandler(this.txtHexFilePath_Enter);
            this.txtHexFilePath.Leave += new System.EventHandler(this.txtHexFilePath_Leave);
            // 
            // txtOutput
            // 
            this.txtOutput.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.txtOutput.Location = new System.Drawing.Point(312, 267);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(180, 67);
            this.txtOutput.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 376);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.txtHexFilePath);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = ". v";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtHexFilePath;
        private System.Windows.Forms.TextBox txtOutput;
    }
}

