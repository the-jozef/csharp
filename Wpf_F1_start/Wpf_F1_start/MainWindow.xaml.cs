using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Media;
using System.Windows.Threading;
using System.Timers;
using System.Reflection.Metadata;

namespace Wpf_F1_start
{
    public partial class MainWindow : Window
    {
        private readonly DispatcherTimer _timer = new DispatcherTimer();
        private readonly Stopwatch stopwatch;
        private readonly System.Timers.Timer timer;
        private int _currentIndex;
        private readonly Brush _off = Brushes.DimGray;
        private readonly Brush _on = Brushes.Red;
        private double IntervalSeconds = 1;
        private Random random = new Random();
        private Stopwatch bestTime = new Stopwatch();
        public MainWindow()
        {
            InitializeComponent();
            Stopwatch.Text = "00.00.000";
            stopwatch = new Stopwatch();
            timer = new System.Timers.Timer();
            timer.Elapsed += Timer_Elapsed;

            _timer.Interval = TimeSpan.FromSeconds(IntervalSeconds);
            _timer.Tick += Timer_Tick;


            Stop.IsEnabled = false;
            Reset.IsEnabled = false;
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            Start.Dispatcher.Invoke(() =>
            {
                Stopwatch.Text = stopwatch.Elapsed.ToString(@"ss\.ff\.fff");
            });

        }

        private void Start_Click(object sender, RoutedEventArgs e)
        {
            Stop.IsEnabled = true;
            _timer.Start();

            SetColorsOn(_currentIndex);
            stopwatch.Start();
            Start.IsEnabled = false;
        }
        private void Stop_Click(object sender, RoutedEventArgs e)
        {
            Reset.IsEnabled = true;

            _timer.Stop();

            stopwatch.Stop();
            timer.Stop();
            Time_calculation();
        }

        private void Reset_Click(object sender, RoutedEventArgs e)
        {
            SetColorOff();
            Start.IsEnabled = true;
            Stop.IsEnabled = false;
            Reset.IsEnabled = false;

            _currentIndex = 0;

            Stopwatch.Text = "00.00.000";

            stopwatch.Reset();

        }
        private void SetColorOff()
        {
            circle1.Fill = _off;
            circle2.Fill = _off;
            circle3.Fill = _off;
            circle4.Fill = _off;
            circle5.Fill = _off;
            circle6.Fill = _off;
            circle7.Fill = _off;
            circle8.Fill = _off;
            circle9.Fill = _off;
            circle10.Fill = _off;
        }
        private void SetColorsOn(int index)
        {
            if (index == 0) circle1.Fill = circle2.Fill = _on;
            if (index == 1) circle3.Fill = circle4.Fill = _on;
            if (index == 2) circle5.Fill = circle6.Fill = _on;
            if (index == 3) circle7.Fill = circle8.Fill = _on;
            if (index == 4) circle9.Fill = circle10.Fill = _on;

        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            // posun index
            _currentIndex++;
            if (_currentIndex > 5)
            {
                IntervalSeconds = random.NextDouble() * 2 + 1.5; 
                SetColorOff();  
                timer.Start();
            }
            SetColorsOn(_currentIndex);
        }
        private void Time_calculation()
        {

            if ()
            {
                bestTime = stopwatch;
                BestTime.Text = stopwatch.Elapsed.ToString(@"ss\.ff\.fff");
            }


        }
    } 
}