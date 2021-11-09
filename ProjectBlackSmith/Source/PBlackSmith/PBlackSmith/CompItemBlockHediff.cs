using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Verse;
using RimWorld;

namespace PBlackSmith
{
    public class CompItemBlockHediff : ThingComp
    {
        private CompProperties_ItemBlockHediff Props => (CompProperties_ItemBlockHediff)props;

        //pas bon, simple idée à revoir
        protected void Block(Hediff hediffToAdd)
        {
            Pawn p =  hediffToAdd.pawn;
            foreach (HediffDef defs in Props.hediffImmuneTo)
            {
                if (hediffToAdd.def != defs)
                {
                    p.health.AddHediff(hediffToAdd);
                }
            }
        }

    }
}
