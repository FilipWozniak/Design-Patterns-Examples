namespace ChainofResponsibilityCalculator
{
    public class Numbers
    {
        private int numberOne; 
        private int numberTwo;

        private string calculationWanted;

        public Numbers(int newNumberOne, int newNumberTwo, string calculationW)
        {
            numberOne = newNumberOne;
            numberTwo = newNumberTwo;
            calculationWanted = calculationW;
        }

        public int getNumberOne() { return numberOne; }
        public int getNumberTwo() { return numberTwo; }
        public string getCalculatonWanted() { return calculationWanted;  }

    }
}