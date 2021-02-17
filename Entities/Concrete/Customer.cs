using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    //Müşteriler tablosu
    public class Customer:IEntity
    {
        //Customers-->UserId,CompanyName

        public int Id { get; set; }
        public int UserId { get; set; } //*****Kullanıcılar ve müşteriler ilişkilidir.
        public string CompanyName { get; set; }

    }
}
