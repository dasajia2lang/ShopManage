using System;

namespace ShopManageContact
{
    public class Order
    {
        public long Id { get; set; }

        public decimal OrderAmount { get; set; }

        public DateTime OrderDate { get; set; }

        public long MemberId { get; set; }


        public string MemberName { get; set; }
    }
}
