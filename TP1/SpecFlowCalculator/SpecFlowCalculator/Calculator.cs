using System;

namespace SpecFlowCalculator
{
    public class Calculator
    {
        public int FirstNumber { get; set; }
        public int SecondNumber { get; set; }
        public List<int> Numbers { get; set; } = new List<int>();

        public int Add()
        {
            return FirstNumber + SecondNumber;
        }
        public int Substract()
        {
            return FirstNumber - SecondNumber;
        }

        public int Multiply()
        {
            return FirstNumber * SecondNumber;
        }

        public float Divide()
        {
               if (SecondNumber == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero");
            }
            return FirstNumber / SecondNumber;
        }

        public int AddAll()
        {
            int result = 0;
            foreach (int number in Numbers)
            {
                result += number;
            }
            return result;
        }

        public int SubtractAll()
        {
            int result = 0;
            foreach (int number in Numbers)
            {
                result -= number;
            }
            return result;
        }

        public int MultiplyAll()
        {
            int result = 1;
            foreach (int number in Numbers)
            {
                result *= number;
            }
            return result;
        }

        public float DivideAll()
        {
            if (Numbers.Contains(0))
            {
                throw new DivideByZeroException("Cannot divide by zero");
            }
            float result = Numbers[0];
            for (int i = 1; i < Numbers.Count; i++)
            {
                result /= Numbers[i];
            }
            return result;
        }
    }
}