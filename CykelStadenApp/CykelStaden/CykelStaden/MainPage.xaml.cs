﻿using System;
using CykelStaden.Resources.Icons;
using CykelStaden.Resources.Langs;
using System.Collections.Generic;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace CykelStaden
{
    /// <summary>
    /// Material Drawer navigation page.
    /// </summary>
    [Preserve(AllMembers = true)]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        /// <summary>
        /// Defines the DrawerHeaderWidth.
        /// </summary>
        public static double DrawerHeaderWidth = DeviceDisplay.MainDisplayInfo.Width / DeviceDisplay.MainDisplayInfo.Density * 0.8;

        /// <summary>
        /// Defines the DrawerHeaderHeight.
        /// </summary>
        public static double DrawerHeaderHeight = DeviceDisplay.MainDisplayInfo.Height / DeviceDisplay.MainDisplayInfo.Density * 0.25;

        /// <summary>
        /// Defines the DrawerFooterHeight.
        /// </summary>
        public static double DrawerFooterHeight = DeviceDisplay.MainDisplayInfo.Height / DeviceDisplay.MainDisplayInfo.Density * 0.10;

        /// <summary>
        /// Initializes a new instance of the <see cref="MainPage"/> class.
        /// </summary>
        public MainPage()
        {
            InitializeComponent();
            drawerNavItems();
            LanguageChangedEvent();
        }

        /// <summary>
        /// The drawerNavItems.
        /// </summary>
        private void drawerNavItems()
        {
            List<MenuItem> itemList = new List<MenuItem>();
            itemList.Add(new MenuItem { 
                ItemIcon = IconFont.LocationOn, 
                ItemName = Lang.Map 
            });
            itemList.Add(new MenuItem { 
                ItemIcon = IconFont.Report, 
                ItemName = Lang.ErrorReport 
            });
            itemList.Add(new MenuItem { 
                ItemIcon = IconFont.Settings, 
                ItemName = Lang.Settings 
            });

            listView.ItemsSource = itemList;
        }

        /// <summary>
        /// The menuButton_Clicked.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void menuButton_Clicked(object sender, EventArgs e)
        {
            navigationDrawer.ToggleDrawer();
        }

        /// <summary>
        /// The listView_ItemSelected.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="SelectedItemChangedEventArgs"/>.</param>
        public void listView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            switch (e.SelectedItemIndex)
            {
                case 0:
                    settingsPage.IsVisible = false;
                    headerLabel.Text = Lang.Map.ToUpper();
                    break;

                case 1:
                    settingsPage.IsVisible = false;
                    headerLabel.Text = Lang.ErrorReport.ToUpper();
                    break;

                case 2:
                    settingsPage.IsVisible = true;
                    headerLabel.Text = Lang.Settings.ToUpper();
                    break;

                default:
                    settingsPage.IsVisible = false;
                    headerLabel.Text = Lang.AppName.ToUpper();
                    break;
            }

            navigationDrawer.ToggleDrawer();
        }

        //Here we subscribe to the LanguageChangedEvent
        //and we update the menu list with the translated values.
        private void LanguageChangedEvent()
        {
            MessagingCenter.Subscribe<object, string>(this, "LanguageChanged", (sender, arg) =>
            {
                drawerNavItems();
                headerLabel.Text = Lang.Settings.ToUpper();
            });
        }
    }

    /// <summary>
    /// Defines the <see cref="MenuItem" />.
    /// </summary>
    internal class MenuItem
    {
        /// <summary>
        /// Gets or sets the ItemIcon.
        /// </summary>
        public string ItemIcon { get; set; }

        /// <summary>
        /// Gets or sets the ItemName.
        /// </summary>
        public string ItemName { get; set; }
    }
}
