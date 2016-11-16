namespace Hackathon.Domain
{
    public class Statut
    {
        public long Id { get; set; }

        public Etat Libelle { get; set; }        
    }

    public enum Etat
    {
        EnCours,
        Valide, 
        Publie,
        Cloture
    }
}