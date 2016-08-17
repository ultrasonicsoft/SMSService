using System.Collections.Generic;
using SMSService.Models;

namespace SMSService.Providers
{
    public interface ICountryProvider
    {
        IList<Country> GetAllCountries();
    }
}