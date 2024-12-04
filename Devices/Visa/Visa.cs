using Ivi.Visa.Interop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Devices.Visa
{
    public abstract class Visa
    {
        public string DeviceAddress { get; set; }
        private ResourceManagerClass ResourceManager { get; set; }
        private FormattedIO488Class ResourceIO { get; set; }

        public void Initialization()
        {


            ResourceManager = new ResourceManagerClass();
            ResourceIO = new FormattedIO488Class();

            try
            {
                ResourceManager.Open(DeviceAddress, AccessMode.NO_LOCK, 0, "");
                ResourceIO.IO = (Ivi.Visa.Interop.IMessage)ResourceManager.Open(DeviceAddress, AccessMode.NO_LOCK, 0, "");
            }
            catch (Exception e)
            {

                throw new Exception($@"Error Initialization method:{e.Message}");
            }
        }

        // Protected, not visible for other users.
        public void WriteCommand(string command)
        {
            try
            {
                ResourceIO.WriteString(command, true);
            }
            catch (Exception e)
            {
                throw new Exception($@"Error Write Command method:{e.Message}");
            }
        }

        protected string ReadCommand()
        {
            string buffer;
            try
            {
                buffer = ResourceIO.ReadString();
            }
            catch (Exception e)
            {
                throw new Exception($@"Error Read Command method:{e.Message}");
            }

            return buffer;
        }

        public string FindDevice()
        {
            string deviceName = "";
            try
            {
                WriteCommand("*IDN?");
                System.Threading.Thread.Sleep(100);
                deviceName = ReadCommand();
                return deviceName;
            }
            catch (Exception e)
            {
                throw new Exception($@"Error Find Device method:{e.Message}");
            }
        }

        public void Reset()
        {
            try
            {
                WriteCommand("*RTS");
            }
            catch (Exception e)
            {
                throw new Exception($@"Error Find Device method:{e.Message}");
            }
        }

        public void Clear()
        {
            try
            {
                WriteCommand("*CLS");
            }
            catch (Exception e)
            {
                throw new Exception($@"Error:{e.Message}");
            }
        }

    }
}
