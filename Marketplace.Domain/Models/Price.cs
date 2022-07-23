using Marketplace.Domain.Services;

namespace Marketplace.Domain.Models
{
    public class Price:Money
    {
        private Price(decimal amount, string currencyCode, ICurrencyLookup currencyLookup):base(amount, currencyCode, currencyLookup)
        {

        }
    }
}