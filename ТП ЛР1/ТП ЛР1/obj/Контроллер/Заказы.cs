using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ТП_ЛР1.Контроллер
{
    struct Заказы
    {
        public double Summa { get; set; }
        public DateTime Data { get; set; }
        public int Time { get; set; }
        public int Ves { get; set; }
        public double Sebestoim { get; set; }
        public double Pribyl { get; set; }
        public ObservableCollection<Заказ> SpisokBlud;
    }
}
