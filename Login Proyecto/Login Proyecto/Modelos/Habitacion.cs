using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login_Proyecto.Modelos
{
    public class Habitacion
    {
        public int Id { get; set; }
        public string TipodeHabitacion { get; set; }
        public double Precio { get; set; }

        public Habitacion()
        {
            
        }

        public Habitacion(int id, string tipohabitacion, double precio)
        {
            Id = id;
            TipodeHabitacion = tipohabitacion;
            Precio = precio;    
        }
    }
}
