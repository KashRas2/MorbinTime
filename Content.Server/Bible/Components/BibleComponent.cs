using Content.Shared.Damage;
using Robust.Shared.Audio;
using Content.Shared.FixedPoint;

namespace Content.Server.Bible.Components
{
    [RegisterComponent]
    public sealed partial class BibleComponent : Component
    {
        /// <summary>
        /// Damage that will be healed on a success
        /// </summary>
        [DataField("damage", required: true)]
        [ViewVariables(VVAccess.ReadWrite)]
        public DamageSpecifier Damage = default!;

        /// <summary>
        /// Damage that will be dealt on a failure
        /// </summary>
        [DataField("damageOnFail", required: true)]
        [ViewVariables(VVAccess.ReadWrite)]
        public DamageSpecifier DamageOnFail = default!;

        /// <summary>
        /// Damage that will be dealt when a non-chaplain attempts to heal
        /// </summary>
        [DataField("damageOnUntrainedUse", required: true)]
        [ViewVariables(VVAccess.ReadWrite)]
        public DamageSpecifier DamageOnUntrainedUse = default!;

        /// <summary>
        /// Chance the bible will fail to heal someone with no helmet
        /// </summary>
        [DataField("failChance")]
        [ViewVariables(VVAccess.ReadWrite)]
        public float FailChance = 0.34f;

        [DataField("sizzleSound")]
        public SoundSpecifier SizzleSoundPath = new SoundPathSpecifier("/Audio/Effects/lightburn.ogg");
        [DataField("healSound")]
        public SoundSpecifier HealSoundPath = new  SoundPathSpecifier("/Audio/Effects/holy.ogg");

        [DataField("locPrefix")]
        public string LocPrefix = "bible";

        // ADT Chaplain
        [DataField("healCost")]
        [ViewVariables(VVAccess.ReadWrite)]
        public FixedPoint2 HealCost = 2;
    }
}
