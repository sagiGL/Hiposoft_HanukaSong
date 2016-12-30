using Hiposoft_HanukaSong.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hiposoft_HanukaSong.ModelView
{
    public class SongViewModel
    {
        public Song song { get; set; }

        public List<Song> songs { get; set; }
    }
}