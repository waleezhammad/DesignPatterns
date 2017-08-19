namespace StrategyPattern.BeforeStrategy
{
    public class Order
    {
        public string Item { get; set; }
        public OrderMethod Method { get; set; }

        public double Price { get; set; }
    }

    public enum OrderMethod
    {
        UPS=1,
        Fedex=2,
        USPS=3
    }
}