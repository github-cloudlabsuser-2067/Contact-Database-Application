using CRUD_application_2.Models;
using System.Linq;
using System.Web.Mvc;
 
namespace CRUD_application_2.Controllers
{
    public class UserController : Controller
    {
        public static System.Collections.Generic.List<User> userlist = new System.Collections.Generic.List<User>();
        // GET: User
        public ActionResult Index()
        {
            // Retrieve the list of users from the userlist
            var users = userlist.ToList();

            // Return the Index view with the list of users
            return View(users);
        }

        // GET: User/Details/5
        public ActionResult Details(int id)
        {
            // Retrieve the user from the userlist based on the provided ID
            var user = userlist.FirstOrDefault(u => u.Id == id);

            // If no user is found, return a HttpNotFoundResult
            if (user == null)
            {
                return HttpNotFound();
            }

            // Return the Details view with the user
            return View(user);
        }

        // GET: User/Create
        public ActionResult Create()
        {
            // Return the Create view
            return View();
        }

        // POST: User/Create
        [HttpPost]
        public ActionResult Create(User user)
        {
            // Add the new user to the userlist
            userlist.Add(user);

            // Redirect to the Index action to display the updated list of users
            return RedirectToAction("Index");
        }

        // GET: User/Edit/5
        public ActionResult Edit(int id)
        {
            // Retrieve the user from the userlist based on the provided ID
            var user = userlist.FirstOrDefault(u => u.Id == id);

            // If no user is found, return a HttpNotFoundResult
            if (user == null)
            {
                return HttpNotFound();
            }

            // Return the Edit view with the user
            return View(user);
        }

        // POST: User/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, User updatedUser)
        {
            // Retrieve the user from the userlist based on the provided ID
            var user = userlist.FirstOrDefault(u => u.Id == id);

            // If no user is found, return a HttpNotFoundResult
            if (user == null)
            {
                return HttpNotFound();
            }

            // Update the user's information with the updatedUser
            user.Name = updatedUser.Name;
            user.Email = updatedUser.Email;

            // Redirect to the Index action to display the updated list of users
            return RedirectToAction("Index");
        }

        // GET: User/Delete/5
        public ActionResult Delete(int id)
        {
            // Retrieve the user from the userlist based on the provided ID
            var user = userlist.FirstOrDefault(u => u.Id == id);

            // If no user is found, return a HttpNotFoundResult
            if (user == null)
            {
                return HttpNotFound();
            }

            // Return the Delete view with the user
            return View(user);
        }

        // POST: User/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            // Retrieve the user from the userlist based on the provided ID
            var user = userlist.FirstOrDefault(u => u.Id == id);

            // If no user is found, return a HttpNotFoundResult
            if (user == null)
            {
                return HttpNotFound();
            }

            // Remove the user from the userlist
            userlist.Remove(user);

            // Redirect to the Index action to display the updated list of users
            return RedirectToAction("Index");
        }
    }
}
