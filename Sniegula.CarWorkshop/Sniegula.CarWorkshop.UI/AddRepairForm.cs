using Logic;
using Sniegula.CarWorkshop.Data;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Sniegula.CarWorkshop.UI
{
    public partial class AddRepairForm : Form
    {
        public CarService CarService { get; set; }
        public Repair Repair { get; set; }

      
        public AddRepairForm(CarService carService)
        {
            this.CarService = carService;
            InitializeComponent();
        }

        private void AddRepairForm_Load(object sender, EventArgs e)
        {

            List<CarBrand> brands = CarService.GetAllCarBrands();
              foreach(CarBrand brand in brands) {
               comboBoxBrand.Items.Add(brand);
             }
  

        }

       

        private void comboBoxBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            //1 Pobierz markę z combobox1 (comboboox brand)
            CarBrand carBrand =  (CarBrand)comboBoxBrand.SelectedItem;

            //2 Wyczyść listę od combobx2 (comboboboxx mechanic)
            comboBoxMechanic.Items.Clear();
            //3 PObierz z serwisu listę mechaników dla wybranego branda
            List<Mechanic> mechanics = CarService.GetMechanicsForBrand(carBrand);
            //4 Dodaj ich do listy combobx2 (comboboboxx mechanic)
            foreach (Mechanic mechanic in mechanics) {
                comboBoxMechanic.Items.Add(mechanic);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBoxBrand.SelectedItem != null && comboBoxMechanic.SelectedItem != null)
            {
               
                CarBrand carBrand = (CarBrand)comboBoxBrand.SelectedItem;
                Mechanic mechanic = (Mechanic)comboBoxMechanic.SelectedItem;
                DateTime dateTime = dateTimePicker1.Value.Date;
                

                Repair repair = new Repair();
                repair.CarBrand = carBrand;
                repair.MechanicResponsible = mechanic;
                repair.RepairDate = dateTime;
                repair.RegistrationNumber = textBoxRegistration.Text;
                repair.TimeInHours = (int) numericUpDownRepairTime.Value;
                Repair = repair;

                this.DialogResult = DialogResult.OK;
                this.Close();

            }



        }
    }
}
