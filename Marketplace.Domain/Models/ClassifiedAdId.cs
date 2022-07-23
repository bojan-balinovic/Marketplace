using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marketplace.Domain.Models
{
    public class ClassifiedAdId
    {
        public Guid Value { get; set; }
        public ClassifiedAdId(Guid id)
        {
            if(id == Guid.Empty || id == default)
            {
                throw new ArgumentNullException(nameof(id),"Classified Ad id cannot be empty");
            }
            Value=id;
        } 
    }
}
