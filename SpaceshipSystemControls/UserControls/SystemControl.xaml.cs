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

namespace SpaceshipSystemControls.UserControls
{
    /// <summary>
    /// Interaction logic for SystemControl.xaml
    /// </summary>
    public partial class SystemControl : UserControl
    {
        public GameSetup game;
        public TrashCompactor compactor = new TrashCompactor();
        public TractorBeam tractorBeam = new TractorBeam();
        public SpaceshipPlans plans = new SpaceshipPlans();

        public SystemControl()
        {
            InitializeComponent();
            compactor.controls = this;
            tractorBeam.controls = this;
            plans.controls = this;
        }

        private void systemControls_Loaded(object sender, RoutedEventArgs e)
        {
            var window = Window.GetWindow(this);
            window.KeyDown += systemControlsNavigation;
        }

        private void systemControlsNavigation(object sender, KeyEventArgs e)
        {
            var window = Window.GetWindow(this);
            if (e.Key == Key.D && Keyboard.IsKeyDown(Key.A) && Keyboard.IsKeyDown(Key.LeftCtrl))
            {
                (Application.Current.MainWindow.FindName("gameContent") as ContentControl).Content = game;
                window.KeyDown -= systemControlsNavigation;
            }
            if(e.Key == Key.NumPad1 || e.Key == Key.D1)
            {
                (Application.Current.MainWindow.FindName("gameContent") as ContentControl).Content = compactor;
                window.KeyDown -= systemControlsNavigation;
            }
            if (e.Key == Key.NumPad2 || e.Key == Key.D2)
            {
                (Application.Current.MainWindow.FindName("gameContent") as ContentControl).Content = tractorBeam;
                window.KeyDown -= systemControlsNavigation;
            }
            if (e.Key == Key.NumPad3 || e.Key == Key.D3)
            {
                (Application.Current.MainWindow.FindName("gameContent") as ContentControl).Content = plans;
                window.KeyDown -= systemControlsNavigation;
            }
        }
    }
}
