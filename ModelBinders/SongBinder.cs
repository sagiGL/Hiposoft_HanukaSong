using Hiposoft_HanukaSong.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hiposoft_HanukaSong.ModelBinders
{
    public class SongBinder : IModelBinder
    {
        public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            HttpContextBase objContext = controllerContext.HttpContext;
            string SongNumber = objContext.Request.Form["Number"];
            string SongName = objContext.Request.Form["Name"];
            string SongWriterName = objContext.Request.Form["WriterName"];
            string SongLyrics = objContext.Request.Form["Lyrics"];
            string SongYoutubeLink = objContext.Request.Form["YoutubeLink"];
           

            Song obj = new Song()
            {
                Number = SongNumber,
                Name = SongName,
                WriterName = SongWriterName,
                Lyrics = SongLyrics,
                YouTubeLink = SongYoutubeLink,
            };

            return obj;
        }
    }
}