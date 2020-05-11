using SharpCraft.Game.Enumerates;

namespace SharpCraft.Game.Nbt
{
    public class NbtTagDouble : NbtBase
    {
        public override NbtType Type => NbtType.Double;
        
        public override int Id => (int) NbtType.Double;

        public double Value { get; set; }

        public NbtTagDouble(double value)
        {
            Value = value;
        }
    }
}