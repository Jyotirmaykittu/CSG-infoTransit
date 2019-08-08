using CsgITLed1._0.User;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CsgITLed1._0
{
    public partial class MainMenu : Form
    {
        //private object form;

        public MainMenu()
        {
            InitializeComponent();
        }

        private void xmlReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloaseAllActiveForm();
            MessageBox.Show("");
        }
        private void sendReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloaseAllActiveForm();
            try
            {
                String pathToSourceFile = @"D:\Users.xml";
                //String localPath = @"\\192.168.50.62\New Folder\Users1.xml";
                String localPath = @"\\169.254.10.190\share_folder\Users.xml";
                //String localPath = @"\\192.168.50.52\RaspberryPi NAS\Users.xml";
                if (!System.IO.Directory.Exists(pathToSourceFile))
                {
                    if (!System.IO.Directory.Exists(localPath))
                    {
                        File.Copy(pathToSourceFile, localPath);
                    }
                }
                MessageBox.Show("XML File shared you location");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error !!!" + ex);
            }
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void CloaseAllActiveForm()
        {
            Form[] childArray = this.MdiChildren;
            foreach (Form childform in childArray)
            {
                childform.Close();
            }
        }


        private void RouteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloaseAllActiveForm();
            CreateRoute cr = new CreateRoute();
            cr.MdiParent = this;
            cr.Show();
        }

        private void StopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloaseAllActiveForm();
            CreateStop cs = new CreateStop();
            cs.MdiParent = this;
            cs.Show();
        }

        private void PartialRouteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloaseAllActiveForm();
            MessageBox.Show("This feature will come next version of this application ");
        }

        private void DataCenterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloaseAllActiveForm(); 
            DataCenter dc = new DataCenter();
            dc.MdiParent = this;            
            dc.Show();
        }

        private void ExitPicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void newDataCenterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloaseAllActiveForm();
            SetDataCenter sdc = new SetDataCenter();
            sdc.MdiParent =this;            
            sdc.Show();
        }
    }
}
