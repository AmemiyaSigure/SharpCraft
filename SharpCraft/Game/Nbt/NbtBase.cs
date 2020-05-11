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
        // Todo: Parent and Name are not used so far.
        public NbtBase Parent { get; internal set; }
        public string Name { get; set; }
        
        public abstract NbtType Type { get; }
        public abstract int Id { get; }

        public bool HasValue { 
            get
            {
                switch (Type)
                {
                    case NbtType.Compound:
                    case NbtType.Unknown:
                    case NbtType.End:
                    case NbtType.List:
                        return false;
                    default:
                        return true;
                }
            }
        }
    }
}
