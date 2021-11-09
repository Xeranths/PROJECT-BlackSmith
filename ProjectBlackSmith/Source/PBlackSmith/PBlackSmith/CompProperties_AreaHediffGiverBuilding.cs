using System;
using Verse;

namespace RimWorld
{

	public class CompProperties_AreaHediffGiverBuilding : CompProperties
	{
		public CompProperties_AreaHediffGiverBuilding()
		{
			//seems it doesnt detect my comp class even in the same project, well it's ugly but solve problem --'
			this.compClass = typeof(PBlackSmith.CompAreaHediffGiverBuilding);
		}

		public HediffDef hediff;

		public float radius = 99f;

        public float severity = -1f;
	}
}
