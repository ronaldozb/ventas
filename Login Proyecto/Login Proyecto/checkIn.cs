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
    public partial class checkIn : Form
    {
        public checkIn()
        {
            InitializeComponent();
            
        }

        public void cargarDatos(ClienteBL clienteBL, HabitacionBL habitacionBL)
        {
            
            listadeClientesBindingSource.DataSource = clienteBL.ListadeClientes;
            listadeHabitacionBindingSource.DataSource = habitacionBL.ListadeHabitacion;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void nombreTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }
    }
}
