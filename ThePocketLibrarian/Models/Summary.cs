using System;
using Org.BouncyCastle.Utilities;

namespace ThePocketLibrarian.Models
{
	public class Summary
    {
        public Summary()
        {
		}
        public Items[]? items { get; set; }
    }
}

public class Items
{
    public Items()
    {
    }

    public VolumeInfo volumeInfo { get; set; }

}

public class VolumeInfo
{
    public VolumeInfo()
    {
    }

    public string description { get; set; }
}
