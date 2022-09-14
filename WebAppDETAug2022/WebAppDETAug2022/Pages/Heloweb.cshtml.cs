using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebAppDETAug2022.Pages
{
    public class HelowebModel : PageModel
    {
        public string Message { get; set; }
        public int Discount { get; set; }
public string Cuponcode { get; set; }
    //HTTPGET
    public void OnGet()
        {
            Message = "Asp.Net Core is Rocking!!";
            Discount = 15;
            Cuponcode = "NewUser";

        }
        
        }
    }

