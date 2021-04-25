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
    public partial class ContactsUC : UserControl
    {
        covidDatabaseEntities context = new covidDatabaseEntities();
        public ContactsUC()
        {
            InitializeComponent();
            listContacts();
        }

        void listContacts()
        {
            var contacts = from x in context.Contacts
                           select x;
            contactBindingSource.DataSource = contacts.ToList();
        }

        bool checkDate()
        {
            Regex r = new Regex("^([12]\\d{3}\\.(0[1-9]|1[0-2])\\.(0[1-9]|[12]\\d|3[01]))$");
            return r.IsMatch(textBoxDate.Text);
        }



        bool checkLocation()
        {
            if (textBoxLocation.Text != "") return true;
            else return false;
        }
        
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (!checkDate())
            {
                MessageBox.Show("Incorrect date!");
                return;
            }
            else if (!checkLocation())
            {
                MessageBox.Show("Location missing!");
                return;
            }
            Contact newContact = new Contact();
            newContact.contact_date = Convert.ToDateTime(textBoxDate.Text);
            newContact.contact_place = textBoxLocation.Text;
            context.Contacts.Add(newContact);
            try
            {
                context.SaveChanges();
                listContacts();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var deleteID = ((Contact)contactBindingSource.Current).contact_id;
            var deleteContact = (from x in context.Contacts
                                 where x.contact_id == deleteID
                                 select x).FirstOrDefault();
            context.Contacts.Remove(deleteContact);
            try
            {
                context.SaveChanges();
                listContacts();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
