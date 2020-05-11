using SharpCraft.Game.Enumerates;

namespace SharpCraft.Game.Nbt
{
    public class NbtTagString : NbtBase
    {
        public override NbtType Type => NbtType.String;

        public override int Id => (int) NbtType.String;

        public string Value { get; set; }

        public NbtTagString(string value)
        {
            Value = value;
        }
    }
}