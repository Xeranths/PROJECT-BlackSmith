using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RimWorld;
using Verse;

namespace PBlackSmith
{
    class CompProperties_ItemBlockHediff : CompProperties
    {
        public CompProperties_ItemBlockHediff()
        {
            //seems it doesnt detect my comp class even in the same project, well it's ugly but solve problem --'
            this.compClass = typeof(PBlackSmith.CompItemBlockHediff);
        }

        public List<HediffDef> hediffImmuneTo;

    }
}
