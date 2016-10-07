// <copyright file="DamageEzrealW.cs" company="LeagueSharp">
// Copyright (c) LeagueSharp. All rights reserved.
// </copyright>

namespace LeagueSharp.Common.Spells
{
    using System.ComponentModel.Composition;

    /// <summary>
    ///     Spell Damage, Ezreal W.
    /// </summary>
    [Export(typeof(IDamageSpell))]
    [ExportDamageMetadata("Ezreal", SpellSlot.W)]
    public class DamageEzrealW : DamageSpell
    {
        #region Constructors and Destructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="DamageEzrealW" /> class.
        /// </summary>
        public DamageEzrealW()
        {
            this.Slot = SpellSlot.W;
            this.DamageType = Common.Damage.DamageType.Magical;
        }

        #endregion

        #region Methods

        /// <inheritdoc />
        protected override double GetDamage(Obj_AI_Base source, Obj_AI_Base target, int level)
        {
            return new double[] { 70, 115, 160, 205, 250 }[level] + (0.8 * source.TotalMagicalDamage);
        }

        #endregion
    }
}