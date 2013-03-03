﻿using System;
using System.Windows;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using CitySafe.Resources;
using Parse;
using Microsoft.Phone.Scheduler;
using System.Diagnostics;
using ScheduledLocationAgent.Data;
using System.Threading.Tasks;
using CitySafe.ViewModels;

namespace CitySafe
{
    /// <summary>
    /// The settings page for the app.
    /// It also controls the PeriodicTask used to 
    /// sending location data to the server in the background.
    /// </summary>
    public partial class SettingsPage : PhoneApplicationPage
    {
        //private PeriodicTask periodicTask;//The background agent used to update user location
        private UserSettings userSettings;//View Model for loading and saving data.

        public SettingsPage()
        {
            InitializeComponent();
            userSettings = new UserSettings();
            SettingsPanel.DataContext = userSettings;
            LoadUIData();
        }

        #region Listeners For UI
        /// <summary>
        /// Lisenter for the ChangeUserButton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangeUserButton_Click(object sender, RoutedEventArgs e)
        {
            ParseUser.LogOut();
            Utilities.SaveParseCredential("", "");//Also clear the user credential stored in the phone.
            App.RemoveAgent();
            //Go back to login page
            NavigationService.Navigate(new Uri("/LoginPage.xaml", UriKind.Relative));
            //Remove back entry. Prevent user from coming back to settings page by pressing back button
            //when he or she is on the login page
            NavigationService.RemoveBackEntry();
        }

        private async void ApplySettingsButton_Click(object sender, RoutedEventArgs e)
        {
            //First save the user settings.
            bool savingResult = await SaveUIData();
            if (!savingResult)
                return;

            bool agentStartingResult = true;

            //Then register/unregister the agent.
            if (userSettings.trackingEnabled)
                agentStartingResult = App.StartPeriodicAgent();
            else
                App.RemoveAgent();

            if (!agentStartingResult)//If the period agent was not started successfully,
            {
                userSettings.trackingEnabled = false;
                await SaveUIData();
            }
        }

        private async void RefreshButton_Click(object sender, RoutedEventArgs e)
        {
            await LoadUIData();
        }

        #endregion

        #region Helper_Method

        /// <summary>
        /// Load the data for the UI.
        /// </summary>
        private async Task LoadUIData()
        {
            App.ShowProgressOverlay(AppResources.Setting_SyncingUserSettingsWithParseServer);
            try
            {
                await userSettings.LoadSettings();
            }
            catch (Exception e)
            {
                Debug.WriteLine("Fail to initialize user settings to the server:\n");
                Debug.WriteLine(e.ToString());
                MessageBox.Show(AppResources.Setting_SyncingFailed);
            }
            App.HideProgressOverlay();
        }

        /// <summary>
        /// Save the UI data to the server.
        /// </summary>
        private async Task<bool>  SaveUIData()
        {
            bool result = true;
            App.ShowProgressOverlay(AppResources.Setting_SyncingUserSettingsWithParseServer);
            try
            {
                await userSettings.SaveSettings();
            }
            catch (Exception e)
            {
                Debug.WriteLine("Fail to save user settings to the server:\n");
                Debug.WriteLine(e.ToString());
                MessageBox.Show(AppResources.Setting_SyncingFailed);
                result = false;
            }
            App.HideProgressOverlay();
            return result;
        }

        #endregion
    }
}