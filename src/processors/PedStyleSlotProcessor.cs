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
            for (int dr = 0; dr < slotData.drawableCount; dr++)
            {
                if (slot.SetVariation(dr))
                {
                    var drData = new ClothDrawableData
                    {
                        textureCount = slot.TextureCount
                    };
                    slotData.drawables.Add(dr, drData);

                    for (int t = 0; t < slot.TextureCount; t++)
                    {
                        if (slot.SetVariation(dr, t))
                        {
                            drData.textures.Add(t, new ClothTextureData
                            {
                                id = t,
                                hash = Function.Call<uint>(Hash.GET_HASH_NAME_FOR_COMPONENT, ped.Handle, component, dr, t)
                            });
                        }
                    }
                }
                
            }
        }
        
    }
}