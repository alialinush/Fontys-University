using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using BalanceTopUp;


namespace balance_top_up
{
    public partial class BalanceTopUpForm : Form
    {
        private DatabaseUtils conn;
        public BalanceTopUpForm()
        {
            InitializeComponent();
            conn = new DatabaseUtils();
        }
        private void InitializeDisplay()
        {
            pbxSign.Image = null;
            lbxTopUp.Items.Clear();
        }
        private void btnLoadFile_Click(object sender, EventArgs e)
        {
        //    InitializeDisplay();
        //    if (openFileDialog1.ShowDialog() == DialogResult.OK)
        //    {
        //        FileStream fs = null;
        //        StreamReader sr = null;
        //        try
        //        {
        //            fs = new FileStream(this.openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
        //            sr = new StreamReader(fs);
        //            string line1 = sr.ReadLine(); // orgnaziatior iban
        //            line1 = line1.Replace(" ", "");
        //            if (line1 == "NL91ABNA0417164300")
        //            {
        //                btnCfmTop.Enabled = true;
        //                sr.ReadLine(); // start time
        //                sr.ReadLine(); // end time
        //                sr.ReadLine(); // nr of transfer
        //                string s = sr.ReadLine();
        //                while (s != null)
        //                {
        //                    lbxTopUp.Items.Add(s);
        //                    s = sr.ReadLine();
        //                }
        //            }
        //        }
        //        catch (IOException) { MessageBox.Show("something wrong about file"); }
        //        finally
        //        {
        //            if (sr != null) sr.Close();
        //            if (fs != null) fs.Close();
        //        }
        //    }
        }
        private void btnCfmTop_Click(object sender, EventArgs e)
        {
            if (lbxTopUp.Items.Count > 0)
            {
                ArrayList arrlist = new ArrayList();
                foreach (string record in lbxTopUp.Items)
                {
                    string[] recArr = record.Split(' ');
                    arrlist.Add(recArr);
                }
                //if (conn.TopUpAll(arrlist))
                //{
                //    pbxSign.Image = ilstSign.Images[1];
                //    lbxTopUp.Items.Clear();
                //    lbxTopUp.Items.Add("TOP-UP SUCCEEDED !");
                //    btnCfmTop.Enabled = false;
                //}
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbTransactions_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnLoadFile_Click_1(object sender, EventArgs e)
        {

        }
    }
}
