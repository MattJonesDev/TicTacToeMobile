﻿using System;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TicTacToe.Services
{
    public interface INavigationService
    {
        string CurrentPageKey { get; }

        void Configure(string pageKey, Type pageType);
        Task GoBack();
        Task NavigateModalAsync(string pageKey, bool animated = true);
        Task NavigateModalAsync(string pageKey, object parameter, bool animated = true);
        Task NavigateAsync(string pageKey, bool animated = true);
        Task NavigateAsync(string pageKey, object parameter, bool animated = true);
    }
}