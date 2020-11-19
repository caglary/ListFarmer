using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
namespace StaticClass
{
    public class HardDrive
    {
    
        public string Model { get; set; }
        public string InterfaceType { get; set; }
        public string Caption { get; set; }
        public string SerialNo { get; set; }
     
        public List<HardDrive> GetHDDInformation()
        {
            var searcher = new ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive");
            List<HardDrive> hardDrive = new List<HardDrive>();
            foreach (ManagementObject wmi_HD in searcher.Get())
            {
                HardDrive hd = new HardDrive();
                hd.Model = wmi_HD["Model"].ToString();
                hd.InterfaceType = wmi_HD["InterfaceType"].ToString();
                hd.Caption = wmi_HD["Caption"].ToString();
                hd.SerialNo = wmi_HD.GetPropertyValue("SerialNumber").ToString();
                hardDrive.Add(hd);
            }
            return hardDrive;
        }
    }
}
