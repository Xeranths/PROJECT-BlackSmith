using Verse;

namespace PBlackSmith
{
    public class ModExtension_HediffBullet : DefModExtension
    {
        public float addHediffChance = 1.0f;
        public HediffDef hediffToAdd;
        public float minSeverity = 0f;
        public float maxSeverity = 1f;
    }
}
