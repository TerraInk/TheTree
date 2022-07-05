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
                //Krypton.Toolkit.KryptonListView aa = new Krypton.Toolkit.KryptonListView("22");
                //logListViewitem logv = new logListView("11");
                //logListView.Items.Add("Соединение с сервером успешно");
                ListViewItem logv = new ListViewItem(DateTime.Now.ToString());
                logv.SubItems.Add("Соединение с сервером успешно");
                logListView.Items.Add(logv);
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

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
