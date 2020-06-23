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
            
            foreach (string key in listLocations.SelectedItems)
                selectedLocation = db.joggingLocations[key];
            
            Event newEvent = new InPersonEvent(
                dateTimePicker1.Value,
                double.Parse(txtAvgSpeed.Text),
                selectedLocation);
            db.events.Add(newEvent);
            db.inPersonEvents.Add((InPersonEvent)newEvent);
            this.Close();

            Console.WriteLine(newEvent.ToString());
        }

        private void btnCreateNewVirtualEventoOk_Click(object sender, EventArgs e)
        {
            Event newEvent = new VirtualEvent(
                dateTimePicker2.Value,
                double.Parse(txtVirtEventAvgSpeed.Text),
                double.Parse(txtVirtualEventLength.Text));
            db.events.Add(newEvent);
            db.virtualEvents.Add((VirtualEvent)newEvent);

            this.Close();
            Console.WriteLine(newEvent.ToString());

        }

        private void CreateNewEventForm_Load(object sender, EventArgs e)
        {
            foreach (Location i in db.joggingLocations.Values)
                listLocations.Items.Add(i.ToString());
        }

        private void btnCreateNewLocation_Click(object sender, EventArgs e)
        {
            CreateNewLocationForm createNewLocation = new CreateNewLocationForm();
            createNewLocation.ShowDialog();
            ListLocationsRefresh();
        }

        private void ListLocationsRefresh()
        {
            listLocations.Items.Clear();
            foreach (Location i in db.joggingLocations.Values)
            listLocations.Items.Add(i.ToString());
        }
    }
}
