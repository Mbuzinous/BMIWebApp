using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Diagnostics;

namespace BMIWebApp.Pages
{
    public class BMIModel : PageModel
    {
        [BindProperty]
        public byte Height { get; set; }
        
        [BindProperty]
        public double Weight { get; set; }
        public double Bmi { get; private set; }

        public void OnGet()
        {
        }
        public void OnPost()
        {

        }
        public void OnPostMyFirstForm() 
        {
            BMICalculator.BMICalculator calc = new BMICalculator.BMICalculator();
            Bmi = calc.Calculate(Weight, Height);
            Debug.WriteLine("OnPost kaldt" + Weight + "" + Height);
        }
    }
}
