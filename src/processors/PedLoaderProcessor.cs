using System;
using clothInfoGen.data;
using GTA;

namespace clothInfoGen.processors
{
    public class PedLoaderProcessor
    {

        private static PedHash[] peds = 
        {
            PedHash.FreemodeMale01,
            PedHash.FreemodeFemale01
        };
        
        public static void Process()
        {

            foreach (var pedH in peds)
            {
                Ped ped = World.CreatePed(pedH, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 2.0f);

                if (ped != null)
                {
                    Script.Wait(100);
                    Style style = ped.Style;
                    
                    var pedData = Main.Storage.AddPed(pedH, new PedData
                    {
                        hash = pedH
                    });

                    var components = style.GetAllComponents();
                    for(int i = 0; i < components.Length; i++)
                    {
                        var slotdata = new ClothSlotData();
                        pedData.slots.Add(i, slotdata);
                        PedStyleSlotProcessor.Process(ped, i, components[i], slotdata);
                    }
                    
                    ped.Delete();
                }
            }
            
        }
        
    }
}