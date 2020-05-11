namespace SharpCraft.Game.Nbt.Extensions
{
    public static class NbtCompound
    {
        public static byte GetByte(this NbtTagCompound nbt, string name)
        {
            return nbt.Get<NbtTagByte>(name).Value;
        }
        
        public static void SetByte(this NbtTagCompound nbt, string name, byte value)
        {
            nbt.Set(name, new NbtTagByte(value));
        }
        
        public static short GetShort(this NbtTagCompound nbt, string name)
        {
            return nbt.Get<NbtTagShort>(name).Value;
        }
        
        public static void SetShort(this NbtTagCompound nbt, string name, short value)
        {
            nbt.Set(name, new NbtTagShort(value));
        }
        
        public static int GetInt(this NbtTagCompound nbt, string name)
        {
            return nbt.Get<NbtTagInt>(name).Value;
        }
        
        public static void SetInt(this NbtTagCompound nbt, string name, int value)
        {
            nbt.Set(name, new NbtTagInt(value));
        }
        
        public static long GetLong(this NbtTagCompound nbt, string name)
        {
            return nbt.Get<NbtTagLong>(name).Value;
        }

        public static void SetLong(this NbtTagCompound nbt, string name, long value)
        {
            nbt.Set(name, new NbtTagLong(value));
        }
        
        public static float GetFloat(this NbtTagCompound nbt, string name)
        {
            return nbt.Get<NbtTagFloat>(name).Value;
        }
        
        public static void SetFloat(this NbtTagCompound nbt, string name, float value)
        {
            nbt.Set(name, new NbtTagFloat(value));
        }
        
        public static double GetDouble(this NbtTagCompound nbt, string name)
        {
            return nbt.Get<NbtTagDouble>(name).Value;
        }
        
        public static void SetDouble(this NbtTagCompound nbt, string name, float value)
        {
            nbt.Set(name, new NbtTagDouble(value));
        }
        
        public static string GetString(this NbtTagCompound nbt, string name)
        {
            return nbt.Get<NbtTagString>(name).Value;
        }
        
        public static void SetString(this NbtTagCompound nbt, string name, string value)
        {
            nbt.Set(name, new NbtTagString(value));
        }
    }
}