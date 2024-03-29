﻿using System;
using Xamarin.Forms;
using Acr.UserDialogs;

namespace Ziggeo.Xamarin.NetStandard.Demo
{
    public partial class ItemDetailPage : ContentPage
    {
        ItemDetailViewModel viewModel;

        // Note - The Xamarin.Forms Previewer requires a default, parameterless constructor to render a page.
        public ItemDetailPage()
        {
            InitializeComponent();

            var item = new VideoItem
            {
                token = "Item 1",
            };

            viewModel = new ItemDetailViewModel(item);
            BindingContext = viewModel;
        }

        public ItemDetailPage(ItemDetailViewModel viewModel)
        {
            InitializeComponent();

            BindingContext = this.viewModel = viewModel;
            LoadImage();
        }

        async void LoadImage()
        {
            ShowLoading();
            try
            {
                var stream = await App.ZiggeoApplication.Videos.DownloadImage(viewModel.Item.token);
                this.img.Source = ImageSource.FromStream(() => { return stream; });
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", ex.Message, "Okay");
            }
            finally
            {
                HideLoading();
            }
        }

        async void Delete_Clicked(object sender, System.EventArgs e)
        {
            ShowLoading();
            try
            {
                await App.ZiggeoApplication.Videos.Destroy(viewModel.Item.token);
                await Navigation.PopAsync();
            }
            catch (Exception exception)
            {
                await DisplayAlert("Error", exception.Message, "Okay");
            }
            finally
            {
                HideLoading();
            }
        }

        async void Play_Clicked(object sender, System.EventArgs e)
        {
            Ziggeo.IZiggeoPlayer player = App.ZiggeoApplication.Player;
            await player.Play(viewModel.Item.token);
        }

        private void ShowLoading()
        {
            UserDialogs.Instance.Loading().Show();
        }

        private void HideLoading()
        {
            UserDialogs.Instance.Loading().Hide();
        }
    }
}