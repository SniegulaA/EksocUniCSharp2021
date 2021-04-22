using Sniegula.StudentManager.Data;
using Sniegula.StudentManager.Logic;
using Sniegula.StudentsManager.UI.views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sniegula.StudentsManager.UI
{
    public partial class Form1 : Form
    {

        StudentService studentService = new StudentService();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddStudent addStudentForm = new AddStudent("Przekaż coś do formularza");
     
            DialogResult dialogResult =  addStudentForm.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {

                Student s = addStudentForm.StudentToCreate;
                labelNewStudent.Text = s.Name + " " + s.Surname;

            }
            else {
                labelNewStudent.Text = "Anulowano";
            }
            //Po zamknięciu okienka wrócimy w to miejsce
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            studentService.Initialize();

            refreshDataGrid();

        }

        public void refreshDataGrid() {
            List<Student> students = studentService.GetAllStudents();

            DataGridView dataGridView = dataGridView1;
            dataGridView.DataSource = null;
            dataGridView.DataSource = students;
            dataGridView.Refresh();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0) {

                //SPOSÓB 1
                Student s = (Student) dataGridView1.SelectedRows[0].DataBoundItem;

                //Sposób 2
                int selectedRowNumber = dataGridView1.SelectedRows[0].Index;
                Student s2 = studentService[selectedRowNumber];

                labelSelected.Text = s2.Name + " " + s2.Surname;
                listBox1.Items.Clear();

                foreach (Note n in s.Notes) {
                    listBox1.Items.Add(n);
                }
            }
        }


    }
}
