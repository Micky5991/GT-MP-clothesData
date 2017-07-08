using clothInfoGen.data;
using GTA;
using GTA.Native;

namespace clothInfoGen.processors
{
    public class PedStyleSlotProcessor
    {

        public static void Process(Ped ped, int component, PedComponent slot, ClothSlotData slotData)
        {
            slotData.drawableCount = slot.Count;
            slotData.variationCount = new int[slotData.drawableCount];
            for (int dr = 0; dr < slotData.drawableCount; dr++)
            {
                slotData.variationCount[dr] =
                    Function.Call<int>(Hash.GET_NUMBER_OF_PED_TEXTURE_VARIATIONS, ped.Handle, component, dr) + 1;
            }
        }
        
    }
}