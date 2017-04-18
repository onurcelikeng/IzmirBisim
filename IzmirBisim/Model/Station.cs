using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IzmirBisim.Model
{

    public class BisimPlace
    {

        public string name { get; set; }

        public string state { get; set; }

        public int emptyCount { get; set; }

        public int availableBcycle { get; set; }

        public double lat { get; set; }

        public double lon { get; set; }

    }

    public class Station
    {

        public List<BisimPlace> bisimPlaces { get; set; }

        public bool success { get; set; }

        public int count { get; set; }

    }

}
