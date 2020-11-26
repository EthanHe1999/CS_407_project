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
        string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/" + "csvFilePath.txt";
        public CS_407()
        {
            InitializeComponent();
            //LaunchJupyter();
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

        string RemakePath(string s)
        {
            string path = "";
            for(int i = 0; i < s.Length; i++)
            {
                if(s.ElementAt(i) == '\\')
                {
                    path += "/";
                }
                else
                {
                    path += s.ElementAt(i);
                }
            }

            return path;
        }
        private void Linear_Regression(object sender, EventArgs e)
        {
            Linear_Regressions ls = new Linear_Regressions();
            try
            {
                string pathL = Environment.CurrentDirectory + "/" + "Regressions%20with%20charts.ipynb";
                string[] sepStrings = { "\\" };
                string[] words = pathL.Split(sepStrings, System.StringSplitOptions.RemoveEmptyEntries);
                string path2 = "";
                for (int i = 3; i < words.Length; i++)
                {
                    if (i != words.Length - 1)
                    {
                        path2 += words[i];
                        path2 += "/";
                    }
                    else
                    {
                        path2 += words[i];
                    }

                }

                if (!File.Exists(path))
                {
                    TextWriter tsw = new StreamWriter(path, true);
                    ls.ShowDialog();
                    string pathfile = ls.getpath();
                    bool checkCreate = ls.getcheck();
                    string Newpath = RemakePath(pathfile);
                    if (checkCreate == true)
                    {
                        tsw.WriteLine(Newpath);                        
                        GoToLink("http://127.0.0.1:8888/notebooks/" + path2);
                    }
                    tsw.Close();
                }
                else
                {
                    File.Delete(path);
                    TextWriter tsw = new StreamWriter(path, true);
                    ls.ShowDialog();
                    string pathfile = ls.getpath();
                    bool checkCreate = ls.getcheck();
                    string Newpath = RemakePath(pathfile);
                    if (checkCreate == true)
                    {
                        tsw.WriteLine(Newpath);                                       
                        GoToLink("http://127.0.0.1:8888/notebooks/" + path2);
                    }
                    tsw.Close();
                }
            }
            catch(Exception s)
            {
                MessageBox.Show(s.Message);
            }                 
        }

        private void Logistic_Regression(object sender, EventArgs e)
        {
            Linear_Regressions ls = new Linear_Regressions();
            try
            {
                string pathL = Environment.CurrentDirectory + "/" + "Logistic%20Regression.ipynb";
                string[] sepStrings = { "\\" };
                string[] words = pathL.Split(sepStrings, System.StringSplitOptions.RemoveEmptyEntries);
                string path2 = "";
                for (int i = 3; i < words.Length; i++)
                {
                    if (i != words.Length - 1)
                    {
                        path2 += words[i];
                        path2 += "/";
                    }
                    else
                    {
                        path2 += words[i];
                    }

                }

                if (!File.Exists(path))
                {
                    TextWriter tsw = new StreamWriter(path, true);
                    ls.ShowDialog();
                    string pathfile = ls.getpath();
                    bool checkCreate = ls.getcheck();
                    string Newpath = RemakePath(pathfile);
                    if (checkCreate == true)
                    {
                        tsw.WriteLine(Newpath);
                        GoToLink("http://127.0.0.1:8888/notebooks/" + path2);
                    }
                    tsw.Close();
                }
                else
                {
                    File.Delete(path);
                    TextWriter tsw = new StreamWriter(path, true);
                    ls.ShowDialog();
                    string pathfile = ls.getpath();
                    bool checkCreate = ls.getcheck();
                    string Newpath = RemakePath(pathfile);
                    if (checkCreate == true)
                    {
                        tsw.WriteLine(Newpath);
                        GoToLink("http://127.0.0.1:8888/notebooks/" + path2);
                    }
                    tsw.Close();
                }
            }
            catch (Exception s)
            {
                MessageBox.Show(s.Message);
            }
        }

        private void Baye_Classification(object sender, EventArgs e)
        {
            Linear_Regressions ls = new Linear_Regressions();
            try
            {
                string pathL = Environment.CurrentDirectory + "/" + "Naive%20Bayes.ipynb";
                string[] sepStrings = { "\\" };
                string[] words = pathL.Split(sepStrings, System.StringSplitOptions.RemoveEmptyEntries);
                string path2 = "";
                for (int i = 3; i < words.Length; i++)
                {
                    if (i != words.Length - 1)
                    {
                        path2 += words[i];
                        path2 += "/";
                    }
                    else
                    {
                        path2 += words[i];
                    }

                }

                if (!File.Exists(path))
                {
                    TextWriter tsw = new StreamWriter(path, true);
                    ls.ShowDialog();
                    string pathfile = ls.getpath();
                    bool checkCreate = ls.getcheck();
                    string Newpath = RemakePath(pathfile);
                    if (checkCreate == true)
                    {
                        tsw.WriteLine(Newpath);
                        GoToLink("http://127.0.0.1:8888/notebooks/" + path2);
                    }
                    tsw.Close();
                }
                else
                {
                    File.Delete(path);
                    TextWriter tsw = new StreamWriter(path, true);
                    ls.ShowDialog();
                    string pathfile = ls.getpath();
                    bool checkCreate = ls.getcheck();
                    string Newpath = RemakePath(pathfile);
                    if (checkCreate == true)
                    {
                        tsw.WriteLine(Newpath);
                        GoToLink("http://127.0.0.1:8888/notebooks/" + path2);
                    }
                    tsw.Close();
                }
            }
            catch (Exception s)
            {
                MessageBox.Show(s.Message);
            }
        }

        private void Descision_Tree(object sender, EventArgs e)
        {

        }

        private void Random_Forrest(object sender, EventArgs e)
        {

        }

    }
}
