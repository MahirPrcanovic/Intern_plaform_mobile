﻿using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People.ViewModel
{
    public partial class SelectionPageViewModel : ObservableObject
    {
        [ObservableProperty]
        string text;
        public SelectionPageViewModel()
        {
            text = "nesto test";
        }
    }
}
