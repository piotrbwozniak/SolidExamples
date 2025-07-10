namespace SolidExamples._2._Open_close
{
    class SeasonalDiscount : Discount
    {
        private readonly decimal _percentage;
        public SeasonalDiscount(decimal percentage)
        {
            _percentage = percentage;
        }

        public override decimal Apply(decimal price) => price - price * _percentage;
    }
}
