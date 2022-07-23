using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marketplace.Domain.Models
{
    public class ClassifiedAdTitle
    {
        public Guid Value { get; set; }
        public ClassifiedAdTitle(string value) => Value = Value;
    }
}
