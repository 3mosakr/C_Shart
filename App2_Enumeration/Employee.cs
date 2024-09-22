namespace App2_Enumeration
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Employee(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public override bool Equals(object? obj)
        {
            if (obj == null || !(obj is Employee))
                return false;

            var emp = obj as Employee;

            return this.Id == emp.Id && this.Name == emp.Name;
            
        }

        public override int GetHashCode()
        {
            int hash = 7;
            hash = hash * 7 + Id.GetHashCode();
            hash = hash * 7 + Name.GetHashCode();
            return hash;

        }
    }

}
