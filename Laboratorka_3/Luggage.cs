using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorka_3

{
    class Luggage
    {
        //конструктор
        public Luggage()
        {
            isWorkOn = true;
        }
        //конструктор
        public Luggage(int capacity_luggage_space)
        {
            isWorkOn = true;
            capacity = capacity_luggage_space;
        }
        //конструктор
        public Luggage(bool isOnOff, int capacity_luggage_space)
        {
            isWorkOn = isOnOff;
            if (!isOnOff)
            {
                capacity = 0;
            }
            else
            {
                capacity = capacity_luggage_space;
            }
        }
        //состояние отделения
        private bool isWorkOn;
        public bool IsWorkOn
        {
            get { return isWorkOn; }
        }
        //текущая вместимость отделения
        private int capacity;
        public int Capacity
        {
            get { return capacity; }
        }
        //открыть отделение
        public void WorkOn()
        {
            isWorkOn = true;
        }
        //закрыть отделение
        public void WorkOff()
        {
            isWorkOn = false;
     
        }

        //увеличить вместимость багажного отделения
        public void CapacityUp(int d)
        {
            if (isWorkOn)
                capacity = d;
        }
        
        //текущее кол-во багажа в отделении
        private int countOfBag;
        public int CountOfBag
        {
            get { return countOfBag; }
        }
        //увеличить кол-во багажа в отделении
        public void countOfBagUp(int d)
        {
            if (isWorkOn && countOfBag + d <= capacity)
            {
                countOfBag += d;
            }
        }
        //уменьшить кол-во багажа в отделении
        public void countOfBagDown(int d)
        {
            if (isWorkOn && countOfBag - d >= 0)
            {
                countOfBag -= d;
            }
        }
    }

}
