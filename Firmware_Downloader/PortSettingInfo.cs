using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace Firmware_Downloader
{
    public partial class Form1
    {
        string[] ports = SerialPort.GetPortNames();
        string[] baud_rate = { "2400", "4800", "9600", "14400", "38400", "57600", "115200", "230400" };
        string[] data = { "7 bit", "8 bit" };
        string[] parity = { "none", "odd", "even", "mark", "space" };
        string[] stop_bits = { "1 bit", "2 bit" };
        string[] flow_control = { "Xon/Xoff", "RTS/CTS", "DSR/DTR", "none" };
    }

}
