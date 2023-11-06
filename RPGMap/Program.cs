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

        void DisplayMap(int scale=1)
        {
            int arrayHorizontalSize = mapArray[0].Length;
            int arrayVerticalSize = mapArray.Length;
        }
    }
}
