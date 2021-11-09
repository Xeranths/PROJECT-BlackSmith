using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Verse;
using RimWorld;

namespace PBlackSmith
{
    public class CompGiveHediffAtTime : ThingComp
    {
        private CompProperties_GiveHediffAtTime Props => (CompProperties_GiveHediffAtTime)props;
        //may be false, same as BlockHediff
        protected void ApplyHediffIfNight(Pawn p)
        {
            //check if local time for entity is sup tn (night) ou inf tm (morning)
            Hediff hediff = HediffMaker.MakeHediff(Props.hediffToAdd, p);
            if (GenLocalDate.HourInteger(p) >= Props.timeNight || GenLocalDate.HourInteger(p) <= Props.timeMorning)
            {
                p.health.AddHediff(hediff);
            }
            else
            //else remove
            {
                p.health.RemoveHediff(hediff);
            }
        }
    }
}
