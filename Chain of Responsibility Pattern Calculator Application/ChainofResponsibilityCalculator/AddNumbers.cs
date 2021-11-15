using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace ChainofResponsibilityCalculator
{
    class AddNumbers : Chain
    {
        private Chain nextInChain;

        public void setNextChain(Chain nextChain)
        {
            this.nextInChain = nextChain;
            // throw new NotImplementedException();
        }

        public void calculate(Numbers request, TextBlock text)
        {
            if(request.getCalculatonWanted() == "ADDITION")
            {
                int result = request.getNumberOne() + request.getNumberTwo();
                Console.WriteLine(request.getNumberOne() + " + " + request.getNumberTwo() + " = " + result);
                text.Text = String.Empty;
                text.Text = result.ToString();
            } else
            {
                nextInChain.calculate(request, text);
            }
            // throw new NotImplementedException();
        }
    }
}