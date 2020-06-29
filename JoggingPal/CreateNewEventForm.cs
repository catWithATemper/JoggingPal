using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JoggingPal
{
    public partial class CreateNewEventForm : Form
    {
        Database db = Database.Instance();
        public CreateNewEventForm()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            Console.WriteLine(dateTimePicker1.Value.ToString());
        }

        private void btnCreateNewInPersonEventOK_Click(object sender, EventArgs e)
        {
            Location selectedLocation = null;
            string locationKey;

            DateTime dateTime = dateTimePicker1.Value;
            double avgSpeed;
            string eventTitle;

            if (string.IsNullOrWhiteSpace(txtAvgSpeed.Text) 
                || !double.TryParse(txtAvgSpeed.Text, out avgSpeed))
            {
                MessageBox.Show("Please enter a value for the event average speed consisting of digits and one comma.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtInPersonEventTitle.Text))
            {           
                MessageBox.Show("Please enter a title for the event.");
                return;
            }

            if (db.events.ContainsKey(txtInPersonEventTitle.Text))
            {
                MessageBox.Show("An event with this title already exists. Please provide a different title.");
                return;
            }
            else
                eventTitle = txtInPersonEventTitle.Text;

            if (listLocations.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a location from the list or create a new one.");
                return;
            }

            foreach (ListViewItem item in listLocations.SelectedItems)
            {
                locationKey = item.SubItems[0].Text;
                selectedLocation = db.joggingLocations[locationKey];
            }

            Event newEvent = new InPersonEvent(dateTime, avgSpeed, eventTitle, selectedLocation);
            db.events.Add(newEvent.EventTitle, newEvent);
            db.inPersonEvents.Add(newEvent.EventTitle, (InPersonEvent)newEvent);
            Close();
        }

        private void btnCreateNewVirtualEventoOk_Click(object sender, EventArgs e)
        {
            DateTime dateTime = dateTimePicker2.Value;
            double avgSpeed;
            string eventTitle;
            double routeLength;

            if (string.IsNullOrWhiteSpace(txtVirtEventAvgSpeed.Text)
                || !double.TryParse(txtVirtEventAvgSpeed.Text, out avgSpeed))
            {
                MessageBox.Show("Please enter a value for the event average speed consisting of digits and one comma.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtVirtualEventTitle.Text))
            {
                MessageBox.Show("Please enter a title for the event.");
                return;
            }
            if (db.events.ContainsKey(txtVirtualEventTitle.Text))
            {
                MessageBox.Show("An event with this title already exists. Please provide a different title.");
                return;
            }
            else
                eventTitle = txtVirtualEventTitle.Text;

            if (string.IsNullOrWhiteSpace(txtVirtualEventLength.Text)
            || !double.TryParse(txtVirtualEventLength.Text, out routeLength))
            {
                MessageBox.Show("Please enter a value for the event route length consisting of digits and one comma.");
                return;
            }

            Event newEvent = new VirtualEvent(dateTime, avgSpeed, eventTitle, routeLength);
            db.events.Add(newEvent.EventTitle, newEvent);
            db.virtualEvents.Add(newEvent.EventTitle, (VirtualEvent)newEvent);

            Close();
        }

        private void CreateNewEventForm_Load(object sender, EventArgs e)
        {
            listLocationsLoad();
        }

        private void btnCreateNewLocation_Click(object sender, EventArgs e)
        {
            CreateNewLocationForm createNewLocation = new CreateNewLocationForm();
            createNewLocation.ShowDialog();
            listLocations.Items.Clear();
            ListLocationsRefresh();
        }

       private void listLocationsLoad()
       {
            ColumnHeader columnHeader1 = new ColumnHeader();
            ColumnHeader columnHeader2 = new ColumnHeader();
            ColumnHeader columnHeader3 = new ColumnHeader();
            columnHeader1.Text = "Route name";
            columnHeader2.Text = "Length in km";
            columnHeader3.Text = "Starting point";
            this.listLocations.Columns.AddRange(new ColumnHeader[] { columnHeader1,
                                                                    columnHeader2,
                                                                    columnHeader3});
            ListLocationsRefresh();
        }
        
        private void ListLocationsRefresh()
        {
            listLocations.Items.Clear();
            string[] elements = new string[4];
            foreach (Location item in db.joggingLocations.Values)
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
    }
}
