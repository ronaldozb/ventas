using Login_Proyecto.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login_Proyecto.Modelos
{
    public class Factura
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }

        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }

        public double SubTotal { get; set; }
        public double Impuesto { get; set; }
        public double Total { get; set; }

        public bool Activo { get; set; }

        public BindingList<FacturaDetalle> FacturaDetalle { get; set; }

        public Factura()
        {
            Fecha = DateTime.Now;
            Activo = true;
            FacturaDetalle = new BindingList<FacturaDetalle>();
        }

        public void CalcularFactura()
        {
            var habitacionBL = new HabitacionBL();
            double subtotal = 0;
            foreach (var detalle in FacturaDetalle)
            {
                var precio = habitacionBL.ObtenerPrecio(detalle.HabitacionId);
                subtotal=subtotal + detalle.CarcularTotal(precio);
            }

            SubTotal = subtotal;
            Impuesto = SubTotal * 0.15;
            Total = SubTotal + Impuesto;
        }
    }

    public class FacturaDetalle
    {
        public int Id { get; set; }

        public int HabitacionId { get; set; }
        public Habitacion Habitacion { get; set; }

        public int DiasDeEstadia { get; set; }
        public double Precio { get; set; }
        public double Total { get; set; }

        public FacturaDetalle()
        {
            DiasDeEstadia = 1;
            HabitacionId = 1;
        }

        public double CarcularTotal(double precio)
        {
            Precio = precio;
            Total = DiasDeEstadia * Precio;

            return Total;
        }
    }
}
