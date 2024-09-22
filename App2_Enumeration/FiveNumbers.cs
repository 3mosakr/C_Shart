using System.Collections;

namespace App2_Enumeration
{
    class FiveNumbers : IEnumerable
    {
        int [] _values;

        public FiveNumbers(int n1, int n2, int n3, int n4, int n5)
        {
            _values = new[] { n1, n2, n3, n4, n5 };  
        }

        public IEnumerator GetEnumerator()
        {

            foreach (var item in _values)
            {
                yield return item;
            }
        }
    }
}
