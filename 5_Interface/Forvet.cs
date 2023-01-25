using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Interface
{
    public class Forvet:BaseFutbolcu,IFutbolcu
    {

        public void PenaltiKullan()
        {

        }

        public void GolAt()
        {

        }

        public void Kos()
        {
            throw new NotImplementedException();
        }

        public void SutCek()
        {
            throw new NotImplementedException();
        }

        public void PasVer()
        {
            throw new NotImplementedException();
        }

        public void CalimAt()
        {
            throw new NotImplementedException();
        }
    }
}
