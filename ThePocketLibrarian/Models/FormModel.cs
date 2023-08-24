using System;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ThePocketLibrarian
{
	public class FormModel
	{
        public bool IsChecked { get; set; }
		public string genre1 { get; set; }
        public string genre2 { get; set; }
        public string genre3 { get; set; }
        public string genre4 { get; set; }
        public string genre5 { get; set; }
        public string genre6 { get; set; }
        public string genre7 { get; set; }
        public string genre8 { get; set; }
        public string genre9 { get; set; }
        public string genre10 { get; set; }
        public string genre11 { get; set; }
        public string genre12 { get; set; }
        public string genre13 { get; set; }
        public string genre14 { get; set; }

        public string romance1 { get; set; }
        public string romance2 { get; set; }
        public string romance3 { get; set; }
        public string romance4 { get; set; }
        public string romance5 { get; set; }
        public string romance6 { get; set; }
        public string romance7 { get; set; }
        public string romance8 { get; set; }
        public string romance9 { get; set; }
        public string romance10 { get; set; }
        public string romance11 { get; set; }
        public string romance12 { get; set; }

        public string setting1 { get; set; }
        public string setting2 { get; set; }
        public string setting3 { get; set; }

        public string pov1 { get; set; }
        public string pov2 { get; set; }
        public string pov3 { get; set; }
        public string pov4 { get; set; }

        public string protagonist1 { get; set; }
        public string protagonist2 { get; set; }

        public string tropes1 { get; set; }
        public string tropes2 { get; set; }
        public string tropes3 { get; set; }
        public string tropes4 { get; set; }
        public string tropes5 { get; set; }
        public string tropes6 { get; set; }
        public string tropes7 { get; set; }
        public string tropes8 { get; set; }
        public string tropes9 { get; set; }
        public string tropes10 { get; set; }

        public IList<SelectListItem> Genres { get; set; }
        public IList<SelectListItem> Attributes { get; set; }


    }

    public class Genre
    {
        public List<FormModel> Genres { get; set; }
    }

    //public class Characteristics
    //{
    //    public List<FormModel> Attributes { get; set; }
    //}

}

