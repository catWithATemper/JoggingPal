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
            string key;
            foreach (ListViewItem item in listLocations.SelectedItems)
            {
                key = item.SubItems[0].Text;
                selectedLocation = db.joggingLocations[key];
            }
            
            Event newEvent = new InPersonEvent(
                dateTimePicker1.Value,
                double.Parse(txtAvgSpeed.Text),
                txtInPersonEventTitle.Text,
                selectedLocation);
            db.events.Add(newEvent.EventTitle, newEvent);
            db.inPersonEvents.Add(newEvent.EventTitle, (InPersonEvent)newEvent);
            this.Close();

            Console.WriteLine(newEvent.ToString());
        }

        private void btnCreateNewVirtualEventoOk_Click(object sender, EventArgs e)
        {
            Event newEvent = new VirtualEvent(
                dateTimePicker2.Value,
                double.Parse(txtVirtEventAvgSpeed.Text),
                txtVirtualEventTitle.Text,
                double.Parse(txtVirtualEventLength.Text));
            db.events.Add(newEvent.EventTitle, newEvent);
            db.virtualEvents.Add(newEvent.EventTitle, (VirtualEvent)newEvent);

            this.Close();
            Console.WriteLine(newEvent.ToString());

        }

        private void CreateNewEventForm_Load(object sender, EventArgs e)
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

        private void btnCreateNewLocation_Click(object sender, EventArgs e)
        {
            CreateNewLocationForm createNewLocation = new CreateNewLocationForm();
            createNewLocation.ShowDialog();
            listLocations.Items.Clear();
            ListLocationsRefresh();
        }

        private void ListLocationsRefresh()
        {

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
