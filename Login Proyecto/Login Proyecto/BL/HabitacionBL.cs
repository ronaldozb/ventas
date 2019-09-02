using Login_Proyecto.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login_Proyecto.BL
{
    public class HabitacionBL
    {
        public BindingList<Habitacion> ListadeHabitacion { get; set; }

        public HabitacionBL()
        {
            ListadeHabitacion = new BindingList<Habitacion> ();
            CrearDatosdePrueba();
        }

        public double ObtenerPrecio(int id)
        {
            double precio=0;
            foreach (var habitacion in ListadeHabitacion)
            {
                if (habitacion.Id==id)
                {
                    precio = habitacion.Precio;
                }
            }
            return precio;
        }

        private void CrearDatosdePrueba()
        {
            var habitacion1 = new Habitacion(1,"Sencilla", 800);
            var habitacion2 = new Habitacion(2,"Doble", 1400);
            var habitacion3 = new Habitacion(3,"Triple", 1200);
            var habitacion4 = new Habitacion(4,"Precidencial", 3000);

            ListadeHabitacion.Add(habitacion1);
            ListadeHabitacion.Add(habitacion2);
            ListadeHabitacion.Add(habitacion3);
            ListadeHabitacion.Add(habitacion4);
        }
    }
}
