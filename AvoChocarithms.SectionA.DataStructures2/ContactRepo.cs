using AvoChocarithms.SectionA.DataStructures2.Models;

namespace AvoChocarithms.SectionA.DataStructures2
{
    public class ContactRepo
    {
        private Dictionary<char, IEnumerable<PersonInfo>> _contactDetails;

        public ContactRepo(string Data, string LineDelimiter = "\r\n", string FieldDelimiter = ";", bool HasHeaders = true)
        {
            this._contactDetails = new Dictionary<char, IEnumerable<PersonInfo>>();
            this.LoadContactData(Data, LineDelimiter, FieldDelimiter, HasHeaders);
        }

        private void LoadContactData(string Data, string LineDelimiter, string FieldDelimiter, bool HasHeaders)
        {
            List<string> contactDetails = Data.Split(LineDelimiter, StringSplitOptions.RemoveEmptyEntries).ToList();

            if (contactDetails.Count == 0)
            {
                return;
            }

            if (HasHeaders)
            {
                contactDetails.RemoveAt(0);
            }

            foreach (var contact in contactDetails)
            {
                string[] firstAndLastName = contact.Split(FieldDelimiter);
                string firstName = firstAndLastName[0].Trim();
                string lastName = firstAndLastName[1].Trim();
                char lastNamePageIdentifier = char.ToLower(lastName[0]);

                if (!this._contactDetails.ContainsKey(lastNamePageIdentifier))
                {
                    this._contactDetails[lastNamePageIdentifier] = new List<PersonInfo>();
                }

                List<PersonInfo> currentPage = this._contactDetails[lastNamePageIdentifier].ToList();

                currentPage.Add(new PersonInfo(firstName, lastName));

                this._contactDetails[lastNamePageIdentifier] = currentPage;
            }
        }

        public int GetContactCount()
        {
            return this._contactDetails.Sum(p => p.Value.Count());
        }

        public int GetContactPageCount()
        {
            return this._contactDetails.Count;
        }

        public IEnumerable<PersonInfo>? GetContactPage(char PageIdentifier)
        {
            PageIdentifier = char.ToLower(PageIdentifier);

            if (this._contactDetails.ContainsKey(PageIdentifier))
            {
                return this._contactDetails[PageIdentifier];
            }

            return null;
        }

        public int GetContactPageSize(char PageIdentifier)
        {
            IEnumerable<PersonInfo>? targetPage = this.GetContactPage(PageIdentifier);

            if (targetPage != null)
            {
                return targetPage.Count();
            }

            return 0;
        }

        public IEnumerable<PersonInfo>? GetContactInfoByFirstAndLastName(string FirstName, string LastName)
        {
            FirstName = FirstName.Trim();
            LastName = LastName.Trim();

            char contactPageIdentifier = LastName[0];
            IEnumerable<PersonInfo>? contactPage = this.GetContactPage(contactPageIdentifier);

            if (contactPage == null)
            {
                return null;
            }
            else
            {
                return contactPage.Where(pi => 
                    pi.FirstName.Equals(FirstName, StringComparison.InvariantCultureIgnoreCase) && 
                    pi.LastName.Equals(LastName, StringComparison.InvariantCultureIgnoreCase));
            }
        }
    }
}
