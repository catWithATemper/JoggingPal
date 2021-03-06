﻿using JoggingPal.Models.Events;
using JoggingPal.Models.Participants;
using System;
using System.Windows.Forms;

namespace JoggingPal
{
    public partial class UploadEventResultsForm : Form
    {
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
            {
                if (!double.TryParse(txtMaxSpeed.Text, out maxSpeedValue))
                {
                    MessageBox.Show("Please enter a value for the maximum speed consisting of digits and one comma.");
                    return;
                }
                else
                    maxSpeed = maxSpeedValue;
            }

            int avgHeartRateValue;
            if (!string.IsNullOrWhiteSpace(txtAvgHeartRate.Text))
            {
                if (!int.TryParse(txtAvgHeartRate.Text, out avgHeartRateValue))
                {
                    MessageBox.Show("Please enter a value for the average heart rate consisting of digits only.");
                    return;
                }
                else
                    avgHeartRate = avgHeartRateValue;
            }
            p.UploadEventResults(totalTime, maxSpeed, avgHeartRate);
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
