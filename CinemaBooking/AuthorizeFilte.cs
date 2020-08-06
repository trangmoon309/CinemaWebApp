using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Filters;

namespace CinemaBooking
{
    internal class AuthorizeFilte : IFilterMetadata
    {
        private AuthorizationPolicy policy;

        public AuthorizeFilte(AuthorizationPolicy policy)
        {
            this.policy = policy;
        }
    }
}