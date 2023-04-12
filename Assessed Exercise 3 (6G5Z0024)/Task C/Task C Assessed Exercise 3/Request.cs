using System;

namespace Task_C_Assessed_Exercise_3
{
    public class Request: IComparable
    {
        private int _id;
        private double _starting;
        private double _finishing;

        public Request(int ID, double starting, double finishing)
        {
            this._id = ID;
            this._starting = starting;
            this._finishing = finishing;
        }

        public int id
        {
            get { return _id; }
            set { _id = value; }
        }

        public double Starting
        {
            get { return _starting; }
            set { _starting = value; }
        }

        public double Finishing
        {
            get { return _finishing; }
            set { _finishing = value; }
        }

        public int CompareTo(Object obj)
        {
            Request other = (Request)obj;
            return Finishing.CompareTo(other.Finishing);
        }

        public override string ToString()
        {
            return $"{id} {_starting: 0.00} {_finishing: 0.00} \n" ; 
        }
    }
}