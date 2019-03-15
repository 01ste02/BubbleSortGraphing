using System;

namespace Övning_12._2
{
    class GenerateNumbers
    {
        public GenerateNumbers()
        {

        }

        public int[] Generate (Random random, int numValues, int minValue = 0, int maxValue = 0)
        {
            int[] randomNumbers = new int[numValues];

            for (int i = 0; i < numValues; i++)
            {
                if (minValue != 0 && maxValue != 0)
                {
                    randomNumbers[i] = random.Next(minValue, maxValue);
                }
                else if (minValue == 0 && maxValue != 0)
                {
                    randomNumbers[i] = random.Next(maxValue);
                }
                else
                {
                    randomNumbers[i] = random.Next();
                }
            }

            return randomNumbers;
        }
    }
}
