using System;
using System.Runtime.Serialization;

namespace CarPolicy.Dtos
{
    [DataContract]
    public class Policy
    {
        [DataMember( Name = "id" )]
        public int Id { get; set; }

        [DataMember(Name = "clientName")]
        public string ClientName { get; set; }

        [DataMember(Name = "clientId")]
        public string ClientIdentification { get; set; }

        [DataMember(Name = "clientBirthDate")]
        public DateTime ClientBirhDate { get; set; }

        [DataMember(Name = "clientCity")]
        public string ClientCity { get; set; }

        [DataMember(Name = "clientAddress")]
        public string ClientAddress { get; set; }

        [DataMember(Name = "carRegistration")]
        public string CarRegistration { get; set; }

        [DataMember(Name = "carModel")]
        public string CarModel { get; set; }

        [DataMember(Name = "carInspected")]
        public bool CarInspected { get; set; }

        [DataMember(Name = "takenPolicyDate")]
        public DateTime TakenPolicyDate { get; set; }

        [DataMember(Name = "coveredHedges")]
        public int CoveredHedges { get; set; }

        [DataMember(Name = "maxValueCovered")]
        public double MaxValueCovered { get; set; }

        [DataMember(Name = "policyName")]
        public string PolicyName { get; set; }
    }
}
