using Renci.SshNet;
using System;
using System.Windows.Forms;


namespace TheTree
{
    public partial class frmMain : Form
    {
        private const int Port = 65123;

        public frmMain()
        {
            InitializeComponent();

        }

        private void LoadTree_Click(object sender, EventArgs e)
        {
            try
            {
                SshClient client = new SshClient("212.109.220.171", Port, "root", "SJbmj0BKbm8I");
                client.Connect();
            }
            catch (Exception eer)
            {
                MessageBox.Show("Connection failed :(---" + "Error: " + eer.Message);
                //return null;
            }
        }

        private void cmdConnect_Click(object sender, EventArgs e)
        {
            try
            {
                SshClient client = new SshClient("212.109.220.171", Port, "root", "SJbmj0BKbm8I");
                client.Connect();
            }
            catch (Exception eer)
            {
                MessageBox.Show("Connection failed :(---" + "Error: " + eer.Message);
                //return null;
            }
        }

        private void kryptonDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void kryptonTableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
