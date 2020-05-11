using SharpCraft.Game.Enumerates;

namespace SharpCraft.Game.Nbt
{
    public class NbtTagLong : NbtBase
    {
        public override NbtType Type => NbtType.Long;
        
        public override int Id => (int) NbtType.Long;

        public long Value { get; set; }

        public NbtTagLong(long value)
        {
            Value = value;
        }
    }
}