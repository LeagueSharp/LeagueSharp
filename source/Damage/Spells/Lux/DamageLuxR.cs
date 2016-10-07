// <copyright file="DamageLuxR.cs" company="LeagueSharp">
// Copyright (c) LeagueSharp. All rights reserved.
// </copyright>

namespace LeagueSharp.Common.Spells
{
    using System.ComponentModel.Composition;

    /// <summary>
    ///     Spell Damage, Lux R.
    /// </summary>
    [Export(typeof(IDamageSpell))]
    [ExportDamageMetadata("Lux", SpellSlot.R)]
    public class DamageLuxR : DamageSpell
    {
        #region Constructors and Destructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="DamageLuxR" /> class.
        /// </summary>
        public DamageLuxR()
        {
            this.Slot = SpellSlot.R;
            this.DamageType = Common.Damage.DamageType.Magical;
        }

        #endregion

        #region Methods

        /// <inheritdoc />
        protected override double GetDamage(Obj_AI_Base source, Obj_AI_Base target, int level)
        {
            return new double[] { 300, 400, 500 }[level] + (0.75 * source.TotalMagicalDamage);
        }

        #endregion
    }
}