using System;

namespace GestionScolarite.Models
{
    public class Epreuve : Model
    {
        public DateTime DateHeureDebut { get; set; }
        public int DureeEnMinutes { get; set; }
        public TypeEpreuve Type { get; set; }

    }

    public enum TypeEpreuve
    {
        Interro = 1,
        Controle =2,
        Examen = 3,
        Tp = 4,
        Autre = 5
    }

}