## TwilioLibrary
Library for sending SMS (now) and data as body of message.

[Nuget Package - **My.Custom.SMS.Library**](https://www.nuget.org/packages/My.Custom.SMS.Library/1.0.0)


**Easy to Test**
------------

```
using TwilioLibrary.Gateways;
using TwilioLibrary.Models;

// Create instance with configuration data
var gateway = new TwilioGateway(
    "YourTwilioAccountSid",
    "YourTwilioAuthToken",
    "+YourTwilioPhoneNumber",
    MESSAGE_MAX_LENGTH_NOT_OPTIONAL-DEFAULT-255);

// Create message
var message = new SmsMessage
{
    RecipientNumber = "+PHONE_NUMBER",
    Body = "Hello from this program!"
};

// Checking message
string res = gateway.SendSms(message);
Console.WriteLine(res);

Console.ReadLine();
```
