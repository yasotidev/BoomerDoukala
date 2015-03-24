using System.Threading.Tasks;
using Microsoft.AspNet.Identity;

namespace Doukala
{
    public class EmailService : IIdentityMessageService
    {
        public Task SendAsync(IdentityMessage message)
        {
            // Connectez votre service e-mail ici pour envoyer un e-mail.
            return Task.FromResult(0);
        }
    }

    public class SmsService : IIdentityMessageService
    {
        public Task SendAsync(IdentityMessage message)
        {
            // Connectez votre service SMS ici pour envoyer un message texte.
            return Task.FromResult(0);
        }
    }
}
