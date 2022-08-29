using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2FA
{
    public partial class Form1 : Form
    {
        public const string tmp = "/config/";
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            Hide();
            AddAuthenticator addAuthenticator = new AddAuthenticator();
            addAuthenticator.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string path = Directory.GetCurrentDirectory(),
                     temp = path + tmp;
            String[] files = Directory.GetFiles(temp).OrderBy(d => new FileInfo(d).CreationTime).ToArray();
            foreach (string path1 in files)
            {
               
                accList.Items.Add(Path.GetFileNameWithoutExtension(path1));
            }

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.ExitThread();
        }

        private void addAuthenticatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach(Form f in Application.OpenForms)
            {
                
                if(f.Text == "AddAuthenticator")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }

            if (IsOpen == false)
            {
                Hide();
                AddAuthenticator addAuthenticator = new AddAuthenticator();
                addAuthenticator.ShowDialog();
            }
        }

        private void accList_SelectedIndexChanged(object sender, EventArgs e)
        {
            timer1.Interval = 100;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string path = Directory.GetCurrentDirectory(),
                    temp = path + tmp;
            string select_acc = accList.GetItemText(accList.SelectedItem);
            var secret = File.ReadAllText(temp + select_acc + ".json");
            try
            {
                var authenticator = new TwoStepsAuthenticator.TimeAuthenticator();
                var code = authenticator.GetCode(secret);
                codeBox.Text = code;
                int IntervalSeconds = 30;
                DateTime dateTime = DateTime.Now;
                TimeSpan ts = (dateTime.ToUniversalTime() - new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc));
                double st = ts.TotalSeconds % IntervalSeconds;

                progressBar1.Value = Convert.ToInt32(100 - (st / 30 * 100));

            }

            catch (Exception)
            {
                MessageBox.Show("Authenticator is failed");
                timer1.Enabled = false;
                timer1.Stop();
            }
        }

      

    
    }
}
