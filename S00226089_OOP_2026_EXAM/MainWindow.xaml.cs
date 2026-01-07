using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace S00226089_OOP_2026_EXAM
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Robots> robots = new List<Robots>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void lstAllRobots_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Robots selectedRobot = lstAllRobots.SelectedItem as Robots;

            if (selectedRobot != null)
            {
                lstAllRobots.ItemsSource = selectedRobot.ToString();
            }
        }
        private void Window_Loaded(object sender, RoutedEventArgs e) 
        { 
            HouseholdRobot houseBot = new HouseholdRobot("Housebot 01", 25, 25, "I am a household robot.\nI can help with chores around the house."  );
            HouseholdRobot gardenMate = new HouseholdRobot("GardenMate", 25, 25, "I am a household robot for gardening.");
            HouseholdRobot housemate3000 = new HouseholdRobot("HouseMate 3000", 25, 25, "I am a household robot capable of any household task.");
            DeliveryRobot deliverBot = new DeliveryRobot("DeliverBot", 25, 25, "I am a delivery robot capable of delivering small packages", 10, Robots.DeliveryMode.Walking);
            DeliveryRobot flyBot = new DeliveryRobot("FlyBot", 25, 25, "I am a delivery robot capable of delivering small packages by air", 10, Robots.DeliveryMode.Flying);
            DeliveryRobot Driver = new DeliveryRobot("Driver", 25, 25, "I am a delivery robot capable of delivering large packages", 150, Robots.DeliveryMode.Driving); 
        }

    }
}