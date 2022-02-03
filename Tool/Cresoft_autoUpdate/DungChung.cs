
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace frm_Update
{
    public class DungChung
    {

        public class bien
        {
            public class FTP_USER
            {
                public static readonly string userName = "Buiyen";
                public static readonly string passWord = "0977335751aA";
            }

        }
        public class Ham
        {
            public class InformationSystem
            {
                public int ID { get; set; }
                public string URLUPDATE { get; set; }
                public string URIUPDATE { get; set; }
                public string Vesion { get; set; }
            }
            public static List<InformationSystem> GetInformationSystems = new List<InformationSystem>();
            public static async Task<List<InformationSystem>> InformationSystems(InformationSystem informationSystem)
            {
                List<InformationSystem> InformationSystems = new List<InformationSystem>();
                 InformationSystems.Add(informationSystem);
                return InformationSystems;
            }

        }
    }
}
