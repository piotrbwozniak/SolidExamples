namespace SolidExamples._3._Liskov_Substitution
{
    class Sparrow : Bird
    {
        public override void Fly()
        {
            Console.WriteLine("Sparrow is flying");
        }
    }
}