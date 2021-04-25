using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace szofttech2_projekt_jpwqqk
{
    public partial class VaccinationsUC : UserControl
    {
        covidDatabaseEntities context = new covidDatabaseEntities();
        public VaccinationsUC()
        {
            InitializeComponent();
            listPeople();
            listVaccinations();
            listVaccines();
        }

        void listVaccinations()
        {
            if (personBindingSource.Current != null)
            {
                var personID = ((Person)personBindingSource.Current).person_id;
                var vaccinations = from x in context.Vaccinations
                                   where x.person_id == personID
                                   select new FormatVaccination
                                   {
                                       vaccination_id = x.vaccination_id, 
                                       vaccination_display = x.Vaccine.vaccine_name + " - " + x.vaccination_date.ToString()
                                   };
                listBoxPersonVaccinations.DataSource = vaccinations.ToList();
                listBoxPersonVaccinations.DisplayMember = "vaccination_display";
            }
            else return;
            
        }

        void listPeople()
        {
            var people = from x in context.People
                         where x.person_name.Contains(textBoxPersonFilter.Text)
                         select x;
            personBindingSource.DataSource = people.ToList();
        }

        void listVaccines()
        {
            var vaccines = from x in context.Vaccines
                           where x.vaccine_name.Contains(textBoxVaccineFilter.Text)
                           select x;
            vaccineBindingSource.DataSource = vaccines.ToList();
        }

        private void textBoxPersonFilter_TextChanged(object sender, EventArgs e)
        {
            listPeople();
        }

        private void textBoxVaccineFilter_TextChanged(object sender, EventArgs e)
        {
            listVaccines();
        }

        private void listBoxPerson_SelectedIndexChanged(object sender, EventArgs e)
        {
            listVaccinations();
        }

        bool checkDate()
        {
            Regex r = new Regex("^([12]\\d{3}\\.(0[1-9]|1[0-2])\\.(0[1-9]|[12]\\d|3[01]))$");
            return r.IsMatch(textBoxDate.Text);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if(!checkDate())
            {
                MessageBox.Show("Date incorrect!");
                return;
            }
            else
            {
                var personID = ((Person)personBindingSource.Current).person_id;
                var vaccineID = ((Vaccine)vaccineBindingSource.Current).vaccine_id;
                Vaccination newVacc = new Vaccination();
                newVacc.person_id = personID;
                newVacc.vaccine_id = vaccineID;
                newVacc.vaccination_date = Convert.ToDateTime(textBoxDate.Text);
                context.Vaccinations.Add(newVacc);
                try
                {
                    context.SaveChanges();
                    listVaccinations();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (listBoxPersonVaccinations != null)
            {
                var vaccID = ((FormatVaccination)listBoxPersonVaccinations.SelectedItem).vaccination_id;
                var deletevaccination = (from x in context.Vaccinations
                                         where x.vaccination_id == vaccID
                                         select x).FirstOrDefault();
                context.Vaccinations.Remove(deletevaccination);
                try
                {
                    context.SaveChanges();
                    listVaccinations();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else return;
            
        }
    }
}
