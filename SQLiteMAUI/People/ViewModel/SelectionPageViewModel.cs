using CommunityToolkit.Maui.Core.Extensions;
using CommunityToolkit.Mvvm.ComponentModel;
using People.Models;
using System.Collections.ObjectModel;


namespace People.ViewModel
{
    public partial class SelectionPageViewModel : ObservableObject
    {
        [ObservableProperty]
        ObservableCollection<Selections> selectionList;
        [ObservableProperty]
        string selectionCount;
        [ObservableProperty]
        string laterCount;
        [ObservableProperty]
        string fullTimeCount;
        public SelectionPageViewModel()
        {
            selectionList = App.SelectionRepository.GetAllSelections().ToObservableCollection();
            selectionCount = selectionList.Count.ToString();
            laterCount = Convert.ToInt32((selectionList.Count * 0.3)).ToString();
            fullTimeCount = Convert.ToInt32((selectionList.Count * 0.2)).ToString();
        }
    }
}
