using NewMInecraftLauncher.Models;
using NewMInecraftLauncher.ViewModels;

namespace NewMInecraftLauncher
{
    public partial class MainPage : ContentPage
    {
        public double ScrollViewRowHeight { get; set; }
        private readonly MainPageViewModel _mainPageViewModel;
        public MainPage()
        {
            InitializeComponent();




            _mainPageViewModel = new MainPageViewModel();

            BindingContext = _mainPageViewModel;

            var screenHeight = Microsoft.Maui.Devices.DeviceDisplay.MainDisplayInfo.Height;
            ScrollViewRowHeight = screenHeight - 200;

        }

    }

}
