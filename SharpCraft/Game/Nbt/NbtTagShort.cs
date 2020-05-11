using SharpCraft.Game.Enumerates;

namespace SharpCraft.Game.Nbt
{
    public class NbtTagShort : NbtBase
    {
        public override NbtType Type => NbtType.Short;
        
        public override int Id => (int) NbtType.Short;

        public short Value { get; set; }

        public NbtTagShort(short value)
        {
            Value = value;
        }
    }
}