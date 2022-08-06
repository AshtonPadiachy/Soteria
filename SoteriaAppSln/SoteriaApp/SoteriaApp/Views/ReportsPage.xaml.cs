using SoteriaApp.ViewModels;
using Xamarin.Forms;

namespace SoteriaApp.Views
{
    public partial class ReportsPage : ContentPage
    {
        private LearnerReportsListViewModel _report;

        public LearnerReportsListViewModel Report
        {
            get { return _report; } 
            set { _report = value; }    
        }
        public ReportsPage(LearnerReportsListViewModel reports)
        {
            InitializeComponent();

            Report = reports;

            BindingContext = this;

        }


    }
}
