using System.Collections.Generic;

namespace clothInfoGen.data
{
    public class ClothDrawableData
    {
        public uint hash;
        public int textureCount;
        public Dictionary<int, ClothTextureData> textures = new Dictionary<int, ClothTextureData>();
    }
}