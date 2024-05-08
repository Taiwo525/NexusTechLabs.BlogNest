//using BlogNest.Core.Repositories;
//using BlogNest.Models;
//using Microsoft.AspNetCore.Mvc;

//namespace BlogNest.Controllers
//{
//    public class CommentController : Controller
//    {
//        private readonly ICommentRepo _commentRepository;

//        public CommentController(ICommentRepo commentRepository)
//        {
//            _commentRepository = commentRepository;
//        }

//        // GET: Comment/Create
//        public IActionResult Create()
//        {
//            return View();
//        }

//        // POST: Comment/Create
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public IActionResult Create(Comment comment)
//        {
//            if (ModelState.IsValid)
//            {
//                _commentRepository.AddComment(comment);
//                return RedirectToAction("Details", "Post", new { id = comment.PostId });
//            }
//            return View(comment);
//        }

//        // GET: Comment/Edit/5
//        public IActionResult Edit(int id)
//        {
//            var comment = _commentRepository.GetCommentById(id);

//            if (comment == null)
//            {
//                return NotFound();
//            }

//            return View(comment);
//        }

//        // POST: Comment/Edit/5
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public IActionResult Edit(int id, Comment comment)
//        {
//            if (id != comment.CommentId)
//            {
//                return NotFound();
//            }

//            if (ModelState.IsValid)
//            {
//                _commentRepository.UpdateComment(comment);
//                return RedirectToAction("Details", "Post", new { id = comment.PostId });
//            }
//            return View(comment);
//        }

//        // GET: Comment/Delete/5
//        public IActionResult Delete(int id)
//        {
//            var comment = _commentRepository.GetCommentById(id);

//            if (comment == null)
//            {
//                return NotFound();
//            }

//            return View(comment);
//        }

//        // POST: Comment/Delete/5
//        [HttpPost, ActionName("Delete")]
//        [ValidateAntiForgeryToken]
//        public IActionResult DeleteConfirmed(int id)
//        {
//            var comment = _commentRepository.GetCommentById(id);
//            if (comment == null)
//            {
//                return NotFound();
//            }

//            _commentRepository.DeleteComment(id);
//            return RedirectToAction("Details", "Post", new { id = comment.Id });
//        }
//    }
//}
