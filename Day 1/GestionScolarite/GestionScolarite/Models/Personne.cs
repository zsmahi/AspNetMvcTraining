namespace GestionScolarite.Models
{
    public abstract class Personne : Model
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public override string Name
        {
            get
            {
                /*Nom + " " + Prenom; */
                return string.Concat(Nom, " ", Prenom); 
            }
        }
    }
}