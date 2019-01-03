using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Whatever;

namespace SecondClass
{
    [Description("firstProperty przyjmuje argument typu string - zwraca argument malymi literami; \n secondProperty przyjmuje argument typu int - zwraca silnie", Copyright = "Ja")]
    public class LowerFactorial : IValid {
        public string firstProperty(string arg) {

            string results = arg.ToLower();
            return results;

        }

        public double secondProperty(int arg) {

         if (arg == 0)
            return 1;    
		  else    
		    return (arg * secondProperty(arg - 1));
        }
    }
}
