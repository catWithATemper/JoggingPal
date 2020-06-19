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
    public partial class CreateNewLocationForm : Form
    {
        Database db = Database.Instance();
        public CreateNewLocationForm()
        {
            InitializeComponent();
        }

        private void btnCreateNewLocationOK_Click(object sender, EventArgs e)
        {
            Location l = new Location(txtRouteName.Text, double.Parse(txtLatitude.Text),
                double.Parse(txtLongitude.Text), double.Parse(txtLength.Text));
            db.joggingLocations.Add(l);
            this.Close();
            Console.WriteLine(l.ToString());
        }
    }
}
