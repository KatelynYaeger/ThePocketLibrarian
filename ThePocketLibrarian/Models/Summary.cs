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

        //public string GoogleMethod()
        //{
        //    var description = "";

        //    foreach (var item in items)
        //    {
        //        description = $"{item.volumeInfo.description}";
        //    }
        //    return description;
        //}
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
    public string? title { get; set; }
    //public string authors { get; set; }

}
