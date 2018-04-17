using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Domain
{
    class SinglePlayerException: Exception
    {
        public SinglePlayerException()
         :base("Player not allowed to play alone")
        {
            
        }
    }
}
