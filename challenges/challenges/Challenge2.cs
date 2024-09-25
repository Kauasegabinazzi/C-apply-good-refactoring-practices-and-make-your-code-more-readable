using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenges
{
    internal class Challenge2
    {

        public double Average(List<double> numbers)
        {
            return Sum(numbers) / numbers.Count;
        }

        private double Sum(List<double> numbers)
        {
            double sum = 0.0;
            foreach (double n in numbers)
            {
                sum += n;
            }
            return sum;
        }

        public double Median(List<double> numbers)
        {
            List<double> sorted = new List<double>(numbers);
            sorted.Sort();
            int meio = sorted.Count / 2;
            if (sorted.Count % 2 == 0)
            {
                return (sorted[meio - 1] + sorted[meio]) / 2.0;
            }
            else
            {
                return sorted[meio];
            }
        }
    }
}
