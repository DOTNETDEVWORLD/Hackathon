using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackathon.Domain
{
    public class Formulaire : NotificationObject
    {
        public Formulaire()
        {
            Reponses = new HashSet<Reponse>();
        }

        public long Id { get; set; }

        public string Titre { get; set; }

        public string Url { get; set; }

        public DateTime DateCreation { get; set; }

        public DateTime DateMaj { get; set; }

        public Utilisateur Utilisateur { get; set; }

        private Statut statut;
        public Statut Statut
        {
            get
            {
                return statut;
            }
            set
            {
                statut = value;
                NotifyPropertyChange();
            }
        }

        public ICollection<Reponse> Reponses { get; set; }

    }
}
