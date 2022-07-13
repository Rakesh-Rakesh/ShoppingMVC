namespace ShoppingMVC.Models
{
    public class Products
    {
        public int Pid { get; set; }
        public string PName { get; set; }
        public string Category { get; set; }
        public double Price { get; set; }
        public bool PISinStock { get; set; }


        static List<Products> pList = new List<Products>()
    {
        new Products(){Pid=101,PName="Cold-Dark",Category="drink",PISinStock=true,Price=30},
        new Products(){Pid=102,PName="Pespi",Category = "Drink",PISinStock=true,Price=40},
        new Products(){Pid=103,PName="pizza",Category="Food",PISinStock=true,Price=50},
        new Products(){Pid=104,PName="SandWitch",Category = "Food" ,PISinStock=true,Price=40 },
        new Products(){Pid=105,PName="Thumbsup",Category="Drink",PISinStock=true,Price=30}
    };
     
       public  List<Products> GetAllProducts()
        {
            return pList;

        }

        public Products GetProductsById(int id)
        {
            var p = (from pr in pList
                     where pr.Pid == id
                     select pr).Single();
            
            if(p!= null)
            {
                return p;
            }
            throw new Exception("Product not found");
        }

        public string AddProducts(Products newProducts)
        {
            pList.Add(newProducts);
            return "products added succesfully";
        }
        public string DeleteProducts(int id)
        {
            var p = (from pr in pList
                     where pr.Pid == id
                     select pr).Single();
            pList.Remove(p);
            return "product deleted succesfuly";
        }
    }
}
