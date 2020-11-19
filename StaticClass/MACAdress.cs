using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
namespace StaticClass
{
    class MACAdress
    {
        public string MAC()
        {
            string macadress = string.Empty;
            string mac = string.Empty;
            foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
            {
                OperationalStatus ot = nic.OperationalStatus;
                if (nic.OperationalStatus == OperationalStatus.Up)
                {
                    macadress = nic.GetPhysicalAddress().ToString();
                    break;
                }
            }
            if (string.IsNullOrEmpty(macadress))
            {
                for (int i = 0; i <= macadress.Length - 1; i++)
                {
                    mac = mac + ":" + macadress.Substring(i, 2);
                    // mac adresini alırken parça parça aldığından 
                    //aralarına : işaretini biz atıyoruz.
                    i++;
                }
                mac = mac.Remove(0, 1);
                // en sonda kalan fazladan : işaretini siliyoruz.
            }
            return mac;
        }
    }
}
