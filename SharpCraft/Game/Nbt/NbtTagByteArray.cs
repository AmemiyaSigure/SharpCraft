using System;
using System.Collections.Generic;
using SharpCraft.Game.Enumerates;

namespace SharpCraft.Game.Nbt
{
    public class NbtTagByteArray : NbtBase
    {
        public override NbtType Type => NbtType.ByteArray;

        public override int Id => (int) NbtType.ByteArray;

        private List<byte> Array = new List<byte>();

        public byte Get(int index)
        {
            if (Array.Count < index)
            {
                throw new ArgumentOutOfRangeException(nameof(index), $"There is no element with index {index}.");
            }

            return Array[index];
        }

        public void Add(byte b)
        {
            Array.Add(b);
        }

        public void Set(int index, byte b)
        {
            if (Array.Count < index)
            {
                throw new ArgumentOutOfRangeException(nameof(index), $"Index {index} is too large to set.");
            }

            Array[index] = b;
        }

        public byte[] GetArray()
        {
            return Array.ToArray();
        }

        public void SetArray(byte[] array)
        {
            Array = new List<byte>(array);
        }
        
        public byte this[int index]
        {
            get { return Get(index); }
            set { Set(index, value); }
        }
    }
}