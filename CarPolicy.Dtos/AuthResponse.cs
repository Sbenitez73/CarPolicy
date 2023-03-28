using System;

namespace CarPolicy.Dtos
{
    public class AuthResponse
    {
        public string Token { get; set; }
        public DateTime ExpirationDate { get; set; }
    }
}
