using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpEgitimKampi301.EntityLayer.Concrete
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public bool CategoryStatus { get; set; }
    }

    //int x; ---> Field (Class'ın içinde)
    //public int y {get; set;} ---> Property
    //void test() {int z;} ---> Variable (Metot içinde tanımlanıyorsa)
}
