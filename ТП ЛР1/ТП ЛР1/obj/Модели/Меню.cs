using System;
using System.Collections.Generic;
using System.Text;

namespace ТП_ЛР1.Модели
{
    class Меню
    {
        public List<Блюда> MyMenu = new List<Блюда>();
        public Меню()
        {       
                Блюда syr = new Закуски("Сырная тарелка", 400, 200, 250, 4);
                Блюда grenki = new Закуски("Гренки", 100, 15, 60, 10);
                Блюда myaso = new Закуски("Мясная нарезка", 600, 300, 350, 4);
                MyMenu.Add(syr);
                MyMenu.Add(grenki);
                MyMenu.Add(myaso);

                Блюда ice = new Десерты("Мороженое", 150, 20, 50, 2);
                Блюда cheesecake = new Десерты("Чизкейк", 300, 150, 70, 20);
                Блюда sherbet = new Десерты("Щербет", 200, 100, 70, 5);
                MyMenu.Add(ice);
                MyMenu.Add(cheesecake);
                MyMenu.Add(sherbet);

                Блюда pyre = new Детское_меню("Фруктовое пюре", 150, 50, 100, 5);
                Блюда nagetsy = new Детское_меню("Нагетсы", 150, 60, 110, 6);
                Блюда free = new Детское_меню("Картофель фри", 60, 30, 60, 5);
                MyMenu.Add(pyre);
                MyMenu.Add(nagetsy);
                MyMenu.Add(free);

                Блюда voda = new Напитки("Вода", 40, 5, 100, 1);
                Блюда pivo = new Напитки("Пиво", 100, 30, 150, 1);
                Блюда milksheyk = new Напитки("Милкшейк", 150, 70, 120, 3);
                MyMenu.Add(voda);
                MyMenu.Add(pivo);
                MyMenu.Add(milksheyk);

                Блюда borch = new Основные_блюда("Борщ", 250, 100, 100, 10);
                Блюда kotletka = new Основные_блюда("Котлетки", 200, 110, 160, 10);
                Блюда uha = new Основные_блюда("Уха", 160, 125, 100, 10);
                MyMenu.Add(borch);
                MyMenu.Add(kotletka);
                MyMenu.Add(uha);
        }
    }
}
