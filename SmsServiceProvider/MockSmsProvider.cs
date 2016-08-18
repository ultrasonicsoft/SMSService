using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mitto.SMSService.Models;

namespace Mitto.SMSService.Providers
{
    public class MockSmsProvider : ISmsProvider
    {
        public State SendSms(SmsParams newSmsParams)
        {
            State status = State.Success;
            return status;
        }
    }
}
