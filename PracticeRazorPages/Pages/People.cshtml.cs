using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PracticeRazorPages.Data;
using PracticeRazorPages.Models;

namespace PracticeRazorPages.Pages
{
    public class PeopleModel : PageModel
    {
        private readonly MyDbContext _dbContext;

        public List<Person> People { get; set; } = new List<Person>();

        [BindProperty]
        public Person NewPerson { get; set; }

        public PeopleModel(MyDbContext myDbContext)
        {
            _dbContext = myDbContext;
        }

        public void OnGet()
        {
            People = _dbContext.People.ToList();
            //_dbContext.
        }

        public IActionResult OnPost()
        {
            _dbContext.People.Add(NewPerson);
            _dbContext.SaveChanges();
            return RedirectToPage();
        }
    }
}
