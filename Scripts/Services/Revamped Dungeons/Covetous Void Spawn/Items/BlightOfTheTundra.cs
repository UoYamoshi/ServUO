using Server;
using System;
using System.Collections.Generic;
using Server.Mobiles;

namespace Server.Items
{
    public class BlightOfTheTundra : CompositeBow, ITokunoDyable
    {
        public override int LabelNumber { get { return 1152727; } } // Blight of the Tundra

        [Constructable]
        public BlightOfTheTundra() : this(true)
        {
        }

        [Constructable]
        public BlightOfTheTundra(bool antique)
        {
            Attributes.BonusStr = 5;
            Attributes.RegenStam = 10;
            Attributes.AttackChance = 15;
            Attributes.WeaponSpeed = 45;
            Attributes.WeaponDamage = 50;

            Slayer = BaseRunicTool.GetRandomSlayer();

            WeaponAttributes.ResistColdBonus = 15;
            AosElementDamages.Fire = 100;
            Hue = 1165;

            if (antique)
            {
                MaxHitPoints = 250;
                NegativeAttributes.Antique = 1;
            }
            else
                MaxHitPoints = 255;

            HitPoints = MaxHitPoints;
        }

        public BlightOfTheTundra(Serial serial)
            : base(serial)
        {
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);
            writer.Write(0);
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);
            int version = reader.ReadInt();
        }
    }

    public class GargishBlightOfTheTundra : SoulGlaive, ITokunoDyable
    {
        public override int LabelNumber { get { return 1152727; } } // Blight of the Tundra

        [Constructable]
        public GargishBlightOfTheTundra() : this(true)
        {
        }

        [Constructable]
        public GargishBlightOfTheTundra(bool antique)
        {
            Attributes.BonusStr = 5;
            Attributes.RegenStam = 10;
            Attributes.AttackChance = 15;
            Attributes.WeaponSpeed = 45;
            Attributes.WeaponDamage = 50;

            Slayer = BaseRunicTool.GetRandomSlayer();

            WeaponAttributes.ResistColdBonus = 15;
            AosElementDamages.Fire = 100;
            Hue = 1165;

            if (antique)
            {
                MaxHitPoints = 250;
                NegativeAttributes.Antique = 1;
            }
            else
                MaxHitPoints = 255;

            HitPoints = MaxHitPoints;
        }

        public GargishBlightOfTheTundra(Serial serial)
            : base(serial)
        {
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);
            writer.Write(0);
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);
            int version = reader.ReadInt();
        }
    }
}