using Shopping_Website.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Shopping_Website.IRepository
{
    public interface IProductRepository
    {
        List<ProductDetail> Getallproduct();
        ProductDetail SelectData(int id);

        int UpdateData(ProductDetail std);

        List<ProductDetail> GetData(int id);
        int InsertData(ProductDetail sp);

    }
}