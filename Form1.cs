using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TranslationSaver
{
    public partial class Form1 : Form
    {
        string path = @"D:\ProgProjects\GIT\TranslationSaver\translations.txt";
        
        public Form1()
        {
            InitializeComponent();
            try
            {
                using (StreamReader sr = new StreamReader(path, Encoding.Default))
                {
                    textBox3.Text = sr.ReadToEnd();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка");
            }

        }

        private void bSaveResult_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                progressBar1.Value = i;
            }

            textBox3.Text = textBox1.Text +" - "+ textBox2.Text;
            string result = textBox3.Text;


            try
            {
                
                using (StreamWriter sw = new StreamWriter(path, true, System.Text.Encoding.Default))
                {
                    sw.WriteLine(result);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка");
            }

            try
            {
                using (StreamReader sr = new StreamReader(path, Encoding.Default))
                {
                    textBox3.Text = sr.ReadToEnd();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка");
            }


        }
    }
}
