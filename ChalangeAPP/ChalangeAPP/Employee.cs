

namespace ChalangeAPP
{
    public class Employee
    {
            public List<int> score = new List<int>();
            public Employee(string name, int age, string surname)
            {
                this.Name = name;
                this.Age = age;
                this.Surname = surname;
            }

            public string Name { get; private set; }
            public int Age { get; private set; }
            public string Surname { get; private set; }

            public int Result
            {
                get
                {
                    return this.score.Sum();
                }
            }
            public void AddScore(int score)
            {
                this.score.Add(score);
            }
    }
}
