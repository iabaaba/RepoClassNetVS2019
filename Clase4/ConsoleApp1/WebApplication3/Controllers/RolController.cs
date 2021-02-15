using BEAN;
using DAO1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace WebApplication3.Controllers
{
    
    public class RolController : Controller
    {
        RolDAO roldao = new RolDAO();
        // GET: Rol
        [HttpGet]
        public ActionResult Index()
        {
            RolDAO rolDAO = new RolDAO();
            List<RolBEAN> listaRol = new List<RolBEAN>();
            listaRol = rolDAO.listaRoles();
            return View(listaRol);
        }
        [HttpGet]
        public ActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Create(RolBEAN rol ) 
        {
            RolDAO dao =new RolDAO();
            bool rpta = dao.RegistroRol(rol);
            if (rpta)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            RolBEAN rolBEAN = roldao.
            return View();
        }
        [HttpPost]
        public ActionResult ActualizarDatosRol(RolBEAN rol  ) {
            bool rpta = roldao.EditarRol(rol);
            if (rpta)
            {
                return RedirectToRoute("index");
            }
            else
            {
                return View();
            }
        }


    }
}