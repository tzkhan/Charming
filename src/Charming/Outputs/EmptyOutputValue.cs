#pragma warning disable SA1600
namespace Charming
{
    internal class EmptyOutputValue : OutputValue
    {
        public override bool HasValue => false;
    }
}
