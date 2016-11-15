using FakeServiceWeb;
using Hackathon.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackathon.ViewModels
{
    public class AccueilViewModel : ViewModelBase
    {
        private List<Formulaire> formulaires;

        private FakeWebService fakeWebService;

        public AccueilViewModel()
        {
            fakeWebService = new FakeWebService();
        }



        public List<Formulaire> Formulaires
        {
            get
            {
                return formulaires ?? (formulaires = fakeWebService.GetFormulaires());
            }
            set
            {
                formulaires = value;
                NotifyPropertyChanged();

            }
        }

    }
}
