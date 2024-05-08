//using BlogNest.Core.Repositories;
//using BlogNest.Models;
//using Microsoft.AspNetCore.Mvc;

//namespace BlogNest.Controllers
//{
//    public class UserController : Controller
//    {
//        private readonly IUserRepo _userRepository;

//        public UserController(IUserRepo userRepository)
//        {
//            _userRepository = userRepository;
//        }

//        // GET: User
//        public async Task<IActionResult> Index()
//        {
//            var users =await _userRepository.GetAllUsersAsync();
//            return View(users);
//        }

//        // GET: User/Details/5
//        public IActionResult Details(int id)
//        {
//            var user = _userRepository.GetUserByIdAsync(id);

//            if (user == null)
//            {
//                return NotFound();
//            }

//            return View(user);
//        }

//        // GET: User/Create
//        public IActionResult Create()
//        {
//            return View();
//        }

//        // POST: User/Create
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public IActionResult Create(User user)
//        {
//            if (ModelState.IsValid)
//            {
//                _userRepository.AddUser(user);
//                return RedirectToAction(nameof(Index));
//            }
//            return View(user);
//        }

//        // GET: User/Edit/5
//        public IActionResult Edit(int id)
//        {
//            var user = _userRepository.GetUserByIdAsync(id);

//            if (user == null)
//            {
//                return NotFound();
//            }

//            return View(user);
//        }

//        // POST: User/Edit/5
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public IActionResult Edit(int id, User user)
//        {
//            if (id != user.UserId)
//            {
//                return NotFound();
//            }

//            if (ModelState.IsValid)
//            {
//                _userRepository.UpdateUser(user);
//                return RedirectToAction(nameof(Index));
//            }
//            return View(user);
//        }

//        // GET: User/Delete/5
//        public IActionResult Delete(int id)
//        {
//            var user = _userRepository.GetUserByIdAsync(id);

//            if (user == null)
//            {
//                return NotFound();
//            }

//            return View(user);
//        }

//        // POST: User/Delete/5
//        [HttpPost, ActionName("Delete")]
//        [ValidateAntiForgeryToken]
//        public IActionResult DeleteConfirmed(int id)
//        {
//            _userRepository.DeleteUser(id);
//            return RedirectToAction(nameof(Index));
//        }
//    }
//}
