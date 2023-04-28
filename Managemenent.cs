using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LinqDemo
{
    public class Management
    {
        public void Top3Records(List<ProductReview> ListOfProductReview)
        {
            var RecordData = (from products in ListOfProductReview
                              orderby products.Rating descending
                              select products).Take(3);
            foreach (var record in RecordData)
            {
                Console.Write("{0} {1} {2} {3} {4}\n", record.ProductID, record.UserID, record.Review, record.Rating, record.IsLike);
            
            }
        
        }
        

       
    }
}
