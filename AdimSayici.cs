using System;
using System.Collections;
using System.Collections.Generic;

namespace Calisma36_Yield
{
    class AdimSayici : IEnumerable<int>
    {
        public int AdimSayisi;
        public int Maksimum;
        IEnumerator<int> IEnumerable<int>.GetEnumerator()
        {
            for (int i = 0; i < Maksimum; i += AdimSayisi)
            {
                yield return i;
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return null;
        }
    }

}
