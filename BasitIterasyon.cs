using System;
using System.Collections;
using System.Collections.Generic;

namespace Calisma36_Yield
{
    class BasitIterasyon : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return 1;
            yield return 2;
            yield return 3;
        }
    }
    
}
