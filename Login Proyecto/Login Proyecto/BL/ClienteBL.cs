using Login_Proyecto.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login_Proyecto.BL
{
    public class ClienteBL
    {
        public BindingList<Cliente>ListadeClientes { get; set; }

        public ClienteBL()
        {
            ListadeClientes = new BindingList<Cliente>();
            CrearDatosdePrueba();
        }
        private void CrearDatosdePrueba()
        {
            var habitacion1 = new Habitacion(1, "Sencilla", 800);
            var habitacion2 = new Habitacion(2,"Doble", 1400);
            var habitacion3 = new Habitacion(3,"Triple", 1200);
            var habitacion4 = new Habitacion(4,"Precidencial",3000);

            var cliente1 = new Cliente(0801,"Juan Perez","99-00-00-000",habitacion1);
            var cliente2 = new Cliente(0506, "Marta Castro", "99-33-23-60", habitacion2);
            var cliente3 = new Cliente(0801, "Marcos Ponce", "99-70-12-88", habitacion3);
            var cliente4 = new Cliente(0101, "Laura Nieto", "99-66-53-16", habitacion4);

            ListadeClientes.Add(cliente1);
            ListadeClientes.Add(cliente2);
            ListadeClientes.Add(cliente3);
            ListadeClientes.Add(cliente4);
        }
    }
}
