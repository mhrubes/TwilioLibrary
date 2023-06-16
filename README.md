## TwilioLibrary
Library for sending SMS (now) and data as body of message.

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
