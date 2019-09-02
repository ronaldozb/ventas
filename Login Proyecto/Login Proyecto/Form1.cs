using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_Proyecto
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            
            InitializeComponent();
        }

        private void btnentrar_Click(object sender, EventArgs e)
        {
            var menu = new Menu();
            if (txtusuario.Text == "Ronaldo" && txtcontra.Text == "123")
            {
                
                menu.Show();
                this.Hide();
            }
            else if (txtusuario.Text == "Orlando" && txtcontra.Text == "1234")
            {
                menu.Show();
                this.Hide();
            }
            else if ((txtusuario.Text == "Criss" && txtcontra.Text == "12345") || (txtusuario.Text=="Dubby" && txtcontra.Text=="123456"))
            {
                menu.Show();
                this.Hide();
            }
            
            else
            {
                lblerror.Visible = true;
                
            }

        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            txtusuario.Clear();
            txtcontra.Clear();
            lblerror.Visible = false;
        }
    }
    }
    

