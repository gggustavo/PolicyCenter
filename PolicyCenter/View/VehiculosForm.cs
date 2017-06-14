﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class VehiculosForm : Form
    {
        private Controller.VehiculosController vehiculosController = new Controller.VehiculosController();

        public VehiculosForm()
        {
            InitializeComponent();

            vehiculoBindingSource.DataSource = vehiculosController.ObtenerVehiculos()
                                                                  .Select(_ => new {  Marca = _.Marca.Nombre, Modelo = _.Modelo.Nombre,
                                                                                      Version = _.Version.Nombre, Precio = _.Precio,
                                                                                      Ramo = _.Ramo.Nombre, Anio = _.Anio });
        }
    }
}
