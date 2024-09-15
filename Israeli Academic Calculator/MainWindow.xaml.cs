using System.Collections.ObjectModel;
using System.Linq.Expressions;
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

namespace Israeli_Academic_Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            DataContext=this;
            entries = new ObservableCollection<Course>();
            InitializeComponent();
            
        }
        Calculator calculator = new Calculator();

        private ObservableCollection<Course> entries;

        public ObservableCollection<Course> Entries
        {
            get { return entries; }
            set { entries = value; }
        }

        

        private void CreditsButton_Click(object sender, RoutedEventArgs e)
        {
            //placeholder will update at a later date
        }

        private void Addbutton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double.Parse(CourseGrade.Text);
            }
            catch
            {
                MessageBox.Show("Course Score must be a number", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
                return;

            }

            try
            {
                double.Parse(CourseNakaz.Text);
            }
            catch
            {
                MessageBox.Show("course Nakaz must be a number", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            try
            {
                Entries.Add(new Course(CourseName.Text, double.Parse(CourseGrade.Text), double.Parse(CourseNakaz.Text), BinaryPass.IsChecked ?? false));
                calculator.AddCourse(new Course(CourseName.Text, double.Parse(CourseGrade.Text), double.Parse(CourseNakaz.Text), BinaryPass.IsChecked ?? false));
                if (BinaryPass.IsChecked == true)
                {
                    BinaryPass.IsChecked = false;
                }

                CourseName.Clr_Data_Entry_Box();
                CourseGrade.Clr_Data_Entry_Box();
                CourseNakaz.Clr_Data_Entry_Box();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {

            Course selected_course = (Course)C_entries.SelectedItem;
            calculator.DeleteCourse(selected_course);
            Entries.Remove(selected_course);
        }

        private void CalculateButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Your average score is : " + calculator.CalculateAverageScore(), "RESULT", MessageBoxButton.OK);
        }
    }
}