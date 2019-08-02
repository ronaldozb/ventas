﻿using Mantenimiento.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mantenimiento
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            var clienteBL = new ClienteBL();
            listadeClienteBindingSource.DataSource = clienteBL.ListadeCliente;

            var ciudadBL = new CiudadBL();
            listadeCiudadBindingSource.DataSource = ciudadBL.ListadeCiudad;
        }
    }
}
