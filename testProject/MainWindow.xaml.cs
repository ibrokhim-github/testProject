using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace testProject
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    /// 

    
    public partial class MainWindow : Window
        
    { 
      
        ApplicationContext db ;

        public object NavigationService { get; private set; }

        public MainWindow()
        {
            InitializeComponent();
            db = new ApplicationContext();
           
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string textV = textB.Text;

            int number = int.Parse(textV) + 1;
            for (int i = 0; i < 2; i++)

                //   int number1 = number + i; 

                textB.Text = number.ToString();
          
           
        }

        private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

       

        private void vikka_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void buttons_Click(object sender, RoutedEventArgs e)
        {
            string textV = textB.Text;

            int number1 = int.Parse(textV) - 1;
            if (number1 < 0)
                number1 = 0;

                //   int number1 = number + i; 

                textB.Text = number1.ToString();
            
            
           
            string word = block.Text ;
            block.Text = "";
            var username = "dsakdsa";
            User user = new User(username);
            db.Users.Add(user);
            db.SaveChanges();

           

        }

        private void Chip_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void Rectangle_ImageFailed(object sender, ExceptionRoutedEventArgs e)
        {

        }

        private void total_Click(object sender, RoutedEventArgs e)
        {
            Form1 form = new Form1();
            form.Show();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }
    }
}
