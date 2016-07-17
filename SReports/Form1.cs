using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SReports
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.ControlBox = false;            
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.TopMost = true; 
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            Dashboard newDashForm = new Dashboard();
            newDashForm.FormClosed += new FormClosedEventHandler(newDashForm_FormClosed);
            newDashForm.Show();
            this.Hide();
        }

        private void newDashForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        
    }
}
