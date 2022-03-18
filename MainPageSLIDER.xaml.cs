using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
namespace App11
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            var Cars = new List<string>
            {
                "https://imageio.forbes.com/specials-images/imageserve/5d35eacaf1176b0008974b54/2020-Chevrolet-Corvette-Stingray/0x0.jpg?fit=crop&format=jpg&crop=4560,2565,x790,y784,safe",
                "https://www.autocar.co.uk/sites/autocar.co.uk/files/styles/body-image/public/ferrari-f8-tributo.jpg?itok=jGis6jFY",
                "https://i.insider.com/550c6d0c6da8118d60b5030a?width=1000&format=jpeg&auto=webp"
            };
            TopRated.ItemsSource = Cars;
        }
    }
}