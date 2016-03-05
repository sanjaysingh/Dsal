using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dsal
{
    public abstract class AlgorithmBase : IAlgorithm
    {
        public void Execute()
        {
            this.OnExecute();
        }

        protected abstract void OnExecute();

    }
}
