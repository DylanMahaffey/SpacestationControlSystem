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
using GameData;

namespace SpaceshipSystemControls.UserControls
{
    /// <summary>
    /// Interaction logic for GameSetup.xaml
    /// </summary>
    public partial class GameSetup : UserControl
    {
        public Window parentWindow;
        

        public GameSetup()
        {
            InitializeComponent();

            
        }

        public void commandBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                var window = Window.GetWindow(this);

                if (commandBox.Text == "end")
                {
                    window.Close();
                }
                if (commandBox.Text == "start")
                {
                    commandBox.Clear(); 
                    SystemControl controls = new SystemControl();
                    controls.game = this;
                    (Application.Current.MainWindow.FindName("gameContent") as ContentControl).Content = controls;
                }
            }
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            trooperUsername.Focus();
        }
    }
}
