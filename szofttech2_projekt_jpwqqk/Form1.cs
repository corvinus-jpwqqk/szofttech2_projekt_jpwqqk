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
    public partial class Form1 : Form
    {
        enum Opened
        {
            Empty,
            People, 
            Contacts, 
            Vaccines, 
            Connections, 
            Vaccinations, 
            Trace

        }
        Opened activeWindow;
        List<Button> menuButtons = new List<Button>();
        public Form1()
        {
            InitializeComponent();
            activeWindow = Opened.Empty;
            menuButtons.Add(btnPeople);
            menuButtons.Add(button1);
            menuButtons.Add(button2);
            menuButtons.Add(button3);
            menuButtons.Add(button4);
            menuButtons.Add(button5);
            OpenPeople();
        }

        void resetButtons()
        {
            foreach(Button btn in menuButtons)
            {
                btn.BackColor = SystemColors.Control;
            }
        }

        void OpenPeople()
        {
            if (activeWindow != Opened.People)
            {
                panel1.Controls.Clear();
                PeopleUC peopleUC = new PeopleUC();
                panel1.Controls.Add(peopleUC);
                peopleUC.Dock = DockStyle.Fill;
                activeWindow = Opened.People;
                resetButtons();
                btnPeople.BackColor = SystemColors.GradientActiveCaption;
            }
            else return;
        }

        void OpenContacts()
        {
            if (activeWindow != Opened.Contacts)
            {
                panel1.Controls.Clear();
                ContactsUC contactsUC = new ContactsUC();
                panel1.Controls.Add(contactsUC);
                contactsUC.Dock = DockStyle.Fill;
                activeWindow = Opened.Contacts;
                resetButtons();
                button2.BackColor = SystemColors.GradientActiveCaption;
            }
            else return;
        }

        void OpenVaccines()
        {
            if (activeWindow != Opened.Vaccines)
            {
                panel1.Controls.Clear();
                VaccinesUC vaccinesUC = new VaccinesUC();
                panel1.Controls.Add(vaccinesUC);
                vaccinesUC.Dock = DockStyle.Fill;
                activeWindow = Opened.Vaccines;
                resetButtons();
                button3.BackColor = SystemColors.GradientActiveCaption;
            }
            else return;
        }

        void OpenConnections()
        {
            if (activeWindow != Opened.Connections)
            {
                panel1.Controls.Clear();
                ConnectionsUC connectionsUC = new ConnectionsUC();
                panel1.Controls.Add(connectionsUC);
                connectionsUC.Dock = DockStyle.Fill;
                activeWindow = Opened.Connections;
                resetButtons();
                button4.BackColor = SystemColors.GradientActiveCaption;
            }
            else return;
        }

        void OpenVaccinations()
        {
            if (activeWindow != Opened.Vaccinations)
            {
                panel1.Controls.Clear();
                VaccinationsUC vaccinationsUC = new VaccinationsUC();
                panel1.Controls.Add(vaccinationsUC);
                vaccinationsUC.Dock = DockStyle.Fill;
                activeWindow = Opened.Vaccinations;
                resetButtons();
                button1.BackColor = SystemColors.GradientActiveCaption;
            }
            else return;
        }
        void OpenTrace()
        {
            if (activeWindow != Opened.Trace)
            {
                panel1.Controls.Clear();
                TraceUC traceUC = new TraceUC();
                panel1.Controls.Add(traceUC);
                traceUC.Dock = DockStyle.Fill;
                activeWindow = Opened.Trace;
                resetButtons();
                button5.BackColor = SystemColors.GradientActiveCaption;
            }
            else return;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            OpenPeople();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenContacts();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenVaccines();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenConnections();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenTrace();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            OpenVaccinations();
        }
    }
}
