using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Ejer1
    {

        //Complete the solution so that it returns true if the first argument(string) passed in ends with the 2nd argument (also a string).
        public bool Solution(string str,string ending)
        {
            if(ending == "") { return true; }

            if (ending[ending.Length - 1] != str[str.Length-1]) { return false; }
         
            var bandera = false;
            var j = 1;
           
            for (int i = ending.Length-1; i >= 0; i--)
            {
                if(str.Length-j >= 0)
                {
                    if (str[str.Length - j] == ending[i])
                    {
                        bandera = true;
                    }
                    else
                    {
                        bandera = false;
                    }

                    j++;
                }
                else
                {
                    bandera = false;
                }
            }

            return bandera;
        }
    }
}
