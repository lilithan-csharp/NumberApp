using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberApp
{
    public interface INumberAppService
    {
        void AddNumberToList(int num);

        decimal GetTotalNumbers();

        decimal GetAverage();  
        decimal GetHighestNumber();
    }
}
