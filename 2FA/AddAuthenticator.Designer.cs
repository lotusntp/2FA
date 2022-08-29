namespace _2FA
{
    partial class AddAuthenticator
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
            this.label1 = new System.Windows.Forms.Label();
            this.nameAcc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.secretCode = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SimSun", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // nameAcc
            // 
            this.nameAcc.Font = new System.Drawing.Font("SimSun", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.nameAcc.Location = new System.Drawing.Point(97, 12);
            this.nameAcc.Name = "nameAcc";
            this.nameAcc.Size = new System.Drawing.Size(196, 29);
            this.nameAcc.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SimSun", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "SECRET:";
            // 
            // secretCode
            // 
            this.secretCode.Font = new System.Drawing.Font("SimSun", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.secretCode.Location = new System.Drawing.Point(97, 66);
            this.secretCode.Name = "secretCode";
            this.secretCode.Size = new System.Drawing.Size(196, 29);
            this.secretCode.TabIndex = 3;
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("SimSun", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.addButton.Location = new System.Drawing.Point(308, 36);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(87, 31);
            this.addButton.TabIndex = 5;
            this.addButton.Text = "ADD";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // AddAuthenticator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 109);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.secretCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameAcc);
            this.Controls.Add(this.label1);
            this.Name = "AddAuthenticator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddAuthenticator";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddAuthenticator_FormClosed);
            this.Load += new System.EventHandler(this.AddAuthenticator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameAcc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox secretCode;
        private System.Windows.Forms.Button addButton;
    }
}