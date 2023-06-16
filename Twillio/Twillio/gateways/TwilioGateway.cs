using System;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twillio.models;

namespace Twillio.gateways
{
    public class TwilioGateway : ISmsGateway
    {
        private readonly string accountSid;
        private readonly string authToken;
        private readonly string phoneNumber;

        public TwilioGateway(string accountSid, string authToken, string phoneNumber)
        {
            this.accountSid = accountSid;
            this.authToken = authToken;
            this.phoneNumber = phoneNumber;
        }

        public bool SendSms(SmsMessage smsMessage)
        {
            try
            {
                TwilioClient.Init(accountSid, authToken);

                var message = MessageResource.Create(
                    body: smsMessage.Body,
                    from: new Twilio.Types.PhoneNumber(phoneNumber),
                    to: new Twilio.Types.PhoneNumber(smsMessage.RecipientNumber)
                );

                return message != null;
            }
            catch (Exception ex)
            {
                // Handle any exceptions here
                Console.WriteLine(ex.ToString());
                return false;
            }
        }
    }
}
