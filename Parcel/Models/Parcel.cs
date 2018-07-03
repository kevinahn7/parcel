using System;
namespace Parcel.Models
{
    public class ShippingItem
    {
        private int _length;
        private int _width;
        private int _height;
        private int _weight;
   
        public ShippingItem(int length, int width, int height, int weight)
        {
            _length = length;
            _width = width;
            _height = height;
            _weight = weight;
        }

        public int CalculateVolume()
        {
            int volume = _width * _length * _height;
            return volume;
        }

        public int CalculateCost()
        {
            int costToShip = _weight * CalculateVolume();
            return costToShip;
        }
    }
}
