using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGMap
{
    internal class Program
    {
        
        /*
        Unscaled Map
        
         */

        static void Main(string[] args)
        {
            string[] testMap =
            {
                "^^^'''''''''''''''''''''''''''",
                "^^''''**''''''''''''''''~~~'''",
                "^^'''**'''''''''''''''~~~'''''",
                "^'''''''''''''''''''''''''''''",
                "''''~~~'''''''''''''''''''''''",
                "''''~~~'''''''''''''''''''''''",
                "'''~~~~'''''''''''''''^^''''''",
                "'''''~~~'''''''''''''^^^^'''''",
                "'''''~~~~''''''''''''''^^^^'''",
                "'''''''~''''''''''''''''''''''",
                "''''''''''''''''''''''''''''''",
                "''''''''''''''''''''''''''''''"
            };
            MapRenderer mapper = new MapRenderer(null); 
            mapper.DisplayMap();
        }

        
    }

    class MapRenderer
    {
        string[] mapArray;
        string[] DEFAULT_MAP =
        {
            "^^^'''''''''''''''''''''''''''",
            "^^''''**''''''''''''''''~~~'''",
            "^^'''**'''''''''''''''~~~'''''",
            "^'''''''''''''''''''''''''''''",
            "''''~~~'''''''''''''''''''''''",
            "''''~~~'''''''''''''''''''''''",
            "'''~~~~'''''''''''''''^^''''''",
            "'''''~~~'''''''''''''^^^^'''''",
            "'''''~~~~''''''''''''''^^^^'''",
            "'''''''~''''''''''''''''''''''",
            "''''''''''''''''''''''''''''''",
            "''''''''''''''''''''''''''''''"
        };
        public MapRenderer(string[] _MapStringArray) { 
            if (_MapStringArray == null)
            {
                this.mapArray = DEFAULT_MAP;
            }
            else this.mapArray = _MapStringArray;
        }

        public List<string> DisplayMap() 
        {
            return DisplayMap(1);
        }

        public List<string> DisplayMap(int scale)
        {
            List<string> border = new List<string>();
            int arrayHorizontalSize = mapArray[0].Length;
            int arrayVerticalSize = mapArray.Length;

            for (int i = 0; i < arrayVerticalSize + 2; i++){
                for (int j = 0; j < arrayHorizontalSize + 2; j++){
                    if (i == 0 || i == arrayVerticalSize + 1) {
                        border[i] += "-";
                    }
                    else border[i] += "|";
                }
            }

            Console.WriteLine(border);
            return border;
        }
    }
}