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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var deleteID = ((Vaccine)vaccineBindingSource.Current).vaccine_id;
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
    }
}
