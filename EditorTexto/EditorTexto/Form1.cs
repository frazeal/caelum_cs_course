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

namespace EditorTexto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            File.Delete(@"C:\Users\csharp6472\Documents\Visual Studio 2013\Projects\EditorTexto\texto.txt");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtEditor.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            File.WriteAllText(@"C:\Users\csharp6472\Documents\Visual Studio 2013\Projects\EditorTexto\texto.txt", txtEditor.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtEditor.Text = File.ReadAllText(@"C:\Users\csharp6472\Documents\Visual Studio 2013\Projects\EditorTexto\texto.txt");
        }
    }
}
