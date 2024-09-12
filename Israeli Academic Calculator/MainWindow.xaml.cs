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


        private void Add_btn_Click(object sender, RoutedEventArgs e)
        {
            
            try
            {
                int.Parse(Course_grade.Text);
            }
            catch
            {
                MessageBox.Show("Course Score must be a number", "ERROR", MessageBoxButton.OK,MessageBoxImage.Error);
                return;
                
            }

            try
            {
                int.Parse(Course_nakaz.Text);
            }
            catch
            {
                MessageBox.Show("course Nakaz must be a number", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
                return ;
            }

            try
            {
                Entries.Add(new Course(Course_name.Text, int.Parse(Course_grade.Text), int.Parse(Course_nakaz.Text), Binary_pass.IsChecked ?? false));
                calculator.Add_Course(new Course(Course_name.Text, int.Parse(Course_grade.Text), int.Parse(Course_nakaz.Text), Binary_pass.IsChecked ?? false));
                if (Binary_pass.IsChecked == true)
                {
                    Binary_pass.IsChecked = false;
                }

                Course_name.Clr_Data_Entry_Box();
                Course_grade.Clr_Data_Entry_Box();
                Course_nakaz.Clr_Data_Entry_Box();
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message , "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            
            
        }

        private void Delbtn_Click(object sender, RoutedEventArgs e)
        {
            Course selected_course = (Course)C_entries.SelectedItem;
            calculator.Del_Course(selected_course);
            Entries.Remove(selected_course);

        }


        private void Calculatebtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Your average score is : "+calculator.Calculate_Average_Score(), "RESULT",MessageBoxButton.OK);
        }


        private void Credits_btn_Click(object sender, RoutedEventArgs e)
        {
            //placeholder will update at a later date 
        }
    }
}