using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Whatever;

namespace FirstClass
{
    [Description("firstProperty przyjmuje argument typu string - zwraca argument jako wielkie litery; \n secondProperty przyjmuje argument typu int - zwraca ilosc liczb fibbonaciego podana w argumencie.", Copyright = "Ja")]
    public class UpperFib : IValid {
        public string firstProperty(string arg) {

            string results = arg.ToUpper();

            return results;
        }

        public double secondProperty(int arg) {

            int a = 0;
            int b = 1;

            for (int i = 0; i < arg; i++) {
                int tempValue = a;
                a = b;
                b = tempValue + b;
            }

            return a;

        }
    }
}
