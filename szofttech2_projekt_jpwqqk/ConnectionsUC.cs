﻿using System;
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
    public partial class ConnectionsUC : UserControl
    {
        covidDatabaseEntities context = new covidDatabaseEntities();
        public ConnectionsUC()
        {
            InitializeComponent();
            listPeople();
            listContacts();
            listPersonContacts();
        }
        void listPeople()
        {
            var people = from x in context.People
                         where x.person_name.Contains(textBoxPersonFilter.Text)
                         select x;
            personBindingSource.DataSource = people.ToList();
        }

        void listContacts()
        {
            var contacts = from x in context.Contacts
                           where x.contact_place.Contains(textBoxContactFilter.Text) ||
                                    x.contact_date.ToString().Contains(textBoxContactFilter.Text)
                           select new FormatContact
                           {
                               contact_id = x.contact_id,
                               contact_display = x.contact_place + " - " + x.contact_date.ToString()
                           };
            listBoxContact.DataSource = contacts.ToList();
            listBoxContact.DisplayMember = "contact_display";
        }

        void listPersonContacts()
        {
            if (personBindingSource.Current != null)
            {
                var personID = ((Person)personBindingSource.Current).person_id;
                var personContacts = from x in context.Connections
                                     where x.person_id == personID
                                     select new FormatContact
                                     {
                                         contact_id = x.contact_id,
                                         contact_display = x.Contact.contact_place + " - " + x.Contact.contact_date.ToString()
                                     };

                formatContactBindingSource.DataSource = personContacts.ToList();
            }
            else return;
        }

        private void textBoxPersonFilter_TextChanged(object sender, EventArgs e)
        {
            listPeople();
        }

        private void textBoxContactFilter_TextChanged(object sender, EventArgs e)
        {
            listContacts();
        }

        private void listBoxPerson_SelectedIndexChanged(object sender, EventArgs e)
        {
            listPersonContacts();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if(listBoxContact.SelectedItem != null)
            {
                if(personBindingSource.Current != null)
                {
                    var contactID = ((FormatContact)listBoxContact.SelectedItem).contact_id;
                    var personID = ((Person)personBindingSource.Current).person_id;
                    Connection newConn = new Connection();
                    newConn.contact_id = contactID;
                    newConn.person_id = personID;
                    context.Connections.Add(newConn);
                    try
                    {
                        context.SaveChanges();
                        listPersonContacts();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(" ajaj " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Please select a person!");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Please select a contact to add!");
                return;
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {

        }
    }
}
