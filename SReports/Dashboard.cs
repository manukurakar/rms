using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SReports
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();          
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            List<CustomButton> buttons = new List<CustomButton>();
            for (int i = 301; i <= 350; i++)
            {
                CustomButton newButton = new CustomButton();
                newButton.buttonData = i;
                newButton.Click += new EventHandler(this.newButton_Click);
                newButton.Text = i.ToString();
                newButton.Height = 50;
                if (i % 2 == 0)
                {
                    newButton.BackColor = Color.Red;
                }
                else
                {
                    newButton.BackColor = Color.Green;
                }
                buttons.Add(newButton);
                buttonsPanel.AutoScroll = true;
                buttonsPanel.Controls.Add(newButton);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            CustomButton btn = sender as CustomButton;
            string buttonData = btn.buttonData.ToString();
            MessageBox.Show(buttonData);
        }
    }
}
