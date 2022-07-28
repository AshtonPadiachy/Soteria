using Prism;
using Prism.Ioc;
using SoteriaApp.Services;
using SoteriaApp.Services.Interfaces;
using SoteriaApp.ViewModels;
using SoteriaApp.Views;
using Xamarin.Essentials.Implementation;
using Xamarin.Essentials.Interfaces;
using Xamarin.Forms;

namespace SoteriaApp
{
    public partial class App
    {
        public App(IPlatformInitializer initializer)
            : base(initializer)
        {
        }

        protected override async void OnInitialized()
        {
            InitializeComponent();

            var prefs = Container.Resolve<IPreferences>();
            var tracking = Container.Resolve<IVersionTracking>();

            if (prefs.Get("AlwaysShowTutorial", true) || tracking.IsFirstLaunchForCurrentVersion)
                await NavigationService.NavigateAsync("TutorialPage");
            else
                await NavigationService.NavigateAsync("LandingTabbedPage");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<IAppInfo, AppInfoImplementation>();
            containerRegistry.RegisterSingleton<IVersionTracking, VersionTrackingImplementation>();
            containerRegistry.RegisterSingleton<IPreferences, PreferencesImplementation>();

            containerRegistry.Register<ISoteriaService, SoteriaService>();

            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<LandingTabbedPage, LandingTabbedPageViewModel>();
            containerRegistry.RegisterForNavigation<CommunityChat, CommunityChatViewModel>();
            containerRegistry.RegisterForNavigation<InsightsPage, InsightsPageViewModel>();
            containerRegistry.RegisterForNavigation<AccountPage, AccountPageViewModel>();
            containerRegistry.RegisterForNavigation<TutorialPage, TutorialPageViewModel>();
            containerRegistry.RegisterForNavigation<LoginPage, LoginPageViewModel>();
            containerRegistry.RegisterForNavigation<SettingPage, SettingPageViewModel>();
            containerRegistry.RegisterForNavigation<HelplinePage, HelplinePageViewModel>();
            containerRegistry.RegisterForNavigation<SignInPage, SignInPageViewModel>();
            containerRegistry.RegisterForNavigation<ChooseProfileType, ChooseProfileTypeViewModel>();
            containerRegistry.RegisterForNavigation<ThankYouPage, ThankYouPageViewModel>();
            containerRegistry.RegisterForNavigation<ReportPage, ReportPageViewModel>();
            containerRegistry.RegisterForNavigation<LearnerProfilePageContentPage, LearnerProfilePageViewModel>();
            containerRegistry.RegisterForNavigation<ProfilePage, ProfilePageViewModel>();

        }
    }
}
