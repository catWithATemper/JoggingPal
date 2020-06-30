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
    public partial class EventDetailsForm : Form
    {
        public EventDetailsForm()
        {
            InitializeComponent();
        }
        public Event SelectedEvent { get; set; }

        private void EventDetailsForm_Load(object sender, EventArgs e)
        {
            listEventDetailsLoad();
        }

        private void listEventDetailsLoad()
        {
            ColumnHeader columnHeader1 = new ColumnHeader();
            ColumnHeader columnHeader2 = new ColumnHeader();

            listEventDetails.Columns.AddRange(new ColumnHeader[] { columnHeader1,
                                                                    columnHeader2 });
            
            listEventDetailsRefresh();
        }

        private void listEventDetailsRefresh()
        {
            listEventDetails.Items.Clear();

            string[] eventTypeRow = new string[2];
            eventTypeRow[0] = "Event type: ";
            if (typeof(InPersonEvent).IsInstanceOfType(SelectedEvent))
                eventTypeRow[1] = "In person event";
            else
                eventTypeRow[1] = "Virtual event";
            listEventDetails.Items.Add(new ListViewItem(eventTypeRow));

            string[] eventDateTimeRow = new string[2];
            eventDateTimeRow[0] = "Date and time: ";
            eventDateTimeRow[1] = SelectedEvent.DateTime.ToString("dddd, dd MMMM yyyy HH:mm");
            listEventDetails.Items.Add(new ListViewItem(eventDateTimeRow));

            string[] eventTitleRow = new string[2];
            eventTitleRow[0] = "Event title: ";
            eventTitleRow[1] = SelectedEvent.EventTitle;
            listEventDetails.Items.Add(new ListViewItem(eventTitleRow));

            string[] eventAvgSpeedRow = new string[2];
            eventAvgSpeedRow[0] = "Average speed: ";
            eventAvgSpeedRow[1] = SelectedEvent.AverageSpeed.ToString() + " minuti/km";
            listEventDetails.Items.Add(new ListViewItem(eventAvgSpeedRow));

            Participant participant = SelectedEvent.FindParticipant(LogInForm.CurrentUser);

            if (participant.ctx.CurrentState == LocationSet.Instance
                || participant.ctx.CurrentState == CheckedIn.Instance
                || participant.ctx.CurrentState == EventResultsUploaded.Instance)
            {

                string[] locationRow1 = new string[2];
                locationRow1[0] = "Location: ";
                locationRow1[1] = participant.JoggingLocation.RouteName;
                listEventDetails.Items.Add(new ListViewItem(locationRow1));

                string[] locationRow2 = new string[2];
                locationRow2[1] = participant.JoggingLocation.StartingPoint.ToString();
                listEventDetails.Items.Add(new ListViewItem(locationRow2));

                string[] locationRow3 = new string[2];
                locationRow3[1] = "Route length: " + participant.JoggingLocation.RouteLength.ToString() + " km";
                listEventDetails.Items.Add(new ListViewItem(locationRow3));

                if (typeof(InPersonEvent).IsInstanceOfType(SelectedEvent))
                {
                    InPersonEvent e = (InPersonEvent)SelectedEvent;

                    string[] locationRow4 = new string[2];
                    locationRow4[1] = "Location set by event organizer";
                    listEventDetails.Items.Add(new ListViewItem(locationRow4));
                }
                else
                {
                    VirtualEvent e = (VirtualEvent)SelectedEvent;

                    string[] locationRow4 = new string[2];
                    locationRow4[1] = "Location set by participant";
                    listEventDetails.Items.Add(new ListViewItem(locationRow4));
                }
            }
            else
            {
                string[] locationRow1 = new string[2];
                locationRow1[0] = "Location: ";
                locationRow1[1] = "Location not yet set by participant";
                listEventDetails.Items.Add(new ListViewItem(locationRow1));
            }

            listEventDetails.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listEventDetails.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
    }
}
