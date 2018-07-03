using System;
namespace Parcel.Models
{
    public class ShippingItem
    {
        private int _length;
        private int _width;
        private int _height;
        private int _weight;
        private int _volume;
        private int _costToShip;

        public ShippingItem(int length, int width, int height, int weight)
        {
            _length = length;
            _width = width;
            _height = height;
            _weight = weight;
        }

        public int GetLength()
        {
            return _length;
        }

        public int GetWidth()
        {
            return _width;
        }

        public int GetHeight()
        {
            return _height;
        }

        public int GetWeight()
        {
            return _weight;
        }

        public void SetVolume(int volume)
        {
            _volume = volume;
        }

        public int GetVolume()
        {
            return _volume;
        }

        public int GetCost()
        {
            return _costToShip;
        }

        public void SetCost(int cost)
        {
            _costToShip = cost;
        }

        public int CalculateVolume()
        {
            int volume = this.GetWidth() * this.GetLength() * this.GetHeight();
            //_volume = _width * _length * _height;
            return volume;
        }

        public int CalculateCost()
        {
            int costToShip = this.GetWeight();
            return costToShip;
        }

    }
}
