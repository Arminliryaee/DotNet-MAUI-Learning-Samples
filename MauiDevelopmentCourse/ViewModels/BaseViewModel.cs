using CommunityToolkit.Mvvm.ComponentModel;

namespace MauiDevelopmentCourse.ViewModels
{
    public partial class BaseViewModel : ObservableObject
    {
        [ObservableProperty]
        string title;
        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(isNotLoading))]
        bool isLoading;

        bool isNotLoading => !isLoading;
    }
}
