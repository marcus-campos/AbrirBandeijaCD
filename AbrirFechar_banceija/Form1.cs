using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows;
namespace AbrirFechar_banceija
{
    public partial class Form1 : Form
    {
        [System.Runtime.InteropServices.DllImport("winmm.dll")]
        static extern Int32 mciSendString(string command, StringBuilder buffer, int bufferSize, IntPtr hwndCallback);

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenCD();
        }
       
        public void OpenCD()
        {
            IntPtr ptr = IntPtr.Zero;
            StringBuilder returnstring = new StringBuilder();
            mciSendString("set CDAudio door open", returnstring, 127, IntPtr.Zero);
        }

        public void FecharCD()
        {
            IntPtr ptr = IntPtr.Zero;
            StringBuilder returnstring = new StringBuilder();
            mciSendString("set CDAudio door close", returnstring, 127, IntPtr.Zero);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            FecharCD();
        }
    }
}
