namespace Mitto.SmsDbManager
{
    public interface ISmsDbManager
    {
        bool StoreSmsInDatabase(Sms newSms);
    }
}