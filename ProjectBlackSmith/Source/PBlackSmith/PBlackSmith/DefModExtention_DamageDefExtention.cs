using RimWorld;
using System.Collections.Generic;
using Verse;

namespace PBlackSmith
{
    public class DamageDefExtension : DefModExtension
    {

        public static readonly DamageDefExtension defaultValues = new DamageDefExtension();

        // For DamageWorker_BluntPowerFist
        public float knockbackDistancePerDamageDealt;
        public bool scaleKnockbackWithBodySize;
        public float hitBuildingStunDurationFactor;

        // Can be applied to any DamageDef
        public int stunDuration;

    }
}

//https://github.com/Endgegner/RimWorld-Mod-Cybernetic-Warfare-and-Special-Weapons/blob/master/Source/DefModExtensions/DamageDefExtension.cs