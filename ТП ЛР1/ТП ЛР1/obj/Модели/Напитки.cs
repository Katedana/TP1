﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ТП_ЛР1.Модели
{
    class Напитки : Блюда
    {
        string _name;
        double _price, _sebestoim;
        int _ves, _time;
        public Напитки(string Name, double Price, double Sebestoim, int Ves, int Time)
        {
            _name = Name;
            _price = Price;
            _sebestoim = Sebestoim;
            _ves = Ves;
            _time = Time;
        }
        public string name { get => _name; set => _name = value; }
        public double price { get => _price; set => _price = value; }
        public double sebestoim { get => _sebestoim; set => _sebestoim = value; }
        public int ves { get => _ves; set => _ves = value; }
        public int time { get => _time; set => _time = value; }
    }
}
