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
    public partial class PeopleUC : UserControl
    {
        covidDatabaseEntities context = new covidDatabaseEntities();
        public PeopleUC()
        {
            InitializeComponent();
            listPeople();
        }

        void listPeople()
        {
            var people = from x in context.People
                         select x;
            personBindingSource.DataSource = people.ToList();
        }

        bool checkName()
        {
            if(textBoxName.Text != "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        bool checkBirthdate()
        {
            Regex r = new Regex("^([12]\\d{3}\\.(0[1-9]|1[0-2])\\.(0[1-9]|[12]\\d|3[01]))$");
            return r.IsMatch(textBoxBirthdate.Text);
        }

        bool checkPhoneNumber()
        {
            Regex r = new Regex("[0-9]{11}");
            return r.IsMatch(textBoxPhoneNumber.Text);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (!checkName())
            {
                MessageBox.Show("Name missing!");
                return;
            }
            else if (!checkBirthdate())
            {
                MessageBox.Show("Birthdate incorrect!");
                return;
            }
            else if (!checkPhoneNumber())
            {
                MessageBox.Show("Phone number incorrect!");
                return;
            }
            Person newPerson = new Person();
            newPerson.person_name = textBoxName.Text;
            newPerson.person_birthdate = Convert.ToDateTime(textBoxBirthdate.Text);
            newPerson.person_number = textBoxPhoneNumber.Text;
            context.People.Add(newPerson);
            try
            {
                context.SaveChanges();
                listPeople();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var deleteID = ((Person)personBindingSource.Current).person_id;
            var deletePerson = (from x in context.People
                               where x.person_id == deleteID
                               select x).FirstOrDefault();
            context.People.Remove(deletePerson);
            try
            {
                context.SaveChanges();
                listPeople();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
