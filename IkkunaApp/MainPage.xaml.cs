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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace IkkunaApp
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

        public double ikkunan_leveys = 0;
        public double ikkunan_korkeus = 0;
        public double karmin_leveys = 0;
        public double apu1;
        public double apu2;
        public double apu3;

        private void laskubutton_Click(object sender, RoutedEventArgs e)
        {
            double ikkunan_leveys = double.Parse(leveysBox.Text);
            double ikkunan_korkeus = double.Parse(korkeusBox.Text);
            double karmin_leveys = double.Parse(karmiBox.Text);

            apu1 = ikkunan_leveys * ikkunan_korkeus;
            ikkunaBlock.Text = apu1.ToString("0.00") + " cm^2";

            apu2 = 
        }
    }
}
