using System;
using System.Collections;
using System.Windows.Forms;
using QStatitstics.Appcode;

namespace QStatitstics
{
    public partial class SetupRosterForm : Form
    {
        private readonly Team team;

        public SetupRosterForm(Team team)
        {
            InitializeComponent();
            this.team = team;
        }

        private void SetupRosterForm_Load(object sender, EventArgs e)
        {
            lbNotSet.Items.Clear();
            lbChasers.Items.Clear();
            Text = team.Name;
            team.FillListBox(lbNotSet);
        }

        private void btnAddChaser_Click(object sender, EventArgs e)
        {
            MovePlayer(lbNotSet, lbChasers);
        }

        private static void MovePlayer(ListBox source, ListBox destination)
        {
            if (source.SelectedItems.Count == 0)
                return;
            var itemsToMove = new ArrayList();
            foreach (object player in source.SelectedItems)
            {
                itemsToMove.Add(player);
            }
            foreach (object player in itemsToMove)
            {
                destination.Items.Add(player);
                source.Items.Remove(player);
            }
        }

        private void AddPlayer(ListBox destination)
        {
            MovePlayer(lbNotSet, destination);
        }

        private void RemovePlayer(ListBox source)
        {
            MovePlayer(source, lbNotSet);
        }

        private void btnRemoveChaser_Click(object sender, EventArgs e)
        {
            RemovePlayer(lbChasers);
        }

        private void lbChasers_DoubleClick(object sender, EventArgs e)
        {
            RemovePlayer(lbChasers);
        }

        private void btnAddBeater_Click(object sender, EventArgs e)
        {
            AddPlayer(lbBeaters);
        }

        private void btnRemoveBeater_Click(object sender, EventArgs e)
        {
            RemovePlayer(lbBeaters);
        }

        private void btnAddKeeper_Click(object sender, EventArgs e)
        {
            AddPlayer(lbKeepers);
        }

        private void btnRemoveKeeper_Click(object sender, EventArgs e)
        {
            RemovePlayer(lbKeepers);
        }

        private void lbKeepers_DoubleClick(object sender, EventArgs e)
        {
            RemovePlayer(lbKeepers);
        }

        private void btnAddSeeker_Click(object sender, EventArgs e)
        {
            AddPlayer(lbSeekers);
        }

        private void btnRemoveSeeker_Click(object sender, EventArgs e)
        {
            RemovePlayer(lbSeekers);
        }

        private void lbSeekers_DoubleClick(object sender, EventArgs e)
        {
            RemovePlayer(lbSeekers);
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (lbNotSet.Items.Count > 0 &&
                MessageBox.Show("Не все игроки распределены", "Игроки", MessageBoxButtons.OKCancel) ==
                DialogResult.Cancel)
            {
                return;
            }
            foreach (TeamPlayer player in lbChasers.Items)
            {
                player.PlayerPosition = TeamPlayer.Position.Chaser;
            }
            foreach (TeamPlayer player in lbKeepers.Items)
            {
                player.PlayerPosition = TeamPlayer.Position.Keeper;
            }
            foreach (TeamPlayer player in lbBeaters.Items)
            {
                player.PlayerPosition = TeamPlayer.Position.Beater;
            }
            foreach (TeamPlayer player in lbSeekers.Items)
            {
                player.PlayerPosition = TeamPlayer.Position.Seeker;
            }
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}