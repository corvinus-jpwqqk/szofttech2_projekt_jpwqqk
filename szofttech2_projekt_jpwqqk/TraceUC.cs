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
    public partial class TraceUC : UserControl
    {
        covidDatabaseEntities context = new covidDatabaseEntities();
        List<int> Traced = new List<int>();
        public TraceUC()
        {
            InitializeComponent();
            ListPeople();
        }
        void ListPeople()
        {
            var people = from x in context.People
                         where x.person_name.Contains(textBoxPersonFilter.Text)
                         select x;
            personBindingSource.DataSource = people.ToList();
        }

        void ListTraced()
        {
            var p = (from x in context.People
                     where Traced.Contains(x.person_id)
                     select x).ToList();
            personBindingSource1.DataSource = p;
        }

        void Trace(int personID)
        {
            Traced.Clear();
            MessageBox.Show(Traced.Count.ToString());
            var contacts = (from x in context.Connections
                            where x.person_id == personID
                            select x.contact_id).ToList();

            foreach(var contactid in contacts)
            {
                var people = (from x in context.Connections
                             where x.contact_id == contactid &&
                             x.person_id != personID
                             select x.person_id).ToList();
                foreach(var id in people)
                {
                    if (!Traced.Contains(id))
                    {
                        Traced.Add(id);
                        var getdate = (from x in context.Contacts
                                       where x.contact_id == contactid
                                       select x.contact_date).FirstOrDefault();
                        DateTime date = Convert.ToDateTime(getdate);
                        MessageBox.Show("Calling trace on: " + id.ToString() + " with date: " + date.ToString());
                        Trace(id, date);
                    }
                }
            }
            MessageBox.Show("Removing from list: "+ personID.ToString());
            Traced.Remove(personID);
            ListTraced();
            MessageBox.Show("Successfully traced: " + personID.ToString());
        }
        void Trace(int personID, DateTime contactDate)
        {
            var contacts = (from x in context.Connections
                            where x.person_id == personID
                            select x.contact_id).ToList();

            foreach (var contactid in contacts)
            {
                var people = (from x in context.Connections
                              where x.contact_id == contactid &&
                              x.Contact.contact_date<contactDate &&
                              x.person_id != personID
                              select x.person_id).ToList();
                
                foreach (var id in people)
                {
                    if(!Traced.Contains(id))
                    {
                        Traced.Add(id);
                        var getdate = (from x in context.Contacts
                                         where x.contact_id == id
                                         select x.contact_date).FirstOrDefault();
                        DateTime date = Convert.ToDateTime(getdate);
                        Trace(id, date);
                    }
                }
            }
        }

        private void TextBoxPersonFilter_TextChanged(object sender, EventArgs e)
        {
            ListPeople();
        }

        private void buttonTrace_Click(object sender, EventArgs e)
        {
            Traced.Clear();
            int personID = ((Person)personBindingSource.Current).person_id;
            Trace(personID);
        }
    }
}
