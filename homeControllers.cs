using
using
using
using
using
System;
System.Collections.Generic;
System.Linq;
System.Threading.Tasks;
Microsoft.AspNetCore.Mvc;
namespace PartyInvites.Controllers {
public class HomeController : Controller {
public IActionResult Index() {
return View();
}
public IActionResult About() {
ViewData["Message"] = "Your application description page.";
return View();
}
public IActionResult Contact() {
ViewData["Message"] = "Your contact page.";
return View();
}
public IActionResult Error() {
return View();
}
}
}