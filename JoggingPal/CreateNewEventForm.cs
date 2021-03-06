﻿using JoggingPal.Models.Events;
using JoggingPal.Models.Locations;
using JoggingPal.Db;
using System;
using System.Windows.Forms;

namespace JoggingPal
{
    public partial class CreateNewEventForm : Form
    {
        private Database db = Database.Instance();
        public CreateNewEventForm()
        {
            InitializeComponent();
        }

        //
        // Tab 1: Create in-person-event
        //
        private void CreateNewEventForm_Load(object sender, EventArgs e)
        {
            listLocationsLoad();
        }

        private void btnCreateNewInPersonEventOK_Click(object sender, EventArgs e)
        {
            Location selectedLocation = null;
            string locationKey;

            DateTime dateTime = dateTimePicker1.Value;
            double avgSpeed;
            string eventTitle;

            if (dateTime.CompareTo(DateTime.Now) <= 0)
            {
                MessageBox.Show("You can only create events that take place in the future.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtAvgSpeedTab1.Text) 
                || !double.TryParse(txtAvgSpeedTab1.Text, out avgSpeed))
            {
                MessageBox.Show("Please enter a value for the event average speed consisting of digits and one comma.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtEventTitleTab1.Text))
            {           
                MessageBox.Show("Please enter a title for the event.");
                return;
            }

            if (db.Events.ContainsKey(txtEventTitleTab1.Text))
            {
                MessageBox.Show("An event with this title already exists. Please provide a different title.");
                return;
            }
            else
                eventTitle = txtEventTitleTab1.Text;

            if (listLocations.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a location from the list or create a new one.");
                return;
            }

            foreach (ListViewItem item in listLocations.SelectedItems)
            {
                locationKey = item.SubItems[0].Text;
                selectedLocation = db.RunningLocations[locationKey];
            }

            Event newEvent = new InPersonEvent(dateTime, avgSpeed, eventTitle, selectedLocation);
            db.Events.Add(newEvent.EventTitle, newEvent);
            Close();
        }

        private void btnCreateNewLocation_Click(object sender, EventArgs e)
        {
            CreateNewLocationForm createNewLocation = new CreateNewLocationForm();
            createNewLocation.ShowDialog();
            listLocations.Items.Clear();
            ListLocationsRefresh();
        }

        private void btnCancelTab1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void listLocationsLoad()
        {
            ColumnHeader[] columnHeaders = FormUtils.CreateColumnHeaders(
                new String[] { "Route name", "Length in km", "Starting point" });

            listLocations.Columns.AddRange(columnHeaders);
            ListLocationsRefresh();
        }

        private void ListLocationsRefresh()
        {
            listLocations.Items.Clear();
            string[] elements = new string[3];
            foreach (Location item in db.RunningLocations.Values)
            {
                elements[0] = item.RouteName;
                elements[1] = item.RouteLength.ToString();
                elements[2] = item.StartingPoint.ToString();
                ListViewItem row = new ListViewItem(elements);
                listLocations.Items.Add(row);
            }
            listLocations.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listLocations.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        //
        // Tab 2: Create virtual event
        //
        private void btnCreateNewVirtualEventoOk_Click(object sender, EventArgs e)
        {
            DateTime dateTime = dateTimePicker2.Value;
            double avgSpeed;
            string eventTitle;
            double routeLength;

            if (dateTime.CompareTo(DateTime.Now) <= 0)
            {
                MessageBox.Show("You can only create events that take place in the future.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtAvgSpeedTab2.Text)
                || !double.TryParse(txtAvgSpeedTab2.Text, out avgSpeed))
            {
                MessageBox.Show("Please enter a value for the event average speed consisting of digits and one comma.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtEventTitleTab2.Text))
            {
                MessageBox.Show("Please enter a title for the event.");
                return;
            }
            if (db.Events.ContainsKey(txtEventTitleTab2.Text))
            {
                MessageBox.Show("An event with this title already exists. Please provide a different title.");
                return;
            }
            else
                eventTitle = txtEventTitleTab2.Text;

            if (string.IsNullOrWhiteSpace(txtLengthTab2.Text)
            || !double.TryParse(txtLengthTab2.Text, out routeLength))
            {
                MessageBox.Show("Please enter a value for the event route length consisting of digits and one comma.");
                return;
            }

            Event newEvent = new VirtualEvent(dateTime, avgSpeed, eventTitle, routeLength);
            db.Events.Add(newEvent.EventTitle, newEvent);

            Close();
        }

        private void btnCancelTab2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
