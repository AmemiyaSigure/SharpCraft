using System;
using System.Collections.Generic;
using SharpCraft.Game.Enumerates;

namespace SharpCraft.Game.Nbt
{
    public class NbtTagList<T> : NbtBase where T : NbtBase
    {
        public override NbtType Type => NbtType.List;

        public override int Id => (int)NbtType.List;

        private readonly List<T> Tags = new List<T>();
        
        public bool HasTags()
        {
            return Tags.Count > 0;
        }
        
        public T Get(int index)
        {
            if (Tags.Count < index)
            {
                throw new ArgumentOutOfRangeException(nameof(index), $"There is no element with index {index}.");
            }

            return Tags[index];
        }

        public void Add(T i)
        {
            Tags.Add(i);
        }

        public void Set(int index, T i)
        {
            if (Tags.Count < index)
            {
                throw new ArgumentOutOfRangeException(nameof(index), $"Index {index} is too large to set.");
            }

            Tags[index] = i;
        }

        public T[] GetArray()
        {
            return Tags.ToArray();
        }

        public T this[int index]
        {
            get { return Get(index); }
            set { Set(index, value); }
        }
    }
}