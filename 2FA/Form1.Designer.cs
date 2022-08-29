namespace _2FA
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
            this.components = new System.ComponentModel.Container();
            this.codeBox = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.accList = new System.Windows.Forms.ListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.configToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addAuthenticatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // codeBox
            // 
            this.codeBox.Enabled = false;
            this.codeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.codeBox.Location = new System.Drawing.Point(12, 12);
            this.codeBox.Name = "codeBox";
            this.codeBox.Size = new System.Drawing.Size(241, 38);
            this.codeBox.TabIndex = 7;
            this.codeBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 70);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(241, 35);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 12;
            // 
            // accList
            // 
            this.accList.FormattingEnabled = true;
            this.accList.ItemHeight = 12;
            this.accList.Location = new System.Drawing.Point(12, 124);
            this.accList.Name = "accList";
            this.accList.Size = new System.Drawing.Size(241, 88);
            this.accList.TabIndex = 13;
            this.accList.SelectedIndexChanged += new System.EventHandler(this.accList_SelectedIndexChanged);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(268, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(92, 35);
            this.button3.TabIndex = 14;
            this.button3.Text = "COPY";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 48);
            // 
            // configToolStripMenuItem
            // 
            this.configToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addAuthenticatorToolStripMenuItem});
            this.configToolStripMenuItem.Name = "configToolStripMenuItem";
            this.configToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.configToolStripMenuItem.Text = "config";
            // 
            // addAuthenticatorToolStripMenuItem
            // 
            this.addAuthenticatorToolStripMenuItem.Name = "addAuthenticatorToolStripMenuItem";
            this.addAuthenticatorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addAuthenticatorToolStripMenuItem.Text = "Add Authenticator";
            this.addAuthenticatorToolStripMenuItem.Click += new System.EventHandler(this.addAuthenticatorToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 224);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.button3);
            this.Controls.Add(this.accList);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.codeBox);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox codeBox;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ListBox accList;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem configToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addAuthenticatorToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
    }
}

