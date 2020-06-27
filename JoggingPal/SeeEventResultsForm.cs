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
    public partial class SeeEventResultsForm : Form
    {
        Database db = Database.Instance();

        public SeeEventResultsForm()
        {
            InitializeComponent();
        }

        public Event SelectedEvent { get; set; }

        private void SeeEventResultsForm_Load(object sender, EventArgs e)
        {;
            listAverageSpeedLoad();
            listMaxSpeedLoad();
            listAvgHeartRateLoad();
        }

        private void listAverageSpeedLoad() 
        {
            ColumnHeader columnHeader1 = new ColumnHeader();
            ColumnHeader columnHeader2 = new ColumnHeader();
            columnHeader1.Text = "Participant";
            columnHeader2.Text = "Average speed";

            listAverageSpeed.Columns.AddRange(new ColumnHeader[] { columnHeader1,
                                                                columnHeader2 });

            listAverageSpeedRefresh();
        }
        private void listMaxSpeedLoad() 
        {
            ColumnHeader columnHeader1 = new ColumnHeader();
            ColumnHeader columnHeader2 = new ColumnHeader();
            columnHeader1.Text = "Participant";
            columnHeader2.Text = "Maximum speed";

            listMaxSpeed.Columns.AddRange(new ColumnHeader[] { columnHeader1,
                                                                columnHeader2 });
            listMaxSpeedRefresh();
        }
        private void listAvgHeartRateLoad() 
        {
            ColumnHeader columnHeader1 = new ColumnHeader();
            ColumnHeader columnHeader2 = new ColumnHeader();
            columnHeader1.Text = "Participant";
            columnHeader2.Text = "Average heart rate";

            listAvgHeartRate.Columns.AddRange(new ColumnHeader[] { columnHeader1,
                                                                columnHeader2 });
            listAvgHeartRateRefresh();
        }
        private void listAverageSpeedRefresh()
        {
            listAverageSpeed.Items.Clear();
            string[] averageSpeedString = new string[2];
            foreach (Participant p in SelectedEvent.Participants)
            {
                EventResults results = p.EventResults;
                if (results.resultParts.ContainsKey("Total time: "))
                {
                    averageSpeedString[0] = p.EventParticipant.UserName;
                    averageSpeedString[1] = results.resultParts["Total time: "].ToString();

                    ListViewItem row = new ListViewItem(averageSpeedString);

                    listAverageSpeed.Items.Add(row);
                }
                listAverageSpeed.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                listAverageSpeed.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
        }

        private void listMaxSpeedRefresh() 
        {
            listMaxSpeed.Items.Clear();
            string[] maxSpeedString = new string[2];

            foreach (Participant p in SelectedEvent.Participants)
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

        private void listAvgHeartRateRefresh() 
        {
            listAvgHeartRate.Items.Clear();
            string[] avgHeartRateString = new string[2];

            foreach (Participant p in SelectedEvent.Participants)
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
}
