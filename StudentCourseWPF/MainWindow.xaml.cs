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

namespace StudentCourseWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //private StudentCourseCatalogDic catalog;
        //private StudentCourseCatalogSortedDic catalog;
        //private StudentCourseCatalogSortedList catalog;
        private StudentCatalog catalog;


        public MainWindow()
        {
            InitializeComponent();
            catalog = new StudentCourseCatalogDic();
            //catalog = new StudentCourseCatalogSortedDic();
            //catalog = new StudentCourseCatalogSortedList();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            Student s = getStudent();
            catalog.AddStudent(s.StudentID, s);
        }

        private void RemoveButton_Click(object sender, RoutedEventArgs e)
        {
            int studentID = int.Parse(StudentIDTextBox.Text);
            catalog.RemoveStudent(studentID);
        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            Student s = getStudent();
            catalog.ModifyGrade(s.StudentID, s);
        }



        private Student getStudent()
        {
            int studentID = int.Parse(StudentIDTextBox.Text);
            string firstName = FirstNameTextBox.Text;
            string lastName = LastNameTextBox.Text;
            Student student = new Student(studentID, firstName, lastName);
            return student;
        }

        private void ListButton_Click(object sender, RoutedEventArgs e)
        {
            StudentsTextBlock.Text = catalog.printStudents();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            StudentsTextBlock.Text = catalog.printStudentsSorted();
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            StudentsTextBlock.Text = "";
            FirstNameTextBox.Text = "";
            LastNameTextBox.Text = "";
            StudentIDTextBox.Text = "";
        }

        

        

        
    }
}
