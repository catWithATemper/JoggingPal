using System;
using System.Globalization;
using System.Windows.Forms;
using JoggingPal.Models.Events;
using JoggingPal.Models.Participants;
using JoggingPal.Db;
using JoggingPal.Models.Results;

namespace JoggingPal
{
    public partial class SeeEventResultsForm : Form
    {
        public SeeEventResultsForm()
        {
            InitializeComponent();
        }

        public Event SelectedEvent { get; set; }

        private void SeeEventResultsForm_Load(object sender, EventArgs e)
        {
            listAveragePaceLoad();
            listMaxSpeedLoad();
            listAvgHeartRateLoad();
        }

        private void listAveragePaceLoad() 
        {
            ColumnHeader[] columnHeaders = FormUtils.CreateColumnHeaders(
                new String[] { "Participant", "Total time hh:mm:ss", "Average pace min/km" });

            listAveragePace.Columns.AddRange(columnHeaders);
            listAveragePaceRefresh();
        }

        private void listMaxSpeedLoad() 
        {
            ColumnHeader[] columnHeaders = FormUtils.CreateColumnHeaders(
                new String[] { "Participant", "Maximum speed km/h" });

            listMaxSpeed.Columns.AddRange(columnHeaders);
            listMaxSpeedRefresh();
        }

        private void listAvgHeartRateLoad() 
        {
            ColumnHeader[] columnHeaders = FormUtils.CreateColumnHeaders(
                new String[] { "Participant", "Average heart rate" });

            listAvgHeartRate.Columns.AddRange(columnHeaders);
            listAvgHeartRateRefresh();
        }
        private void listAveragePaceRefresh()
        {
            listAveragePace.Items.Clear();
            string[] averagePaceString = new string[3];
            foreach (Participant p in SelectedEvent.Participants)
            {
                if (p.EventResults != null &&
                    p.EventResults.resultParts.ContainsKey("Total time: "))
                {
                    EventResults results = p.EventResults;
                    TimeSpan totalTime = TimeSpan.Parse(results.resultParts["Total time: "],
                                        CultureInfo.InvariantCulture);

                    TimeSpan avgPace = CalculateAvgPace(p.RunningLocation.RouteLength,
                                        totalTime);

                    averagePaceString[0] = p.EventParticipant.UserName;
                    averagePaceString[1] = results.resultParts["Total time: "].ToString();
                    averagePaceString[2] = avgPace.Minutes.ToString() + ":" + avgPace.Seconds.ToString();

                    ListViewItem row = new ListViewItem(averagePaceString);

                    listAveragePace.Items.Add(row);
                }
            }
            listAveragePace.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listAveragePace.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }


        private void listMaxSpeedRefresh() 
        {
            listMaxSpeed.Items.Clear();
            string[] maxSpeedString = new string[2];

            foreach (Participant p in SelectedEvent.Participants)
            {
                if (p.EventResults != null)
                {
                    EventResults results = p.EventResults;
                    if (results.resultParts.ContainsKey("Maximum speed: "))
                    {
                        maxSpeedString[0] = p.EventParticipant.UserName;
                        maxSpeedString[1] = results.resultParts["Maximum speed: "].ToString();
                        ListViewItem row = new ListViewItem(maxSpeedString);

                        listMaxSpeed.Items.Add(row);
                    }
                    listMaxSpeed.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                    listMaxSpeed.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                }
            }
        }

        private void listAvgHeartRateRefresh() 
        {
            listAvgHeartRate.Items.Clear();
            string[] avgHeartRateString = new string[2];

            foreach (Participant p in SelectedEvent.Participants)
            {
                if (p.EventResults != null)
                {
                    EventResults results = p.EventResults;
                    if (results.resultParts.ContainsKey("Average heart rate: "))
                    {
                        avgHeartRateString[0] = p.EventParticipant.UserName;
                        avgHeartRateString[1] = results.resultParts["Average heart rate: "].ToString();
                        ListViewItem row = new ListViewItem(avgHeartRateString);

                        listAvgHeartRate.Items.Add(row);
                    }
                    listAvgHeartRate.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                    listAvgHeartRate.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                }
            }
        }

        private TimeSpan CalculateAvgPace(double routeLengthInKm, TimeSpan totalTime)
        {
            int distanceInMeters = (int)(routeLengthInKm * 1000);
            TimeSpan avgPace = new TimeSpan(totalTime.Ticks / distanceInMeters * 1000);
            return avgPace;
        }
    }
}
