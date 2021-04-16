using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.Exceptions
{
    [Serializable]
    public class SolutionNotFoundException : ApplicationException
    {
        public SolutionNotFoundException(string message):base(message)
        {
        }
    }
}
