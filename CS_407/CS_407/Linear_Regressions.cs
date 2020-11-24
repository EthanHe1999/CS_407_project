using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_407
{
    public partial class Linear_Regressions : Form
    {
        string stringanme = "";
        bool check = false;

        public string getpath()
        {
            return stringanme;
        }
        public bool getcheck()
        {
            return check;
        }
        public Linear_Regressions()
        {
            InitializeComponent();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                stringanme = openFileDialog1.FileName;                           
            }
            if(stringanme.Length >= 3)
            {
                int lenth = stringanme.Length;
                string filename = stringanme.Substring(lenth - 3, 3);
                if (filename != "csv")
                {
                    MessageBox.Show("The path is: " + stringanme + ", please select a csv file");
                }
                else
                {
                    MessageBox.Show("The path is: " + stringanme + ", file path save");
                    check = true;
                    this.Hide();
                }
            }                    
        }

       
    }
}
