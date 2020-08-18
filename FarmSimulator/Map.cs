using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmSimulator
{
    class Map
    {
        protected int[,] map = new int[1000,1000];


        public void generateMap(bool lake , bool river = true)
        {
            //Creamos el mapa con distintos objetos ( piedras, arboles, etc )
            CreateObjects(this.map);

            if (river == true)
            {
                CreateRiver(this.map);
            }

            if (lake == true)
            {
                CreateLake(this.map);
            }

            CreateFarm(this.map);

        }

        private void CreateRiver(int[,] map)
        {

        }

        private void CreateLake(int[,] map)
        {

        }

        private void CreateObjects(int[,] map)
        {

        }

        private void CreateFarm(int[,] map)
        {

        }
    }
}
