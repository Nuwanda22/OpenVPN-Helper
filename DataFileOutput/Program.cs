using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using ClassLibrary;

namespace MakingDataFile
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                #region 삭제함
                //using (BinaryWriter bw = new BinaryWriter(File.Create(@"C:\Users\ko997\Desktop\VPN\data.bin")))
                //{
                //	bw.Write(false);
                //	bw.Write(2);
                //	Console.WriteLine("성공적으로 출력되었습니다!");
                //}
                #endregion
                BinaryFormatter bf = new BinaryFormatter();
                OpenVpn ovpn = new OpenVpn();
				//bf.Serialize(File.Open(@"C:\Users\Nuwanda\Desktop\data.bin", FileMode.Create, FileAccess.Write), ovpn);
				bf.Serialize(File.Open(@"C:\Program Files\OpenVPN Helper\data.bin", FileMode.Create, FileAccess.Write), ovpn);
				Console.WriteLine("Output");
                Console.WriteLine(ovpn.ToString());

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
