using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;


namespace People.ViewModel
{
    public partial class ProfilePageViewModel : ObservableObject
    {
        [ObservableProperty]
        string email;
        [ObservableProperty]
        string currentPassword;
        [ObservableProperty]
        string newPassword;
        [ObservableProperty]
        string error;
        public ProfilePageViewModel()
        {
            email = App.loggedInUser.Email;
        }

        [RelayCommand]
        public void ChangePassword()
        {
            if(App.loggedInUser.Password != currentPassword)
            {
                error = "Current password do not match";
                return;
            }
            App.UserRepository.ChangePassword(email, newPassword);
            error = App.UserRepository.StatusMessage;
        }
    }
}
