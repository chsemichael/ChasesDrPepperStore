// - Added CartItemViewModel (as a class in Models folder of UI layer)
// - Add using statement to get easy access to EF Models (for Product)

using ChasesDrPepperStore.DATA.EF.Models;
using ChasesDrPepperStore.DATA.EF.Models;//EF stuff

namespace ChasesDrPepperStore.UI.MVC.Models
{
    public class CartItemViewModel
    {
        public int Qty { get; set; }//quantity of the product in the cart

        public Product Product { get; set; }//item to buy in cart

        //Complex datatype > any class with multiple properties (DateTime, Product, ContactViewModel)

        //Primitive datatype > A class or struct (type) that stores a single value
        // examples: int, bool, string, char, decimal, etc

        //The above code with Product as a complex-type property of our complex-type class CartItemViewModel is called "Containment". 


        //constructor
        public CartItemViewModel(int qty, Product product)
        {
            //Assignment
            Qty = qty;
            Product = product;
        }
    }
}
