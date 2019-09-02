using Login_Proyecto.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login_Proyecto.BL
{
    public class FacturaBL
    {
        public BindingList<Factura> ListadeFacturas { get; set; }

        public FacturaBL()
        {
            ListadeFacturas = new BindingList<Factura>();
        }
    }
}
