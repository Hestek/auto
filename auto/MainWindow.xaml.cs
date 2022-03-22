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

namespace auto
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Vehicle auto1;
        Vehicle auto2;

        public MainWindow()
        {
            InitializeComponent();
            auto1 = new Vehicle("Škoda");
            ShowVehicle(auto1, txt1);
            auto1.Type = "Osobní Auto";

            auto2 = new Vehicle("W");           
            auto2.Type = "Dodávka";
            ShowVehicle(auto2, txt2);
        }

        public void ShowVehicle(Vehicle vehicle, TextBox textbox)
        {
            textbox.Text = $"brand: {vehicle.Brand}\n";
            textbox.Text += $"Type: {vehicle.Type}\n";
            textbox.Text += $"Fuel: {vehicle.Fuel}\n";
            textbox.Text += $"EngineVolume: {Math.Round(vehicle.EngineVolume), 2}\n";
            textbox.Text += $"FuelLevel: {vehicle.FuelLevel}\n";
            textbox.Text += $"Distance: {vehicle.Distance}\n";
            textbox.Text += $"PneuState: {Math.Round(vehicle.PneuState), 2}\n";

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            auto1.Move();
            
            ShowVehicle(auto1, txt1);
            
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            auto2.Move();
            ShowVehicle(auto2, txt2);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            auto1.Refuel();
            ShowVehicle(auto1, txt1);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            auto1.TireChange();
            ShowVehicle(auto1, txt1);
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            auto1.DistanceReset();
            ShowVehicle(auto1, txt1);
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            auto1.EngineRepair();
            ShowVehicle(auto1, txt1);
        }
    }
}
