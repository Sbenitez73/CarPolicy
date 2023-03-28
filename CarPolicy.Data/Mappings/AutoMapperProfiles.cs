namespace CarPolicy.Data.Mappings
{
    using AutoMapper;    

    public class AutoMapperProfiles: Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Dtos.Policy, Domain.Entities.Policy>();
        }
    }
}
