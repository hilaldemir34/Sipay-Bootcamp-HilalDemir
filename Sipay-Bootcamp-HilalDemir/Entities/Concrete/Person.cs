using Sipay_Bootcamp_HilalDemir.Entities.Abstract;

namespace Sipay_Bootcamp_HilalDemir.Entities.Concrete
{
    public class Person:IEntity
    {
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string Phone { get; set; }
        public int AccessLevel { get; set; }
        public decimal Salary { get; set; }
    }
}
