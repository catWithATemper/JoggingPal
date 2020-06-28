﻿using System;
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
    public partial class BrowseLocationsForm : Form
    {
        Database db = Database.Instance();

        public BrowseLocationsForm()
        {
            InitializeComponent();
        }

        public VirtualEvent SelectedEvent { get; set; }

        private void BrowseLocationsForm_Load(object sender, EventArgs e)
        {
            listLocationsLoad();
        }

        private void btnChooseLocationOK_Click(object sender, EventArgs e)
        {
            if (SelectedEvent == null)
            {
                MessageBox.Show("Select a virtual event from the previous window");
                Close();
                return;
            }
            if (listLocations.SelectedIndices.Count == 0)
                MessageBox.Show("Select a location from the list");
            foreach (ListViewItem item in listLocations.SelectedItems)
            {
                string key = item.SubItems[0].Text;
         
                Participant p = SelectedEvent.FindParticipant(LogInForm.CurrentUser);
                p.SetRunningLocation(db.joggingLocations[key]);
                MessageBox.Show("Location selected successfully");
            }    
        }

        private void btnChooseLocationCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreateNewLocation_Click(object sender, EventArgs e)
        {
            CreateNewLocationForm createNewLocation = new CreateNewLocationForm();
            createNewLocation.ShowDialog();
            listLocationsRefresh();
        }

        private void listLocationsLoad()
        {
            ColumnHeader columnHeader1 = new ColumnHeader();
            ColumnHeader columnHeader2 = new ColumnHeader();
            ColumnHeader columnHeader3 = new ColumnHeader();
            columnHeader1.Text = "Route name";
            columnHeader2.Text = "Length in km";
            columnHeader3.Text = "Starting point";
            listLocations.Columns.AddRange(new ColumnHeader[] { columnHeader1,
                                                                    columnHeader2,
                                                                    columnHeader3});
            listLocationsRefresh();
        }

        private void listLocationsRefresh()
        {
            listLocations.Items.Clear();

            string[] elements = new string[3];
            foreach (Location item in db.joggingLocations.Values)
            {
                elements[0] = item.RouteName;
                elements[1] = item.RouteLength.ToString();
                elements[2] = item.StartingPoint.ToString();
                ListViewItem row = new ListViewItem(elements);
                listLocations.Items.Add(row);
            }
            listLocations.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listLocations.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
    }
}
