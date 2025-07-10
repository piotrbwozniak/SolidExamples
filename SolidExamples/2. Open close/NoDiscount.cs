namespace SolidExamples._2._Open_close
{
    class NoDiscount : Discount
    {
        public override decimal Apply(decimal price) => price;
    }
}