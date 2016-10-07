// <copyright file="DamageOriannaE.cs" company="LeagueSharp">
// Copyright (c) LeagueSharp. All rights reserved.
// </copyright>

namespace LeagueSharp.Common.Spells
{
    using System.ComponentModel.Composition;

    /// <summary>
    ///     Spell Damage, Orianna E.
    /// </summary>
    [Export(typeof(IDamageSpell))]
    [ExportDamageMetadata("Orianna", SpellSlot.E)]
    public class DamageOriannaE : DamageSpell
    {
        #region Constructors and Destructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="DamageOriannaE" /> class.
        /// </summary>
        public DamageOriannaE()
        {
            this.Slot = SpellSlot.E;
            this.DamageType = Common.Damage.DamageType.Magical;
        }

        #endregion

        #region Methods

        /// <inheritdoc />
        protected override double GetDamage(Obj_AI_Base source, Obj_AI_Base target, int level)
        {
            return new double[] { 60, 90, 120, 150, 180 }[level] + (0.3 * source.TotalMagicalDamage);
        }

        #endregion
    }
}