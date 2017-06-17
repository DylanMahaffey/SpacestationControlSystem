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
using SpaceshipSystemControls.UserControls;
using GameData;

namespace SpaceshipSystemControls
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public double width;
        public double height;
        GameSetup game = new GameSetup();
        
        Window parentWindow = Application.Current.MainWindow;

        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            game.parentWindow = Window.GetWindow(this);
            
            gameContent.Content = game;
        }
    }
}
