using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pomodoro
{
    public partial class Form1 : Form
    {
        public static int workDuration;
        public static int breakDuration;
        public static int currentCountdown;
        public static string pomodoroState;
        public Form1()
        {
            InitializeComponent();
            timerControlsPanel.Visible = false;
            // Kontrol panelini yukarı al
            timerControlsPanel.Location = new Point(12, 71);
        }
        void toggleFormHeight()
        {
            // Form uzun modda ise kısa mod yap, kısa modda ise uzun mod yap
            if (Form1.ActiveForm.Size.Height == 200)
            {
                // Formun min max ve anlık boyutunu ayarla
                Form1.ActiveForm.MinimumSize = new Size(250, 150);
                Form1.ActiveForm.MaximumSize = new Size(250, 150);
                Form1.ActiveForm.Size = new Size(250, 150);
                // Oturum bilgilerini içeren paneli gizle
                timerControlsPanel.Visible = false;
                startButton.Visible = true;
                return;
            }
            // Formun min max ve anlık boyutunu ayarla
            Form1.ActiveForm.MaximumSize = new Size(250, 200);
            Form1.ActiveForm.MinimumSize = new Size(250, 200);
            Form1.ActiveForm.Size = new Size(250, 200);
            startButton.Visible = false;
            // Oturum bilgilerini içeren paneli göster
            timerControlsPanel.Visible = true;
        }
        // Oturum devam ettirme
        void resumeSession()
        {
            countdownTimer.Start();
            pomodoroStateLabel.Text = "Çalışma";
            pauseButton.Text = "Durdur";
        }
        // Oturum durdurma
        void pauseSession()
        {
            countdownTimer.Stop();
            pomodoroStateLabel.Text = "Durduruldu";
            pauseButton.Text = "Devam Ettir";
        }
        // Oturum bitirme
        void stopSession()
        {
            // Formu ilk haline getir
            toggleFormHeight();
            countdownTimer.Stop();
            countdownLabel.Text = "000";
            pomodoroStateLabel.Text = "Çalışma";
            pomodoroState = "Work";
        }

        private void pauseButton_Click(object sender, EventArgs e)
        {
            // Oturum durdurulmuşsa devam ettir, devam ediyorsa durdur
            if (pomodoroStateLabel.Text == "Durduruldu")
            {
                resumeSession();
                return;
            }
            pauseSession();
        }
        private void cancelButton_Click(object sender, EventArgs e)
        {
            stopSession();
        }
        private void startButton_Click(object sender, EventArgs e)
        {
            // Pomodoro sürelerini al
            workDuration = (int)workDurationInput.Value;
            breakDuration = (int)breakDurationInput.Value;
            currentCountdown = workDuration;
            // Pomodoro süresini dakika cinsinden göster
            countdownLabel.Text = workDuration.ToString();
            // Zamanlayıcıyı başlat
            countdownTimer.Start();
            pomodoroState = "Work";
            // Formu uzat
            pomodoroStateLabel.Text = "Çalışma";
            toggleFormHeight();
            pauseButton.Text = "Durdur";
        }

        private void countdownTimer_Tick(object sender, EventArgs e)
        {
            // Kalan süreyi al
            currentCountdown -= 1;
            // Kalan süreyi bir azalt ve ekrana yaz
            countdownLabel.Text = "" + currentCountdown;
            if (currentCountdown == 0)
            {
                // Çalışma süresi bitmişse
                if (pomodoroStateLabel.Text == "Çalışma")
                {
                    // Molayı başlat
                    currentCountdown = breakDuration;
                    // Mola süresini ekrana yazdır
                    countdownLabel.Text = "" + breakDuration;
                    pomodoroStateLabel.Text = "Mola";
                    pomodoroState = "Break";
                    return;
                }
                // Mola süresi bitmişse
                stopSession();
            }
        }

    }
}
