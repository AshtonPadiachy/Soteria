using SoteriaApp.ViewModels;
using System.Collections.Generic;
using Xamarin.Forms;

namespace SoteriaApp.Views
{
    public partial class LearnerDetailsList : ContentPage
    {
        private List<LearnerDetailsListViewModel> _learnersList = new List<LearnerDetailsListViewModel>();
        public List<LearnerDetailsListViewModel> LearnersList
        {
            get { return _learnersList; }
            set { _learnersList = value; }
        }
        public LearnerDetailsList()
        {
            InitializeComponent();

            var learner = new LearnerDetailsListViewModel();
            learner.NameOfLearner = "David Jonkers";
            learner.NameofImage = "ninja.png";

            LearnersList.Add(learner);

            learner = new LearnerDetailsListViewModel();
            learner.NameOfLearner = "Olwethu Mapisa";
            learner.NameofImage = "princess.png";

            LearnersList.Add(learner);

            learner = new LearnerDetailsListViewModel();
            learner.NameOfLearner = "Brandon Cloete";
            learner.NameofImage = "boy.png";

            LearnersList.Add(learner);


            learner = new LearnerDetailsListViewModel();
            learner.NameOfLearner = "Asanda Dyibi";
            learner.NameofImage = "boy.png";

            LearnersList.Add(learner);


            BindingContext = this;
        }
    }
}
