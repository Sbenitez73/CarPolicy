namespace CarPolicy.Application.Services
{
    using Domain.Entities;

    public interface IPolicyService
    {
        public Task<Policy> Get(string index);
    }
}
