using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marketplace.Domain.Models
{
    public class UserId
    {
        public Guid Value { get; set; }
        public UserId(Guid value)
        {
            if (value == Guid.Empty || value == default)
            {
                throw new ArgumentNullException(nameof(value), "Classified Ad id cannot be empty");
            }
            Value = value;
        }
    }
}
