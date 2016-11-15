using Hackathon.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeServiceWeb
{
    public class FakeService
    {
        public List<Formulaire> GetFormulaires()
        {
            return new List<Formulaire>()
            {
                new Formulaire()
                {
                    Id = 1,
                    Titre = "Titre 01",
                    DateCreation = new DateTime(2016,11,11),
                    DateMaj = new DateTime(2016,11,11),
                    Reponses = new List<Reponse>()
                    {
                        new Reponse(), new Reponse (), new Reponse()
                    }
                },

                new Formulaire()
                {
                    Id = 2,
                    Titre = "Titre 02",
                    DateCreation = new DateTime(2016,05,01),
                    DateMaj = new DateTime(2016,11,11),

                },

                new Formulaire()
                {
                    Id = 3,
                    Titre = "Titre 03",
                    DateCreation = new DateTime(2016,10,11),
                    DateMaj = new DateTime(2016,11,11),
                    Reponses = new List<Reponse>()
                    {
                        new Reponse(), new Reponse()
                    }
                }
            };
        }

    }
}
