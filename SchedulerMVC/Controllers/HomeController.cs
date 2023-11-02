using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SchedulerDB.Models;
using SchedulerMVC.Models;
using System.Diagnostics;

namespace SchedulerMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }

    public class MeetingController : Controller
    {
        private readonly List<Meeting> events;
        private readonly List<Person> people;
        private readonly List<Room> rooms;

        public MeetingController()
        {
            events = new List<Meeting>();
            people = new List<Person>();
            rooms = new List<Room>();
        }

        public IActionResult Index()
        {
            return View(events);
        }

        public IActionResult CreateEvent()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateEvent(Meeting newEvent)
        {
            events.Add(newEvent);
            return RedirectToAction("Index");
        }

        public IActionResult People()
        {
            return View(people);
        }

        public IActionResult CreatePerson()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreatePerson(Person newPerson)
        {
            people.Add(newPerson);
            return RedirectToAction("People");
        }

        public IActionResult Rooms()
        {
            return View(rooms);
        }

        public IActionResult CreateRoom()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateRoom(Room newRoom)
        {
            rooms.Add(newRoom);
            return RedirectToAction("Rooms");
        }
    }
}