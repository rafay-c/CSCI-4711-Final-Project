using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class Animal
    {
        public int AnimalID { get; }
        public string Name { get; set; }
        public string Species { get; set; }
        public string DateReceived { get; set; }

        public string Entry
        {
            get
            {
                return $"{AnimalID -3}, { Name }, {Species}, {DateReceived}";
            }
        }
    }
}
