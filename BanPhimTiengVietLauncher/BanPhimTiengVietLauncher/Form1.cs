using System.Diagnostics;

namespace BanPhimTiengVietLauncher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!System.Windows.Forms.Application.MessageLoop)
            {
                return;
            }
            // WinForms app
            System.Windows.Forms.Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProcessStartInfo info = new ProcessStartInfo("BanPhimTiengVietLauncherForForm.exe");
            Process.Start(info);
            if (System.Windows.Forms.Application.MessageLoop)
            {
                System.Windows.Forms.Application.Exit();
            }
        }
    }
}
