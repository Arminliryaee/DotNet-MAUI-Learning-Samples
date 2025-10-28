using CommunityToolkit.Mvvm.Input;
using MauiDevelopmentCourse.Models;
using MauiDevelopmentCourse.Repositories;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace MauiDevelopmentCourse.ViewModels
{
    public partial class CarListViewModel : BaseViewModel
    {
        private readonly CarRepository repository;
        public ObservableCollection<Car> Cars { get; private set; } = [];

        public CarListViewModel(CarRepository repository)
        {
            Title = "Car List";
            this.repository = repository;
        }

        [RelayCommand]
        async Task GetCars()
        {
            if (IsLoading) return;
            try
            {
                IsLoading = true;
                if (Cars.Any()) Cars.Clear();

                var cars = repository.GetCars();
                foreach (var car in cars) Cars.Add(car);

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                await Shell.Current.DisplayAlert("Error", "something went wrong!", "ok");
            }
            finally
            {
                IsLoading = false;
            }

        }
    }
}
