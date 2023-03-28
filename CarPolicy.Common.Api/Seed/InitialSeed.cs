namespace CarPolicy.Common.Api.Seed
{
    using Domain.Entities;

    public static class InitialSeed
    {
        public static List<Policy> GetPolicySeed()
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
                },
                new Policy()
                {
                    Id = 22,
                    PolicyId = 3,
                    ClientName = "Juan",
                    ClientIdentification = Guid.NewGuid().ToString(),
                    ClientBirhDate = new DateTime(1998, 7, 23),
                    ClientCity = "Cali",
                    ClientAddress = "Cra 1 #34 - 11",
                    TakenPolicyDate = new DateTime(2023, 12, 1),
                    CoveredHedges = 2,
                    MaxValueCovered = 750000.00,
                    PolicyName = "Poliza de vida",
                    CarRegistration = "GHI-789",
                    CarModel = "",
                    CarInspected = false
                },
                new Policy()
                {
                    Id = 23,
                    PolicyId = 4,
                    ClientName = "Carla",
                    ClientIdentification = Guid.NewGuid().ToString(),
                    ClientBirhDate = new DateTime(1976, 1, 5),
                    ClientCity = "Barranquilla",
                    ClientAddress = "Cra 43 #21 - 85",
                    TakenPolicyDate = new DateTime(2023, 1, 2),
                    CoveredHedges = 1,
                    MaxValueCovered = 1000000.00,
                    PolicyName = "Poliza automotriz",
                    CarRegistration = "JKL-012",
                    CarModel = "Chevrolet Spark",
                    CarInspected = true
                },
                new Policy()
                {
                    Id = 24,
                    PolicyId = 5,
                    ClientName = "Pedro",
                    ClientIdentification = Guid.NewGuid().ToString(),
                    ClientBirhDate = new DateTime(1991, 11, 27),
                    ClientCity = "Cartagena",
                    ClientAddress = "Cra 5 #8 - 12",
                    TakenPolicyDate = new DateTime(2023, 11, 1),
                    CoveredHedges = 0,
                    MaxValueCovered = 300000.00,
                    PolicyName = "Poliza de hogar",
                    CarRegistration = "MNO-345",
                    CarModel = "",
                    CarInspected = false
                },
                new Policy()
                {
                    Id= 25,
                    PolicyId = 6,
                    ClientName = "Ana",
                    ClientIdentification = Guid.NewGuid().ToString(),
                    ClientBirhDate = new DateTime(1995, 2, 12),
                    ClientCity = "Bogotá",
                    ClientAddress = "Cra 20 #70 - 40",
                    TakenPolicyDate = new DateTime(2023, 1, 1),
                    CoveredHedges = 1,
                    MaxValueCovered = 500000.00,
                    PolicyName = "Poliza de salud",
                    CarRegistration = "PQRS-678",
                    CarModel = "",
                    CarInspected = false
                },
                new Policy()
                {
                    Id = 26,
                    PolicyId = 7,
                    ClientName = "Luis",
                    ClientIdentification = Guid.NewGuid().ToString(),
                    ClientBirhDate = new DateTime(1980, 5, 3),
                    ClientCity = "Cali",
                    ClientAddress = "Cra 50 #10 - 25",
                    TakenPolicyDate = new DateTime(2023, 2, 14),
                    CoveredHedges = 0,
                    MaxValueCovered = 750000.00,
                    PolicyName = "Poliza de hogar",
                    CarRegistration = "TUV-901",
                    CarModel = "",
                    CarInspected = false
                },
                new Policy()
                {
                    Id = 27,
                    PolicyId = 8,
                    ClientName = "Gabriela",
                    ClientIdentification = Guid.NewGuid().ToString(),
                    ClientBirhDate = new DateTime(1997, 9, 1),
                    ClientCity = "Medellín",
                    ClientAddress = "Cra 80 #20 - 10",
                    TakenPolicyDate = new DateTime(2023, 11, 11),
                    CoveredHedges = 2,
                    MaxValueCovered = 1250000.00,
                    PolicyName = "Poliza de vida",
                    CarRegistration = "TWXYZ-234",
                    CarModel = "",
                    CarInspected = false
                },
                new Policy()
                {
                    Id = 28,
                    PolicyId = 9,
                    ClientName = "Diego",
                    ClientIdentification = Guid.NewGuid().ToString(),
                    ClientBirhDate = new DateTime(1989, 3, 19),
                    ClientCity = "Barranquilla",
                    ClientAddress = "Cra 34 #8 - 40",
                    TakenPolicyDate = new DateTime(2023, 3, 15),
                    CoveredHedges = 1,
                    MaxValueCovered = 1000000.00,
                    PolicyName = "Poliza automotriz",
                    CarRegistration = "ABXY-567",
                    CarModel = "Kia Rio",
                    CarInspected = true
                },
                new Policy()
                {
                    Id = 29,
                    PolicyId = 10,
                    ClientName = "Valentina",
                    ClientIdentification = Guid.NewGuid().ToString(),
                    ClientBirhDate = new DateTime(1994, 8, 27),
                    ClientCity = "Cartagena",
                    ClientAddress = "Cra 10 #5 - 11",
                    TakenPolicyDate = new DateTime(2023, 10, 1),
                    CoveredHedges = 0,
                    MaxValueCovered = 500000.00,
                    PolicyName = "Poliza de hogar",
                    CarRegistration = "LMNO-890",
                    CarModel = "LMNO-890",
                    CarInspected = false
                }
            };
        }
    }
}
