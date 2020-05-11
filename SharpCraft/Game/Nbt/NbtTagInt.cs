using SharpCraft.Game.Enumerates;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SharpCraft.Game.Nbt
{
    public class NbtTagInt : NbtBase
    {
        public override NbtType Type => NbtType.Int;

        public override int Id => (int) NbtType.Int;

        public int Value { get; set; }

        public NbtTagInt(int value)
        {
            Value = value;
        }
    }
}
