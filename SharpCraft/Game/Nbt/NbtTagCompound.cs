using SharpCraft.Game.Enumerates;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

namespace SharpCraft.Game.Nbt
{
    public class NbtTagCompound : NbtBase
    {
        public override NbtType Type => NbtType.Compound;

        public override int Id => (int) NbtType.Compound;
        
        private readonly Dictionary<string, NbtBase> Tags = new Dictionary<string, NbtBase>();
        
        public bool HasTags()
        {
            return Tags.Count > 0;
        }

        public bool HasKey(string key)
        {
            return Tags.ContainsKey(key);
        }

        public NbtBase Get(string name)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            
            if (HasKey(name))
            {
                return Tags[name];
            }
            return null;
        }

        public T Get<T>(string name) where T : NbtBase
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            if (HasKey(name))
            {
                var value = Tags[name];
                if (value is T)
                {
                    return value as T;
                }
            }
            
            return null;
        }
        
        public void Set(string name, NbtBase value)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            if (value == this)
            {
                throw new InvalidOperationException("A nbt tag compound cannot contains itself. Why do that?");
            }
            Tags[name] = value;
        }
        
        public NbtBase this[string name]
        {
            get { return Get(name); }
            set { Set(name, value); }
        }
    }
}
