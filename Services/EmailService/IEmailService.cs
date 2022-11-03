namespace SendEmailApi.Services.EmailService
{
    public interface IEmailService
    {
        void SendEmail(EmailDto request);
    }
}