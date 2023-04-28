﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LinqDemo
{
    public class Management
    {
        public void RetireveProductIDReview(List<ProductReview> ListOfProductReview)
        {
            var RecordData = from Products in ListOfProductReview
                             select new { ProductID = Products.ProductID, Review = Products.Review };
            foreach (var Record in RecordData)
            {
                Console.WriteLine(Record.ProductID + " " + Record.Review);

            }



        }
    }
}
