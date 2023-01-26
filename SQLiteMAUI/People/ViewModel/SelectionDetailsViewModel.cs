using CommunityToolkit.Maui.Core.Extensions;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using People.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People.ViewModel
{
    public partial class SelectionDetailsViewModel : ObservableObject
    {
        [ObservableProperty]
        Selections selection;
        [ObservableProperty]
        string selectionName;
        [ObservableProperty]
        string selectionDescription;
        [ObservableProperty]
        ObservableCollection<Student> selectionStudents;
        [ObservableProperty]
        DateTime selectionStartDate;
        [ObservableProperty]
        DateTime selectionEndDate;
        [ObservableProperty]
        string createdBy;
        [ObservableProperty]
        string selectedItem;
        [ObservableProperty]
        string text;
        [ObservableProperty]
        string index;
        public SelectionDetailsViewModel(int selectionID)
        {
            selection = App.SelectionRepository.GetSelection(selectionID);
            selectionName = selection.SelectionName;
            selectionDescription = selection.Description;
            selectionStudents = App.SelectionStudentRepository.getAllSelectionStudents(selectionID).ToObservableCollection();
            selectionStartDate = selection.DateOfStart;
            selectionEndDate = selection.DateOfEnd;
            CreatedBy = App.UserRepository.getByID(selection.UserID).Email;
        }
        [RelayCommand]
        public void AddNewStudent()
        {
            text = index;
            if (index.Trim().Length == 0) return;
            selectionStudents.Add(App.PersonRepository.GetByEmail(index));
            App.SelectionStudentRepository.AddNewfield(selection.Id, App.PersonRepository.GetByEmail(index).Id);
        }
    }
}
