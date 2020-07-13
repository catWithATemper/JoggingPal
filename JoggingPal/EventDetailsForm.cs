using JoggingPal.Models.Events;
using JoggingPal.Models.Participants;
using JoggingPal.Models.ParticipantStates;
using System;
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
            listEventDetails.Columns.AddRange(new ColumnHeader[] { new ColumnHeader(),
                                                                    new ColumnHeader() });
            listEventDetailsRefresh();
        }

        private void listEventDetailsRefresh()
        {
            listEventDetails.Items.Clear();

            string eventType;
            if (typeof(InPersonEvent).IsInstanceOfType(SelectedEvent))
                eventType = "In person event";
            else
                eventType = "Virtual event";

            AddRow("Event type: ", eventType);
            AddRow("Date and time: ", SelectedEvent.DateTime.ToString("dddd, dd MMMM yyyy HH:mm"));
            AddRow("Event title: ", SelectedEvent.EventTitle);
            AddRow("Average speed: ", SelectedEvent.AverageSpeed.ToString() + " km/h");

            Participant participant = SelectedEvent.FindParticipant(LogInForm.CurrentUser);

            if (participant.ctx.CurrentState == LocationSet.Instance
                || participant.ctx.CurrentState == CheckedIn.Instance
                || participant.ctx.CurrentState == EventResultsUploaded.Instance)
            {
                AddRow("Location: ", participant.RunningLocation.RouteName);
                AddRow("", participant.RunningLocation.StartingPoint.ToString());
                AddRow("", "Route length: " + participant.RunningLocation.RouteLength.ToString() + " km");

                if (typeof(InPersonEvent).IsInstanceOfType(SelectedEvent))
                {
                    AddRow("", "Location set by event organizer");
                }
                else
                {
                    AddRow("", "Location set by participant");
                }
            }
            else
            {
                AddRow("Location: ", "Location not yet set by participant");
            }

            AddRow("Participant state: ", participant.ctx.CurrentState.ToString());
            AddRow("No. of participants: ", SelectedEvent.Participants.Count.ToString());

            listEventDetails.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listEventDetails.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void AddRow(string label, string value)
        {
            string[] eventRow = new string[] { label, value };
            listEventDetails.Items.Add(new ListViewItem(eventRow));
        }
    }
}
