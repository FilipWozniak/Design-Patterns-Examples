using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorChainofResponsibility
{
    class Caretaker
    {
        List<Memento> savedDrawings = new List<Memento>();

        public void addMemento(Memento m) { savedDrawings.Add(m); }

        public Memento getMemento(int index) { return savedDrawings[index]; }

    }
}