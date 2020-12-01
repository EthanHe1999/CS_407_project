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
using System.Threading;

namespace CS_407
{
    public partial class CS_407 : Form
    {
        string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/" + "csvFilePath.txt";
        string result;
        public CS_407()
        {
            //start();
            //Thread.Sleep(5000);
           
            //Thread.Sleep(5000);
            InitializeComponent();
            
          
        }
        
        private void label5_Click(object sender, EventArgs e)
        {
            
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
                        //start();
                        //Thread.Sleep(5000);
                        GoToLink("http://localhost:8888/notebooks/" + path2);
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
                        //start();
                        //Thread.Sleep(5000);
                        GoToLink("http://localhost:8888/notebooks/" + path2);
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
                        GoToLink("http://localhost:8888/notebooks/" + path2);
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
                        GoToLink("http://localhost:8888/notebooks/" + path2);
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
                        
                        GoToLink("http://localhost:8888/notebooks/" + path2);
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
                       
                        GoToLink("http://localhost:8888/notebooks/" + path2);
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

        private void pictureBox12_Click(object sender, EventArgs e)
        {

        }

        public void pythonPath()

        {
            //  start();
            string pathPython = System.AppDomain.CurrentDomain.BaseDirectory + "python" +
                "\\Scripts\\jupyter-notebook.exe";
             string FileName = Environment.CurrentDirectory + @"/python/Scripts/jupyter-notebook.exe";
            System.Diagnostics.Process.Start(pathPython);
        }
        public void start()
        {
            string pathL = Environment.CurrentDirectory + "/" + "Regressions%20with%20charts.ipynb";
            string[] sepStrings = { "\\" };
            string[] words = pathL.Split(sepStrings, System.StringSplitOptions.RemoveEmptyEntries);
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            ProcessStartInfo command = new ProcessStartInfo();
            command.FileName = "cmd.exe";
            command.WorkingDirectory = @words[0] + "\\" + words[1] + "\\" + words[2];

            command.Arguments = "/C where python";
            command.UseShellExecute = false;
            command.RedirectStandardOutput = true;
            using (Process process2 = Process.Start(command))
            {
                using (StreamReader reader = process2.StandardOutput)
                {
                     result = reader.ReadToEnd();
                    if (result == "")
                    {
                        //command.Arguments = "/C install python";
                        MessageBox.Show("DownLoad");
                    }
                    else
                    {
                        MessageBox.Show(result);
                    }
                }
            }
            //command.WorkingDirectory = @"C:\Users\Owner";
            //command.Arguments = "/C jupyter notebook";
            //process.StartInfo = command;
            //process.Start();
        }
        private void run_cmd(string cmd, string args)
        {
            ProcessStartInfo start = new ProcessStartInfo();
            start.FileName = "cmd.exe";
            start.Arguments = string.Format("{0} {1}", cmd, args);
            start.UseShellExecute = false;
            start.RedirectStandardOutput = true;
            using (Process process = Process.Start(start))
            {
                using (StreamReader reader = process.StandardOutput)
                {
                    string result = reader.ReadToEnd();
                    Console.Write(result);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pythonPath();
        }
    }
}
