using System;
using System.Collections.Generic;
using SharpCraft.Game.Enumerates;

namespace SharpCraft.Game.Nbt
{
    public class NbtTagIntArray : NbtBase
    {
        public override NbtType Type => NbtType.IntArray;

        public override int Id => (int) NbtType.IntArray;

        private List<int> Array = new List<int>();

        public int Get(int index)
        {
            if (Array.Count < index)
            {
                throw new ArgumentOutOfRangeException(nameof(index), $"There is no element with index {index}.");
            }

            return Array[index];
        }

        public void Add(int i)
        {
            Array.Add(i);
        }

        public void Set(int index, int i)
        {
            if (Array.Count < index)
            {
                throw new ArgumentOutOfRangeException(nameof(index), $"Index {index} is too large to set.");
            }

            Array[index] = i;
        }

        public int[] GetArray()
        {
            return Array.ToArray();
        }

        public void SetArray(int[] array)
        {
            Array = new List<int>(array);
        }
        
        public int this[int index]
        {
            get { return Get(index); }
            set { Set(index, value); }
        }
    }
}