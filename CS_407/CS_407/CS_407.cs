using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace CS_407
{
    public partial class CS_407 : Form
    {
        public CS_407()
        {
            InitializeComponent();
        }
        
        private void label5_Click(object sender, EventArgs e)
        {
            
        }

        void LaunchJupyter()
        {
            try
            {
                Process cmd = new Process();
                cmd.StartInfo.FileName = "cmd.exe";
                cmd.StartInfo.RedirectStandardInput = true;
                cmd.StartInfo.RedirectStandardOutput = true;
                cmd.StartInfo.CreateNoWindow = true;
                cmd.StartInfo.UseShellExecute = false;
                cmd.Start();

                cmd.StandardInput.WriteLine("jupyter notebook");
                cmd.StandardInput.Flush();
                cmd.StandardInput.Close();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            
        }

        void ColseJupyter()
        {
            Process cmd = new Process();
            cmd.StartInfo.FileName = "cmd.exe";
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.CreateNoWindow = true;
            cmd.StartInfo.UseShellExecute = false;
            cmd.Start();

            cmd.StandardInput.WriteLine("Jupyter notebook stop");
            cmd.StandardInput.Flush();
            cmd.StandardInput.Close();
        }

        void GoToLink(string link)
        {
            try
            {
                Process.Start(link);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        private void Linear_Regression(object sender, EventArgs e)
        {
            GoToLink("http://127.0.0.1:8888/?token=15d9a9fd76d9041ea66fa91c78b186c04277827887e2a952");
        }

        private void Logistic_Regression(object sender, EventArgs e)
        {

        }

        private void Baye_Classification(object sender, EventArgs e)
        {

        }

        private void Descision_Tree(object sender, EventArgs e)
        {

        }

        private void Random_Forrest(object sender, EventArgs e)
        {

        }

        private void Cluster_Analysis(object sender, EventArgs e)
        {

        }
    }
}
