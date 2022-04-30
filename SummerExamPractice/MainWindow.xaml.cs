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

namespace SummerExamPractice
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        GameData db = new GameData();
        List<Game> allGames;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            var query = from g in db.Games
                        orderby g.Name
                        select g;

            var result = query.ToList();
            lbxGame.ItemsSource = result;
        }

        private void lbxGame_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Game selected = lbxGame.SelectedItem as Game;

            if(selected != null)
            {
                tbxName.Text = selected.GetDetails();
                imgGame.Source = new BitmapImage(new Uri(selected.Game_Image, UriKind.Relative));
            }
        }
    }
}
