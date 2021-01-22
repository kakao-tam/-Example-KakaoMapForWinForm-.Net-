using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            webBrowser1.Navigate("http://test-tam.pe.kr/mapForWinForm.html");

        }

        private void invoke(string name, object[] param)
        {
            webBrowser1.Document.InvokeScript(name, param);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            object[] param = new object[] { "roadview" };
            invoke("addOverlayMapTypeId", param);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            object[] param = new object[] { "use_district" };
            invoke("addOverlayMapTypeId", param);
        }

        private void button3_Click(object sender, EventArgs e)
        {           
            object[] param = new object[] { "terrain" };
            invoke("addOverlayMapTypeId", param);
        }

        private void button2_Click(object sender, EventArgs e)
        {   
            object[] param = new object[] { "traffic" };
            invoke("addOverlayMapTypeId", param);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            invoke("addControlForMapType", null);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            invoke("addControlForZoom", null); 
        }
    }

}
