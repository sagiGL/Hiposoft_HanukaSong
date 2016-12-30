using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Hiposoft_HanukaSong.Models;
using Hiposoft_HanukaSong.ModelBinders;
using Hiposoft_HanukaSong.Dal;
using Hiposoft_HanukaSong.ModelView;

namespace Hiposoft_HanukaSong.Controllers
{
    public class SongController : Controller
    {
        // GET: Song
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult NewSong()
        {
            return View();
        }

        public ActionResult SearchSongs()
        {
            SongViewModel svm = new SongViewModel();
            svm.songs = new List<Song>();

            return View("SearchSongs", svm);
        }

        // For some reasone my VS didnt let me  to create this SearchResults
        // action without a page, which made me create twice the same view
        public ActionResult SearchResults() 
        {
            SongDal dal = new SongDal();
            string searchValue = Request.Form["txtSongName"].ToString();
            List<Song> objSongs = (from x in dal.Songs
                                   where x.Name.Contains(searchValue)
                                   select x).ToList<Song>();
            SongViewModel svm = new SongViewModel();
            svm.songs = objSongs;

            return View(svm);
        }

        public ActionResult Enter()
        {
            SongDal dal = new SongDal();
            List<Song> objSongs = dal.Songs.ToList<Song>();
            SongViewModel svm = new SongViewModel();

            svm.song = new Song();
            svm.songs = objSongs;
            return View(svm);
        }

        [HttpPost]
        public ActionResult Submit()
        {
            SongViewModel svm = new SongViewModel();
            Song objSong = new Song();
            objSong.Number = Request.Form["song.Number"].ToString();
            objSong.Name = Request.Form["song.Name"].ToString();
            objSong.WriterName = Request.Form["song.WriterName"].ToString();
            objSong.Lyrics = Request.Form["song.Lyrics"].ToString();
            objSong.YouTubeLink = Request.Form["song.YouTubeLink"].ToString();
            SongDal dal = new SongDal();

            if (ModelState.IsValid)
            {
                dal.Songs.Add(objSong);
                dal.SaveChanges();
                svm.song = new Song();
            }
            else
                svm.song = objSong;
            svm.songs = dal.Songs.ToList<Song>();

            return View("Enter", svm);
        }
    }
}