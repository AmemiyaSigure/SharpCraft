using SharpCraft.Game.Enumerates;

namespace SharpCraft.Game.Nbt
{
    public class NbtTagEnd : NbtBase
    {
        public override NbtType Type => NbtType.End;

        public override int Id => (int)NbtType.End;
    }
}