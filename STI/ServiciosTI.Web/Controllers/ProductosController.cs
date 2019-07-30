﻿using ServiciosTI.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ServiciosTI.Web.Controllers
{
    public class ProductosController : Controller
    {
        // GET: Productos
        public ActionResult Index()
        {
            var producto1 = new ProductoModel();
            producto1.Id = 1;
            producto1.Descripcion = "Auriculares";


            var producto2= new ProductoModel();
            producto2.Id = 2;
            producto2.Descripcion = "Usb";


            var producto3 = new ProductoModel();
            producto3.Id = 3;
            producto3.Descripcion = "Baterias";

            var listadeproductos = new List<ProductoModel>();
            listadeproductos.Add(producto1);
            listadeproductos.Add(producto2);
            listadeproductos.Add(producto3);
            return View(listadeproductos);
        }
    }
}