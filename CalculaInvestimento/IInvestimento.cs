using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculaInvestimento
{
    public interface IInvestimento
    {
        void Investir(ContaBancaria conta);
    }
}
