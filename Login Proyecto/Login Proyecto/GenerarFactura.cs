using Login_Proyecto.BL;
using Login_Proyecto.Modelos;
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
    public partial class GenerarFactura : Form
    {
        
        public GenerarFactura()
        {
            InitializeComponent();
        }

        public void cargarDatos(FacturaBL facturasBL, ClienteBL clientesBL, HabitacionBL habitacionesBL)
        {
            
            listadeFacturasBindingSource.DataSource = facturasBL.ListadeFacturas;
            listadeClientesBindingSource.DataSource = clientesBL.ListadeClientes;
            listadeHabitacionBindingSource.DataSource = habitacionesBL.ListadeHabitacion;

        }

        private void GenerarFactura_Load(object sender, EventArgs e)
        {

        }

        private void facturaDetalleDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var factura = (Factura)listadeFacturasBindingSource.Current;
            factura.CalcularFactura();
            listadeFacturasBindingSource.ResetBindings(false);
        }
    }
}
