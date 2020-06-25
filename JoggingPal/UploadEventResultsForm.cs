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
            double? totalTime = null;
            double? maxSpeed = null;
            int? avgHeartRate = null; 

            Participant p = SelectedEvent.FindParticipant(db.currentUser);

            if (!string.IsNullOrEmpty(txtTotalTime.Text))
                totalTime = double.Parse(txtTotalTime.Text);

            if (!string.IsNullOrEmpty(txtMaxSpeed.Text))
                maxSpeed = double.Parse(txtMaxSpeed.Text);

            if (!string.IsNullOrEmpty(txtAvgHeartRate.Text))
                avgHeartRate = int.Parse(txtAvgHeartRate.Text);

            EventResults results = p.UploadEventResults(totalTime, maxSpeed, avgHeartRate);

            Console.WriteLine(results.ListParts());
        }
    }
}
