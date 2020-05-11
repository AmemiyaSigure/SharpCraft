using System;
using System.Collections.Generic;
using SharpCraft.Game.Enumerates;

namespace SharpCraft.Game.Nbt
{
    public class NbtTagLongArray : NbtBase
    {
        public override NbtType Type => NbtType.LongArray;

        public override int Id => (int) NbtType.LongArray;

        private List<long> Array = new List<long>();

        public long Get(int index)
        {
            if (Array.Count < index)
            {
                throw new ArgumentOutOfRangeException(nameof(index), $"There is no element with index {index}.");
            }

            return Array[index];
        }

        public void Add(long l)
        {
            Array.Add(l);
        }

        public void Set(int index, long l)
        {
            if (Array.Count < index)
            {
                throw new ArgumentOutOfRangeException(nameof(index), $"Index {index} is too large to set.");
            }

            Array[index] = l;
        }

        public long[] GetArray()
        {
            return Array.ToArray();
        }

        public void SetArray(long[] array)
        {
            Array = new List<long>(array);
        }
        
        public long this[int index]
        {
            get { return Get(index); }
            set { Set(index, value); }
        }
    }
}