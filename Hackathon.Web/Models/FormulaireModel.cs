using Hackathon.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hackathon.Web.Models
{
    public class FormulaireModel
    {
        private int currentPageNumber = 0;

        public Formulaire Formulaire { get; set; }

        public int CurrentPageNumber
        {
            get
            {
                return currentPageNumber;
            }
        }

        public bool IsFirstPage
        {
            get
            {
                return currentPageNumber == 0;
            }
        }


        public bool IsLastPage
        {
            get
            {
                return currentPageNumber == Formulaire.Pages.Count;
            }
        }


        public Page GetNextPage()
        {
            currentPageNumber++;
            return Formulaire.Pages[currentPageNumber];
        }


        public Page GetPreviousPage()
        {
            currentPageNumber--;
            return Formulaire.Pages[currentPageNumber];
        }

        public void UpdateCurrentPage(Page page)
        {
            Formulaire.Pages[currentPageNumber] = page;
        }
    }
}