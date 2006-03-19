#region Using directives

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Org.Mentalis.Utilities;

#endregion

namespace ClosingTime
{
    partial class ClosingTimeForm : Form
    {
        private class RestartTypeListOption
        {
            private string displayName;

            public string DisplayName
            {
                get { return displayName; }
                set { displayName = value; }
            }

            private RestartOptions restartOption;

            public RestartOptions RestartOption
            {
                get { return restartOption; }
                set { restartOption = value; }
            }

            public RestartTypeListOption(string display,
                RestartOptions option)
            {
                displayName = display;
                restartOption = option;
            }
        }

        bool isStart = true;
        DateTime endTime;
        TimeSpan interval;

        public ClosingTimeForm()
        {
            InitializeComponent();

            List<RestartTypeListOption> options = new List<RestartTypeListOption>(
                new RestartTypeListOption[] {
            new RestartTypeListOption("Shut Down", RestartOptions.ShutDown),
            new RestartTypeListOption("Log Off", RestartOptions.LogOff),
            new RestartTypeListOption("Reboot", RestartOptions.Reboot),
            new RestartTypeListOption("Suspend", RestartOptions.Suspend),
            new RestartTypeListOption("Hibernate", RestartOptions.Hibernate)
        });
            comboBoxRestartType.DataSource = options;
            comboBoxRestartType.DisplayMember = "DisplayName";
            comboBoxRestartType.ValueMember = "RestartOption";
            comboBoxRestartType.SelectedIndex = 0;
            maskedTextBoxTime.ValidatingType = typeof(TimeSpan);
        }

        private void buttonStartStop_Click(object sender, EventArgs e)
        {
            timerTick.Enabled = isStart;
            maskedTextBoxTime.ReadOnly = isStart;

            if(isStart)
            {
                endTime = DateTime.Now + interval;
                buttonStartStop.Text = "Stop";
                labelStatus.Text = "Timer running.";
            }
            else
            {
                buttonStartStop.Text = "Start";
                labelStatus.Text = "Timer stopped.";
            }

            isStart = !isStart;
        }

        private void timerTick_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            TimeSpan remaining = endTime - DateTime.Now;

            if(remaining.TotalSeconds < 0)
            {
                timerTick.Enabled = false;
                RestartOptions option = (RestartOptions) comboBoxRestartType.SelectedValue;
                WindowsController.ExitWindows(option, checkBoxForce.Checked);
            }

            maskedTextBoxTime.Text = remaining.ToString();
        }

        private void ClosingTimeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            timerTick.Enabled = false;
        }

        private void maskedTextBoxTime_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            buttonStartStop.Enabled = e.IsValidInput;
            if(!e.IsValidInput)
            {
                toolTipInputInvalid.Show(
                    "Please enter a valid time.",
                    maskedTextBoxTime,
                    maskedTextBoxTime.Location.X,
                    maskedTextBoxTime.Location.Y,
                    5000);
            }
            else
            {
                interval = (TimeSpan) e.ReturnValue;
            }

        }

        private void maskedTextBoxTime_KeyDown(object sender, KeyEventArgs e)
        {
            toolTipInputInvalid.Hide(maskedTextBoxTime);
        }
    }
}