using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Hiposoft_HanukaSong.Models;

namespace Hiposoft_HanukaSong.Dal
{
    public class SongDal : DbContext 
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Song>().ToTable("tblSong");
        }

        public DbSet<Song> Songs { get; set; }
    }
}