namespace HomeWork_ISP_203_13_01.Forms
{
    partial class FormMain
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
            this.showLoginLabel = new System.Windows.Forms.Label();
            this.goSecondFormButton = new System.Windows.Forms.Button();
            this.mainFormLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // showLoginLabel
            // 
            this.showLoginLabel.AutoSize = true;
            this.showLoginLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.showLoginLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.showLoginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showLoginLabel.Location = new System.Drawing.Point(898, 0);
            this.showLoginLabel.Margin = new System.Windows.Forms.Padding(0);
            this.showLoginLabel.Name = "showLoginLabel";
            this.showLoginLabel.Size = new System.Drawing.Size(101, 33);
            this.showLoginLabel.TabIndex = 0;
            this.showLoginLabel.Text = "lable 1";
            this.showLoginLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // goSecondFormButton
            // 
            this.goSecondFormButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.goSecondFormButton.Location = new System.Drawing.Point(209, 263);
            this.goSecondFormButton.Name = "goSecondFormButton";
            this.goSecondFormButton.Size = new System.Drawing.Size(580, 141);
            this.goSecondFormButton.TabIndex = 1;
            this.goSecondFormButton.Text = "Переход на другую форму";
            this.goSecondFormButton.UseVisualStyleBackColor = true;
            this.goSecondFormButton.Click += new System.EventHandler(this.goSecondFormButton_Click);
            // 
            // mainFormLabel
            // 
            this.mainFormLabel.AutoSize = true;
            this.mainFormLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.mainFormLabel.Location = new System.Drawing.Point(315, 191);
            this.mainFormLabel.Name = "mainFormLabel";
            this.mainFormLabel.Size = new System.Drawing.Size(368, 51);
            this.mainFormLabel.TabIndex = 2;
            this.mainFormLabel.Text = "Основная форма";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 594);
            this.Controls.Add(this.mainFormLabel);
            this.Controls.Add(this.goSecondFormButton);
            this.Controls.Add(this.showLoginLabel);
            this.Name = "FormMain";
            this.ShowIcon = false;
            this.Text = "Основная форма";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label showLoginLabel;
        private System.Windows.Forms.Button goSecondFormButton;
        private System.Windows.Forms.Label mainFormLabel;
    }
}