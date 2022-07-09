using System;
using System.Collections.Generics;

namespace OnlineShopping
{

    public class ProductsController:Controller
    {

        public ActionResult Index()
        {
            return View();
        }


        public ActionResult Details(itn id)
        {
            //GEt details of Product based on id from database using ORM
            Product theProduct = new Product();

            return View(theProduct);
        }

    }
}