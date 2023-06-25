using Twilio;
using Twilio.Rest.Api.V2010.Account;
using TwilioLibrary.Models;
using TwilioLibrary.Errors;
using System.Text.RegularExpressions;

namespace TwilioLibrary.Gateways
{
    public class TwilioGateway : ISmsGateway
    {
        private readonly string accountSid;
        private readonly string authToken;
        private readonly string phoneNumber;
        private readonly int messageMaxLength;

        public TwilioGateway(string accountSid, string authToken, string phoneNumber, int messageMaxLength = 255)
        {
            this.accountSid = accountSid;
            this.authToken = authToken;
            this.phoneNumber = phoneNumber;
            this.messageMaxLength = messageMaxLength;
        }

        public string SendSms(SmsMessage smsMessage)
        {
            try
            {
                TwilioClient.Init(accountSid, authToken);

                if (smsMessage.Body.Length >= messageMaxLength)
                    return string.Format(TwilioErrorCodes.SmsMessageLengthError, messageMaxLength);

                if (!Regex.IsMatch(smsMessage.RecipientNumber, @"^\+\d+$"))
                    return string.Format(TwilioErrorCodes.RecipientNumberError, smsMessage.RecipientNumber);

                var message = MessageResource.Create(
                    body: smsMessage.Body,
                    from: new Twilio.Types.PhoneNumber(phoneNumber),
                    to: new Twilio.Types.PhoneNumber(smsMessage.RecipientNumber)
                );

                message = MessageResource.Fetch(pathSid: message.Sid);
                return message.Status.ToString();
            }
            catch (Exception ex)
            {
                // Handle any exceptions here
                Console.WriteLine(ex.ToString());
                return "Error: " + ex.Message;
            }
        }
    }
}
