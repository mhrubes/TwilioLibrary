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
    "+YourTwilioPhoneNumber");

// Create message
var message = new SmsMessage
{
    RecipientNumber = "+PHONE_NUMBER",
    Body = "Hello from Twilio!"
};

// Send message
bool isSent = gateway.SendSms(message);

// Checking message
string msg = isSent ? "SMS was sent successfully." : "Failed to send SMS.";
Console.WriteLine(msg);

Console.ReadLine();
```
