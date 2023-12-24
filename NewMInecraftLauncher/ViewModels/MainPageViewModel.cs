using CommunityToolkit.Mvvm.ComponentModel;
using NewMInecraftLauncher.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace NewMInecraftLauncher.ViewModels
{
    public partial class MainPageViewModel : ObservableObject
    {
        public MainPageViewModel()
        {
            FetchNews();
        }

        [ObservableProperty]
        ObservableCollection<News> news;

        private void FetchNews()
        {
            List<string> NewsColors = new List<string>();
            NewsColors.Add("fff846");
            NewsColors.Add("753ff4");
            NewsColors.Add("f43f4c");
            News = new ObservableCollection<News>();

            for (int i = 1; i <= 10; i++)
            {
                News.Add(new Models.News
                {
                    Name = $"Title{i.ToString()}",
                    Description = $"Description{i.ToString()}",
                    Image = ImageSource.FromUri(new Uri("https://picsum.photos/1024/720"))
                });
            }
        }
    }
}
