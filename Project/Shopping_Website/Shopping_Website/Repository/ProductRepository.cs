using Shopping_Website.IRepository;
using Shopping_Website.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Shopping_Website.Repository
{
    public class ProductRepository: IProductRepository
    {
        Shopping_DBEntities db = new Shopping_DBEntities();
      

        public List<ProductDetail> Getallproduct()
        {
            return db.ProductDetails.ToList();
        }

        

        public int InsertData(ProductDetail sp)
        {
            db.ProductDetails.Add(sp);
            return db.SaveChanges();

        }
        public List<ProductDetail> GetData(int id)
        {
            return db.ProductDetails.Where(x=>x.Sellerid==id).ToList();
        }
        public int UpdateData(ProductDetail std)
        {
            var res = db.ProductDetails.FirstOrDefault(x => x.Sellerid == std.Sellerid&&x.Id==std.Id);
            res.Name = std.Name;
            res.Description = std.Description;
            res.Category = std.Category;
            res.Gender = std.Gender;
            res.Price = std.Price;
            res.Publish = std.Publish;
            res.Discount = std.Discount;
            if (std.Imageurl != null)
            {
                res.Imageurl = std.Imageurl;
            }
            return db.SaveChanges();

        }
        public ProductDetail SelectData(int id)
        {
            var res = db.ProductDetails.FirstOrDefault(x => x.Id == id);
            return res;
        }



    }
}