using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwilioLibrary.Models;

namespace TwilioLibrary.Gateways
{
    public interface ISmsGateway
    {
        bool SendSms(SmsMessage smsMessage);
    }
}
