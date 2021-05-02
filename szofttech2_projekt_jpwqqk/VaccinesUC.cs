using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace szofttech2_projekt_jpwqqk
{
    public partial class VaccinesUC : UserControl
    {
        covidDatabaseEntities context = new covidDatabaseEntities();
        bool editing = false;
        int editingID;
        public VaccinesUC()
        {
            InitializeComponent();
            listVaccines();
        }

        void listVaccines()
        {
            var vaccines = from x in context.Vaccines
                           select x;
            vaccineBindingSource.DataSource = vaccines.ToList();
        }

        bool checkName()
        {
            if (textBoxName.Text != "") return true;
            else return false;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (!checkName())
            {
                MessageBox.Show("Name missing!");
                return;
            }
            Vaccine newVaccine = new Vaccine();
            newVaccine.vaccine_name = textBoxName.Text;
            context.Vaccines.Add(newVaccine);
            try
            {
                context.SaveChanges();
                listVaccines();
                textBoxName.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var deleteID = ((Vaccine)vaccineBindingSource.Current).vaccine_id;

            //delete vaccinations
            var vacc = (from x in context.Vaccinations
                        where x.vaccine_id == deleteID
                        select x).ToList();
            foreach(var vac in vacc)
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

            //delete vaccine
            var deleteVaccine = (from x in context.Vaccines
                                 where x.vaccine_id == deleteID
                                 select x).FirstOrDefault();
            context.Vaccines.Remove(deleteVaccine);
            try
            {
                context.SaveChanges();
                listVaccines();
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
                if(vaccineBindingSource.Current == null)
                {
                    MessageBox.Show("No item selected;");
                    return;
                }
                else
                {
                    editing = true;
                    editingID = ((Vaccine)vaccineBindingSource.Current).vaccine_id;
                    var editedVaccine = (from x in context.Vaccines
                                         where x.vaccine_id == editingID
                                         select x).FirstOrDefault();
                    textBoxName.Text = editedVaccine.vaccine_name;
                    buttonAdd.Enabled = false;
                    buttonDelete.Enabled = false;
                    buttonEditSave.Text = "Save";
                }
            }
            else
            {
                if (!checkName())
                {
                    MessageBox.Show("Name missing!");
                    return;
                }
                var editedVaccine = (from x in context.Vaccines
                                     where x.vaccine_id == editingID
                                     select x).FirstOrDefault();
                editedVaccine.vaccine_name = textBoxName.Text;
                try
                {
                    context.SaveChanges();
                    listVaccines();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                buttonAdd.Enabled = true;
                buttonDelete.Enabled = true;
                buttonEditSave.Text = "Edit";
                textBoxName.Text = "";
            }
        }
    }
}
