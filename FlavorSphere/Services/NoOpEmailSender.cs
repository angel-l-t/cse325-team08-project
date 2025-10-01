using Microsoft.AspNetCore.Identity.UI.Services;

namespace FlavorSphere.Services;

public class NoOpEmailSender : IEmailSender
{
    public Task SendEmailAsync(string email, string subject, string htmlMessage)
    {
        // This is a no-op implementation. It does nothing.
        return Task.CompletedTask;
    }
}