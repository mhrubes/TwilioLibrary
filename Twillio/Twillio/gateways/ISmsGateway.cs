using Twillio.models;

namespace Twillio.gateways
{
    public interface ISmsGateway
    {
        bool SendSms(SmsMessage smsMessage);
    }
}