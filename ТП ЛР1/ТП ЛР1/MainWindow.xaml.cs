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
using ТП_ЛР1.Контроллер;
using ТП_ЛР1.Модели;
namespace ТП_ЛР1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Меню todayMenu;
        Оформление oformlenie;
        public MainWindow()
        {
            todayMenu = new Меню();
            oformlenie = new Оформление();
            InitializeComponent();
            this.DataContext = todayMenu;
            MenuView.ItemsSource = todayMenu.MyMenu;
            OrderView.ItemsSource = oformlenie.Zakaz;
            ZakazyView.ItemsSource = oformlenie.Zakazy;
        }
        private void MenuView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            BludoName.Text = todayMenu.MyMenu[MenuView.SelectedIndex].name;
            BludoPrice.Text = todayMenu.MyMenu[MenuView.SelectedIndex].price.ToString();
            BludoVes.Text = todayMenu.MyMenu[MenuView.SelectedIndex].ves.ToString();
            BludoTime.Text = todayMenu.MyMenu[MenuView.SelectedIndex].time.ToString();
            BludoSebestoim.Text = todayMenu.MyMenu[MenuView.SelectedIndex].sebestoim.ToString();

        }
        private void OrderView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Add(object sender, RoutedEventArgs e)
        {
            OrderView.ItemsSource = oformlenie.Zakaz;
            oformlenie.Vybrat(todayMenu.MyMenu[MenuView.SelectedIndex], Int32.Parse(BludoKol.Text));
            double Itog = 0;
            foreach (Заказ zakaz in oformlenie.Zakaz)
            {
                Itog = zakaz.bludo.price * zakaz.Количество + Itog;
            }
            Total.Text = Itog.ToString();
        }
        int total = 0;
        private void Clean(object sender, RoutedEventArgs e)

        {
            OrderView.ItemsSource = null;
            total = 0;
        }

        private void Finish(object sender, RoutedEventArgs e)
        {
            oformlenie.Sozdat();
        }

        private void ZakazyView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            OrderView.ItemsSource = oformlenie.Zakazy[ZakazyView.SelectedIndex].SpisokBlud;
        }
    }
}
