using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marketplace.Domain.Models
{
    public class ClassifiedAd
    {
        public ClassifiedAdId Id { get; set; }
        public UserId OwnerId { get; set; }
        public ClassifiedAdTitle Title { get; set; }
        public Price Price { get; set; }
        public enum ClassifiedAdState
        {
            PendingReview,
            Active,
            Inactive,
            MarkedAsSold
        }
    }
}
