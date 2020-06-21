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
        {
            foreach (Participant p in SelectedEvent.participants)
            {
                EventResults results = p.eventResults;
                if (results.resultParts.ContainsKey("Total time: "))
                    listAverageSpeed.Items.Add(results.resultParts["Total time: "].ToString());
                if (results.resultParts.ContainsKey("Maximum speed: "))
                    listMaxSpeed.Items.Add(results.resultParts["Maximum speed: "].ToString());
                if (results.resultParts.ContainsKey("Average heart rate: "))
                    listAvgHeartRate.Items.Add(results.resultParts["Average heart rate: "].ToString());
            }    
        }
    }
}
