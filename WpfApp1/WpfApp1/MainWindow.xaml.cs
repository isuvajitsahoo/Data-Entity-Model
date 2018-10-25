using System;
using System.Collections.Generic;
using System.Data;
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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Training_19Sep18_PuneEntities tr = new Training_19Sep18_PuneEntities();

            Person_160918 p = new Person_160918();

            var ve = from v in tr.Person_160918 where v.FirstName.StartsWith(TXT.Text) select v;
            //IEnumerable<Person_160918> person_160918s = ve;



            dataGrid.ItemsSource = ve.ToList();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Training_19Sep18_PuneEntities tr = new Training_19Sep18_PuneEntities();

            Person_160918 p = new Person_160918();

            var VW = from v in tr.Person_160918 where v.FirstName.StartsWith( TXT.Text) select v;

            foreach(Person_160918 p1 in VW)
            {
                tr.Person_160918.Remove(p1);
            }
            tr.SaveChanges();

        }
    }
}

