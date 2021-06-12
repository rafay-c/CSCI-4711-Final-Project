using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class FeedData
    {
        public string FID { get; set; }
        public string TimeFed { get; set; }
        public string AID { get; set; }
        public string Entry
        {
            get
            {
                return $"{FID}, {TimeFed}, {AID}";
            }
        }
    }
}
