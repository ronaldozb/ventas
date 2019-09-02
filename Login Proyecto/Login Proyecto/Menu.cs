using Login_Proyecto.BL;
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
    public partial class Menu : Form
    {
        ClienteBL _clienteBL;
        HabitacionBL _habitacionBL;
        FacturaBL _facturaBL;

        public Menu()
        {
            
            InitializeComponent();
            _clienteBL = new ClienteBL();
            _habitacionBL = new HabitacionBL();
            _facturaBL = new FacturaBL();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var login = new Form1();
            login.Show();
            this.Hide();
        }

        private void checkInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var chekin = new checkIn();
            chekin.MdiParent = this;
            chekin.cargarDatos(_clienteBL, _habitacionBL);
            chekin.Show();
            pictureBox1.Visible = false;
            label2.Visible = false;

        }

        private void checkOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var cancelar = new CancelarReservacion();
            cancelar.MdiParent = this;
            cancelar.cargarDatos(_clienteBL, _habitacionBL);
            cancelar.Show();
            pictureBox1.Visible = false;
            label2.Visible = false;
        }

        private void generarFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var generarfactura = new GenerarFactura();
            generarfactura.MdiParent = this;
            generarfactura.cargarDatos(_facturaBL, _clienteBL, _habitacionBL);
            generarfactura.Show();
            pictureBox1.Visible = false;
            label2.Visible = false;
        }
    }
}
