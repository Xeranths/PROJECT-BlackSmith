using RimWorld;
using Verse;

namespace PBlackSmith
{
    public class Projectile_HediffBullet : Bullet
    {
        public ModExtension_HediffBullet Props => def.GetModExtension<ModExtension_HediffBullet>();
        protected override void Impact(Thing hitThing)
        {
            base.Impact(hitThing);
            //check if pawn hit and make a random launch to detemine if apply hediff (addHediffChance)
            if (Props != null && hitThing != null && hitThing is Pawn hitPawn && Rand.Range(0f, 1f) <= Props.addHediffChance)
            {
                Hediff hediffOnPawn = hitPawn.health?.hediffSet?.GetFirstHediffOfDef(Props.hediffToAdd);
                //if one of the two are used, use the piece of code following
                if (Props.minSeverity > 0f || Props.maxSeverity < 1f)
                {
                    float randomSeverity = Rand.Range(Props.minSeverity, Props.maxSeverity);  // entre 10% et 35

                    if (hediffOnPawn != null)
                    {
                        hediffOnPawn.Severity += randomSeverity;
                    }
                    else
                    {
                        Hediff hediff = HediffMaker.MakeHediff(Props.hediffToAdd, hitPawn);
                        hediff.Severity = randomSeverity;
                        hitPawn.health.AddHediff(hediff);
                    }
                }
                else  // if no severity set, use this one
                {
                    Hediff hediff = HediffMaker.MakeHediff(Props.hediffToAdd, hitPawn);
                    hitPawn.health.AddHediff(hediff);
                }
            }
        }
    }
}
