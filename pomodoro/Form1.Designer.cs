namespace pomodoro
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.workDurationInput = new System.Windows.Forms.NumericUpDown();
            this.breakDurationInput = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.timerControlsPanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.pauseButton = new System.Windows.Forms.Button();
            this.countdownLabel = new System.Windows.Forms.Label();
            this.countdownTimer = new System.Windows.Forms.Timer(this.components);
            this.pomodoroStateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.workDurationInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.breakDurationInput)).BeginInit();
            this.timerControlsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // workDurationInput
            // 
            this.workDurationInput.Location = new System.Drawing.Point(96, 10);
            this.workDurationInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.workDurationInput.Name = "workDurationInput";
            this.workDurationInput.Size = new System.Drawing.Size(126, 20);
            this.workDurationInput.TabIndex = 0;
            this.workDurationInput.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            // 
            // breakDurationInput
            // 
            this.breakDurationInput.Location = new System.Drawing.Point(96, 38);
            this.breakDurationInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.breakDurationInput.Name = "breakDurationInput";
            this.breakDurationInput.Size = new System.Drawing.Size(126, 20);
            this.breakDurationInput.TabIndex = 0;
            this.breakDurationInput.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "Çalışma Süresi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mola Süresi:";
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.DarkGreen;
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.startButton.ForeColor = System.Drawing.Color.White;
            this.startButton.Location = new System.Drawing.Point(12, 66);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(210, 39);
            this.startButton.TabIndex = 2;
            this.startButton.Text = "Oturumu Başlat";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // timerControlsPanel
            // 
            this.timerControlsPanel.Controls.Add(this.pomodoroStateLabel);
            this.timerControlsPanel.Controls.Add(this.label4);
            this.timerControlsPanel.Controls.Add(this.cancelButton);
            this.timerControlsPanel.Controls.Add(this.pauseButton);
            this.timerControlsPanel.Controls.Add(this.countdownLabel);
            this.timerControlsPanel.Location = new System.Drawing.Point(12, 111);
            this.timerControlsPanel.Name = "timerControlsPanel";
            this.timerControlsPanel.Size = new System.Drawing.Size(210, 84);
            this.timerControlsPanel.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(55, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "dk";
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.Red;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cancelButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cancelButton.ForeColor = System.Drawing.Color.White;
            this.cancelButton.Location = new System.Drawing.Point(140, 43);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(70, 39);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "İptal Et";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // pauseButton
            // 
            this.pauseButton.BackColor = System.Drawing.Color.OrangeRed;
            this.pauseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pauseButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pauseButton.Location = new System.Drawing.Point(0, 43);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(134, 39);
            this.pauseButton.TabIndex = 2;
            this.pauseButton.Text = "Durdur";
            this.pauseButton.UseVisualStyleBackColor = false;
            this.pauseButton.Click += new System.EventHandler(this.pauseButton_Click);
            // 
            // countdownLabel
            // 
            this.countdownLabel.AutoSize = true;
            this.countdownLabel.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.countdownLabel.Location = new System.Drawing.Point(-2, 0);
            this.countdownLabel.Name = "countdownLabel";
            this.countdownLabel.Size = new System.Drawing.Size(63, 34);
            this.countdownLabel.TabIndex = 0;
            this.countdownLabel.Text = "000";
            // 
            // countdownTimer
            // 
            this.countdownTimer.Interval = 60000;
            this.countdownTimer.Tick += new System.EventHandler(this.countdownTimer_Tick);
            // 
            // pomodoroStateLabel
            // 
            this.pomodoroStateLabel.AutoSize = true;
            this.pomodoroStateLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pomodoroStateLabel.Location = new System.Drawing.Point(137, 11);
            this.pomodoroStateLabel.Name = "pomodoroStateLabel";
            this.pomodoroStateLabel.Size = new System.Drawing.Size(65, 18);
            this.pomodoroStateLabel.TabIndex = 1;
            this.pomodoroStateLabel.Text = "Çalışma";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 111);
            this.Controls.Add(this.timerControlsPanel);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.breakDurationInput);
            this.Controls.Add(this.workDurationInput);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(250, 150);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(250, 150);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Pomodoro Timer";
            ((System.ComponentModel.ISupportInitialize)(this.workDurationInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.breakDurationInput)).EndInit();
            this.timerControlsPanel.ResumeLayout(false);
            this.timerControlsPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown workDurationInput;
        private System.Windows.Forms.NumericUpDown breakDurationInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Panel timerControlsPanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button pauseButton;
        private System.Windows.Forms.Label countdownLabel;
        private System.Windows.Forms.Timer countdownTimer;
        private System.Windows.Forms.Label pomodoroStateLabel;
    }
}

