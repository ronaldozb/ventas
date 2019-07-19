using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tarea_2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
    
        private void button1_Click(object sender, EventArgs e)
        {
            //Categorias
            var ciudad1 = new ciudades();
            ciudad1.Id = 1;
            ciudad1.Descripcion = "Urraco";

            var ciudad2 = new ciudades();
            ciudad2.Id = 2;
            ciudad2.Descripcion = "Peña Blanca";

            var ciudad3 = new ciudades();
            ciudad3.Id = 3;
            ciudad3.Descripcion = "Puerto Cortes";

            //Clientes
            var cliente1 = new clientes();
            cliente1.Id = 1;
            cliente1.Nombre = "Carlos Perez";
            cliente1.Telefono = "9998-9796";
            cliente1.Ciudad = ciudad1;
            cliente1.Direccion = "8 ave. 7 calle";

            var cliente2 = new clientes();
            cliente2.Id = 2;
            cliente2.Nombre = "Juana Martinez";
            cliente2.Telefono = "9998-9999";
            cliente2.Ciudad = ciudad2;
            cliente2.Direccion = "6 y 7 ave. 10 calle";

            var cliente3 = new clientes();
            cliente3.Id = 3;
            cliente3.Nombre = "Ronaldo Zelaya";
            cliente3.Telefono = "9735-2021";
            cliente3.Ciudad = ciudad3;
            cliente3.Direccion = "3-4 ave. 1 calle";

            var listadeclientes = new List<clientes>();
            listadeclientes.Add(cliente1);
            listadeclientes.Add(cliente2);
            listadeclientes.Add(cliente3);

            foreach (var c in listadeclientes)
            {
                MessageBox.Show("Cliente:"+c.Nombre+"\nCiudad:"+c.Ciudad.Descripcion);

            }


            

        }
    }
}
