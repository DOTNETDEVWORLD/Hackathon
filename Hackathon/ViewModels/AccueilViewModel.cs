using FakeServiceWeb;
using Hackathon.Commands;
using Hackathon.Domain;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Hackathon.ViewModels
{
    public class AccueilViewModel : ViewModelBase
    {
        private ObservableCollection<Formulaire> formulaires;

        private FakeService fakeWebService;

        public AccueilViewModel()
        {
            fakeWebService = new FakeService();
        }

        public ObservableCollection<Formulaire> Formulaires
        {
            get
            {
                return formulaires ?? (formulaires = new ObservableCollection<Formulaire>(fakeWebService.GetFormulaires()));
            }
            set
            {
                formulaires = value;
                NotifyPropertyChanged();
            }
        }

        public ICommand TestCommand
        {
            get
            {
                return new Command(supprimerFormulaire);
            }
        }

        public ICommand SupprimerFormulaireCommand
        {
            get
            {
                return new Command(supprimerFormulaire);
            }
        }

        private void supprimerFormulaire(object parameter)
        {
            var formulaireToDelete = parameter as Formulaire;

            Formulaires.Remove(formulaireToDelete);
        }
    }
}
