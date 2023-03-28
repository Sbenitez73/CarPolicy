using System;

namespace CarPolicy.Domain.Entities
{
    public class Policy
    {
        public int Id { get; set; }
        public string ClientName { get; set; }
        public string ClientIdentification { get; set; }
        public DateTime ClientBirhDate { get; set; }
        public string ClientCity { get; set; }
        public string ClientAddress { get; set; }
        public string CarRegistration { get; set; }
        public string CarModel { get; set; }
        public bool CarInspected { get; set; }
        public DateTime TakenPolicyDate { get; set; }
        public int CoveredHedges { get; set; }
        public double MaxValueCovered { get; set; }
        public string PolicyName { get; set; }
        public int PolicyId { get; set; }
    }
}
