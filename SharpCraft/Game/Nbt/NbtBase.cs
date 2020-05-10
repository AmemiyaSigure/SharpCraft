using SharpCraft.Game.Enumerates;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SharpCraft.Game.Nbt
{
    /// <summary>
    /// Base class for different kinds of nbt tags.
    /// </summary>
    public abstract class NbtBase
    {
        public abstract NbtType Type { get; }

        public abstract int Id { get; }
    }
}
