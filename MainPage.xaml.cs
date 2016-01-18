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

namespace Valera
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



        private void play_Click(object sender, RoutedEventArgs e)
        {
            get_Song();
            mediaElement1.Play();
        }

       

        private void get_Song()
        {
            Random rnd = new Random();
            int song_number = rnd.Next(1, 6);
            mediaElement1.Source = new Uri("ms-appx:///Assets/Sound" + song_number + ".mp3", UriKind.Absolute);
            
        }
    }
}
