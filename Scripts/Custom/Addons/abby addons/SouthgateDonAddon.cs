
////////////////////////////////////////
//                                    //
//   Generated by CEO's YAAAG - V1.2  //
// (Yet Another Arya Addon Generator) //
//                                    //
////////////////////////////////////////
using System;
using Server;
using Server.Items;

namespace Server.Items
{
	public class SouthgateDonAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {6732, 0, 0, 14}// 3	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new SouthgateDonAddonDeed();
			}
		}

		[ Constructable ]
		public SouthgateDonAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 1010, -1, 0, 23, 1910, -1, "", 1);// 1
			AddComplexComponent( (BaseAddon) this, 1008, 1, 0, 22, 1910, -1, "", 1);// 2
			AddComplexComponent( (BaseAddon) this, 1006, 0, 0, 24, 1910, -1, "", 1);// 4
			AddComplexComponent( (BaseAddon) this, 1006, 1, 0, 14, 1910, -1, "", 1);// 5
			AddComplexComponent( (BaseAddon) this, 1007, 0, 1, 0, 1910, -1, "", 1);// 6
			AddComplexComponent( (BaseAddon) this, 1006, -1, 0, 0, 1910, -1, "", 1);// 7
			AddComplexComponent( (BaseAddon) this, 1006, 0, 0, 0, 1910, -1, "", 1);// 8
			AddComplexComponent( (BaseAddon) this, 1006, -1, 0, 9, 1910, -1, "", 1);// 9
			AddComplexComponent( (BaseAddon) this, 1006, 1, 0, 19, 1910, -1, "", 1);// 10
			AddComplexComponent( (BaseAddon) this, 1006, -1, 0, 20, 1910, -1, "", 1);// 11
			AddComplexComponent( (BaseAddon) this, 1006, -1, 0, 5, 1910, -1, "", 1);// 12
			AddComplexComponent( (BaseAddon) this, 1018, 1, -1, 0, 1910, -1, "", 1);// 13
			AddComplexComponent( (BaseAddon) this, 1006, -1, 0, 14, 1910, -1, "", 1);// 14
			AddComplexComponent( (BaseAddon) this, 1017, -1, 1, 0, 1910, -1, "", 1);// 15
			AddComplexComponent( (BaseAddon) this, 1016, 1, 1, 0, 1910, -1, "", 1);// 16
			AddComplexComponent( (BaseAddon) this, 1009, -1, -1, 0, 1910, -1, "", 1);// 17
			AddComplexComponent( (BaseAddon) this, 1009, 0, -1, 0, 1910, -1, "", 1);// 18
			AddComplexComponent( (BaseAddon) this, 1006, 1, 0, 0, 1910, -1, "", 1);// 19
			AddComplexComponent( (BaseAddon) this, 1006, 1, 0, 6, 1910, -1, "", 1);// 20
			AddComplexComponent( (BaseAddon) this, 1006, 1, 0, 2, 1910, -1, "", 1);// 21
			AddComplexComponent( (BaseAddon) this, 1006, 1, 0, 9, 1910, -1, "", 1);// 22

		}

		public SouthgateDonAddon( Serial serial ) : base( serial )
		{
		}

        private static void AddComplexComponent(BaseAddon addon, int item, int xoffset, int yoffset, int zoffset, int hue, int lightsource)
        {
            AddComplexComponent(addon, item, xoffset, yoffset, zoffset, hue, lightsource, null, 1);
        }

        private static void AddComplexComponent(BaseAddon addon, int item, int xoffset, int yoffset, int zoffset, int hue, int lightsource, string name, int amount)
        {
            AddonComponent ac;
            ac = new AddonComponent(item);
            if (name != null && name.Length > 0)
                ac.Name = name;
            if (hue != 0)
                ac.Hue = hue;
            if (amount > 1)
            {
                ac.Stackable = true;
                ac.Amount = amount;
            }
            if (lightsource != -1)
                ac.Light = (LightType) lightsource;
            addon.AddComponent(ac, xoffset, yoffset, zoffset);
        }

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( 0 ); // Version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}

	public class SouthgateDonAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new SouthgateDonAddon();
			}
		}

		[Constructable]
		public SouthgateDonAddonDeed()
		{
			Name = "SouthgateDon";
		}

		public SouthgateDonAddonDeed( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( 0 ); // Version
		}

		public override void	Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}
}