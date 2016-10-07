// <copyright file="DamageLuxQ.cs" company="LeagueSharp">
// Copyright (c) LeagueSharp. All rights reserved.
// </copyright>

namespace LeagueSharp.Common.Spells
{
    using System.ComponentModel.Composition;

    /// <summary>
    ///     Spell Damage, Lux Q.
    /// </summary>
    [Export(typeof(IDamageSpell))]
    [ExportDamageMetadata("Lux", SpellSlot.Q)]
    public class DamageLuxQ : DamageSpell
    {
        #region Constructors and Destructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="DamageLuxQ" /> class.
        /// </summary>
        public DamageLuxQ()
        {
            this.Slot = SpellSlot.Q;
            this.DamageType = Common.Damage.DamageType.Magical;
        }

        #endregion

        #region Methods

        /// <inheritdoc />
        protected override double GetDamage(Obj_AI_Base source, Obj_AI_Base target, int level)
        {
            return new double[] { 50, 100, 150, 200, 250 }[level] + (0.7 * source.TotalMagicalDamage);
        }

        #endregion
    }
}