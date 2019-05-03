using System;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using System.Windows.Threading;

namespace WpfApplication2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        private int i = 1;
        private DispatcherTimer timer;
        public MainWindow()
        {
            InitializeComponent();
            
            
            
        }
        
        private void timer_Tick(object sender, EventArgs e)
        {
            if (i == 10)
            {
                timer.Stop();
                Button.Visibility = Visibility.Visible;
                Image.Visibility = Visibility.Hidden; 
            }
            i++;
        }

        private void BaseFirst(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Нажата зеленая кнопка");
        }
        private void ExitProg(object sender, RoutedEventArgs e)
        {
            Close();
        }
        private void RepeatProg(object sender, RoutedEventArgs e)
        {
            int x =  Convert.ToInt32(TextBlock.Text);
            x += 1;
            TextBlock.Text = x.ToString();
        }

        void StartGame(object sender, RoutedEventArgs e)
        {
            TextBlock.Text = 0.ToString();
            Button.Visibility = Visibility.Hidden;
            Image.Visibility = Visibility.Visible;

            i = 0;
            timer = new DispatcherTimer();
            timer.Tick += new EventHandler(timer_Tick);
            timer.Interval = new TimeSpan(0,0,1);
            timer.Start();
        }

        private void Recast(object sender, RoutedEventArgs e)
        {
             Random random = new Random();
            RepeatProg(sender,e);
                    double r = random.Next(20,901);
                    double t = random.Next(20,401);
                    Canvas.SetRight(Image,r);
                    Canvas.SetTop(Image,t);
                
            
        }
    }
}

/*
 * <Button x:Name="Button1"
                    Background="Green" 
                    Content="Top 20 Left 40" 
                    Canvas.Top="170" 
                    Canvas.Left="40"
                    Height="30"
                    Width="100"
                    Foreground="White"
                    Click="BaseFirst"/>
            <Button Background="White"
                    Content="Exit"
                    Canvas.Top="220"
                    Height="20"
                    Canvas.Left="40"
                    Click="ExitProg"/>
            
            <RepeatButton Background="White"
                    Content="Repeat"
                    Canvas.Top="260"
                    Canvas.Left="40"
                    Click="RepeatProg"/>
 */