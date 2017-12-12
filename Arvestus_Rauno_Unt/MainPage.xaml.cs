using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Arvestus_Rauno_Unt
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void button1_Click_1(object sender, RoutedEventArgs e)
        {
            if (textbox1.Text == "kasutaja" && passwordbox1.Password.ToString() == "parool264")
            {
                answer1.Text = "Sisselogimine õnnestus.";
                this.Frame.Navigate(typeof(Content));
            }
            else
            {
                answer1.Text = "Sisselogimine ebaõnnestus.";

            }
        }



    }
}
