// by Nitro
// E-Mail: nitro0@naver.com
// GitHub: https://github.com/Nitro1231

// [License]
// This work is licensed under a Creative Commons Attribution-NonCommercial-ShareAlike 4.0 International License
// Check the more detail about the license at here: https://creativecommons.org/licenses/by-nc-sa/4.0/

using System;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Windows.Input;

namespace MineFish {
    public partial class Main : Form {

        #region In-Game UI
        public struct RECT {
            public int Left;
            public int Top;
            public int Right;
            public int Bottom;
        }

        [DllImport("user32.dll")]
        static extern bool GetWindowRect(IntPtr hWnd, out RECT lpRect);

        [DllImport("user32.dll")]
        public static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);

        [DllImport("user32.dll")]
        public static extern int GetWindowLong(IntPtr hWnd, int nIndex);

        [DllImport("user32.dll", SetLastError = true)]
        private static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);

        public static int GWL_STYLE = -16;
        public static int WS_CHILD = 0x40000000;

        Process mineProcess;
        RECT info;
        int padding = 10;
        Stopwatch sw;
        #endregion

        #region Input Hook
        // Mouse click event
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);

        private const uint RBUTTONDOWN = 0x0008;
        private const uint RBUTTONUP = 0x00010;
        #endregion

        int startCount;

        public Main() { InitializeComponent(); }

        private void Main_Load(object sender, EventArgs e) {
            Utils.smoothBorder(this, 4);
            Utils.smoothBorder(sidePanel, sidePanel.Width);
            Utils.smoothBorder(minPanel, minPanel.Width);
            Utils.smoothBorder(closePanel, closePanel.Width);
            Utils.smoothBorder(macroBox, 6);

            // In-Game UI
            // Find Minecraft process id by process name.
            mineProcess = Process.GetProcessesByName("javaw").FirstOrDefault();
            if (mineProcess != null) {
                // Fix the window position if program started with 'In-Game UI' mode.
                Utils.moveable = false;

                // Get Minecraft's window size information.
                GetWindowRect(mineProcess.MainWindowHandle, out info);

                // Set window size and location.
                SetBounds(info.Right - info.Left - Width - padding - 20, padding, 0, 0, BoundsSpecified.Location);
                IntPtr hostHandle = mineProcess.MainWindowHandle;
                IntPtr guestHandle = Handle;
                SetWindowLong(guestHandle, GWL_STYLE, GetWindowLong(guestHandle, GWL_STYLE) | WS_CHILD);
                SetParent(guestHandle, hostHandle);
            }
        }

        private void MacroBox_Click(object sender, EventArgs e) {
            if (mainTimer.Enabled) {
                // Stop
                mainTimer.Enabled = false;
                macroBox.BackColor = Color.FromArgb(46, 204, 113);
                macroBox.Image = Properties.Resources.icons8_play_50;
                sw.Stop();
            } else {
                // Start
                macroBox.BackColor = Color.FromArgb(231, 76, 60);
                macroBox.Image = Properties.Resources.icons8_stop_50;
                startCount = 0;
                timeLabel.Text = "0";
                startTimer.Enabled = true;
            }
        }

        private void StartTimer_Tick(object sender, EventArgs e) {
            if (startCount >= 5) {
                sw = new Stopwatch();
                sw.Start();
                mainTimer.Enabled = true;
                startTimer.Enabled = false;
                mouse_event(RBUTTONDOWN, 0, 0, 0, 0);
                return;
            } else {
                startCount++;
                timeLabel.Text = startCount.ToString();
            }
        }

        private void MainTimer_Tick(object sender, EventArgs e) {
            timeLabel.Text = sw.Elapsed.ToString(@"hh\:mm\:ss");

            // 'ESC' for stop the marco.
            if (Keyboard.GetKeyStates(Key.Escape).ToString().Contains("Down")) {
                mouse_event(RBUTTONUP, 0, 0, 0, 0); // Right button up.
                macroBox.BackColor = Color.FromArgb(46, 204, 113);
                macroBox.Image = Properties.Resources.icons8_play_50;
                sw.Stop();
                mainTimer.Enabled = false;
                return;
            }
        }

        private void UiTimer_Tick(object sender, EventArgs e) {
            if (mineProcess != null) {
                // Get window info and re-locate the form.
                GetWindowRect(mineProcess.MainWindowHandle, out info);
                Location = new Point(info.Right - info.Left - Width - padding - 20, padding);
            } else {
                // If game is not running, let user move the form.
                uiTimer.Enabled = false;
            }
        }

        private void Main_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e) { Utils.mouseMove(Handle); }
        private void ClosePanel_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e) { Close(); }
        private void MinPanel_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e) { WindowState = FormWindowState.Minimized; }

        #region Links
        private void WebBox_Click(object sender, EventArgs e) { Process.Start("https://nitro1231.github.io/"); }
        private void BlogBox_Click(object sender, EventArgs e) { Process.Start("http://nitr0.tistory.com/"); }
        private void MailBox_Click(object sender, EventArgs e) { Process.Start("mailto:nitr0@naver.com"); }
        private void GithubBox_Click(object sender, EventArgs e) { Process.Start("https://github.com/Nitro1231"); }
        private void YoutubeBox_Click(object sender, EventArgs e) { Process.Start("https://goo.gl/GcQ2XE"); }
        private void DiscordBox_Click(object sender, EventArgs e) { Process.Start(" https://discord.gg/4dpkX2F"); }
        #endregion
    }
}
