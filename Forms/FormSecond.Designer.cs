namespace HomeWork_ISP_203_13_01.Forms
{
    partial class FormSecond
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
            this.buttonReturn = new System.Windows.Forms.Button();
            this.showLoginLabel = new System.Windows.Forms.Label();
            this.secondFormLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonReturn
            // 
            this.buttonReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonReturn.Location = new System.Drawing.Point(211, 268);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(583, 181);
            this.buttonReturn.TabIndex = 0;
            this.buttonReturn.Text = "Вернуться на основную форму";
            this.buttonReturn.UseVisualStyleBackColor = true;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // showLoginLabel
            // 
            this.showLoginLabel.AutoSize = true;
            this.showLoginLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.showLoginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showLoginLabel.Location = new System.Drawing.Point(912, 0);
            this.showLoginLabel.Name = "showLoginLabel";
            this.showLoginLabel.Size = new System.Drawing.Size(93, 33);
            this.showLoginLabel.TabIndex = 1;
            this.showLoginLabel.Text = "label1";
            this.showLoginLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // secondFormLabel
            // 
            this.secondFormLabel.AutoSize = true;
            this.secondFormLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.secondFormLabel.Location = new System.Drawing.Point(246, 194);
            this.secondFormLabel.Name = "secondFormLabel";
            this.secondFormLabel.Size = new System.Drawing.Size(511, 51);
            this.secondFormLabel.TabIndex = 2;
            this.secondFormLabel.Text = "Дополнительная форма";
            // 
            // FormSecond
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 643);
            this.Controls.Add(this.secondFormLabel);
            this.Controls.Add(this.showLoginLabel);
            this.Controls.Add(this.buttonReturn);
            this.Name = "FormSecond";
            this.ShowIcon = false;
            this.Text = "Дополнительная форма";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormSecond_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonReturn;
        private System.Windows.Forms.Label showLoginLabel;
        private System.Windows.Forms.Label secondFormLabel;
    }
}