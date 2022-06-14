using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Renci.SshNet;


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
    }
}
