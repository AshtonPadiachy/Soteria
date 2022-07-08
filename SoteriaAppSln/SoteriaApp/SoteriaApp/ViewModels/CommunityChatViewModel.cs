using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SoteriaApp.ViewModels
{
    public class CommunityChatViewModel : ViewModelBase
    {
        public CommunityChatViewModel(INavigationService nav) : base(nav)
        {
            Title = "Community";
        }
    } 
}
