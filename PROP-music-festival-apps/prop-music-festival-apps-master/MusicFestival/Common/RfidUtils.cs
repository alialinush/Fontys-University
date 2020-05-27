using Phidget22;
using Phidget22.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    /**
     * RFID utils class
     * can be used like: RfidUtils.Instance.OpenConnection();
     */
    public sealed class RfidUtils
    {
        private static RfidUtils instance = null;
        private static readonly object padlock = new object();
        private static RFID rfidReader;
        private static RfidTagListener tagListener = null;

        public static RfidUtils Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new RfidUtils();
                    }
                    return instance;
                }
            }
        }
        RfidUtils()
        {
            rfidReader = new RFID();
            rfidReader.Tag += new RFIDTagEventHandler(HandleTagChange);
        }

        public void OpenConnection()
        {
            try
            {
                rfidReader.Open();
            } catch(PhidgetException)
            {
                // TODO: handle this
            }
        }

        public void CloseConnection()
        {
            try
            {
                rfidReader.Close();
                tagListener = null;
            }
            catch (PhidgetException)
            {
                // TODO: handle this
            }
        }

        /**
         * Switches the rfid listening on/off so this way we don't need to reopen connection every time
         */
        public void SwitchAntenna(bool isOn)
        {
            if (rfidReader.Attached)
            {
                if (isOn)
                {
                    if (rfidReader.AntennaEnabled)
                    {
                        rfidReader.AntennaEnabled = !rfidReader.AntennaEnabled;
                    }
                } else
                {
                    if (!rfidReader.AntennaEnabled)
                    {
                        rfidReader.AntennaEnabled = !rfidReader.AntennaEnabled;
                    }
                }
            }
        }

        /**
         * Sets tag event listener
         */
        public void SetTagListener(RfidTagListener eventListener)
        {
            tagListener = eventListener;
        }

        private void HandleTagChange(object sender, RFIDTagEventArgs e)
        {
            if(tagListener != null)
            {
                tagListener.OnTagChange(e.Tag);
            }
        }
    }
}
