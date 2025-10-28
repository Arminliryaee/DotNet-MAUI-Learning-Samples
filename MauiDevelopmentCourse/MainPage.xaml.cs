using MauiDevelopmentCourse.ViewModels;

namespace MauiDevelopmentCourse
{
    public partial class MainPage : ContentPage
    {

        public MainPage(CarListViewModel vm)
        {
            InitializeComponent();
            BindingContext = vm;
        }

        
    }
}
