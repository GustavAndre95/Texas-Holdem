using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Domain;
using System.Windows.Forms;
using ConsoleApp1.GUI;
namespace ConsoleApp1
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
          
            Controller controller = new Controller(new GameTable(new CardDeck(new List<Card>(), new Random()), new ResultAnalyzer()));
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindow(controller));
            
            
      
             
        }
    }
}
