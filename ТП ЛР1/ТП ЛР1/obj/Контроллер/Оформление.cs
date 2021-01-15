using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using ТП_ЛР1.Модели;

namespace ТП_ЛР1.Контроллер
{
    class Оформление
    {
        public double Itog;
        public int ItogVes;
        public int Time;
        public double Sebest;
        public double Pribyl;
        public ObservableCollection<Заказ> Zakaz = new ObservableCollection<Заказ>();
        public ObservableCollection<Заказы> Zakazy = new ObservableCollection<Заказы>();
        public Оформление()
        {
            Zakaz = new ObservableCollection<Заказ>();
            Zakazy = new ObservableCollection<Заказы>();
        }
        public bool Vybrat(Блюда Eda, int Qantity)
        {
            Заказ Zakazy = new Заказ();
            Zakazy.bludo = Eda;
            Zakazy.Количество = Qantity;
            Zakaz.Add(Zakazy);
            return true;

        }
        public bool Sozdat()
        {
            Itog = 0;
            foreach (Заказ Zakazz in Zakaz)
            {
                Itog = Zakazz.bludo.price * Zakazz.Количество + Itog;
            }
            Time = 0;
            foreach (Заказ Zakazz in Zakaz)
            {
                if (Zakazz.bludo.time > Time)
                {
                    Time = Zakazz.bludo.time;
                }
            }
            ItogVes = 0;
            foreach (Заказ Zakazz in Zakaz)
            {
                ItogVes = Zakazz.bludo.ves * Zakazz.Количество + ItogVes;
            }
            Sebest = 0;
            foreach (Заказ Zakazz in Zakaz)
            {
                Sebest = Zakazz.bludo.sebestoim * Zakazz.Количество + Sebest;
            }
            Pribyl = 0;
            Pribyl = Itog - Sebest + Pribyl;
            Заказы Zakazy1 = new Заказы();
            Zakazy1.SpisokBlud = Zakaz;
            Zakazy1.Summa = Itog;
            Zakazy1.Time = Time;
            Zakazy1.Pribyl = Pribyl;
            Zakazy1.Sebestoim = Sebest;
            Zakazy.Add(Zakazy1);
            Zakaz = new ObservableCollection<Заказ>();
            return true;
        }
    }
}
