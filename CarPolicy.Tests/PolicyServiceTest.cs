namespace CarPolicy.Tests
{
    using Controllers;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class PolicyServiceTest
    {
        [TestMethod]
        public void GetPolicySuccessfulTest()
        {
            //Arrange
            var controller = new PolicyController(new TestStorageAppContext());

            //Act 

            //Assert
        }
    }
}
