namespace KeepTime {
    partial class frmMain {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.fileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsTrayIcon = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsDisablePopup = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsDisableSound = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsSep1 = new System.Windows.Forms.ToolStripSeparator();
            this.options24HourTime = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsDayMonthYearFormat = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsSep2 = new System.Windows.Forms.ToolStripSeparator();
            this.optionsHideDate = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsHideTime = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.helpGithub = new System.Windows.Forms.ToolStripMenuItem();
            this.helpSep1 = new System.Windows.Forms.ToolStripSeparator();
            this.helpChangelog = new System.Windows.Forms.ToolStripMenuItem();
            this.helpSep2 = new System.Windows.Forms.ToolStripSeparator();
            this.helpTopics = new System.Windows.Forms.ToolStripMenuItem();
            this.helpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabAlarm = new System.Windows.Forms.TabPage();
            this.btnAlarmStart = new System.Windows.Forms.Button();
            this.gbAlarmRepeat = new System.Windows.Forms.GroupBox();
            this.chkAlarmMonday = new System.Windows.Forms.CheckBox();
            this.chkAlarmWednesday = new System.Windows.Forms.CheckBox();
            this.chkAlarmSaturday = new System.Windows.Forms.CheckBox();
            this.chkAlarmTuesday = new System.Windows.Forms.CheckBox();
            this.chkAlarmFriday = new System.Windows.Forms.CheckBox();
            this.chkAlarmSunday = new System.Windows.Forms.CheckBox();
            this.chkAlarmThursday = new System.Windows.Forms.CheckBox();
            this.txtAlarmMessage = new System.Windows.Forms.TextBox();
            this.lblAlarmMessage = new System.Windows.Forms.Label();
            this.cmbAlarmMinute = new System.Windows.Forms.ComboBox();
            this.cmbAlarmSecond = new System.Windows.Forms.ComboBox();
            this.lblAlarmMinute = new System.Windows.Forms.Label();
            this.lblAlarmSecond = new System.Windows.Forms.Label();
            this.cmbAlarmHour = new System.Windows.Forms.ComboBox();
            this.lblAlarmHour = new System.Windows.Forms.Label();
            this.tabTimer = new System.Windows.Forms.TabPage();
            this.chkTimerRepeat = new System.Windows.Forms.CheckBox();
            this.btnTimerStart = new System.Windows.Forms.Button();
            this.lblTimerMessage = new System.Windows.Forms.Label();
            this.lblTimerSecond = new System.Windows.Forms.Label();
            this.lblTimerMinute = new System.Windows.Forms.Label();
            this.lblTimerHour = new System.Windows.Forms.Label();
            this.numTimerMinutes = new System.Windows.Forms.NumericUpDown();
            this.numTimerSeconds = new System.Windows.Forms.NumericUpDown();
            this.numTimerHours = new System.Windows.Forms.NumericUpDown();
            this.txtTimerMessage = new System.Windows.Forms.TextBox();
            this.tabStopwatch = new System.Windows.Forms.TabPage();
            this.btnStopwatchReset = new System.Windows.Forms.Button();
            this.btnStopwatchStart = new System.Windows.Forms.Button();
            this.lblStopwatch = new System.Windows.Forms.Label();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusSep1 = new System.Windows.Forms.ToolStripSeparator();
            this.statusTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.trayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.trayIconMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timerTime = new System.Windows.Forms.Timer(this.components);
            this.timerDate = new System.Windows.Forms.Timer(this.components);
            this.timerAlarm = new System.Windows.Forms.Timer(this.components);
            this.timerTimer = new System.Windows.Forms.Timer(this.components);
            this.timerStopwatch = new System.Windows.Forms.Timer(this.components);
            this.mainMenu.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabAlarm.SuspendLayout();
            this.gbAlarmRepeat.SuspendLayout();
            this.tabTimer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTimerMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTimerSeconds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTimerHours)).BeginInit();
            this.tabStopwatch.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.trayIconMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuOptions,
            this.menuHelp,
            this.toolStripMenuItem1});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(272, 24);
            this.mainMenu.TabIndex = 0;
            this.mainMenu.Text = "menuStrip1";
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileExit});
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(37, 20);
            this.menuFile.Text = strings.File;
            // 
            // fileExit
            // 
            this.fileExit.Image = Properties.Resources.cross;
            this.fileExit.Name = "fileExit";
            this.fileExit.Size = new System.Drawing.Size(92, 22);
            this.fileExit.Text = strings.Exit;
            this.fileExit.Click += new System.EventHandler(this.fileExit_Click);
            // 
            // menuOptions
            // 
            this.menuOptions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsTrayIcon,
            this.optionsDisablePopup,
            this.optionsDisableSound,
            this.optionsSep1,
            this.options24HourTime,
            this.optionsDayMonthYearFormat,
            this.optionsSep2,
            this.optionsHideDate,
            this.optionsHideTime});
            this.menuOptions.Name = "menuOptions";
            this.menuOptions.Size = new System.Drawing.Size(61, 20);
            this.menuOptions.Text = strings.Options;
            // 
            // optionsTrayIcon
            // 
            this.optionsTrayIcon.Checked = Properties.Settings.Default.OptionAlwaysShowTrayIcon;
            this.optionsTrayIcon.CheckOnClick = true;
            this.optionsTrayIcon.Name = "optionsTrayIcon";
            this.optionsTrayIcon.Size = new System.Drawing.Size(201, 22);
            this.optionsTrayIcon.Text = strings.AlwaysShowTrayIcon;
            this.optionsTrayIcon.CheckedChanged += new System.EventHandler(this.optionsTrayIcon_CheckedChanged);
            // 
            // optionsDisablePopup
            // 
            this.optionsDisablePopup.Checked = Properties.Settings.Default.OptionDisableAlertPopup;
            this.optionsDisablePopup.CheckOnClick = true;
            this.optionsDisablePopup.Name = "optionsDisablePopup";
            this.optionsDisablePopup.Size = new System.Drawing.Size(201, 22);
            this.optionsDisablePopup.Text = strings.DisableAlertPopup;
            this.optionsDisablePopup.CheckedChanged += new System.EventHandler(this.optionsDisablePopup_CheckedChanged);
            // 
            // optionsDisableSound
            // 
            this.optionsDisableSound.Checked = Properties.Settings.Default.OptionDisableSoundAlert;
            this.optionsDisableSound.CheckOnClick = true;
            this.optionsDisableSound.Name = "optionsDisableSound";
            this.optionsDisableSound.Size = new System.Drawing.Size(201, 22);
            this.optionsDisableSound.Text = strings.DisableSoundAlert;
            this.optionsDisableSound.CheckedChanged += new System.EventHandler(this.optionsDisableSound_CheckedChanged);
            // 
            // optionsSep1
            // 
            this.optionsSep1.Name = "optionsSep1";
            this.optionsSep1.Size = new System.Drawing.Size(198, 6);
            // 
            // options24HourTime
            // 
            this.options24HourTime.Checked = Properties.Settings.Default.Option24HourClock;
            this.options24HourTime.CheckOnClick = true;
            this.options24HourTime.Name = "options24HourTime";
            this.options24HourTime.Size = new System.Drawing.Size(201, 22);
            this.options24HourTime.Text = strings.TwentyFourHourClock;
            this.options24HourTime.CheckedChanged += new System.EventHandler(this.options24HourTime_CheckedChanged);
            // 
            // optionsDayMonthYearFormat
            // 
            this.optionsDayMonthYearFormat.Checked = Properties.Settings.Default.OptionDayMonthYearFormat;
            this.optionsDayMonthYearFormat.CheckOnClick = true;
            this.optionsDayMonthYearFormat.Name = "optionsDayMonthYearFormat";
            this.optionsDayMonthYearFormat.Size = new System.Drawing.Size(201, 22);
            this.optionsDayMonthYearFormat.Text = strings.DayMonthYearFormat;
            this.optionsDayMonthYearFormat.CheckedChanged += new System.EventHandler(this.optionsDayMonthYearFormat_CheckedChanged);
            // 
            // optionsSep2
            // 
            this.optionsSep2.Name = "optionsSep2";
            this.optionsSep2.Size = new System.Drawing.Size(198, 6);
            // 
            // optionsHideDate
            // 
            this.optionsHideDate.Checked = Properties.Settings.Default.OptionHideDate;
            this.optionsHideDate.CheckOnClick = true;
            this.optionsHideDate.Name = "optionsHideDate";
            this.optionsHideDate.Size = new System.Drawing.Size(201, 22);
            this.optionsHideDate.Text = strings.HideDate;
            this.optionsHideDate.CheckedChanged += new System.EventHandler(this.optionsHideDate_CheckedChanged);
            // 
            // optionsHideTime
            // 
            this.optionsHideTime.Checked = Properties.Settings.Default.OptionHideTime;
            this.optionsHideTime.CheckOnClick = true;
            this.optionsHideTime.Name = "optionsHideTime";
            this.optionsHideTime.Size = new System.Drawing.Size(201, 22);
            this.optionsHideTime.Text = strings.HideTime;
            this.optionsHideTime.CheckedChanged += new System.EventHandler(this.optionsHideTime_CheckedChanged);
            // 
            // menuHelp
            // 
            this.menuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpGithub,
            this.helpSep1,
            this.helpChangelog,
            this.helpSep2,
            this.helpTopics,
            this.helpAbout});
            this.menuHelp.Name = "menuHelp";
            this.menuHelp.Size = new System.Drawing.Size(44, 20);
            this.menuHelp.Text = strings.Help;
            // 
            // helpGithub
            // 
            this.helpGithub.Image = Properties.Resources.github_16x16;
            this.helpGithub.Name = "helpGithub";
            this.helpGithub.Size = new System.Drawing.Size(197, 22);
            this.helpGithub.Text = strings.VisitGithub;
            this.helpGithub.Click += new System.EventHandler(this.helpGithub_Click);
            // 
            // helpSep1
            // 
            this.helpSep1.Name = "helpSep1";
            this.helpSep1.Size = new System.Drawing.Size(194, 6);
            // 
            // helpChangelog
            // 
            this.helpChangelog.Image = Properties.Resources.page_white_text;
            this.helpChangelog.Name = "helpChangelog";
            this.helpChangelog.Size = new System.Drawing.Size(197, 22);
            this.helpChangelog.Text = strings.Changelog;
            this.helpChangelog.Click += new System.EventHandler(this.helpChangelog_Click);
            // 
            // helpSep2
            // 
            this.helpSep2.Name = "helpSep2";
            this.helpSep2.Size = new System.Drawing.Size(194, 6);
            // 
            // helpTopics
            // 
            this.helpTopics.Image = Properties.Resources.help;
            this.helpTopics.Name = "helpTopics";
            this.helpTopics.Size = new System.Drawing.Size(197, 22);
            this.helpTopics.Text = strings.HelpTopics;
            this.helpTopics.Click += new System.EventHandler(this.helpTopics_Click);
            // 
            // helpAbout
            // 
            this.helpAbout.Image = Properties.Resources.information;
            this.helpAbout.Name = "helpAbout";
            this.helpAbout.Size = new System.Drawing.Size(197, 22);
            this.helpAbout.Text = strings.About;
            this.helpAbout.Click += new System.EventHandler(this.helpAbout_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 20);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabAlarm);
            this.tabControl.Controls.Add(this.tabTimer);
            this.tabControl.Controls.Add(this.tabStopwatch);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 24);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(272, 265);
            this.tabControl.TabIndex = 0;
            // 
            // tabAlarm
            // 
            this.tabAlarm.Controls.Add(this.btnAlarmStart);
            this.tabAlarm.Controls.Add(this.gbAlarmRepeat);
            this.tabAlarm.Controls.Add(this.txtAlarmMessage);
            this.tabAlarm.Controls.Add(this.lblAlarmMessage);
            this.tabAlarm.Controls.Add(this.cmbAlarmMinute);
            this.tabAlarm.Controls.Add(this.cmbAlarmSecond);
            this.tabAlarm.Controls.Add(this.lblAlarmMinute);
            this.tabAlarm.Controls.Add(this.lblAlarmSecond);
            this.tabAlarm.Controls.Add(this.cmbAlarmHour);
            this.tabAlarm.Controls.Add(this.lblAlarmHour);
            this.tabAlarm.Location = new System.Drawing.Point(4, 22);
            this.tabAlarm.Name = "tabAlarm";
            this.tabAlarm.Size = new System.Drawing.Size(264, 239);
            this.tabAlarm.TabIndex = 0;
            this.tabAlarm.Text = strings.Alarm;
            this.tabAlarm.UseVisualStyleBackColor = true;
            // 
            // btnAlarmStart
            // 
            this.btnAlarmStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAlarmStart.Image = Properties.Resources.control_play_blue;
            this.btnAlarmStart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlarmStart.Location = new System.Drawing.Point(155, 209);
            this.btnAlarmStart.Name = "btnAlarmStart";
            this.btnAlarmStart.Size = new System.Drawing.Size(100, 23);
            this.btnAlarmStart.TabIndex = 5;
            this.btnAlarmStart.Text = strings.Start;
            this.btnAlarmStart.UseVisualStyleBackColor = true;
            this.btnAlarmStart.Click += new System.EventHandler(this.btnAlarmStart_Click);
            // 
            // gbAlarmRepeat
            // 
            this.gbAlarmRepeat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbAlarmRepeat.Controls.Add(this.chkAlarmMonday);
            this.gbAlarmRepeat.Controls.Add(this.chkAlarmWednesday);
            this.gbAlarmRepeat.Controls.Add(this.chkAlarmSaturday);
            this.gbAlarmRepeat.Controls.Add(this.chkAlarmTuesday);
            this.gbAlarmRepeat.Controls.Add(this.chkAlarmFriday);
            this.gbAlarmRepeat.Controls.Add(this.chkAlarmSunday);
            this.gbAlarmRepeat.Controls.Add(this.chkAlarmThursday);
            this.gbAlarmRepeat.Location = new System.Drawing.Point(8, 89);
            this.gbAlarmRepeat.Name = "gbAlarmRepeat";
            this.gbAlarmRepeat.Size = new System.Drawing.Size(247, 114);
            this.gbAlarmRepeat.TabIndex = 4;
            this.gbAlarmRepeat.TabStop = false;
            this.gbAlarmRepeat.Text = "Repeat";
            // 
            // chkAlarmMonday
            // 
            this.chkAlarmMonday.AutoSize = true;
            this.chkAlarmMonday.Checked = Properties.Settings.Default.RepeatMonday;
            this.chkAlarmMonday.DataBindings.Add(new System.Windows.Forms.Binding("Checked", Properties.Settings.Default, "RepeatMonday", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkAlarmMonday.Location = new System.Drawing.Point(6, 42);
            this.chkAlarmMonday.Name = "chkAlarmMonday";
            this.chkAlarmMonday.Size = new System.Drawing.Size(64, 17);
            this.chkAlarmMonday.TabIndex = 1;
            this.chkAlarmMonday.Text = strings.Monday;
            this.chkAlarmMonday.UseVisualStyleBackColor = true;
            this.chkAlarmMonday.CheckedChanged += new System.EventHandler(this.chkAlarmMonday_CheckedChanged);
            // 
            // chkAlarmWednesday
            // 
            this.chkAlarmWednesday.AutoSize = true;
            this.chkAlarmWednesday.Checked = Properties.Settings.Default.RepeatWednesday;
            this.chkAlarmWednesday.DataBindings.Add(new System.Windows.Forms.Binding("Checked", Properties.Settings.Default, "RepeatWednesday", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkAlarmWednesday.Location = new System.Drawing.Point(6, 88);
            this.chkAlarmWednesday.Name = "chkAlarmWednesday";
            this.chkAlarmWednesday.Size = new System.Drawing.Size(83, 17);
            this.chkAlarmWednesday.TabIndex = 3;
            this.chkAlarmWednesday.Text = strings.Wednesday;
            this.chkAlarmWednesday.UseVisualStyleBackColor = true;
            this.chkAlarmWednesday.CheckedChanged += new System.EventHandler(this.chkAlarmWednesday_CheckedChanged);
            // 
            // chkAlarmSaturday
            // 
            this.chkAlarmSaturday.AutoSize = true;
            this.chkAlarmSaturday.Checked = Properties.Settings.Default.RepeatSaturday;
            this.chkAlarmSaturday.DataBindings.Add(new System.Windows.Forms.Binding("Checked", Properties.Settings.Default, "RepeatSaturday", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkAlarmSaturday.Location = new System.Drawing.Point(95, 65);
            this.chkAlarmSaturday.Name = "chkAlarmSaturday";
            this.chkAlarmSaturday.Size = new System.Drawing.Size(68, 17);
            this.chkAlarmSaturday.TabIndex = 6;
            this.chkAlarmSaturday.Text = strings.Saturday;
            this.chkAlarmSaturday.UseVisualStyleBackColor = true;
            this.chkAlarmSaturday.CheckedChanged += new System.EventHandler(this.chkAlarmSaturday_CheckedChanged);
            // 
            // chkAlarmTuesday
            // 
            this.chkAlarmTuesday.AutoSize = true;
            this.chkAlarmTuesday.Checked = Properties.Settings.Default.RepeatTuesday;
            this.chkAlarmTuesday.DataBindings.Add(new System.Windows.Forms.Binding("Checked", Properties.Settings.Default, "RepeatTuesday", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkAlarmTuesday.Location = new System.Drawing.Point(6, 65);
            this.chkAlarmTuesday.Name = "chkAlarmTuesday";
            this.chkAlarmTuesday.Size = new System.Drawing.Size(67, 17);
            this.chkAlarmTuesday.TabIndex = 2;
            this.chkAlarmTuesday.Text = strings.Tuesday;
            this.chkAlarmTuesday.UseVisualStyleBackColor = true;
            this.chkAlarmTuesday.CheckedChanged += new System.EventHandler(this.chkAlarmTuesday_CheckedChanged);
            // 
            // chkAlarmFriday
            // 
            this.chkAlarmFriday.AutoSize = true;
            this.chkAlarmFriday.Checked = Properties.Settings.Default.RepeatFriday;
            this.chkAlarmFriday.DataBindings.Add(new System.Windows.Forms.Binding("Checked", Properties.Settings.Default, "RepeatFriday", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkAlarmFriday.Location = new System.Drawing.Point(95, 42);
            this.chkAlarmFriday.Name = "chkAlarmFriday";
            this.chkAlarmFriday.Size = new System.Drawing.Size(54, 17);
            this.chkAlarmFriday.TabIndex = 5;
            this.chkAlarmFriday.Text = strings.Friday;
            this.chkAlarmFriday.UseVisualStyleBackColor = true;
            this.chkAlarmFriday.CheckedChanged += new System.EventHandler(this.chkAlarmFriday_CheckedChanged);
            // 
            // chkAlarmSunday
            // 
            this.chkAlarmSunday.AutoSize = true;
            this.chkAlarmSunday.Checked = Properties.Settings.Default.RepeatSunday;
            this.chkAlarmSunday.DataBindings.Add(new System.Windows.Forms.Binding("Checked", Properties.Settings.Default, "RepeatSunday", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkAlarmSunday.Location = new System.Drawing.Point(6, 19);
            this.chkAlarmSunday.Name = "chkAlarmSunday";
            this.chkAlarmSunday.Size = new System.Drawing.Size(62, 17);
            this.chkAlarmSunday.TabIndex = 0;
            this.chkAlarmSunday.Text = strings.Sunday;
            this.chkAlarmSunday.UseVisualStyleBackColor = true;
            this.chkAlarmSunday.CheckedChanged += new System.EventHandler(this.chkAlarmSunday_CheckedChanged);
            // 
            // chkAlarmThursday
            // 
            this.chkAlarmThursday.AutoSize = true;
            this.chkAlarmThursday.Checked = Properties.Settings.Default.RepeatThursday;
            this.chkAlarmThursday.DataBindings.Add(new System.Windows.Forms.Binding("Checked", Properties.Settings.Default, "RepeatThursday", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkAlarmThursday.Location = new System.Drawing.Point(93, 19);
            this.chkAlarmThursday.Name = "chkAlarmThursday";
            this.chkAlarmThursday.Size = new System.Drawing.Size(70, 17);
            this.chkAlarmThursday.TabIndex = 4;
            this.chkAlarmThursday.Text = strings.Thursday;
            this.chkAlarmThursday.UseVisualStyleBackColor = true;
            this.chkAlarmThursday.CheckedChanged += new System.EventHandler(this.chkAlarmThursday_CheckedChanged);
            // 
            // txtAlarmMessage
            // 
            this.txtAlarmMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAlarmMessage.DataBindings.Add(new System.Windows.Forms.Binding("Text", Properties.Settings.Default, "AlarmMessage", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtAlarmMessage.Location = new System.Drawing.Point(132, 24);
            this.txtAlarmMessage.Multiline = true;
            this.txtAlarmMessage.Name = "txtAlarmMessage";
            this.txtAlarmMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAlarmMessage.Size = new System.Drawing.Size(124, 59);
            this.txtAlarmMessage.TabIndex = 3;
            this.txtAlarmMessage.Text = Properties.Settings.Default.AlarmMessage;
            this.txtAlarmMessage.Leave += new System.EventHandler(this.txtAlarmMessage_Leave);
            // 
            // lblAlarmMessage
            // 
            this.lblAlarmMessage.AutoSize = true;
            this.lblAlarmMessage.Location = new System.Drawing.Point(132, 8);
            this.lblAlarmMessage.Name = "lblAlarmMessage";
            this.lblAlarmMessage.Size = new System.Drawing.Size(53, 13);
            this.lblAlarmMessage.TabIndex = 6;
            this.lblAlarmMessage.Text = "Message:";
            // 
            // cmbAlarmMinute
            // 
            this.cmbAlarmMinute.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAlarmMinute.FormattingEnabled = true;
            this.cmbAlarmMinute.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.cmbAlarmMinute.Location = new System.Drawing.Point(67, 35);
            this.cmbAlarmMinute.Name = "cmbAlarmMinute";
            this.cmbAlarmMinute.Size = new System.Drawing.Size(59, 21);
            this.cmbAlarmMinute.TabIndex = 1;
            this.cmbAlarmMinute.SelectedIndexChanged += new System.EventHandler(this.cmbAlarmMinute_SelectedIndexChanged);
            // 
            // cmbAlarmSecond
            // 
            this.cmbAlarmSecond.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAlarmSecond.FormattingEnabled = true;
            this.cmbAlarmSecond.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.cmbAlarmSecond.Location = new System.Drawing.Point(67, 62);
            this.cmbAlarmSecond.Name = "cmbAlarmSecond";
            this.cmbAlarmSecond.Size = new System.Drawing.Size(59, 21);
            this.cmbAlarmSecond.TabIndex = 2;
            this.cmbAlarmSecond.SelectedIndexChanged += new System.EventHandler(this.cmbAlarmSecond_SelectedIndexChanged);
            // 
            // lblAlarmMinute
            // 
            this.lblAlarmMinute.AutoSize = true;
            this.lblAlarmMinute.Location = new System.Drawing.Point(8, 38);
            this.lblAlarmMinute.Name = "lblAlarmMinute";
            this.lblAlarmMinute.Size = new System.Drawing.Size(42, 13);
            this.lblAlarmMinute.TabIndex = 3;
            this.lblAlarmMinute.Text = "Minute:";
            // 
            // lblAlarmSecond
            // 
            this.lblAlarmSecond.AutoSize = true;
            this.lblAlarmSecond.Location = new System.Drawing.Point(8, 65);
            this.lblAlarmSecond.Name = "lblAlarmSecond";
            this.lblAlarmSecond.Size = new System.Drawing.Size(47, 13);
            this.lblAlarmSecond.TabIndex = 2;
            this.lblAlarmSecond.Text = "Second:";
            // 
            // cmbAlarmHour
            // 
            this.cmbAlarmHour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAlarmHour.FormattingEnabled = true;
            this.cmbAlarmHour.Location = new System.Drawing.Point(67, 8);
            this.cmbAlarmHour.Name = "cmbAlarmHour";
            this.cmbAlarmHour.Size = new System.Drawing.Size(59, 21);
            this.cmbAlarmHour.TabIndex = 0;
            this.cmbAlarmHour.SelectedIndexChanged += new System.EventHandler(this.cmbAlarmHour_SelectedIndexChanged);
            // 
            // lblAlarmHour
            // 
            this.lblAlarmHour.AutoSize = true;
            this.lblAlarmHour.Location = new System.Drawing.Point(8, 11);
            this.lblAlarmHour.Name = "lblAlarmHour";
            this.lblAlarmHour.Size = new System.Drawing.Size(33, 13);
            this.lblAlarmHour.TabIndex = 0;
            this.lblAlarmHour.Text = "Hour:";
            // 
            // tabTimer
            // 
            this.tabTimer.Controls.Add(this.chkTimerRepeat);
            this.tabTimer.Controls.Add(this.btnTimerStart);
            this.tabTimer.Controls.Add(this.lblTimerMessage);
            this.tabTimer.Controls.Add(this.lblTimerSecond);
            this.tabTimer.Controls.Add(this.lblTimerMinute);
            this.tabTimer.Controls.Add(this.lblTimerHour);
            this.tabTimer.Controls.Add(this.numTimerMinutes);
            this.tabTimer.Controls.Add(this.numTimerSeconds);
            this.tabTimer.Controls.Add(this.numTimerHours);
            this.tabTimer.Controls.Add(this.txtTimerMessage);
            this.tabTimer.Location = new System.Drawing.Point(4, 22);
            this.tabTimer.Name = "tabTimer";
            this.tabTimer.Size = new System.Drawing.Size(264, 239);
            this.tabTimer.TabIndex = 1;
            this.tabTimer.Text = strings.Timer;
            this.tabTimer.UseVisualStyleBackColor = true;
            // 
            // chkTimerRepeat
            // 
            this.chkTimerRepeat.AutoSize = true;
            this.chkTimerRepeat.Checked = Properties.Settings.Default.RepeatTimer;
            this.chkTimerRepeat.DataBindings.Add(new System.Windows.Forms.Binding("Checked", Properties.Settings.Default, "RepeatTimer", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkTimerRepeat.Location = new System.Drawing.Point(8, 89);
            this.chkTimerRepeat.Name = "chkTimerRepeat";
            this.chkTimerRepeat.Size = new System.Drawing.Size(61, 17);
            this.chkTimerRepeat.TabIndex = 4;
            this.chkTimerRepeat.Text = strings.Repeat;
            this.chkTimerRepeat.UseVisualStyleBackColor = true;
            this.chkTimerRepeat.CheckedChanged += new System.EventHandler(this.chkTimerRepeat_CheckedChanged);
            // 
            // btnTimerStart
            // 
            this.btnTimerStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTimerStart.Image = Properties.Resources.control_play_blue;
            this.btnTimerStart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimerStart.Location = new System.Drawing.Point(155, 209);
            this.btnTimerStart.Name = "btnTimerStart";
            this.btnTimerStart.Size = new System.Drawing.Size(100, 23);
            this.btnTimerStart.TabIndex = 5;
            this.btnTimerStart.Text = strings.Start;
            this.btnTimerStart.UseVisualStyleBackColor = true;
            this.btnTimerStart.Click += new System.EventHandler(this.btnTimerStart_Click);
            // 
            // lblTimerMessage
            // 
            this.lblTimerMessage.AutoSize = true;
            this.lblTimerMessage.Location = new System.Drawing.Point(132, 8);
            this.lblTimerMessage.Name = "lblTimerMessage";
            this.lblTimerMessage.Size = new System.Drawing.Size(53, 13);
            this.lblTimerMessage.TabIndex = 10;
            this.lblTimerMessage.Text = "Message:";
            // 
            // lblTimerSecond
            // 
            this.lblTimerSecond.AutoSize = true;
            this.lblTimerSecond.Location = new System.Drawing.Point(65, 67);
            this.lblTimerSecond.Name = "lblTimerSecond";
            this.lblTimerSecond.Size = new System.Drawing.Size(49, 13);
            this.lblTimerSecond.TabIndex = 8;
            this.lblTimerSecond.Text = "Seconds";
            // 
            // lblTimerMinute
            // 
            this.lblTimerMinute.AutoSize = true;
            this.lblTimerMinute.Location = new System.Drawing.Point(65, 41);
            this.lblTimerMinute.Name = "lblTimerMinute";
            this.lblTimerMinute.Size = new System.Drawing.Size(44, 13);
            this.lblTimerMinute.TabIndex = 7;
            this.lblTimerMinute.Text = "Minutes";
            // 
            // lblTimerHour
            // 
            this.lblTimerHour.AutoSize = true;
            this.lblTimerHour.Location = new System.Drawing.Point(65, 15);
            this.lblTimerHour.Name = "lblTimerHour";
            this.lblTimerHour.Size = new System.Drawing.Size(35, 13);
            this.lblTimerHour.TabIndex = 6;
            this.lblTimerHour.Text = "Hours";
            // 
            // numTimerMinutes
            // 
            this.numTimerMinutes.Location = new System.Drawing.Point(8, 37);
            this.numTimerMinutes.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numTimerMinutes.Name = "numTimerMinutes";
            this.numTimerMinutes.Size = new System.Drawing.Size(51, 20);
            this.numTimerMinutes.TabIndex = 1;
            this.numTimerMinutes.ValueChanged += new System.EventHandler(this.numTimerMinutes_ValueChanged);
            // 
            // numTimerSeconds
            // 
            this.numTimerSeconds.Location = new System.Drawing.Point(8, 63);
            this.numTimerSeconds.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numTimerSeconds.Name = "numTimerSeconds";
            this.numTimerSeconds.Size = new System.Drawing.Size(51, 20);
            this.numTimerSeconds.TabIndex = 2;
            this.numTimerSeconds.ValueChanged += new System.EventHandler(this.numTimerSeconds_ValueChanged);
            // 
            // numTimerHours
            // 
            this.numTimerHours.Location = new System.Drawing.Point(8, 11);
            this.numTimerHours.Maximum = new decimal(new int[] {
            8760,
            0,
            0,
            0});
            this.numTimerHours.Name = "numTimerHours";
            this.numTimerHours.Size = new System.Drawing.Size(51, 20);
            this.numTimerHours.TabIndex = 0;
            this.numTimerHours.ValueChanged += new System.EventHandler(this.numTimerHours_ValueChanged);
            // 
            // txtTimerMessage
            // 
            this.txtTimerMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTimerMessage.DataBindings.Add(new System.Windows.Forms.Binding("Text", Properties.Settings.Default, "TimerMessage", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtTimerMessage.Location = new System.Drawing.Point(132, 24);
            this.txtTimerMessage.Multiline = true;
            this.txtTimerMessage.Name = "txtTimerMessage";
            this.txtTimerMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTimerMessage.Size = new System.Drawing.Size(124, 59);
            this.txtTimerMessage.TabIndex = 3;
            this.txtTimerMessage.Text = Properties.Settings.Default.TimerMessage;
            this.txtTimerMessage.Leave += new System.EventHandler(this.txtTimerMessage_Leave);
            // 
            // tabStopwatch
            // 
            this.tabStopwatch.Controls.Add(this.btnStopwatchReset);
            this.tabStopwatch.Controls.Add(this.btnStopwatchStart);
            this.tabStopwatch.Controls.Add(this.lblStopwatch);
            this.tabStopwatch.Location = new System.Drawing.Point(4, 22);
            this.tabStopwatch.Name = "tabStopwatch";
            this.tabStopwatch.Size = new System.Drawing.Size(264, 239);
            this.tabStopwatch.TabIndex = 2;
            this.tabStopwatch.Text = strings.Stopwatch;
            this.tabStopwatch.UseVisualStyleBackColor = true;
            // 
            // btnStopwatchReset
            // 
            this.btnStopwatchReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStopwatchReset.Image = Properties.Resources.arrow_refresh;
            this.btnStopwatchReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStopwatchReset.Location = new System.Drawing.Point(49, 209);
            this.btnStopwatchReset.Name = "btnStopwatchReset";
            this.btnStopwatchReset.Size = new System.Drawing.Size(100, 23);
            this.btnStopwatchReset.TabIndex = 0;
            this.btnStopwatchReset.Text = strings.Reset;
            this.btnStopwatchReset.UseVisualStyleBackColor = true;
            this.btnStopwatchReset.Click += new System.EventHandler(this.btnStopwatchReset_Click);
            // 
            // btnStopwatchStart
            // 
            this.btnStopwatchStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStopwatchStart.Image = Properties.Resources.control_play_blue;
            this.btnStopwatchStart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStopwatchStart.Location = new System.Drawing.Point(155, 209);
            this.btnStopwatchStart.Name = "btnStopwatchStart";
            this.btnStopwatchStart.Size = new System.Drawing.Size(100, 23);
            this.btnStopwatchStart.TabIndex = 1;
            this.btnStopwatchStart.Text = strings.Start;
            this.btnStopwatchStart.UseVisualStyleBackColor = true;
            this.btnStopwatchStart.Click += new System.EventHandler(this.btnStopwatchStart_Click);
            // 
            // lblStopwatch
            // 
            this.lblStopwatch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStopwatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStopwatch.Location = new System.Drawing.Point(8, 11);
            this.lblStopwatch.Name = "lblStopwatch";
            this.lblStopwatch.Size = new System.Drawing.Size(248, 33);
            this.lblStopwatch.TabIndex = 2;
            this.lblStopwatch.Text = "00:00:00";
            this.lblStopwatch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusDate,
            this.statusSep1,
            this.statusTime});
            this.statusStrip.Location = new System.Drawing.Point(0, 289);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(272, 23);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "statusStrip1";
            // 
            // statusDate
            // 
            this.statusDate.Name = "statusDate";
            this.statusDate.Size = new System.Drawing.Size(31, 18);
            this.statusDate.Text = strings.Date;
            // 
            // statusSep1
            // 
            this.statusSep1.Name = "statusSep1";
            this.statusSep1.Size = new System.Drawing.Size(6, 23);
            // 
            // statusTime
            // 
            this.statusTime.Name = "statusTime";
            this.statusTime.Size = new System.Drawing.Size(34, 18);
            this.statusTime.Text = strings.Time;
            // 
            // trayIcon
            // 
            this.trayIcon.ContextMenuStrip = this.trayIconMenu;
            this.trayIcon.Text = strings.Alarm;
            this.trayIcon.DoubleClick += new System.EventHandler(this.trayIcon_DoubleClick);
            // 
            // trayIconMenu
            // 
            this.trayIconMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.trayIconMenu.Name = "trayIconMenu";
            this.trayIconMenu.Size = new System.Drawing.Size(93, 26);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = strings.Exit;
            // 
            // timerTime
            // 
            this.timerTime.Enabled = true;
            this.timerTime.Interval = 500;
            this.timerTime.Tick += new System.EventHandler(this.timerTime_Tick);
            // 
            // timerDate
            // 
            this.timerDate.Enabled = true;
            this.timerDate.Interval = 86400000;
            this.timerDate.Tick += new System.EventHandler(this.timerDate_Tick);
            // 
            // timerAlarm
            // 
            this.timerAlarm.Interval = 500;
            this.timerAlarm.Tick += new System.EventHandler(this.timerAlarm_Tick);
            // 
            // timerTimer
            // 
            this.timerTimer.Interval = 500;
            this.timerTimer.Tick += new System.EventHandler(this.timerTimer_Tick);
            // 
            // timerStopwatch
            // 
            this.timerStopwatch.Interval = 500;
            this.timerStopwatch.Tick += new System.EventHandler(this.timerStopwatch_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 312);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.mainMenu);
            this.MainMenuStrip = this.mainMenu;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1920, 351);
            this.MinimumSize = new System.Drawing.Size(288, 351);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simple Alarm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Resize += new System.EventHandler(this.frmMain_Resize);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabAlarm.ResumeLayout(false);
            this.tabAlarm.PerformLayout();
            this.gbAlarmRepeat.ResumeLayout(false);
            this.gbAlarmRepeat.PerformLayout();
            this.tabTimer.ResumeLayout(false);
            this.tabTimer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTimerMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTimerSeconds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTimerHours)).EndInit();
            this.tabStopwatch.ResumeLayout(false);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.trayIconMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabAlarm;
        private System.Windows.Forms.TabPage tabTimer;
        private System.Windows.Forms.TabPage tabStopwatch;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuOptions;
        private System.Windows.Forms.ToolStripMenuItem menuHelp;
        private System.Windows.Forms.ToolStripMenuItem fileExit;
        private System.Windows.Forms.ToolStripMenuItem optionsTrayIcon;
        private System.Windows.Forms.ToolStripMenuItem optionsDisablePopup;
        private System.Windows.Forms.ToolStripMenuItem optionsDisableSound;
        private System.Windows.Forms.ToolStripSeparator optionsSep1;
        private System.Windows.Forms.ToolStripMenuItem optionsHideDate;
        private System.Windows.Forms.ToolStripMenuItem optionsHideTime;
        private System.Windows.Forms.ToolStripMenuItem helpGithub;
        private System.Windows.Forms.ToolStripSeparator helpSep1;
        private System.Windows.Forms.ToolStripMenuItem helpChangelog;
        private System.Windows.Forms.ToolStripSeparator helpSep2;
        private System.Windows.Forms.ToolStripMenuItem helpTopics;
        private System.Windows.Forms.ToolStripMenuItem helpAbout;
        private System.Windows.Forms.Label lblAlarmHour;
        private System.Windows.Forms.ComboBox cmbAlarmHour;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusDate;
        private System.Windows.Forms.ToolStripStatusLabel statusTime;
        private System.Windows.Forms.ToolStripSeparator statusSep1;
        private System.Windows.Forms.NotifyIcon trayIcon;
        private System.Windows.Forms.ContextMenuStrip trayIconMenu;
        private System.Windows.Forms.Label lblAlarmMinute;
        private System.Windows.Forms.Label lblAlarmSecond;
        private System.Windows.Forms.ComboBox cmbAlarmMinute;
        private System.Windows.Forms.ComboBox cmbAlarmSecond;
        private System.Windows.Forms.Label lblAlarmMessage;
        private System.Windows.Forms.TextBox txtAlarmMessage;
        private System.Windows.Forms.GroupBox gbAlarmRepeat;
        private System.Windows.Forms.CheckBox chkAlarmSunday;
        private System.Windows.Forms.CheckBox chkAlarmMonday;
        private System.Windows.Forms.CheckBox chkAlarmThursday;
        private System.Windows.Forms.CheckBox chkAlarmWednesday;
        private System.Windows.Forms.CheckBox chkAlarmFriday;
        private System.Windows.Forms.CheckBox chkAlarmSaturday;
        private System.Windows.Forms.CheckBox chkAlarmTuesday;
        private System.Windows.Forms.Button btnAlarmStart;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Timer timerTime;
        private System.Windows.Forms.Timer timerDate;
        private System.Windows.Forms.ToolStripMenuItem options24HourTime;
        private System.Windows.Forms.ToolStripMenuItem optionsDayMonthYearFormat;
        private System.Windows.Forms.ToolStripSeparator optionsSep2;
        private System.Windows.Forms.Label lblTimerSecond;
        private System.Windows.Forms.Label lblTimerMinute;
        private System.Windows.Forms.Label lblTimerHour;
        private System.Windows.Forms.NumericUpDown numTimerMinutes;
        private System.Windows.Forms.NumericUpDown numTimerSeconds;
        private System.Windows.Forms.NumericUpDown numTimerHours;
        private System.Windows.Forms.Button btnTimerStart;
        private System.Windows.Forms.TextBox txtTimerMessage;
        private System.Windows.Forms.Label lblTimerMessage;
        private System.Windows.Forms.Label lblStopwatch;
        private System.Windows.Forms.Button btnStopwatchStart;
        private System.Windows.Forms.Timer timerAlarm;
        private System.Windows.Forms.Timer timerTimer;
        private System.Windows.Forms.Button btnStopwatchReset;
        private System.Windows.Forms.CheckBox chkTimerRepeat;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Timer timerStopwatch;
    }
}