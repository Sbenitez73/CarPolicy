namespace CarPolicy.Api.Tests.Mocks
{
    using Domain.Entities;

    public static class PolicyMocker
    {
        public static IEnumerable<Policy> GetTwoDiferentsPolicies()
        {
            return new List<Policy>()
            {
                new Policy()
                {
                    Id = 20,
                    PolicyId = 1,
                    ClientName = "Santiago",
                    ClientIdentification = Guid.NewGuid().ToString(),
                    ClientBirhDate = new DateTime(1992, 4, 10),
                    ClientCity = "Bogotá",
                    ClientAddress = "Cra 15 #80 - 25",
                    TakenPolicyDate = new DateTime(2023, 3, 1),
                    CoveredHedges = 3,
                    MaxValueCovered = 1500000.00,
                    PolicyName = "Poliza de salud",
                    CarRegistration = "",
                    CarModel = "ABC-123",
                    CarInspected = false
                },
                new Policy()
                {
                    Id = 21,
                    PolicyId = 2,
                    ClientName = "Maria",
                    ClientIdentification = Guid.NewGuid().ToString(),
                    ClientBirhDate = new DateTime(1985, 9, 18),
                    ClientCity = "Medellín",
                    ClientAddress = "Cra 52 #62 - 30",
                    TakenPolicyDate = new DateTime(2023, 2, 15),
                    CoveredHedges = 0,
                    MaxValueCovered = 500000.00,
                    PolicyName = "Poliza de hogar",
                    CarRegistration = "DEF-456",
                    CarModel = "",
                    CarInspected = false

                }
            };
        }

        public static IEnumerable<Policy> GetTwoDiferentsPoliciesWithDiferentCarRegistration()
        {
            return new List<Policy>()
            {
                new Policy()
                {
                    Id = 20,
                    PolicyId = 1,
                    ClientName = "Santiago",
                    ClientIdentification = Guid.NewGuid().ToString(),
                    ClientBirhDate = new DateTime(1992, 4, 10),
                    ClientCity = "Bogotá",
                    ClientAddress = "Cra 15 #80 - 25",
                    TakenPolicyDate = new DateTime(2023, 3, 1),
                    CoveredHedges = 3,
                    MaxValueCovered = 1500000.00,
                    PolicyName = "Poliza de salud",
                    CarRegistration = "",
                    CarModel = "ABC-123",
                    CarInspected = false
                },
                new Policy()
                {
                    Id = 21,
                    PolicyId = 2,
                    ClientName = "Maria",
                    ClientIdentification = Guid.NewGuid().ToString(),
                    ClientBirhDate = new DateTime(1985, 9, 18),
                    ClientCity = "Medellín",
                    ClientAddress = "Cra 52 #62 - 30",
                    TakenPolicyDate = new DateTime(2023, 2, 15),
                    CoveredHedges = 0,
                    MaxValueCovered = 500000.00,
                    PolicyName = "Poliza de hogar",
                    CarRegistration = "ABC-123",
                    CarModel = "",
                    CarInspected = false

                }
            };
        }
    }
}
