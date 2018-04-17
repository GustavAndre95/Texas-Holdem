using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Domain
{
    class Person : Player
    {
        public Person(string n, int c, GameTable gameBoard) : base(n, c, gameBoard)
        {
        }
       
        public override void makeDecision(){
            this.showCards();
        
        }

    }
}
