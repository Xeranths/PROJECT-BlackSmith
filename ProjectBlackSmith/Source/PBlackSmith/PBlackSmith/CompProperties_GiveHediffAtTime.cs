using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RimWorld;
using Verse;

namespace PBlackSmith
{
    class CompProperties_GiveHediffAtTime : CompProperties
    {
        public CompProperties_GiveHediffAtTime()
        {
            this.compClass = typeof(PBlackSmith.CompGiveHediffAtTime);
        }

        public HediffDef hediffToAdd;

        public int timeNight = 22;

        public int timeMorning = 6;

    }
}
