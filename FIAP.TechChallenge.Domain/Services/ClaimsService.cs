using FIAP.Crosscutting.Domain.Events.Notifications;
using FIAP.Crosscutting.Domain.Helpers.Extensions;
using FIAP.Crosscutting.Domain.Helpers.Validators;
using FIAP.Crosscutting.Domain.Interfaces.Services;
using FIAP.Crosscutting.Domain.MediatR;
using FIAP.TechChallenge.Domain.Helpers.Constants;
using FIAP.TechChallenge.Domain.Interfaces.Services;
using System.Security.Claims;

namespace FIAP.TechChallenge.Domain.Services
{
    public class ClaimsService : IClaimsService
    {
        private readonly ICryptographyService _cryptographyService;
        private readonly ClaimsPrincipal _claims;
        private readonly IMediatorHandler _mediator;

        public ClaimsService(
            ICryptographyService cryptographyService,
            ClaimsPrincipal claims,
            IMediatorHandler mediator)
        {
            _cryptographyService = cryptographyService;
            _claims = claims;
            _mediator = mediator;
        }

        public Guid GetCurrentUserId()
        {
            string userId = _claims.GetUserIdFromToken();

            if (!string.IsNullOrEmpty(userId))
            {
                userId = _cryptographyService.Decrypt(userId);

                if (!Validator.IsGuid(userId))
                {
                    NotifyError(Values.Message.UserRequestNotFound);
                    return Guid.Empty;
                }
            }

            return Guid.Parse(userId);
        }

        public List<string> GetCurrentUserRoles()
        {
            var roles = _claims.GetRolesFromToken();

            if (!roles?.Any() ?? false)
            {
                NotifyError(Values.Message.UserRequestNotFound);
                return null;
            }

            return roles.Select(x => _cryptographyService.Decrypt(x)).ToList();
        }

        protected void NotifyError(string message) => NotifyError(string.Empty, message);

        protected void NotifyError(string code, string message)
        {
            _mediator.PublishEvent(new DomainNotification(code, message));
        }
    }
}
