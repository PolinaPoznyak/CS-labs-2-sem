﻿
namespace Bank
{
    partial class FormSearchForNumber
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSearchForNumber));
            this.numberSearchTextBox = new System.Windows.Forms.RichTextBox();
            this.numberSearch_label = new System.Windows.Forms.Label();
            this.numberSearch_button = new System.Windows.Forms.Button();
            this.OutputBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // numberSearchTextBox
            // 
            this.numberSearchTextBox.Location = new System.Drawing.Point(103, 88);
            this.numberSearchTextBox.Name = "numberSearchTextBox";
            this.numberSearchTextBox.Size = new System.Drawing.Size(397, 45);
            this.numberSearchTextBox.TabIndex = 0;
            this.numberSearchTextBox.Text = "";
            // 
            // numberSearch_label
            // 
            this.numberSearch_label.AutoSize = true;
            this.numberSearch_label.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numberSearch_label.Location = new System.Drawing.Point(196, 32);
            this.numberSearch_label.Name = "numberSearch_label";
            this.numberSearch_label.Size = new System.Drawing.Size(232, 28);
            this.numberSearch_label.TabIndex = 1;
            this.numberSearch_label.Text = "Введите номер клиента:";
            // 
            // numberSearch_button
            // 
            this.numberSearch_button.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numberSearch_button.Location = new System.Drawing.Point(192, 175);
            this.numberSearch_button.Name = "numberSearch_button";
            this.numberSearch_button.Size = new System.Drawing.Size(241, 64);
            this.numberSearch_button.TabIndex = 2;
            this.numberSearch_button.Text = "Поиск";
            this.numberSearch_button.UseVisualStyleBackColor = true;
            this.numberSearch_button.Click += new System.EventHandler(this.numberSearch_button_Click);
            // 
            // OutputBox
            // 
            this.OutputBox.Location = new System.Drawing.Point(42, 279);
            this.OutputBox.Name = "OutputBox";
            this.OutputBox.ReadOnly = true;
            this.OutputBox.Size = new System.Drawing.Size(533, 189);
            this.OutputBox.TabIndex = 3;
            this.OutputBox.Text = "";
            // 
            // FormSearchForNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(615, 499);
            this.Controls.Add(this.OutputBox);
            this.Controls.Add(this.numberSearch_button);
            this.Controls.Add(this.numberSearch_label);
            this.Controls.Add(this.numberSearchTextBox);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormSearchForNumber";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Поиск по номеру";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox numberSearchTextBox;
        private System.Windows.Forms.Label numberSearch_label;
        private System.Windows.Forms.Button numberSearch_button;
        private System.Windows.Forms.RichTextBox OutputBox;
    }
}