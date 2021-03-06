using OpenTabletDriver.Plugin.Tablet;

namespace OpenTabletDriver.Vendors.Wacom
{
    public class IntuosV2AuxReport : IAuxReport
    {
        public IntuosV2AuxReport(byte[] report)
        {
            Raw = report;

            AuxButtons = new bool[]
            {
                (report[4] & (1 << 0)) != 0,
                (report[4] & (1 << 1)) != 0,
                (report[4] & (1 << 2)) != 0,
                (report[4] & (1 << 3)) != 0,
                (report[4] & (1 << 4)) != 0,
                (report[4] & (1 << 5)) != 0,
                (report[4] & (1 << 6)) != 0,
                (report[4] & (1 << 7)) != 0
            };
        }
        
        public byte[] Raw { private set; get; }
        public bool[] AuxButtons { private set; get; }
    }
}
