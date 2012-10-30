using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string url = textBox1.Text;
            string sourceCode = WorkerClass.getSourceCode(url);
            Regex name = new Regex("\"name\": \".*\"");
            Regex condition = new Regex("\"condition\": \".*\"");
            Regex price = new Regex("\"price\": \\d+[.]\\d+");
            Regex shipping = new Regex("\"shipping\": \\d+[.]\\d+,");
            MatchCollection mcn = name.Matches(sourceCode);
            MatchCollection mcc = condition.Matches(sourceCode);
            MatchCollection mcp = price.Matches(sourceCode);
            MatchCollection mcs = shipping.Matches(sourceCode);

           //***Writes source code to file****
            StreamWriter sw = new StreamWriter("website.txt");
            StreamWriter sw2 = new StreamWriter("regex.txt");
            sw.Write(sourceCode);
            sw.Close();

            for (int i = 0; i < mcs.Count; ++i)
            {
                sw2.Write(mcn[i].Value + "\r\n");
                sw2.Write(mcc[i].Value + "\r\n");
                sw2.Write(mcp[i].Value + "\r\n");
                sw2.Write(mcs[i].Value + "\r\n");
                sw2.Write("\r\n");
            }
            sw2.Close();
        }
    }
}
