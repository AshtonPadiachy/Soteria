using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using SoteriaApp.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace SoteriaApp.ViewModels
{
    public class ReportPageViewModel : ViewModelBase
    {
      


        public ReportPageViewModel(INavigationService navigationService) : base(navigationService)
        {

        }


        public IList<string> ZonesOfRegulation
        {
            get
            {
                return new List<string> { " Green ", " Yellow ", " Blue ", " Red " };
            }
           
        }

       


    }
}


