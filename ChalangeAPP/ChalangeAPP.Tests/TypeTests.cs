

namespace ChalangeAPP.Tests
{
    public class TypeTests
    {
        [Test]
        public void GetValueTypeInt_ShouldResultCorrect()
        {
            //arrange
            int serialNumber1 = 9;
            int serialNumber2 = 9;

            //act

            //assert
            Assert.AreEqual(serialNumber1, serialNumber2);
        }

        [Test]
        public void GetValueTypeString_ShouldResultCorrect()
        {
            //arrange
            string SureName1 = "Brzęczyszczykiewicz";
            string SureName2 = "Brzęczyszczykiewicz";

            //act

            //assert
            Assert.AreEqual(SureName1, SureName2);
        }


        [Test]
        public void GetValueTypeVar_ShouldResultCorrect()
        {
            //arrange
            var user1 = GetUser("Grzegorz");
            var user2 = GetUser("Szymon");

            //act

            //assert
            Assert.AreNotEqual(user1, user2);   
        }

        private User GetUser(string SureName)
        {
            return new User(SureName);
        }
    }
}
