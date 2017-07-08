using System.Collections.Generic;
using clothInfoGen.interfaces;
using GTA;

namespace clothInfoGen.data
{
    public class PedData : IHashable
    {

        public PedHash hash;
        public string name;
        
        public Dictionary<int, ClothSlotData> slots = new Dictionary<int, ClothSlotData>();


        public void Hash()
        {
            //this.hash = (PedHash) Game.GenerateHash(this.name);
        }
    }
}