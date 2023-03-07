using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr12_4
{
    class Flower
    {
        public string name;
        public string shade;
        public string country;
        public int price;
        public int length;
        public string info
        {
            get
            {
                return $"Название:{name}\r Оттенок:{shade}\r Страна-производитель:{country}\r Цена:{price.ToString()}\r Длина стебля:{length.ToString()}\r";
            }
            set
            {
                info = value;
            }
               
        }
        public void cost(int quantity)
        {
            
            int bouquet = price * quantity;
        }
        public string Cost
        {
            get
            {
               
            }
            set
            {

            }
        }
    }
}
