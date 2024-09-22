namespace App2_Enumeration
{
    class Tempreture : IComparable
    {
        public int _value { get; set; }

        public Tempreture(int value)
        {
            _value = value;
        }

        public int CompareTo(object? obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException("Obj is null");
            }
            var temp = obj as Tempreture;
            if (temp is null)
            {
                throw new ArgumentException("Obj is not Temp");
            }
            return this._value.CompareTo(temp._value);
        }
    }

}
