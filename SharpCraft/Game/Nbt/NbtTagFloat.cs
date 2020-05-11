using SharpCraft.Game.Enumerates;

namespace SharpCraft.Game.Nbt
{
    public class NbtTagFloat : NbtBase
    {
        public override NbtType Type => NbtType.Float;
        
        public override int Id => (int) NbtType.Float;

        public float Value { get; set; }

        public NbtTagFloat(float value)
        {
            Value = value;
        }
    }
}