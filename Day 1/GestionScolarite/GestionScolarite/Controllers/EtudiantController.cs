using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using GestionScolarite.BDD;
using GestionScolarite.Models;

namespace GestionScolarite.Controllers
{
    public class EtudiantController : Controller
    {
        private void IntializeDataBase()
        {
            BDD.BDD.Intialize();
        }

        // GET: Etudiant
        public ActionResult Index()
        {
            if (BDD.BDD.Etudiants == null || BDD.BDD.Etudiants.Count == 0)
            {
                IntializeDataBase();
            }
            List<Etudiant> etudiants = BDD.BDD.Etudiants;
            return View(etudiants);
        }

        public ActionResult Details(string code)
        {
            if (string.IsNullOrEmpty(code))
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest, "Bad Request");
            }
            if (BDD.BDD.Etudiants == null || BDD.BDD.Etudiants.Count == 0)
            {
                IntializeDataBase();
            }

            List<Etudiant> etudiants = BDD.BDD.Etudiants;
            if (etudiants == null || etudiants.Count == 0)
            {
                return HttpNotFound();
            }
            else
            {
                Etudiant etudiant = etudiants.FirstOrDefault(f => f.Code == code);
                if (etudiant == null)
                {
                    return HttpNotFound();
                }
                else
                {
                    return View(etudiant);
                }
            }
        }
    }
}