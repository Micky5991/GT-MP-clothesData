using System.Collections.Generic;
using clothInfoGen.data;
using GTA;

namespace clothInfoGen
{
    public class Storage
    {
        public Dictionary<int, PedData> pedData = new Dictionary<int, PedData>();


        public PedData AddPed(PedHash ped, PedData data)
        {
            data.Hash();
            if (this.pedData.ContainsKey((int) ped)) return this.pedData[(int) ped];

            this.pedData.Add((int) ped, data);

            return data;
        }
        
    }
}