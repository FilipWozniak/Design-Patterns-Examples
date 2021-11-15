using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace CalculatorChainofResponsibility
{
    class Memento
    {
        private Canvas drawing;

        public Memento(Canvas drawingSave)
        {
            drawing = drawingSave;
        }

        public Canvas getSavedDrawing() { return drawing; }
    }
}