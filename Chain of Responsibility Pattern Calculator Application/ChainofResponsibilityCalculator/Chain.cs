using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace ChainofResponsibilityCalculator
{
    interface Chain
    {
        void setNextChain(Chain nextChain);
        void calculate(Numbers request, TextBlock text);
    }
}