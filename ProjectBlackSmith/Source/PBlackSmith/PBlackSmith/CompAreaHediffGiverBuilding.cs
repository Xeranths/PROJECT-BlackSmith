using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Verse;
using System;
using RimWorld;

namespace PBlackSmith
{
    public class CompAreaHediffGiverBuilding : ThingComp
    {
        private CompProperties_AreaHediffGiverBuilding Props => (CompProperties_AreaHediffGiverBuilding)props;

        //search for any pawns who is colonist (ie belong to player) in area an apply hediff with optional severity
        //used for the LastStandTurret as example, in the ProjectGlitterHome (need to move it into)
        public override void CompTick()
        {
            if (!this.parent.Spawned)
            {
                return;
            }
            if (this.parent.IsHashIntervalTick(60))
            {
                foreach(Pawn pawn in this.parent.Map.mapPawns.AllPawnsSpawned)
                {
                    if (pawn.RaceProps.IsFlesh && this.parent.Position.InHorDistOf(pawn.Position,this.Props.radius) && pawn.IsColonist)
                    {
                        Hediff hediff = HediffMaker.MakeHediff(this.Props.hediff, pawn, null);
                        if (this.Props.severity > 0f)
                        {
                            hediff.Severity = this.Props.severity;
                        }
                        pawn.health.AddHediff(hediff, null, null, null);
                    }
                }
            }
        }
        private const int CheckInterval = 60;
        
    }
}
