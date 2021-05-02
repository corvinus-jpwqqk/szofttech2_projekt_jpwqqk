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
        bool editing = false;
        int editingID;
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
                textBoxName.Text = "";
                textBoxBirthdate.Text = "yyyy.mm.dd";
                textBoxPhoneNumber.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var deleteID = ((Person)personBindingSource.Current).person_id;
            //delete connections
            var deleteConn = (from x in context.Connections
                              where x.person_id == deleteID
                              select x).ToList();
            foreach(var conn in deleteConn)
            {
                context.Connections.Remove(conn);
                try
                {
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Connection deletion error: " + ex.Message);
                }
            }

            //delete vaccinations
            var deleteVacc = (from x in context.Vaccinations
                              where x.person_id == deleteID
                              select x).ToList();
            foreach(var vac in deleteVacc)
            {
                context.Vaccinations.Remove(vac);
                try
                {
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Vaccination deletion error: " + ex.Message);
                }
            }


            //delete person
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

        private void buttonEditSave_Click(object sender, EventArgs e)
        {
            if (!editing)
            {
                if (personBindingSource.Current == null)
                {
                    MessageBox.Show("No item selected!");
                    return;
                }
                else
                {
                    editing = true;
                    buttonAdd.Enabled = false;
                    buttonDelete.Enabled = false;
                    buttonEditSave.Text = "Save";
                    editingID = ((Person)personBindingSource.Current).person_id;
                    var editPerson = (from x in context.People
                                      where x.person_id == editingID
                                      select x).FirstOrDefault();
                    textBoxName.Text = editPerson.person_name;
                    textBoxPhoneNumber.Text = editPerson.person_number;
                    textBoxBirthdate.Text = editPerson.person_birthdate.Value.ToString("yyyy.MM.dd");
                }
            }
            else
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
                var editPerson = (from x in context.People
                                  where x.person_id == editingID
                                  select x).FirstOrDefault();
                editPerson.person_name = textBoxName.Text;
                editPerson.person_birthdate = Convert.ToDateTime(textBoxBirthdate.Text);
                editPerson.person_number = textBoxPhoneNumber.Text;
                try
                {
                    context.SaveChanges();
                    listPeople();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                textBoxName.Text = "";
                textBoxBirthdate.Text = "yyyy.mm.dd";
                textBoxPhoneNumber.Text = "";
                buttonAdd.Enabled = true;
                buttonDelete.Enabled = true;
                buttonEditSave.Text = "Edit";
                editing = false;
            }
            
        }
    }
}
