using Logic;
using Sniegula.CarWorkshop.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sniegula.CarWorkshop.UI
{
    public partial class Form1 : Form
    {
        CarService carservice = new CarService();


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddRepairForm addRepairForm = new AddRepairForm(carservice);
            DialogResult dialogResult =  addRepairForm.ShowDialog();

            if (dialogResult.Equals(DialogResult.OK)) {

                Repair newRepair = addRepairForm.Repair;
                label1.Text = newRepair.MechanicResponsible.Surname;
                label2.Text = newRepair.CarBrand.ToString();
                DateTime dateTime = newRepair.RepairDate;

                label3.Text= dateTime.ToString();

                carservice.AddNewRepair(newRepair);
                refreshRepairDataGrid();

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            refreshRepairDataGrid();


        }

        private void refreshRepairDataGrid()
        {
            List<Repair> repairs = carservice.GetAllRepairs();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = repairs;

        }
    }
}
