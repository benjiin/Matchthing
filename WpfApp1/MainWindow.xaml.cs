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

namespace WpfApp1
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }
        private int amountMatches;

        public int AmountMatches
        {
            get { return amountMatches; }
            set { amountMatches = value; }
        }


        public void Button_Click(object sender, RoutedEventArgs e)
        {
            textblock1.Text = "";

            AmountMatches = 21;


            Button match1 = new Button();
            match1.Content = "I";
            match1.Height = button1.Height;
            match1.Width = button1.Width;
            match1.HorizontalAlignment = button1.HorizontalAlignment;
            match1.VerticalAlignment = button1.VerticalAlignment;
            match1.Margin = button1.Margin;

            Button match2 = new Button();
            match2.Content = "II";
            match2.Height = button3.Height;
            match2.Width = button3.Width;
            match2.HorizontalAlignment = button3.HorizontalAlignment;
            match2.VerticalAlignment = button3.VerticalAlignment;
            match2.Margin = button3.Margin;

            Button match3 = new Button();
            match3.Content = "III";
            match3.Height = button5.Height;
            match3.Width = button5.Width;
            match3.HorizontalAlignment = button5.HorizontalAlignment;
            match3.VerticalAlignment = button5.VerticalAlignment;
            match3.Margin = button5.Margin;


            grid1.Children.Add(match1);
            grid1.Children.Add(match2);
            grid1.Children.Add(match3);

            grid1.Children.Remove(button1);
            grid1.Children.Remove(button2);
            grid1.Children.Remove(button4);


            Human player1 = new Human("Spieler1");
            Human player2 = new Human("Spieler2");
            Game game = new Game(2);

            match1.Click += Match1_Click;
            match2.Click += Match2_Click;
            match3.Click += Match3_Click;

            textblock1.Text = amountMatches.ToString();

        }

        private void Match3_Click(object sender, RoutedEventArgs e)
        {   
            if(AmountMatches>=3)
            {
                amountMatches -= 3;
                textblock1.Text = amountMatches.ToString();
            }
            if (AmountMatches <= 0)
            {
                textblock1.Text = "Du hast verloren";
            }
        }

        private void Match2_Click(object sender, RoutedEventArgs e)
        {
            if(AmountMatches>=2)
            {
                amountMatches -= 2;
                textblock1.Text = amountMatches.ToString();
            }
            if (AmountMatches <= 0)
            {
                textblock1.Text = "Du hast verloren";
            }
        }

        private void Match1_Click(object sender, RoutedEventArgs e)
        {
            if(AmountMatches>=1)
            {
                amountMatches -= 1;
                textblock1.Text = amountMatches.ToString();
            }
            if (AmountMatches <= 0)
            {
                textblock1.Text = "Du hast verloren";
            } 
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {

        }
    }

}