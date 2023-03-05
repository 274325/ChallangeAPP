using System.Reflection.Metadata;

namespace ChalangeAPP.Tests
{
    public class Tests
    {
            [Test]
        public void WhenEmployeeAddScore_ShouldResultSum()
        {
            //arrange
            var employee1 = new Employee("Kiki", 23, "Mouse");

            employee1.AddScore(9);
            employee1.AddScore(2);
            employee1.AddScore(-7);

            //act

            var result = employee1.Result;


            //assert
            Assert.AreEqual(11, result);
        }
    }
}