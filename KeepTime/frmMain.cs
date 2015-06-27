using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeepTime {
    public partial class frmMain : Form {
        #region Private Variables
        private readonly string[] timeFormat12Hour = new string[] {
            "12 AM", "01 AM", "02 AM", "03 AM", "04 AM", "05 AM",
            "06 AM", "07 AM", "08 AM", "09 AM", "10 AM", "11 AM",
            "12 PM", "01 PM", "02 PM", "03 PM", "04 PM", "05 PM",
            "06 PM", "07 PM", "08 PM", "09 PM", "10 PM", "11 PM"
        };

        private readonly string[] timeFormat24Hour = new string[] {
            "00", "01", "02", "03", "04", "05", "06",
            "07", "08", "09", "10", "11", "12", "13",
            "14", "15", "16", "17", "18", "19", "20",
            "21", "22", "23"
        };

        private string[] dayNames = System.Globalization
                                    .CultureInfo.CurrentCulture
                                    .DateTimeFormat.DayNames;
        private bool alarmRunning = false;
        private bool timerRunning = false;
        private bool stopwatchRunning = false;
        private ErrorForm.ErrorForm errorForm = new ErrorForm.ErrorForm();
        private Dictionary<string, bool> repeatDays = new Dictionary<string, bool>();
        #endregion

        #region Form
        public frmMain() {
            InitializeComponent();

            this.Icon = Globals.Icon_32x32;
            trayIcon.Icon = Globals.Icon_16x16;
        }

        private void frmMain_Load(object sender, EventArgs e) {
            UpdateStatusbarDate(optionsDayMonthYearFormat.Checked);
            ChangeTimeFormat(options24HourTime.Checked);
            UpdateStatusbarTime(options24HourTime.Checked);
            
            InitializeSettings();
        }

        private void frmMain_Resize(object sender, EventArgs e) {
            // if the form is minimized, hide it
            // if not, show it
            ChangeWindowState(this.WindowState == FormWindowState.Minimized);
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e) {
            Properties.Settings.Default.Save();
        }
        #endregion

        #region Buttons
        private void btnAlarmStart_Click(object sender, EventArgs e) {
            AlarmRunning = !AlarmRunning;

            if(AlarmRunning) {
                SetAlarm(DateTime.Now);
            }
        }

        private void btnTimerStart_Click(object sender, EventArgs e) {
            TimerRunning = !TimerRunning;

            if(TimerRunning) {
                SetTimer(DateTime.Now);
            }
        }

        private void btnStopwatchStart_Click(object sender, EventArgs e) {
            StopwatchRunning = !StopwatchRunning;

            if(StopwatchRunning) {
                StopwatchDateTime = DateTime.Now;
            }
            else {
                StopStopwatch();
            }
        }

        private void btnStopwatchReset_Click(object sender, EventArgs e) {
            lblStopwatch.Text = "00:00:00";
            LastSpan = TimeSpan.Zero;
        }
        #endregion
        
        #region Repeat Checkboxes
        private void chkAlarmSunday_CheckedChanged(object sender, EventArgs e) {
            repeatDays[dayNames[0]] = chkAlarmSunday.Checked;
            Properties.Settings.Default.RepeatSunday =
                chkAlarmSunday.Checked;
        }

        private void chkAlarmMonday_CheckedChanged(object sender, EventArgs e) {
            repeatDays[dayNames[1]] = chkAlarmMonday.Checked;
            Properties.Settings.Default.RepeatMonday =
                chkAlarmMonday.Checked;
        }

        private void chkAlarmTuesday_CheckedChanged(object sender, EventArgs e) {
            repeatDays[dayNames[2]] = chkAlarmTuesday.Checked;
            Properties.Settings.Default.RepeatTuesday =
                chkAlarmTuesday.Checked;
        }

        private void chkAlarmWednesday_CheckedChanged(object sender, EventArgs e) {
            repeatDays[dayNames[3]] = chkAlarmWednesday.Checked;
            Properties.Settings.Default.RepeatWednesday =
                chkAlarmWednesday.Checked;
        }

        private void chkAlarmThursday_CheckedChanged(object sender, EventArgs e) {
            repeatDays[dayNames[4]] = chkAlarmThursday.Checked;
            Properties.Settings.Default.RepeatThursday =
                chkAlarmThursday.Checked;
        }

        private void chkAlarmFriday_CheckedChanged(object sender, EventArgs e) {
            repeatDays[dayNames[5]] = chkAlarmFriday.Checked;
            Properties.Settings.Default.RepeatFriday =
                chkAlarmFriday.Checked;
        }

        private void chkAlarmSaturday_CheckedChanged(object sender, EventArgs e) {
            repeatDays[dayNames[6]] = chkAlarmSaturday.Checked;
            Properties.Settings.Default.RepeatSaturday =
                chkAlarmSaturday.Checked;
        }

        private void chkTimerRepeat_CheckedChanged(object sender, EventArgs e) {
            Properties.Settings.Default.RepeatTimer =
                chkTimerRepeat.Checked;
        }
        #endregion

        #region Timers
        private void timerTime_Tick(object sender, EventArgs e) {
            if(DisplayTimeInStatusBar)
                UpdateStatusbarTime(options24HourTime.Checked);
        }

        private void timerDate_Tick(object sender, EventArgs e) {
            if(DisplayDateInStatusBar)
                UpdateStatusbarDate(optionsDayMonthYearFormat.Checked);
        }

        private void timerAlarm_Tick(object sender, EventArgs e) {
            if(CompareDateTime(AlarmDateTime)) {
                StopAlarm(!optionsDisableSound.Checked,
                          !optionsDisablePopup.Checked);
            }
        }

        private void timerTimer_Tick(object sender, EventArgs e) {
            if(CompareDateTime(TimerDateTime)) {
                StopTimer(!optionsDisableSound.Checked,
                         !optionsDisablePopup.Checked,
                         chkTimerRepeat.Checked);
            }
        }

        private void timerStopwatch_Tick(object sender, EventArgs e) {
            CurrentSpan = (DateTime.Now - StopwatchDateTime).Add(LastSpan);

            lblStopwatch.Text = string.Format(
                "{0}:{1}:{2}",
                CurrentSpan.Hours.ToString("0#"),
                CurrentSpan.Minutes.ToString("0#"),
                CurrentSpan.Seconds.ToString("0#"));
        }
        #endregion

        #region Miscellaneous
        private void cmbAlarmHour_SelectedIndexChanged(object sender, EventArgs e) {
            Properties.Settings.Default.AlarmHour =
                cmbAlarmHour.SelectedIndex;
        }

        private void cmbAlarmMinute_SelectedIndexChanged(object sender, EventArgs e) {
            Properties.Settings.Default.AlarmMinute =
                cmbAlarmMinute.SelectedIndex;
        }

        private void cmbAlarmSecond_SelectedIndexChanged(object sender, EventArgs e) {
            Properties.Settings.Default.AlarmSecond =
                cmbAlarmSecond.SelectedIndex;
        }

        private void txtAlarmMessage_Leave(object sender, EventArgs e) {
            Properties.Settings.Default.AlarmMessage =
                txtAlarmMessage.Text;
        }

        private void txtTimerMessage_Leave(object sender, EventArgs e) {
            Properties.Settings.Default.TimerMessage =
                txtTimerMessage.Text;
        }

        private void numTimerHours_ValueChanged(object sender, EventArgs e) {
            Properties.Settings.Default.TimerHour =
                (int)numTimerHours.Value;
        }

        private void numTimerMinutes_ValueChanged(object sender, EventArgs e) {
            Properties.Settings.Default.TimerMinute =
                (int)numTimerMinutes.Value;
        }

        private void numTimerSeconds_ValueChanged(object sender, EventArgs e) {
            Properties.Settings.Default.TimerSecond =
                (int)numTimerSeconds.Value;
        }

        private void trayIcon_DoubleClick(object sender, EventArgs e) {
            // if the form is visible, hide it
            // if not, show it
            ChangeWindowState(this.Visible);
        }
        #endregion

        #region File Menu
        private void fileExit_Click(object sender, EventArgs e) {
            Application.Exit();
        }
        #endregion

        #region Options Menu
        private void optionsTrayIcon_CheckedChanged(object sender, EventArgs e) {
            trayIcon.Visible = optionsTrayIcon.Checked;
            Properties.Settings.Default.OptionAlwaysShowTrayIcon =
                optionsTrayIcon.Checked;
        }

        private void optionsDisablePopup_CheckedChanged(object sender, EventArgs e) {
            Properties.Settings.Default.OptionDisableAlertPopup =
                optionsDisablePopup.Checked;
        }

        private void optionsDisableSound_CheckedChanged(object sender, EventArgs e) {
            Properties.Settings.Default.OptionDisableSoundAlert =
                optionsDisableSound.Checked;
        }

        private void options24HourTime_CheckedChanged(object sender, EventArgs e) {
            ChangeTimeFormat(options24HourTime.Checked);
            UpdateStatusbarTime(options24HourTime.Checked);

            Properties.Settings.Default.Option24HourClock =
                options24HourTime.Checked;
        }

        private void optionsDayMonthYearFormat_CheckedChanged(object sender, EventArgs e) {
            UpdateStatusbarDate(optionsDayMonthYearFormat.Checked);
            Properties.Settings.Default.OptionDayMonthYearFormat =
                optionsDayMonthYearFormat.Checked;
        }

        private void optionsHideDate_CheckedChanged(object sender, EventArgs e) {
            DisplayDateInStatusBar = !optionsHideDate.Checked;
            Properties.Settings.Default.OptionHideDate =
                optionsHideDate.Checked;
        }

        private void optionsHideTime_CheckedChanged(object sender, EventArgs e) {
            DisplayTimeInStatusBar = !optionsHideTime.Checked;
            Properties.Settings.Default.OptionHideTime =
                optionsHideTime.Checked;
        }
        #endregion

        #region Help Menu
        private void helpGithub_Click(object sender, EventArgs e) {
            if(!string.IsNullOrEmpty(Globals.GithubLink))
                Process.Start(Globals.GithubLink);
        }

        private void helpChangelog_Click(object sender, EventArgs e) {
            try {
                if(!string.IsNullOrEmpty(Globals.ChangelogPath))
                    Process.Start(Globals.ChangelogPath);
            }
            catch(Exception ex) {
                errorForm.ShowDialog(ex);
            }
        }

        private void helpTopics_Click(object sender, EventArgs e) {
            try {
                if(!string.IsNullOrEmpty(Globals.HelpFilePath))
                    Process.Start(Globals.HelpFilePath);
            }
            catch(Exception ex) {
                errorForm.ShowDialog(ex);
            }
        }

        private void helpAbout_Click(object sender, EventArgs e) {
            using(frmAbout frmAbout = new frmAbout()) {
                frmAbout.ShowDialog();
            }            
        }
        #endregion

        #region Functions
        /// <summary>
        /// Sets the alarm to a specified time.
        /// </summary>
        /// <param name="time">The time to set it to</param>
        private void SetAlarm(DateTime time) {
            AlarmDateTime = time.Date
                .AddHours(cmbAlarmHour.SelectedIndex)
                .AddMinutes(cmbAlarmMinute.SelectedIndex)
                .AddSeconds(cmbAlarmSecond.SelectedIndex);

            if(DateTime.Now.Date == AlarmDateTime.Date &&
               DateTime.Now.TimeOfDay > AlarmDateTime.TimeOfDay) {
                AlarmDateTime = AlarmDateTime.AddDays(1);
            }
        }

        /// <summary>
        /// Set the timer to a specified time.
        /// </summary>
        /// <param name="time">The time to set it to</param>
        private void SetTimer(DateTime time) {
            TimerDateTime = time
                .AddHours((double)numTimerHours.Value)
                .AddMinutes((double)numTimerMinutes.Value)
                .AddSeconds((double)numTimerSeconds.Value);
        }

        /// <summary>
        /// Stop the alarm.
        /// </summary>
        /// <param name="playSound">Whether to play a sound</param>
        /// <param name="showPopup">Whether to show a popup message</param>
        private void StopAlarm(bool playSound, bool showPopup) {
            AlarmRunning = false;

            if(playSound) {
                System.Media.SystemSounds.Asterisk.Play();
            }

            if(showPopup) {
                if(string.IsNullOrEmpty(txtAlarmMessage.Text)) {
                    ShowMessage(strings.DefaultAlarmMessage, strings.Alarm);
                }
                else {
                    ShowMessage(txtAlarmMessage.Text, strings.Alarm);
                }
            }
            else {
                ChangeWindowState(false);
            }

            DateTime date = DateTime.Now.AddDays(1);

            while(date.DayOfWeek != DateTime.Now.DayOfWeek) {
                if(repeatDays[date.DayOfWeek.ToString()]) {
                    SetAlarm(date);
                    AlarmRunning = true;
                    break;
                }

                date = date.AddDays(1);
            }
        }
        
        /// <summary>
        /// Stop the timer.
        /// </summary>
        /// <param name="playSound">Whether to play a sound</param>
        /// <param name="showPopup">Whether to show a popup message</param>
        /// <param name="doRepeat">Whether to repeat afterwards</param>
        private void StopTimer(bool playSound, bool showPopup, bool doRepeat) {
            TimerRunning = false;

            if(playSound) {
                System.Media.SystemSounds.Asterisk.Play();
            }

            if(showPopup) {
                if(string.IsNullOrEmpty(txtTimerMessage.Text)) {
                    ShowMessage(strings.DefaultTimerMessage, strings.Timer);
                }
                else {
                    ShowMessage(txtTimerMessage.Text, strings.Timer);
                }
            }
            else {
                ChangeWindowState(false);
            }

            if(doRepeat) {
                SetTimer(DateTime.Now);
                TimerRunning = true;
            }
        }

        /// <summary>
        /// Stop the stopwatch.
        /// </summary>
        private void StopStopwatch() {
            StopwatchRunning = false;
            btnStopwatchStart.Text = strings.Start;
            LastSpan = CurrentSpan;
            CurrentSpan = TimeSpan.Zero;
        }

        /// <summary>
        /// Show a message when the alarm or timer goes off.
        /// </summary>
        /// <param name="message">The message to show</param>
        /// <param name="caption">The caption of the message window</param>
        private void ShowMessage(string message, string caption) {
            if(!this.Visible) {
                ChangeWindowState(false);
            }

            this.TopMost = true;

            if(MessageBox.Show(message, caption) == DialogResult.OK) {
                this.TopMost = false;
            }
        }

        /// <summary>
        /// Update the statusbar date.
        /// </summary>
        /// <param name="isDmyFormat">Whether to be in day/month/year format</param>
        private void UpdateStatusbarDate(bool isDmyFormat) {
            if(isDmyFormat) {
                statusDate.Text = DateTime.Now.ToString("dd\\/MM\\/yyyy");
            }
            else {
                statusDate.Text = DateTime.Now.ToString("MM\\/dd\\/yyyy");
            }
        }

        /// <summary>
        /// Update the statusbar time.
        /// </summary>
        /// <param name="is24HourFormat">Whether to be in 24-hour format</param>
        private void UpdateStatusbarTime(bool is24HourFormat) {
            if(is24HourFormat) {
                statusTime.Text = DateTime.Now.ToString("HH:mm:ss");
            }
            else {
                statusTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
            }
        }

        /// <summary>
        /// Change the time format between 24- and 12-hour formats.
        /// </summary>
        /// <param name="is24HourFormat">Whether to be in 24-hour format</param>
        private void ChangeTimeFormat(bool is24HourFormat) {
            int currentIndex = cmbAlarmHour.SelectedIndex;
            cmbAlarmHour.Items.Clear();

            if(options24HourTime.Checked)
                cmbAlarmHour.Items.AddRange(timeFormat24Hour);
            else
                cmbAlarmHour.Items.AddRange(timeFormat12Hour);

            cmbAlarmHour.SelectedIndex = currentIndex;
            UpdateStatusbarTime(is24HourFormat);
        }

        /// <summary>
        /// Change the window state between shown and hidden.
        /// </summary>
        /// <param name="shouldWindowHide">Whether the window should hide or be shown</param>
        private void ChangeWindowState(bool shouldWindowHide) {
            if(shouldWindowHide) {
                this.Hide();
                trayIcon.Visible = true;
            }
            else {
                this.Show();
                this.WindowState = FormWindowState.Normal;

                if(!optionsTrayIcon.Checked) {
                    trayIcon.Visible = false;
                }
            }
        }

        /// <summary>
        /// Compare a DateTime to DateTime.Now.
        /// </summary>
        /// <param name="time">The DateTime to compare</param>
        /// <returns></returns>
        private bool CompareDateTime(DateTime time) {
            return time.Date == DateTime.Now.Date &&
                   time.Hour == DateTime.Now.Hour &&
                   time.Minute == DateTime.Now.Minute &&
                   time.Second == DateTime.Now.Second;
        }

        /// <summary>
        /// Initialize the property settings.
        /// </summary>
        private void InitializeSettings() {
            cmbAlarmHour.SelectedIndex = Properties.Settings.Default.AlarmHour;
            cmbAlarmMinute.SelectedIndex = Properties.Settings.Default.AlarmMinute;
            cmbAlarmSecond.SelectedIndex = Properties.Settings.Default.AlarmSecond;
            numTimerHours.Value = Properties.Settings.Default.TimerHour;
            numTimerMinutes.Value = Properties.Settings.Default.TimerMinute;
            numTimerSeconds.Value = Properties.Settings.Default.TimerSecond;

            repeatDays.Add(dayNames[0], chkAlarmSunday.Checked);
            repeatDays.Add(dayNames[1], chkAlarmMonday.Checked);
            repeatDays.Add(dayNames[2], chkAlarmTuesday.Checked);
            repeatDays.Add(dayNames[3], chkAlarmWednesday.Checked);
            repeatDays.Add(dayNames[4], chkAlarmThursday.Checked);
            repeatDays.Add(dayNames[5], chkAlarmFriday.Checked);
            repeatDays.Add(dayNames[6], chkAlarmSaturday.Checked);
        }
        #endregion
    }
}
