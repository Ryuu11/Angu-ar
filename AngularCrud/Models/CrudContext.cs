using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace AngularCrud.Models
{
    public class CrudContext: DbContext

    {
        public DbSet<AngularCrud.Models.Proveedor> Proveedores { get; set; }
    }
}