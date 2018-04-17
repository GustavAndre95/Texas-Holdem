using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Domain
{
    //AI not yet implemented.
    class AI : Player
    {
        public AI(string n, int c, GameTable gameBoard) : base(n, c, gameBoard)
        {
        }

            public override void makeDecision()
        {
            
            bet(5);
        }
    } 
}