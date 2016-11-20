using FakeServiceWeb;
using Hackathon.Commands;
using Hackathon.Domain;
using Hackathon.ServiceHackathon;
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

        private ServiceHackathonClient fakeWebService;

        public AccueilViewModel()
        {
            fakeWebService = new ServiceHackathonClient();

            CompositeType tt = fakeWebService.GetDataUsingDataContract(new CompositeType());
        }

        public ObservableCollection<Formulaire> Formulaires
        {
            get
            {
                return formulaires ?? (formulaires = new ObservableCollection<Formulaire>());
            }          
        }      

        public ICommand SupprimerFormulaireCommand
        {
            get
            {
                return new Command<Formulaire>(supprimerFormulaire);
            }
        }


        public ICommand ValiderFormulaireCommand
        {
            get
            {
                return new Command<Formulaire>(validerFormulaire);
            }
        }

        public ICommand ArchiverFormulaireCommand
        {
            get
            {
                return new Command<Formulaire>(archiverFormulaire);
            }
        }

        public ICommand CloturerFormulaireCommand
        {
            get
            {
                return new Command<Formulaire>(cloturerFormulaire);
            }
        }

        private void supprimerFormulaire(Formulaire formulaireToDelete)
        {
            Formulaires.Remove(formulaireToDelete);
        }

        private void archiverFormulaire(Formulaire formulaireToArchive)
        {
            formulaireToArchive.Statut = new Statut() { Id = 4, Code = CodeStatut.ARC, Libelle = "Archivé" };
            Formulaires.Remove(formulaireToArchive);
        }

        private void validerFormulaire(Formulaire formulaireToValidate)
        {
            formulaireToValidate.Statut = new Statut() { Id = 2, Code = CodeStatut.VAL, Libelle = "Validé" };
        }

        private void cloturerFormulaire(Formulaire formulaireToClose)
        {
            formulaireToClose.Statut = new Statut() { Id = 3, Code = CodeStatut.CLO, Libelle = "Cloturé" };
        }
    }
}
