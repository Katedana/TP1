using System;
using System.Collections.Generic;
using System.Text;
using ТП_ЛР1.Модели;

namespace ТП_ЛР1.Контроллер
{
    struct Заказ
    {
        public Блюда bludo { get; set; }
        public int Количество { get; set; }
        public int time { get; set; }
    }
   
}
