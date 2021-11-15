using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace CalculatorChainofResponsibility
{
    class Originator
    {
        private Canvas drawing;

        public void set(Canvas newDrawing)
        {
            Console.WriteLine("From Originator: Current Version of Drawing \n");
            drawing = newDrawing;
        }

        public Memento storeInMemento()
        {
            Console.WriteLine("From Originator: Saving to Memento \n");
            return new Memento(drawing);
        }

        public Canvas restoreFromMemento(Memento memento)
        {
            drawing = memento.getSavedDrawing();
            Console.WriteLine("From Originator: Previous Drawing Saved in Memento \n");
            return drawing;

        }
    }
}