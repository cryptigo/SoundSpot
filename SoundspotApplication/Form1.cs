using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace SoundspotApplication {
    public partial class MainForm : Form {

        
        
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,      // x-coordinate of upper-left corner
            int nTopRect,       // y-coordinate of upper-left corner
            int nRightRect,     // x-coordinate of lower-right corner
            int nBottomRect,    // y-coordinate of lower-right corner
            int nWidthEllipse,  // width of ellipse
            int nHeightEllipse  // height of ellipse
            );
        public MainForm() {
            InitializeComponent();
            // Rounded corners of form
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }


        private void minimizeButton_MouseClick(object sender, MouseEventArgs e) {
            // Minimize the program
            if (this.WindowState == FormWindowState.Normal) {
                this.WindowState = FormWindowState.Minimized;
            } else if(this.WindowState == FormWindowState.Maximized) {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void expandButton_MouseClick(object sender, MouseEventArgs e) {
            if(this.WindowState == FormWindowState.Normal) {
                
                int screenMaxWidth = Screen.PrimaryScreen.WorkingArea.Width;
                int screenMaxHeight = Screen.PrimaryScreen.WorkingArea.Height;
                this.WindowState = FormWindowState.Maximized;
                this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, screenMaxWidth, screenMaxHeight, 20, 20));
                

            } else if(this.WindowState == FormWindowState.Maximized) {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void closeButton_MouseClick(object sender, MouseEventArgs e) {
            //Close the program
            Application.Exit();
        }

        private void MainForm_Resize(object sender, EventArgs e) {

        }

        private void playlistView_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void siticonePanel1_Paint(object sender, PaintEventArgs e) {

        }

        private void MainForm_Load(object sender, EventArgs e) {

        }

        private void playBtn_Click(object sender, EventArgs e) {

        }
    }
}
