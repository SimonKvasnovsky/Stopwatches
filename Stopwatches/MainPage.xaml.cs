using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Stopwatches
{
    public partial class MainPage : ContentPage
    {
        Stopwatch stopwatch;

        public MainPage()
        {
            InitializeComponent();
            stopwatch = new Stopwatch();

            Stopwatches.Text = "00:00:00.0000";
        }

        private void butStart_Clicked(object sender, EventArgs e)
        {
            if (!stopwatch.IsRunning)
            {
                stopwatch.Start();
                Device.StartTimer(TimeSpan.FromMilliseconds(100), () =>
                {
                    Stopwatches.Text = stopwatch.Elapsed.ToString();
                    if (!stopwatch.IsRunning)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                });

            }
           
            
        }

        private void butReset_Clicked(object sender, EventArgs e)
        {
            Stopwatches.Text = "00:00:00.0000";          
            stopwatch.Reset();
        }

        private void butStop_Clicked(object sender, EventArgs e)
        {           
            stopwatch.Stop();
        }
    }
}
