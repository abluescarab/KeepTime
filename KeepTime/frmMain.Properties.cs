using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeepTime {
    public partial class frmMain {
        public DateTime AlarmDateTime { get; set; }
        public DateTime TimerDateTime { get; set; }
        public DateTime StopwatchDateTime { get; set; }
        public TimeSpan LastSpan { get; set; }
        public TimeSpan CurrentSpan { get; set; }

        public bool DisplayDateInStatusBar {
            get { return statusDate.Visible; }
            set {
                statusDate.Visible = value;
                statusSep1.Visible = value;
            }
        }

        public bool DisplayTimeInStatusBar {
            get { return statusTime.Visible; }
            set { statusTime.Visible = value; }
        }
        
        public bool AlarmRunning {
            get { return alarmRunning; }
            set {
                alarmRunning = 
                    timerAlarm.Enabled = value;
                txtAlarmMessage.Enabled = 
                    cmbAlarmHour.Enabled = 
                    cmbAlarmMinute.Enabled = 
                    cmbAlarmSecond.Enabled = !value;

                if(value) {
                    btnAlarmStart.Text = strings.Stop;
                    btnAlarmStart.Image = Properties.Resources.control_stop_blue;
                }
                else {
                    btnAlarmStart.Text = strings.Start;
                    btnAlarmStart.Image = Properties.Resources.control_play_blue;
                }
            }
        }

        public bool TimerRunning {
            get { return timerRunning; }
            set {
                timerRunning = 
                    timerTimer.Enabled = value;
                txtTimerMessage.Enabled =
                    numTimerHours.Enabled =
                    numTimerMinutes.Enabled =
                    numTimerSeconds.Enabled = !value;

                if(value) {
                    btnTimerStart.Text = strings.Stop;
                    btnTimerStart.Image = Properties.Resources.control_stop_blue;
                }
                else {
                    btnTimerStart.Text = strings.Start;
                    btnTimerStart.Image = Properties.Resources.control_play_blue;
                }
            }
        }

        public bool StopwatchRunning {
            get { return stopwatchRunning; }
            set {
                stopwatchRunning = value;
                timerStopwatch.Enabled = value;
                btnStopwatchReset.Enabled = !value;

                if(value) {
                    btnStopwatchStart.Text = strings.Stop;
                    btnStopwatchStart.Image = Properties.Resources.control_stop_blue;
                    btnStopwatchReset.Enabled = false;
                }
                else {
                    btnStopwatchStart.Text = strings.Start;
                    btnStopwatchStart.Image = Properties.Resources.control_play_blue;
                    btnStopwatchReset.Enabled = true;
                }
            }
        }
    }
}
