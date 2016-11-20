using Hackathon.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hackathon.Web.Models
{
    public class FormulaireModel
    {
        public FormulaireModel()
        {
            CurrentPageNb = 0;
        }

        public Formulaire Formulaire { get; set; }

        public int CurrentPageNb { get; set; }

        public Page CurrentPage
        {
            get
            {
                return Formulaire.Pages.ToList()[CurrentPageNb];
            }                
        }
    }
}