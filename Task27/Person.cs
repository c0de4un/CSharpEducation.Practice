
namespace Task27
{
    public class Person
    {
        public int mAge;
        public string mName;
        public string mCompanyName;

        public Person()
        {
        }

        public Person(int age, string name, string companyName)
        {
            mAge = age;
            mName = name;
            mCompanyName = companyName;
        }

        public Person(int age, string name)
        {
            mAge = age;
            mName = name;
            mCompanyName = "Undefined";
        }
    }
}