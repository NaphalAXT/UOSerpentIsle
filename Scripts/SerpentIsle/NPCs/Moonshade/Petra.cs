using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Server.Items;

namespace Server.Mobiles
{
    class Petra : TalkingBaseCreature
    {
        [Constructable]
        public Petra() : base(AIType.AI_Mage, FightMode.None, 5, 1, 0.1, 0.2)
        {
            Name = "Petra";
            Female = true;
            InitBody();
            SetHits(HitsMax);
        }

        public Petra(Serial serial) : base(serial)
        {
        }

        public void InitBody()
        {
            Body = 0x191;
            Hue = 996;
            SpeechHue = Utility.RandomDyedHue();

            InitOutfit();
        }

        public void InitOutfit()
        {
            Item hair = new Item(8252)
            {
                Hue = 1102,
                Layer = Layer.Hair,
                Movable = false
            };
            AddItem(hair);            

            PackGold(50, 200);
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.Write((int)0); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadInt();
        }
    }
}
