namespace Hackathon.Domain
{
    public class Statut 
    {
        public long Id { get; set; }

        public CodeStatut Code { get; set; }

        public string Libelle { get; set; }        
    }

    public enum CodeStatut
    {
        ECR,
        VAL,         
        CLO,
        ARC
    }
}