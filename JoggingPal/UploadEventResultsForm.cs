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
    public partial class UploadEventResultsForm : Form
    {
        Database db = Database.Instance();
        public UploadEventResultsForm()
        {
            InitializeComponent();
        }

        public Event SelectedEvent { get; set; }

        private void btnUploadResults_Click(object sender, EventArgs e)
        {
            Nullable<double> totalTime = null;
            Nullable<double> maxSpeed = null;
            Nullable<int> avgHeartRate = null; 

            Participant p = SelectedEvent.FindParticipant(db.currentUser);

            if (!String.IsNullOrEmpty(txtTotalTime.Text))
                totalTime = double.Parse(txtTotalTime.Text);

            if (!String.IsNullOrEmpty(txtMaxSpeed.Text))
                maxSpeed = double.Parse(txtMaxSpeed.Text);

            if (!String.IsNullOrEmpty(txtAvgHeartRate.Text))
                avgHeartRate = int.Parse(txtAvgHeartRate.Text);

            EventResults results = p.UploadEventResults(totalTime, maxSpeed, avgHeartRate);

            Console.WriteLine(results.ListParts());
        }
    }
}
