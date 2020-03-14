using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AngularCrud.Models
{
    public class Proveedor
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string direccion { get; set; }
        public string num_telf { get; set; }
    }
}