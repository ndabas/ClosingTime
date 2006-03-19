namespace ClosingTime
{
    partial class ClosingTimeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonStartStop = new System.Windows.Forms.Button();
            this.labelStatus = new System.Windows.Forms.Label();
            this.timerTick = new System.Timers.Timer();
            this.maskedTextBoxTime = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxRestartType = new System.Windows.Forms.ComboBox();
            this.toolTipInputInvalid = new System.Windows.Forms.ToolTip(this.components);
            this.checkBoxForce = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.timerTick)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonStartStop
            // 
            this.buttonStartStop.Enabled = false;
            this.buttonStartStop.Location = new System.Drawing.Point(161, 59);
            this.buttonStartStop.Margin = new System.Windows.Forms.Padding(3, 1, 3, 3);
            this.buttonStartStop.Name = "buttonStartStop";
            this.buttonStartStop.Size = new System.Drawing.Size(111, 26);
            this.buttonStartStop.TabIndex = 3;
            this.buttonStartStop.Text = "Start";
            this.buttonStartStop.Click += new System.EventHandler(this.buttonStartStop_Click);
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(13, 66);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(124, 13);
            this.labelStatus.TabIndex = 4;
            this.labelStatus.Text = "The timer is not running.";
            // 
            // timerTick
            // 
            this.timerTick.Interval = 500;
            this.timerTick.SynchronizingObject = this;
            this.timerTick.Elapsed += new System.Timers.ElapsedEventHandler(this.timerTick_Elapsed);
            // 
            // maskedTextBoxTime
            // 
            this.maskedTextBoxTime.Location = new System.Drawing.Point(48, 10);
            this.maskedTextBoxTime.Mask = "00:00:00";
            this.maskedTextBoxTime.Name = "maskedTextBoxTime";
            this.maskedTextBoxTime.Size = new System.Drawing.Size(84, 21);
            this.maskedTextBoxTime.TabIndex = 5;
            this.maskedTextBoxTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedTextBoxTime.KeyDown += new System.Windows.Forms.KeyEventHandler(this.maskedTextBoxTime_KeyDown);
            this.maskedTextBoxTime.TypeValidationCompleted += new System.Windows.Forms.TypeValidationEventHandler(this.maskedTextBoxTime_TypeValidationCompleted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Time:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "to:";
            // 
            // comboBoxRestartType
            // 
            this.comboBoxRestartType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRestartType.FormattingEnabled = true;
            this.comboBoxRestartType.Location = new System.Drawing.Point(161, 10);
            this.comboBoxRestartType.Name = "comboBoxRestartType";
            this.comboBoxRestartType.Size = new System.Drawing.Size(111, 21);
            this.comboBoxRestartType.TabIndex = 8;
            // 
            // toolTipInputInvalid
            // 
            this.toolTipInputInvalid.IsBalloon = true;
            this.toolTipInputInvalid.ToolTipTitle = "Invalid time.";
            // 
            // checkBoxForce
            // 
            this.checkBoxForce.AutoSize = true;
            this.checkBoxForce.Location = new System.Drawing.Point(161, 38);
            this.checkBoxForce.Name = "checkBoxForce";
            this.checkBoxForce.Size = new System.Drawing.Size(53, 17);
            this.checkBoxForce.TabIndex = 9;
            this.checkBoxForce.Text = "Force";
            this.checkBoxForce.UseVisualStyleBackColor = true;
            // 
            // ClosingTimeForm
            // 
            this.AcceptButton = this.buttonStartStop;
            this.ClientSize = new System.Drawing.Size(281, 95);
            this.Controls.Add(this.checkBoxForce);
            this.Controls.Add(this.comboBoxRestartType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maskedTextBoxTime);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.buttonStartStop);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ClosingTimeForm";
            this.Text = "Closing Time";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClosingTimeForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.timerTick)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStartStop;
        private System.Windows.Forms.Label labelStatus;
        private System.Timers.Timer timerTick;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTime;
        private System.Windows.Forms.ComboBox comboBoxRestartType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip toolTipInputInvalid;
        private System.Windows.Forms.CheckBox checkBoxForce;

    }
}

