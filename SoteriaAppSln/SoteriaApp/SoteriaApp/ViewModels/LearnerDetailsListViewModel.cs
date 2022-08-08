using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SoteriaApp.ViewModels
{
    public class LearnerDetailsListViewModel : BindableBase
    {
        public LearnerDetailsListViewModel()
        {

        }

        public string NameOfLearner { get; set; }
        public string NameofImage { get; set; }
        public int LearnerGrade { get; set; }
    }
}
