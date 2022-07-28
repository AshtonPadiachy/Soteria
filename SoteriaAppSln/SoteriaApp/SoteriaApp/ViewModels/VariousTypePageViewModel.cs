using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;
using Xamarin.Forms;

namespace SoteriaApp.ViewModels
{
    public class VariousTypePageViewModel : ViewModelBase
    {
        public VariousTypePageViewModel(INavigationService nav) : base(nav)
        {
            AnxietyTypeBtnCommand = new Command(OnAnxietyTypeBtn);
            DepressionTypeBtnCommand = new Command(OnDepressionTypeBtn);
            PtsdTypeBtnCommand = new Command(OnPtsdTypeBtn);
            DbdTypeBtnCommand = new Command(OnDbdTypeBtn);
        }

        public ICommand AnxietyTypeBtnCommand { get; }

        public ICommand DepressionTypeBtnCommand { get; }

        public ICommand PtsdTypeBtnCommand { get; }

        public ICommand DbdTypeBtnCommand { get; }

        private void OnDbdTypeBtn()
        {
            NavigationService.NavigateAsync("DbdTypePage");
        }

        private void OnPtsdTypeBtn()
        {
            NavigationService.NavigateAsync("PtsdTypePage");
        }

        private void OnDepressionTypeBtn()
        {
            NavigationService.NavigateAsync("DepressionTypePage");
        }

        private void OnAnxietyTypeBtn()
        {
            NavigationService.NavigateAsync("AnxietyTypesPage");
        }
    }
}
