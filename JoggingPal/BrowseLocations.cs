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
    public partial class BrowseLocationsForm : Form
    {
        Database db = Database.Instance();

        public BrowseLocationsForm()
        {
            InitializeComponent();
        }

            public VirtualEvent SelectedEvent { get; set; }

        private void BrowseLocationsForm_Load(object sender, EventArgs e)
        {
            foreach (Location item in db.joggingLocations)
                listLocations.Items.Add(item.ToString());
        }

        private void btnChooseLocationOK_Click(object sender, EventArgs e)
        {
            if (SelectedEvent == null)
            {
                MessageBox.Show("Select a virtual event from the previous window");
                this.Close();
                return;
            }
            if (listLocations.SelectedIndices.Count == 0)
                MessageBox.Show("Select a location from the list");
            foreach (int i in listLocations.SelectedIndices)
            {
                Participant p = SelectedEvent.FindParticipant(db.currentUser);
                p.SetRunningLocation(db.joggingLocations[i]);
                MessageBox.Show("Location selected successfully");
                Console.WriteLine(p.ToString());
            }    
        }

        private void btnChooseLocationCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreateNewLocation_Click(object sender, EventArgs e)
        {
            CreateNewLocationForm createNewLocation = new CreateNewLocationForm();
            createNewLocation.Show();
        }
    }
}
