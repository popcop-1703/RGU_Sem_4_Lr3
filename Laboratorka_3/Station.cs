using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorka_3
{
    class Station
    {
        
            
        //ссылка на объект класса станции
        private static Station stationInstance;
        //ссылка на объект класса багажное отделение
        private Luggage station_luggage;
        //закрытый конструктор
        private Station()
        {
            station_luggage = new Luggage(true, 0);
        }

        public static Station GetStationInstance()
        {
            if (stationInstance == null)
            {
                stationInstance = new Station();
            }
            return stationInstance;
        }
        //наименование станции (вокзала)
        private string stationName;
        public string StationName
        {
            get { return stationName; }
            set { stationName = value; }
        }
        //состояние отделения
        public bool IsLuggageWorkOn
        {
            get
            {
                return station_luggage.IsWorkOn;
            }
        }
        public bool vokzalWork;
        public bool VokzalWork
        {
            get
            {
                return vokzalWork;
            }
            set
            {
                vokzalWork = value;
            }
        }
        
        
        //открыть отделение
        public void LuggageWorkOn()
        {
            station_luggage.WorkOn();
        }
        //закрыть отделение
        public void LuggageWorkOff()
        {
            station_luggage.WorkOff();
        }
        //текущая вместимость багажного отделения
        public int LuggageCapacity
        {
            get
            {
                return station_luggage.Capacity;
            }
        }
        //увеличить вместимость багажного отделения
        public void LuggageCapacityUp(int d)
        {
            station_luggage.CapacityUp(d);
        }
        //уменьшить вместимость багажного отделения
       
        //текущее кол-во багажа в отделении
        public int LuggageCountOfBag
        {
            get { return station_luggage.CountOfBag; }
        }
        //увеличить кол-во багажа в отделении
        public void LuggageCountOfBagUp(int d)
        {
            station_luggage.countOfBagUp(d);
        }
        //уменьшить кол-во багажа в отделении
        public void LuggageCountOfBagDown(int d)
        {
            station_luggage.countOfBagDown(d);
        }
    }

}