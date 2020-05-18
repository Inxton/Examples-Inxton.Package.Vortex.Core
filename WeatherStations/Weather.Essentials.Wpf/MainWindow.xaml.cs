using HansPlc;
using System.Windows;

namespace Weather.Essentials.Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainWindowViewModel();
        }
    }

    public class MainWindowViewModel
    {
        public MainWindowViewModel()
        {
            Entry.HansPlc.Connector.BuildAndStart();
        }
        public HansPlcTwinController PLC { get; } = Entry.HansPlc;
    }
}
