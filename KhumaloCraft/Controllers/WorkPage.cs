using KhumaloCraft.Models;
using Microsoft.AspNetCore.Mvc;


namespace KhumaloCraft.Controllers
{
    public class WorkPage : Controller
    {
        List<ArtisanWork> workPieces = new List<ArtisanWork>(5);
        public IActionResult Index()
        {

            ArtisanWork piece = new ArtisanWork("Sashveer", "Ramjathan", "This is a great piece of work", 4.3, 199.99, "/Images/angels.jpg");
            ArtisanWork piece2 = new ArtisanWork("Vidur", "Somaru", "Capturing the beauty of sunflowers in a vase", 4.7, 349.99, "/Images/sunflowerpainting.jpg");
            ArtisanWork piece3 = new ArtisanWork("Jade", "Loiters", "5 Recycled bottles for kitchen use", 4.9, 999.99, "/Images/bottles.jpg");
            ArtisanWork piece4 = new ArtisanWork("Shravan", "Ramjathan", "A mix of technoly with a blast from the past painting of the Mona Lisa", 5.0, 499.99, "/Images/modernMonaLisa.jpg");
            ArtisanWork piece5 = new ArtisanWork("Khumalo", "Zulu", "A beaded face that shows the creativity of Africa", 4.6, 249.99, "/Images/face.jpg");
            ArtisanWork piece6 = new ArtisanWork("Vidur", "Somaru", "A little beaded family made with vibrant African colours", 4.0, 299.99, "/Images/beadedPeople.jpg");
            workPieces.Add(piece);
            workPieces.Add(piece2);
            workPieces.Add(piece3);
            workPieces.Add(piece4);
            workPieces.Add(piece5);
            workPieces.Add(piece6);
            return View(workPieces);
        }
    }
}
