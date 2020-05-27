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

namespace TrafficDemo
{
    
    public partial class Form2 : Form
    {
        public static string dirParameter = AppDomain.CurrentDomain.BaseDirectory + @"\file.txt";
        public Form2(string duration)
        {
            InitializeComponent();
            lbActualTime.Text = duration.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btSave_Click(object sender, EventArgs e)
        {

            DialogResult result;
            result = MessageBox.Show("Do you want to save file?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question); 
            if (result == DialogResult.No)
            {
                return;
            }
            if (result == DialogResult.Yes)
            {
                try
                {
                    if (lbPlannedRuntime.Text != null && lbActualTime.Text != null && lbResultCarsEntered .Text != null && lbCarsLeft.Text != null && lbResPedesEntered.Text != null && lbPedestriansLeft.Text != null && lbResSurpriseElem.Text != null && lbAccidents.Text != null)
                    {
                        saveFile(lbPlannedRuntime.Text, lbActualTime.Text,lbResultCarsEntered.Text,lbCarsLeft.Text,lbResPedesEntered.Text,lbPedestriansLeft.Text,lbResSurpriseElem.Text,lbAccidents.Text);
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.ToString());
                }
            }

             void saveFile(string plannedruntime, string actualruntime, string carsEntered, string carsLeft, string pedesEntered, string pedesLeft, string surprisedElem, string accidents)
            {
                string Msg = "Planned Runtime:" + plannedruntime +"\n" + " Actual Runtime:" + actualruntime +"\n" + " Cars Entered:" + carsEntered+"\n" + " Cars Left:" + carsLeft +"\n" + " Pedestrians Entered:"  + pedesEntered +"\n"+" Suprised Elements:" + surprisedElem + "\n" + " Accidents:" + accidents;
                

                // Save File to .txt  
                FileStream fParameter = new FileStream(dirParameter, FileMode.Create, FileAccess.Write);
                StreamWriter m_WriterParameter = new StreamWriter(fParameter);
                m_WriterParameter.BaseStream.Seek(0, SeekOrigin.End);
                m_WriterParameter.Write(Msg);
                m_WriterParameter.Flush();
                m_WriterParameter.Close();
            }

        }
    }
}
