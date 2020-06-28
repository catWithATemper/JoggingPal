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
            TimeSpan totalTime;
            double? maxSpeed = null;
            int? avgHeartRate = null;

            Participant p = SelectedEvent.FindParticipant(LogInForm.CurrentUser);

            if (string.IsNullOrWhiteSpace(txtTotalTime.Text)
                || !TimeSpan.TryParse(txtTotalTime.Text, out totalTime))
            {
                MessageBox.Show("Please enter a value for the total time. Use the format hh:mm:ss");
                return;
            }

            double maxSpeedValue;
            if (!string.IsNullOrWhiteSpace(txtMaxSpeed.Text))
                if (!double.TryParse(txtMaxSpeed.Text, out maxSpeedValue))
                {
                    MessageBox.Show("Please enter a value for the maximum speed consisting of digits and one comma.");
                    return;
                }
                else
                    maxSpeed = maxSpeedValue;

            int avgHeartRateValue;
            if (!string.IsNullOrWhiteSpace(txtAvgHeartRate.Text))
                if (!int.TryParse(txtAvgHeartRate.Text, out avgHeartRateValue))
                {
                    MessageBox.Show("Please enter a value for the average heart rate consisting of digits only.");
                    return;
                }
                else
                    avgHeartRate = avgHeartRateValue;

            p.UploadEventResults(totalTime, maxSpeed, avgHeartRate);
        }
    }
}
