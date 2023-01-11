//using CommunityToolkit.Mvvm.ComponentModel;
//using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

namespace People.ViewModel
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        ObservableCollection<string> items;
        [ObservableProperty]
        string text;

        //public MainViewModel()
        //{
        //    items = new ObservableCollection<string>();
        //}
        //[RelayCommand]
        //void Add()
        //{
        //    //add our item
        //    if (string.IsNullOrWhiteSpace(Text)) return;
        //    Items.Add(text);
        //    Text = string.Empty;
        //}
    }
}
