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
        List<Person> found = new List<Person>();
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

        void trace(int personID, int weeks)
        {
            foreach(int id in traced)
            {
                if(id == personID)
                {
                    return;
                }
            }
            traced.Add(personID);
            var contacts = from x in context.Connections
                           where x.person_id == personID
                           select x;
            //finish
        }

        private void textBoxPersonFilter_TextChanged(object sender, EventArgs e)
        {
            listPeople();
        }

        private void buttonTrace_Click(object sender, EventArgs e)
        {
            int week = (int)numericUpDownWeek.Value;
            int personID = ((Person)personBindingSource.Current).person_id;
            //trace(personID, week);
        }
    }
}
