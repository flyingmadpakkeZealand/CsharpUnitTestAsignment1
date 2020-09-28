using System;

namespace CsharpUnitTestAsignment1
{
    public class Bicycle
    {
        public uint Id { get; set; } //uint because negative Ids are rare.

        private string _color;
        private double _price;
        private byte _gear;

        public string Color
        {
            get { return _color; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }
                if (value.Length<1)
                {
                    throw new ArgumentException();
                }
                _color = value;
            }
        }

        public double Price
        {
            get { return _price; }
            set
            {
                if (value<0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value));
                }
                _price = value;
            }
        }

        public byte Gear
        {
            get { return _gear; }
            set
            {
                if (value<3 || value>32)
                {
                    throw new ArgumentOutOfRangeException(nameof(value));
                }
                _gear = value;
            }
        }

        public Bicycle(string color, double price, byte gear, uint id)
        {
            Color = color;
            Price = price;
            Gear = gear;
            Id = id;
        }

        public Bicycle()
        {
            Color = "Not applied";
            Gear = 3;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Color: {Color}, Price: {Price}, Gears: {Gear}";
        }
    }
}
