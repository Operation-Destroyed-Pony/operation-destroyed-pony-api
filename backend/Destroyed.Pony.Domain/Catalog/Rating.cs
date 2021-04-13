using System;

namespace Destroyed.Pony.Domain.Catalog
{
    public class Rating {
        public int Id { get; set; }
        public int Star { get; set; }
        public string UserName { get; set; }
        public string Review { get; set; }

        public Rating(int Id, int stars, string userName, string review)
    {
        if (stars < 1 || stars > 5)
        {
            throw new ArgumentException("Star rating must be an integer: 1, 2, 3, 4, or 5.");
        }

        if (string.IsNullOrEmpty(userName))
        {
            throw new ArgumentException("UserName cannot be null.");
        }

        this.Star = stars;
        this.UserName = userName;
        this.Review = review;
    }
    }

}