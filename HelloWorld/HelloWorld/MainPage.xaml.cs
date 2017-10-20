using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HelloWorld
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnClicked(object sender, EventArgs args)
        {
            this.labelHelloWorld.Text = "こんにちは世界";
        }

    }
}
