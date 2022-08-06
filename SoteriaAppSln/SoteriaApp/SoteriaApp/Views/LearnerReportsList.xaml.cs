using SoteriaApp.ViewModels;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace SoteriaApp.Views
{
    public partial class LearnerReportsList : ContentPage
    {
        private List<LearnerReportsListViewModel> _reportsList = new List<LearnerReportsListViewModel>();

        public List<LearnerReportsListViewModel> ReportsList
        {
            get { return _reportsList; }
            set { _reportsList = value; }   
        }


        public LearnerReportsList()
        {
            InitializeComponent();

            var report = new LearnerReportsListViewModel();
            report.TitleOfReport = "David Jonkers";
            report.ReportNumbers = 4;
            report.LatestUpdate = new DateTime(2021, 03, 07);
            report.NameofImage = "pokespec.png";

            ReportsList.Add(report);

            report = new LearnerReportsListViewModel();
            report.TitleOfReport = "Ash Levy";
            report.ReportNumbers = 6;
            report.LatestUpdate = new DateTime(2021, 03, 07);
            report.NameofImage = "pokespec.png";

            ReportsList.Add(report);

            report = new LearnerReportsListViewModel();
            report.TitleOfReport = "Dan Chase";
            report.ReportNumbers = 7;
            report.LatestUpdate = new DateTime(2021, 03, 07);
            report.NameofImage = "pokespec.png";

            ReportsList.Add(report);



            /*   report = new LearnerReportsListViewModel();
               report.TitleOfReport = "Dan Chase";
               report.ReportNumbers = 7;
               report.LatestUpdate = new DateTime(2021, 03, 07);
               report.NameofImage = "pokespec.png";

               ReportsList.Add(report);


               report = new LearnerReportsListViewModel();
               report.TitleOfReport = "Hlubi Jozi";
               report.ReportNumbers = 4;
               report.LatestUpdate = new DateTime(2021, 03, 07);
               report.NameofImage = "pokespec.png";

               ReportsList.Add(report);

               report = new LearnerReportsListViewModel();
               report.TitleOfReport = "Zaid Jacobs";
               report.ReportNumbers = 6;
               report.LatestUpdate = new DateTime(2021, 03, 07);
               report.NameofImage = "pokespec.png";

               ReportsList.Add(report);

               report = new LearnerReportsListViewModel();
               report.TitleOfReport = "Raya Williams";
               report.ReportNumbers = 8;
               report.LatestUpdate = new DateTime(2021, 03, 07);
               report.NameofImage = "pokespec.png";

               ReportsList.Add(report);

               report = new LearnerReportsListViewModel();
               report.TitleOfReport = "Jevelyn Peters";
               report.ReportNumbers = 6;
               report.LatestUpdate = new DateTime(2021, 03, 07);
               report.NameofImage = "pokespec.png";

               ReportsList.Add(report);*/


            BindingContext = this;



        }

        private async void ReportsListPage_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            LearnerReportsListViewModel report = e.Item as LearnerReportsListViewModel; 

            if (report != null)
            {
                await Navigation.PushAsync(new ReportsPage(report));
            }
        }
    }
}
