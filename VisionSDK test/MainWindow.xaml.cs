using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using VisionSDK;

namespace VisionSDK_test
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        VisionDevice Device = VisionDevice.Create();
        public MainWindow()
        {
            InitializeComponent();
            Device.SetupConnection(VisionDeviceConnectionDetails.CreateForNetworkConnection("127.0.0.1"));

            Device.Connect();
            //Put the device Online             
            Device.SetOnline_Sync(true);                          
            //Trigger
            Device.Trigger_Sync();   
        }
    }
}
