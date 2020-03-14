using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AngularCrud.Models;

namespace AngularCrud.Controllers
{
    public class ProveedorController : Controller
    {
        private CrudContext _context = null;

        public ProveedorController()
        {
            _context = new CrudContext();
        }
        // GET: Proveedor
        public JsonResult GetProveedores()
        {
            List<Proveedor> listProveedor = _context.Proveedores.ToList();
            return Json(new { list = listProveedor },JsonRequestBehavior.AllowGet

                );
        }

        public JsonResult getProveedorById(int id)
        {
            Proveedor proveedor = _context.Proveedores.Where(c => c.id == id).SingleOrDefault();
            return Json(new { proveedor = proveedor }, JsonRequestBehavior.AllowGet);

        }

        public JsonResult AddProveedor(Proveedor proveedor)
        {
            _context.Proveedores.Add(proveedor);
            _context.SaveChanges();
            return Json(new { status = "El Proveedor ha sido agregado correctamente" });
        }

        public JsonResult UpdateProveedor(Proveedor provedor)
        {
            _context.Entry(provedor).State = System.Data.Entity.EntityState.Modified;
            _context.SaveChanges();
            return Json(new { status = "El Proveedor ha actualizado con exito" });

        }

        public JsonResult DeleteProveedor(int id)
        {
            Proveedor proveedor = _context.Proveedores.Where(c => c.id == id).SingleOrDefault();
            _context.Proveedores.Remove(proveedor);
            _context.SaveChanges();
            return Json(new { status = "El Proveedor ha sido borrado con exito" });
        }
            
    }
}