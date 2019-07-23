using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Phoneword
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();

            var button = new Button()
            {
                Text = "Click me"
            };

            var layout = new StackLayout
            {
                Orientation = StackOrientation.Vertical
            };

            layout.Children.Add(new Label { Text = "Enter Name" });
            layout.Children.Add(new Entry());
            layout.Children.Add(new Button { Text = "Ok" });

            MainPage.BindingContext = layout;
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
