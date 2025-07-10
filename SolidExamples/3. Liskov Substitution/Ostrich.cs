namespace SolidExamples._3._Liskov_Substitution
{
    class Ostrich : Bird
    {
        // BAD: Ostrich can't fly, so overriding Fly with an exception breaks LSP.
        public override void Fly()
        {
            throw new NotSupportedException("Ostrich can't fly!");
        }
    }
}