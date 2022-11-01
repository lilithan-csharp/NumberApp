using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberApp
{
  public  class NumberAppService : INumberAppService
    {
        public List<int> list = new List<int>() { };

        public void AddNumberToList(int num)
        {
           list.Add(num);
           
        }

        public decimal GetAverage()
        {
            decimal sum = GetTotalNumbers();
          
            try
            {
                decimal average = sum / list.Count;
                return average;

            }
            catch(Exception )
            {
                return 0;
            }


            //if (sum > 0)
            //{
              
            //    return average;
            //}
            //return 0;
        }

        public decimal GetHighestNumber()
        {
            decimal highest = list.Max();
            return highest;
        }

        public decimal GetTotalNumbers()
        {
            decimal total = 0;
            for (int i = 0; i < list.Count; i++)
            {
                total += list[i];
            }
            return total;
        }
    
    }
}

