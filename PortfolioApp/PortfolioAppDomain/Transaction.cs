using System;

namespace PortfolioAppDomain
{
    public class Transaction : BaseClass
    {
        public string Symbol { get; set; }
        public DateTime TradeDate { get; set; }
        public float NumberOfShares { get; set; }
        public float SharePrice { get; set; }
        public string? Notes { get; set; }
    }
}
