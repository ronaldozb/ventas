using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login_Proyecto.Modelos
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public DateTime FechaEntrada { get; set; }
        public DateTime FechaSalida { get; set; }
        public string HabitacionId { get; set; }
        public Habitacion Habitacion { get; set; }

        public Cliente()
        {
            Habitacion = new Habitacion();
            HabitacionId = Habitacion.TipodeHabitacion;
        }
        

        public Cliente(int id, string nombre, string telefono, Habitacion habitacion)
        {
            Id = id;
            Nombre = nombre;
            Telefono = telefono;
            HabitacionId = habitacion.TipodeHabitacion;
            Habitacion = habitacion;
            
        }
    }
}
