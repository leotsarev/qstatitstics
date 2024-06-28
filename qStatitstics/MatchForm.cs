using System;
using System.Collections.Generic;
using System.Windows.Forms;
using QStatitstics.Appcode;

namespace QStatitstics;

public partial class MatchForm : Form
{
    private readonly List<MatchEvent> EventList = new List<MatchEvent>();
    private readonly Match MatchData;
    private bool DataSaved;
    private EventTypeItem ET;
    private TimeSpan EventTime = new TimeSpan(0);
    private int fdigit = -1;
    private TeamPlayer FirstPlayer;
    private bool HomeTeamEvent;
    private ViewMatchStatusForm ssf;
    private Step step = Step.MatchNotBegin;
    private bool techStop;

    public MatchForm(Match match)
    {
        MatchData = match;

        InitializeComponent();
    }

    private static void SetBindingSource(DataGridView grid, Team team)
    {
        var bindingSource = new BindingSource();
        team.Roster.Sort();
        bindingSource.DataSource = team.Roster;
        grid.DataSource = bindingSource;
        grid.SetupColumn("DispPosition", 0, "А", 20);
        grid.SetupColumn("Number", 1, "№", 45);
        grid.SetupColumn("Name", 2, "Имя", 120);
        grid.SetupColumn("Goals", 3, "Гол", 35);
        grid.SetupColumn("Fouls", 4, "Фолы", 120);
        grid.HideColumn("IsWomen");
    }


    private void MatchForm_Load(object sender, EventArgs e)
    {
        UpdateGrids();
        MatchEvent.FillListBox(EventTypeBox);
        Text = MatchData.MatchTitle;
        HomeButton.Text = String.Format("Z — {0}", MatchData.HomeTeam.Name);
        VisitorsButton.Text = String.Format("X — {0}", MatchData.VisitorsTeam.Name);
    }

    private static void SetTeamLabel(Control label, Team team)
    {
        label.Text = String.Format("{0} ({1})", team.Name, team.Score);
    }

    private void UpdateGrids()
    {
        //TODO this methods combines setup grids and update data. 
        // Separate and m.b. use Observable things for grid
        SetBindingSource(HomeGrid, MatchData.HomeTeam);
        SetBindingSource(VisitorsGrid, MatchData.VisitorsTeam);
        SetupEventsGrid();
        SetTeamLabel(HomeLabel, MatchData.HomeTeam);
        SetTeamLabel(VisitorsLabel, MatchData.VisitorsTeam);
        var lastRowIndex = EventsGrid.Rows.Count - 1;
        var displayedRowCount = EventsGrid.DisplayedRowCount(false);
        if (EventsGrid.FirstDisplayedScrollingRowIndex + displayedRowCount < lastRowIndex)
        {
            EventsGrid.FirstDisplayedScrollingRowIndex = lastRowIndex - displayedRowCount + 1;
        }
    }

    private void SetupEventsGrid()
    {
        var bindingSource = new BindingSource {DataSource = EventList};
        EventsGrid.DataSource = bindingSource;
        EventsGrid.SetupColumn("EventTime", 0, "Время", 50);
        EventsGrid.SetupColumn("Name", 1, "Событие", 130);
        EventsGrid.SetupColumn("Player1Name", 2, "Игрок", 130);
    }

    private void EventTypeBox_SelectedIndexChanged(object sender, EventArgs e)
    {
        SetEventType();
    }

    private void SetEventType()
    {
        if (step == Step.MatchNotBegin)
        {
            return;
        }
        step = Step.TeamNeeded;
        EventTime = MatchData.MatchTime;
        ET = (EventTypeItem) (EventTypeBox.SelectedItem);
        TimeLabel.Text = Utility.FormatTimeSpan(EventTime);
        EventTypeLabel.Text = ET.ToString();
        UpdateGrids();
    }


    private void HomeGrid_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        SelectPlayerFromGrid(e.RowIndex, true);
    }

    private void VisitorsGrid_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        SelectPlayerFromGrid(e.RowIndex, false);
    }

    private void SelectPlayerFromGrid(int rowIndex, bool homeTeam)
    {
        DataGridView grid = homeTeam ? HomeGrid : VisitorsGrid;
        var player = (TeamPlayer) grid.Rows[rowIndex].DataBoundItem;
        switch (step)
        {
            case Step.MatchNotBegin:
            case Step.TypeNeeed:
                return;
            case Step.TeamNeeded:
            case Step.PlayerNeeded:
                SetTeam(homeTeam);
                SetFirstPlayer(player);
                return;
        }
    }

    private void SetFirstPlayer(TeamPlayer player)
    {
        FirstPlayer = player;


        ApplyEvent();
    }

    private void ApplyEvent()
    {
        if (ET.ET == MatchEvent.EventType.Snitch)
        {
            TechSuspendMatch();
            var cancelSnitch = MessageBox.Show(
                $"Действительно ли СНИТЧ пойман игроком {FirstPlayer.Name} из команды {FirstPlayer.m_Team.Name}? Дождитесь окончательного решения судей.",
                "Окончание матча?", MessageBoxButtons.YesNo) == DialogResult.No;
            BeginOrResumeMatch();
            if (cancelSnitch) 
            { 
                return;
            }

        }
        try
        {
            var ev =
                new MatchEvent(MatchData, EventTime, ET.ET, FirstPlayer);
            EventList.Add(ev);
            UpdateGrids();
            step = Step.TypeNeeed;
            TimeLabel.Text = EventTypeLabel.Text = TeamLabel.Text = FirstPlayerLabel.Text = "";
            DeleteLastButton.Enabled = true;
            if (ET.ET == MatchEvent.EventType.Timeout)
            {
                BeginTimeout();
            }
            if (ET.ET == MatchEvent.EventType.Snitch)
            {
                ApplySnitch();
            }
        }
        catch (EventMalformedException e)
        {
            FirstPlayerLabel.Text = "";
            MessageBox.Show(e.Message);
        }
    }

    private void ApplySnitch()
    {
        MatchData.EndMatch();
        timer1.Stop();
        step = Step.MatchEnded;
        EventTypeBox.Enabled = HomeButton.Enabled = VisitorsButton.Enabled = false;
        SaveDataButton.Enabled = true;
        SnitchFlyingLabel.Text = "СНИТЧ ПОЙМАН";
        if (ssf != null)
        {
            ssf.UpdateInfo();
        }
    }


    private void HomeButton_Click(object sender, EventArgs e)
    {
        DoTeamSelect(true);
    }

    private void DoTeamSelect(bool homeTeam)
    {
        switch (step)
        {
            case Step.MatchNotBegin:
            case Step.TypeNeeed:
                return;
            case Step.TeamNeeded:
            case Step.PlayerNeeded:
                step = Step.PlayerNeeded;
                SetTeam(homeTeam);
                return;
        }
        fdigit = -1;
    }

    private void SetTeam(bool homeTeam)
    {
        HomeTeamEvent = homeTeam;
        TeamLabel.Text = HomeTeamEvent ? MatchData.HomeTeam.Name : MatchData.VisitorsTeam.Name;
        FirstPlayerLabel.Text = "";
    }

    private void VisitorsButton_Click(object sender, EventArgs e)
    {
        DoTeamSelect(false);
    }

    private void MatchForm_KeyPress(object sender, KeyPressEventArgs e)
    {
        switch (Char.ToUpper(e.KeyChar))
        {
            case 'Я':
            case 'Z':
                HomeButton.PerformClick();
                return;
            case 'Ч':
            case 'X':
                VisitorsButton.PerformClick();
                return;
            case 'П':
            case 'G':
                SetEventType(MatchEvent.EventType.Goal);
                return;
            case 'А':
            case 'F':
                SetEventType(MatchEvent.EventType.Foul);
                return;
            case 'Е':
            case 'T':
                SetEventType(MatchEvent.EventType.TFoul);
                return;
            case 'В':
            case 'D':
                SetEventType(MatchEvent.EventType.Disqual);
                return;
            case 'Ф':
            case 'A':
                SetEventType(MatchEvent.EventType.Timeout);
                return;
            case 'Й':
            case 'Q':
                SetEventType(MatchEvent.EventType.Snitch);
                return;
            case 'С':
            case 'C':
                if (DeleteLastButton.Enabled)
                {
                    DeleteLastButton.PerformClick();
                }
                return;
            default:
                if (Char.IsDigit(e.KeyChar) && step == Step.PlayerNeeded)
                {
                    HandleDigit(e.KeyChar);
                }
                return;
        }
    }

    private void HandleDigit(char c)
    {
        int digit = Int32.Parse(c.ToString());
        if (fdigit == -1)
        {
            fdigit = digit;
        }
        else
        {
            int Num = fdigit*10 + digit;
            TeamPlayer player = HomeTeamEvent
                                    ? MatchData.HomeTeam.FindPlayerByNum(Num)
                                    : MatchData.VisitorsTeam.FindPlayerByNum(Num);
            if (player == null)
                MessageBox.Show("Игрок не найден");
            else
            {
                SetFirstPlayer(player);
            }
            fdigit = -1;
        }
    }


    private void SetEventType(MatchEvent.EventType et)
    {
        for (int i = 0; i < EventTypeBox.Items.Count; i++)
        {
            var item = (EventTypeItem) EventTypeBox.Items[i];
            if (item.ET == et)
            {
                if (EventTypeBox.SelectedIndex == i)
                {
                    SetEventType();
                }
                else
                {
                    EventTypeBox.SelectedIndex = i;
                }
                return;
            }
        }
    }

    private void TechStop_Click(object sender, EventArgs e)
    {
        TechSuspendMatch();
    }

    private void TechSuspendMatch()
    {
        TechStop.Enabled = false;
        MatchData.BeginPause();
        techStop = true;
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
        CorrectTime.Enabled = MatchData.Paused;
        MatchTimeLabel.Text = Utility.FormatTimeSpan(MatchData.MatchTime);
        if (MatchData.Paused)
        {
            if (MatchData.TimeOutLeftTime <= TimeSpan.Zero || techStop)
            {
                BeginMatch.Enabled = true;
                BeginMatch.Text = String.Format("Возобновить игру");
            }
            else
            {
                BeginMatch.Enabled = false;
                BeginMatch.Text = String.Format("Таймаут ({0})", Utility.FormatTimeSpan(MatchData.TimeOutLeftTime));
            }
        }
        SnitchFlyingLabel.Visible = MatchData.SnitchFlying;
        if (ssf != null)
        {
            ssf.UpdateInfo();
        }
    }

    private void BeginMatch_Click(object sender, EventArgs e)
    {
        BeginOrResumeMatch();
    }

    private void BeginOrResumeMatch()
    {
        if (MatchData.Paused)
        {
            MatchData.EndPause();
        }
        else
        {
            MatchData.BeginMatch();
        }
        BeginMatch.Enabled = false;
        EventTypeBox.Enabled = HomeButton.Enabled = VisitorsButton.Enabled = true;
        step = Step.TypeNeeed;
        techStop = false;
        TechStop.Enabled = true;
    }

    private void BeginTimeout()
    {
        MatchData.BeginPause();
        BeginMatch.Enabled = false;
        BeginMatch.Text = FirstPlayer.m_Team.Name + " — Таймаут";
        EventTypeBox.Enabled = HomeButton.Enabled = VisitorsButton.Enabled = false;
        step = Step.MatchNotBegin;
        TechStop.Enabled = false;
    }

    private void DeleteLastButton_Click(object sender, EventArgs e)
    {
        int num = EventList.Count - 1;
        if (num < 0)
            return;
        MatchEvent ev = EventList[num];
        MatchData.RemoveLastEvent();
        EventList.RemoveAt(num);

        SetEventType(ev.etype);
        EventTime = ev.time;
        DeleteLastButton.Enabled = false;
        UpdateGrids();
    }

    private void CorrectTime_Click(object sender, EventArgs e)
    {
        var correct = new CorrectTime(MatchData.MatchTime);
        if (correct.ShowDialog() == DialogResult.OK)
        {
            MatchData.CorrectTime(correct.Span);
        }
    }

    private void MatchForm_FormClosing(object sender, FormClosingEventArgs e)
    {
        if (!DataSaved &&
            MessageBox.Show("Данные не будут сохранены! Подвердите выход.", "Выход", MessageBoxButtons.OKCancel) ==
            DialogResult.Cancel)
        {
            e.Cancel = true;
        }
    }


    private void SaveDataButton_Click(object sender, EventArgs e)
    {
        MatchData.SaveData();
        DataSaved = true;
        Close();
    }

    private void MatchForm_FormClosed(object sender, FormClosedEventArgs e)
    {
        ViewReportForm.ShowMatchProtocol(MatchData);
        if (ssf != null)
        {
            ssf.Close();
        }
    }

    private void EventsGrid_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        //MatchEvent ev = (MatchEvent) EventsGrid.Rows[e.RowIndex].DataBoundItem;
        //EditEventForm eef = new EditEventForm(MatchData, ev);
        //eef.ShowDialog();
    }

    private void OpenScoreFormButton_Click(object sender, EventArgs e)
    {
        if (ssf != null) return;
        var reverse = MessageBox.Show("Если форма будет показываться на мониторе, нажмите ДА. Если на проекторе, нажмите НЕТ.", "Перевернуть форму", MessageBoxButtons.YesNo) == DialogResult.Yes;
        var showTimer = MessageBox.Show("Если надо показывать часы, нажмите ДА. Если не надо, нажмите НЕТ.", "Показать часы", MessageBoxButtons.YesNo) == DialogResult.Yes;
        ssf = new ViewMatchStatusForm(MatchData, reverse, showTimer);
        ssf.FormClosed += ssf_FormClosed;
        ssf.Show();
        ssf.UpdateInfo();
        OpenScoreFormButton.Enabled = false;
    }

    private void ssf_FormClosed(object sender, FormClosedEventArgs e)
    {
        ssf = null;
        OpenScoreFormButton.Enabled = true;
    }

    #region Nested type: Step

    private enum Step
    {
        MatchNotBegin = -1,
        TypeNeeed = 0,
        TeamNeeded = 1,
        PlayerNeeded = 2,
        MatchEnded = 4
    }

    #endregion
}