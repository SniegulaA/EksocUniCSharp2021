using Sniegula.StudentManager.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sniegula.StudentsManager.UI.views
{
    public partial class AddStudent : Form
    {
        public Student StudentToCreate { get; set; }
   

        public AddStudent(string title)
        {
            InitializeComponent();


            labelTitle.Text = title;
        }

        private void AddStudent_Load(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Student s = new Student("Nowy", "Student");
            this.StudentToCreate = s;

            this.DialogResult = DialogResult.OK;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
