using JoggingPal.Models.Locations;
using JoggingPal.Db;
using System;
using System.Windows.Forms;

namespace JoggingPal
{
    public partial class CreateNewLocationForm : Form
    {
        Database db = Database.Instance();
        public CreateNewLocationForm()
        {
            InitializeComponent();
        }

        private void btnCreateNewLocationOK_Click(object sender, EventArgs e)
        {
            string routeName;
            double latitude;
            double longitude;
            double routeLength;

            if (String.IsNullOrWhiteSpace(txtRouteName.Text))
            {
                MessageBox.Show("Please enter a name for the new running location.");
                return;
            }
            if (db.RunningLocations.ContainsKey(txtRouteName.Text))
            {
                MessageBox.Show("A route with this name already exists. Please provide a different title.");
                return;
            }
            else
                routeName = txtRouteName.Text;

            if (string.IsNullOrWhiteSpace(txtLatitude.Text) 
                || !(double.TryParse(txtLatitude.Text, out latitude))
                || latitude < -90 || latitude > 90)
            {
                MessageBox.Show("Please enter a value for the latitude between -90,0 and 90,0.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtLongitude.Text) 
                || !(double.TryParse(txtLongitude.Text, out longitude))
                || longitude < -180 || longitude > 180)
            {
                MessageBox.Show("Please enter a value for the longitude between -180,0 and 180,0.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtLength.Text) 
                || !(double.TryParse(txtLength.Text, out routeLength)))
            {
                MessageBox.Show("Please enter a value for the route length consisting of digits and one comma.");
                return;
            }

            if (routeLength == 0)
                MessageBox.Show("The length of the route should be greater than 0.");

            Location l = new Location(routeName, latitude, longitude, routeLength);
            db.RunningLocations.Add(l.RouteName, l);
            Close();
        }

        private void btnCreateNewLocationCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
