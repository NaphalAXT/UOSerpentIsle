// Automatically generated by the
// AddonGenerator script by Arya
// Generator edited 10.Mar.07 by Papler
using System;
using Server;
using Server.Items;
namespace Server.Items
{
	public class ShowerRightAddon : BaseAddon {
		public override BaseAddonDeed Deed{get{return new ShowerRightAddonDeed();}}
		[ Constructable ]
		public ShowerRightAddon()
		{
			AddonComponent ac = null;
			ac = new AddonComponent( 4272 );
			ac.Hue = 951;
			AddComponent( ac, 1, 2, 8 );

			ac = new AddonComponent( 1299 );
			AddComponent( ac, 1, 1, 0 );

			ac = new AddonComponent( 698 );
			AddComponent( ac, 1, 1, 0 );

			ac = new AddonComponent( 1300 );
			AddComponent( ac, 1, 0, 0 );

			ac = new AddonComponent( 1299 );
			AddComponent( ac, 1, -1, 0 );

			ac = new AddonComponent( 6197 );
			ac.Name = "Showerhead";
			AddComponent( ac, 1, -1, 15 );

			ac = new AddonComponent( 5155 );
			ac.Name = "soap";
			AddComponent( ac, 1, -1, 0 );

			ac = new AddonComponent( 4272 );
			AddComponent( ac, 0, 2, 8 );

			ac = new AddonComponent( 1299 );
			AddComponent( ac, 0, 1, 0 );

			ac = new AddonComponent( 698 );
			AddComponent( ac, 0, 1, 0 );

			ac = new AddonComponent( 4269 );
			ac.Hue = 961;
			AddComponent( ac, 0, 1, 10 );

			ac = new AddonComponent( 1299 );
			AddComponent( ac, 0, 0, 0 );

			ac = new AddonComponent( 4269 );
			ac.Hue = 961;
			AddComponent( ac, 0, 0, 10 );

			ac = new AddonComponent( 5154 );
			ac.Hue = 946;
			ac.Name = "soap";
			AddComponent( ac, 0, 0, 0 );

			ac = new AddonComponent( 3837 );
			ac.Name = "shampoo";
			AddComponent( ac, 0, 0, 4 );

			ac = new AddonComponent( 1300 );
			AddComponent( ac, 0, -1, 0 );

			ac = new AddonComponent( 3625 );
			ac.Name = "conditioner";
			AddComponent( ac, 0, -1, 1 );

			ac = new AddonComponent( 4828 );
			AddComponent( ac, 0, -1, 1 );

			ac = new AddonComponent( 672 );
			AddComponent( ac, -1, 1, 0 );

			ac = new AddonComponent( 699 );
			AddComponent( ac, -1, 1, 0 );

			ac = new AddonComponent( 699 );
			AddComponent( ac, -1, 0, 0 );

			ac = new AddonComponent( 5535 );
			ac.Name = "towel";
			AddComponent( ac, -1, -1, 0 );

			ac = new AddonComponent( 699 );
			AddComponent( ac, -1, -1, 0 );

			ac = new AddonComponent( 5535 );
			ac.Name = "towel";
			AddComponent( ac, -2, -1, 0 );

			ac = new AddonComponent( 4839 );
			AddComponent( ac, 1, 2, 0 );

			ac = new AddonComponent( 698 );
			AddComponent( ac, 2, 1, 0 );

			ac = new AddonComponent( 1300 );
			AddComponent( ac, 2, -1, 0 );

			ac = new AddonComponent( 1299 );
			AddComponent( ac, 2, 0, 0 );

			ac = new AddonComponent( 1300 );
			AddComponent( ac, 2, 1, 0 );


		}
		public ShowerRightAddon( Serial serial ) : base( serial ){}
		public override void Serialize( GenericWriter writer ){base.Serialize( writer );writer.Write( 0 );}
		public override void Deserialize( GenericReader reader ){base.Deserialize( reader );reader.ReadInt();}
	}

	public class ShowerRightAddonDeed : BaseAddonDeed {
		public override BaseAddon Addon{get{return new ShowerRightAddon();}}
		[Constructable]
		public ShowerRightAddonDeed(){Name = "ShowerRight";}
		public ShowerRightAddonDeed( Serial serial ) : base( serial ){}
		public override void Serialize( GenericWriter writer ){	base.Serialize( writer );writer.Write( 0 );}
		public override void	Deserialize( GenericReader reader )	{base.Deserialize( reader );reader.ReadInt();}
	}
}