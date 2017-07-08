using System.Collections.Generic;

namespace clothInfoGen.data
{
    public class ClothSlotData
    {
        public int drawableCount;
        public Dictionary<int, ClothDrawableData> drawables = new Dictionary<int, ClothDrawableData>();

    }
}