using CommunityToolkit.Maui.Core.Extensions;
using CommunityToolkit.Mvvm.ComponentModel;
using People.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;


namespace People.ViewModel
{
    public partial class SelectionPageViewModel : ObservableObject
    {
        [ObservableProperty]
        ObservableCollection<Selections> selectionList;
        public SelectionPageViewModel()
        {
            selectionList = App.SelectionRepository.GetAllSelections().ToObservableCollection();
        }
    }
}
