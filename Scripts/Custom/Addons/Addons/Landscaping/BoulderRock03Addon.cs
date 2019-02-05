/////////////////////////////////////////////////
//
// Automatically generated by the
// AddonGenerator script by Arya
//
/////////////////////////////////////////////////
using System;
using Server;
using Server.Items;

namespace Server.Items
{
	public class BoulderRock03Addon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new BoulderRock03AddonDeed();
			}
		}

		[ Constructable ]
		public BoulderRock03Addon()
		{
			AddonComponent ac = null;
			ac = new AddonComponent( 4949 );
			AddComponent( ac, 0, 1, 0 );
			ac = new AddonComponent( 4950 );
			AddComponent( ac, 0, 0, 0 );

		}

		public BoulderRock03Addon( Serial serial ) : base( serial )
		{
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

	public class BoulderRock03AddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new BoulderRock03Addon();
			}
		}

		[Constructable]
		public BoulderRock03AddonDeed()
		{
			Name = "BoulderRock03";
		}

		public BoulderRock03AddonDeed( Serial serial ) : base( serial )
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