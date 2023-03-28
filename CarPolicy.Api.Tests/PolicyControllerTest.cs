using CarPolicy.Api.Tests.Mocks;
using CarPolicy.Controllers;
using CarPolicy.Domain.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CarPolicy.Api.Tests
{
    [TestClass]
    public class PolicyControllerTest: Base
    {
        [TestMethod]
        public async Task GetPolicySuccessfulTest()
        {
            //Arrage
            var mapper = BuildMapper();
            var context = BuildContext();

            IEnumerable<Policy> policies = PolicyMocker.GetTwoDiferentsPolicies();

            context.Policies.Add( policies.First() );
            await context.SaveChangesAsync();

            var secondContext = BuildContext();

            //Assert
            var controller = new PolicyController(secondContext, mapper);
            var response = await controller.GetPolicy( "20" );

            //Act
            var policie = response.Value;
            Assert.IsNotNull( policie );
        }

        public async Task NotFoundPolicySuccessfulTest()
        {
            //Arrage
            var mapper = BuildMapper();
            var context = BuildContext();

            IEnumerable<Policy> policies = PolicyMocker.GetTwoDiferentsPolicies();

            context.Policies.AddRange(policies);
            await context.SaveChangesAsync();

            var secondContext = BuildContext();

            //Assert
            var controller = new PolicyController(secondContext, mapper);
            var response = await controller.GetPolicy("23");            
            //Act
            var policie = response.Value;
            Assert.IsNull(policie);
        }

        public async Task GetByDuplicatedRecordSuccessfulTest()
        {
            //Arrage
            var mapper = BuildMapper();
            var context = BuildContext();

            IEnumerable<Policy> policies = PolicyMocker.GetTwoDiferentsPoliciesWithDiferentCarRegistration();

            context.Policies.AddRange(policies);
            await context.SaveChangesAsync();

            var secondContext = BuildContext();

            //Assert
            var controller = new PolicyController(secondContext, mapper);
            var response = await controller.GetPolicy("DEF-456");
            //Act
            var policie = response.Value;
            Assert.IsNotNull(policie);
        }
    }
}
