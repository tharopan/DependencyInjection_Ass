using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjection_Assi.Models
{
    public class concreteClass : IGreet
    {
        public string display()
        {
            return "Hi Gowthamy!!! Welcome";
        }
    }
}
