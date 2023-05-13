using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExercise
{
    public static class TempConverter
    {
       public static double FarenheitToCelsius(double far)
            {
             
              return (far - 32) /1.8;
                
            }
            public static double CelsiusToFarenheit(double cel)
            {

                return (cel) * 1.8 + 32;

            }
        
    }
}
/*FahrenheitToCelsius that will require a double as a parameter and return a double, the other CelsiusToFahrenheit which will also require a double as a parameter and return a double.

Fill out these methods and call them in your Program.cs file. Make sure they’re accurate!*/
