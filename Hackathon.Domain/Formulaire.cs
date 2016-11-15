using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackathon.Domain
{
    public class Formulaire
    {
        public Formulaire()
        {
            //Reponses = new HashSet<Reponse>();
        }

        public long Id { get; set; }

        public string Titre { get; set; }

        public string Url { get; set; }

        public DateTime DateCreation { get; set; }

        public DateTime DateMaj { get; set; }

        public Utilisateur Utilisateur { get; set; }

        public Statut Statut { get; set; }

        public ICollection<Reponse> Reponses { get; set; }

    }
}
