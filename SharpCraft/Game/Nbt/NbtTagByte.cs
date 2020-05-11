using SharpCraft.Game.Enumerates;

namespace SharpCraft.Game.Nbt
{
    public class NbtTagByte : NbtBase
    {
        public override NbtType Type => NbtType.Byte;
        
        public override int Id => (int) NbtType.Byte;

        public byte Value { get; set; }

        public NbtTagByte(byte value)
        {
            Value = value;
        }
    }
}