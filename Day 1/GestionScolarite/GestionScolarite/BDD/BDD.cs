using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GestionScolarite.Models;

namespace GestionScolarite.BDD
{
    public static class BDD
    {
        public static List<Etudiant> Etudiants { get; set; }
        public static List<Enseignant> Enseignants { get; set; }

        public static void Intialize()
        {
            Etudiants = new List<Etudiant>();
            Enseignants = new List<Enseignant>();

            Etudiant etudiant1 = new Etudiant();
            etudiant1.Prenom = "Said";
            etudiant1.Nom = "Dahdouh";
            etudiant1.Code = "etu0001";

            Etudiant etudiant2 = new Etudiant();
            etudiant2.Prenom = "Sawsan";
            etudiant2.Nom = "Toumi";
            etudiant2.Code = "etu0002";
            Etudiants.Clear();
            Etudiants.Add(etudiant1);
            Etudiants.Add(etudiant2);
        }
    }
}