
namespace AvoChocarithms.SectionA.DataStructures2.Models
{
    public class PersonInfo
    {
        public string FirstName { get; }

        public string LastName { get; }

        public PersonInfo(string FirstName, string LastName)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
        }

        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName}";
        }
    }
}
