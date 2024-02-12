using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson
{
    internal class Human
    {
        public Human()
        {
             Heart = new Heart();
        }
        public Heart Heart;
    }
}
