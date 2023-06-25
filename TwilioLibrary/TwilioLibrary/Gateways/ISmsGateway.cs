using TwilioLibrary.Models;

namespace TwilioLibrary.Gateways
{
    public interface ISmsGateway
    {
        string SendSms(SmsMessage smsMessage);
    }
}
