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
        List<int> traced = new List<int>();
        public TraceUC()
        {
            InitializeComponent();
            listPeople();
        }
        void listPeople()
        {
            var people = from x in context.People
                         where x.person_name.Contains(textBoxPersonFilter.Text)
                         select x;
            personBindingSource.DataSource = people.ToList();
        }

        void listTraced()
        {
            var p = (from x in context.People
                     where traced.Contains(x.person_id)
                     select x).ToList();
            personBindingSource1.DataSource = p;
        }

        void trace(int personID)
        {
            var contactID = (from x in context.Connections
                            where x.person_id == personID
                            select x.contact_id).ToList();
            foreach(var contactf in contactID)
            {
                var people = (from x in context.Connections
                             where x.contact_id == contactf
                             select x.person_id).ToList();
                foreach(var personid in people)
                {
                    traced.Add(personid);
                }
            }

            listTraced();
           
        }

        private void textBoxPersonFilter_TextChanged(object sender, EventArgs e)
        {
            listPeople();
        }

        private void buttonTrace_Click(object sender, EventArgs e)
        {
            traced.Clear();
            int personID = ((Person)personBindingSource.Current).person_id;
            trace(personID);
        }
    }
}
