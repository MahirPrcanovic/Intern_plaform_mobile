using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People.ViewModel
{
    public partial class AddNewSelectionViewModel : ObservableObject
    {
        CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
        private string toastText = "";
        private ToastDuration duration = ToastDuration.Short;
        private double fontSize = 14;
        [ObservableProperty]
        string selectionName;
        [ObservableProperty]
        string description;
        [ObservableProperty]
        DateTime dateOfEnd;
        [ObservableProperty]
        DateTime dateOfStart;
        [ObservableProperty]
        DateTime minimumDate;
        public AddNewSelectionViewModel()
        {
            minimumDate = DateTime.Now;
        }
        [RelayCommand]
        public async void AddNewSelection()
        {
            App.SelectionRepository.AddNewSelection(new Models.Selections { SelectionName = selectionName, DateOfStart = DateOfStart, DateOfEnd = DateOfEnd, Description = description, UserID = App.loggedInUser.Id});
            toastText = App.SelectionRepository.StatusMessage;
            var toast = Toast.Make(toastText, duration, fontSize);
            await toast.Show(cancellationTokenSource.Token);
        }
    }
}
