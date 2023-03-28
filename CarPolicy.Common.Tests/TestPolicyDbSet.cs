namespace CarPolicy.Common.Tests
{
    using Context;
    using Domain.Entities;
    using System.Linq;

    public class TestPolicyDbSet: TestDbSet<Policy>
    {
        public override Policy Find(params object[] keyValues)
        {
            return this.SingleOrDefault(p => p.Id == (int)keyValues.Single());
        }
    }
}
