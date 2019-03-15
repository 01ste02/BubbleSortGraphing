namespace Övning_12._2
{
    class Bubblesort
    {
        public Bubblesort ()
        {
        }

        public int[] Sort (int[] toSort)
        {
            for (int i = toSort.Length - 1; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (toSort[j] > toSort[j + 1])
                    {
                        int temp = toSort[j];
                        toSort[j] = toSort[j + 1];
                        toSort[j + 1] = temp;
                    }
                }
            }

            return toSort;
        }

    }
}
