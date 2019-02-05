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
	public class PussyWillowTreeAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new PussyWillowTreeAddonDeed();
			}
		}

		[ Constructable ]
		public PussyWillowTreeAddon()
		{
			AddonComponent ac = null;
			ac = new AddonComponent( 3302 );
			AddComponent( ac, 1, 0, 0 );
			ac = new AddonComponent( 3151 );
			AddComponent( ac, 0, 1, 10 );
			ac = new AddonComponent( 3152 );
			AddComponent( ac, 1, 1, 20 );
			ac = new AddonComponent( 3151 );
			AddComponent( ac, 2, 0, 20 );
			ac = new AddonComponent( 3152 );
			AddComponent( ac, 2, 1, 18 );
			ac = new AddonComponent( 3155 );
			AddComponent( ac, 2, -1, 21 );
			ac = new AddonComponent( 3156 );
			AddComponent( ac, -1, 1, 14 );
			ac = new AddonComponent( 3151 );
			AddComponent( ac, 0, 1, 5 );
			ac = new AddonComponent( 3152 );
			AddComponent( ac, 2, -1, 5 );

		}

		public PussyWillowTreeAddon( Serial serial ) : base( serial )
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

	public class PussyWillowTreeAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new PussyWillowTreeAddon();
			}
		}

		[Constructable]
		public PussyWillowTreeAddonDeed()
		{
			Name = "PussyWillowTree";
		}

		public PussyWillowTreeAddonDeed( Serial serial ) : base( serial )
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