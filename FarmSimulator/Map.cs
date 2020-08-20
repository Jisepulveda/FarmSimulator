using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace FarmSimulator
{
    class Map
    {
        protected int[,] map;
        private Lake lake;
        private River river;
        private Farm farm;

        public Map(int sizeMap)
        {
            int[,] map = new int[sizeMap, sizeMap];

            this.map = map;
        }
        public int[,] GetMap()
        {
            return this.map;
        }
        public void GenerateMap(bool createLake , bool createRiver = true)
        {

            if(createLake == true)
            {
                Lake lake = new Lake();
            }

            if(createRiver == true)
            {
                River river = new River();
            }



        }

    }
}
