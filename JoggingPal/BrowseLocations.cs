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
            ColumnHeader columnHeader1 = new ColumnHeader();
            ColumnHeader columnHeader2 = new ColumnHeader();
            columnHeader1.Text = "Route name";
            columnHeader2.Text = "Length in km";
            this.listLocations.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2});

            string[] elements = new string[4];
            foreach (Location item in db.joggingLocations.Values)
            {
                elements[0] = item.RouteName;
                elements[1] = item.RouteLength.ToString();
                ListViewItem row = new ListViewItem(elements);
                listLocations.Items.Add(row);
            }
            listLocations.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
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
            foreach (ListViewItem item in listLocations.SelectedItems)
            {
                string key = item.SubItems[0].Text;
         
                Participant p = SelectedEvent.FindParticipant(db.currentUser);
                p.SetRunningLocation(db.joggingLocations[key]);
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
