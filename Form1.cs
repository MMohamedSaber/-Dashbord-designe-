using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gymsystemProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Dash_Bord dash = new Dash_Bord();
            addUserControl(dash);
        }

        private void addUserControl(UserControl uc)
        {
            PanelContainer.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            uc.BringToFront();
            PanelContainer.Controls.Add(uc);

        }

      

        private void guna2Button1_Click(object sender, EventArgs e)
        {
          
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
       
        }
    }
}
