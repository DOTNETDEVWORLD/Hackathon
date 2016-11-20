using Hackathon.Domain;
using Hackathon.Domain.Questions;
using Hackathon.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hackathon.Web.Controllers
{
    public class FormulaireController : Controller
    {
        // GET: Formulaire
        public ActionResult Index()
        {
            var form = new FormulaireModel()
            {
                Formulaire = new Formulaire()
                {
                    Pages = new List<Page>()
                    {
                        new Page()
                        {
                            Questions = new List<Question>()
                            {
                                new QuestionText()
                                {
                                    Libelle = "Votre Nom"
                                },
                                new QuestionChoixUnique()
                                {
                                    Libelle = "Langue préférée",
                                    Propositions = new List<string>() { "C#", "JAVA", "JAVASCRIPT", "C++" }

                                },

                                 new QuestionChoixMultiples()
                                {
                                    Libelle = "Vos loisirs",
                                    Propositions = new List<string>() { "Sport", "Cuisine", "Cinéma", "Voyage" }

                                }
                            }
                        }
                    }
                }

            };

            Session["FormulaireModel"] = form;

            return View(form);
        }


        public ActionResult FormulairePage()
        {
            var formulaire = Session["FormulaireModel"] as FormulaireModel;
            return View(formulaire.CurrentPage);
        }
    }
}