using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SoteriaApp.ViewModels
{
    public class LearnerReportsListViewModel : BindableBase
    {
        public LearnerReportsListViewModel()
        {

        }

        public string TitleOfReport { get; set; }

        public string NameofImage { get; set; }

        public DateTime LatestUpdate { get; set; }

        public int ReportNumbers { get; set; }
    }
}
