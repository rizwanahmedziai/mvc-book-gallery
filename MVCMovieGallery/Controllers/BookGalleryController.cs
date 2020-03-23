using MVCBookGallery.Models;
using MVCMovieGallery.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCBookGallery.Controllers
{
    public class BookGalleryController : Controller
    {
        private BookRepository _bookRepository = null;

        public BookGalleryController()
        {
            _bookRepository = new BookRepository();
        }

        public ActionResult Index()
        {
            var books = _bookRepository.GetBooks();

            return View(books);
        }
        public ActionResult Detail(int? id)
        {
            if(id == null)
            {
                return HttpNotFound();
            }

            var book = _bookRepository.GetBook((int)id);

            return View(book);
            
        }
    }
}