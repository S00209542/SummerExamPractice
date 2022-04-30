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

        public void Window_Loaded(object sender, RoutedEventArgs e)
        {

            var query = from g in db.Games
                        orderby g.Name
                        select g;

            allGames = query.ToList();
            lbxGame.ItemsSource = allGames;
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

        private void rdoAll_Click(object sender, RoutedEventArgs e)
        {
            RadioButton rb = sender as RadioButton;

            string platform = rb.Content.ToString();

            switch (platform)
            {
                case "Playstation":
                    lbxGame.ItemsSource = allGames.Where(g => g.Platform.Contains("Playstation"));
                    break;
                case "Xbox":
                    lbxGame.ItemsSource = allGames.Where(g => g.Platform.Contains("Xbox"));
                    break;
                case "Switch":
                    lbxGame.ItemsSource = allGames.Where(g => g.Platform.Contains("Switch"));
                    break;
                case "PC":
                    lbxGame.ItemsSource = allGames.Where(g => g.Platform.Contains("PC"));
                    break;
                default:
                    lbxGame.ItemsSource = allGames;
                    break;
            }
        }
    }
}
