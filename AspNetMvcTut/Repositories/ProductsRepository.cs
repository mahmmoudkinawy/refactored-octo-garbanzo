using AspNetMvcTut.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetMvcTut.Repositories
{
    public class ProductsRepository
    { 

        public static List<UserProduct> _userProducts = new List<UserProduct>();  
        
        public static List<UserProduct> GetAll()
        {
            return _userProducts;
        }

        public static void Add(UserProduct user)
        {
            _userProducts.Add(user);
        }
    }
}
