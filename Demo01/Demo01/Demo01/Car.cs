using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo01
{
    internal class Car
    {
        // Attributes:

        private int id;
        private int speed;
        private string model;

        // Constructors:
        //public Car()
        //{
        //    // Do Nothing
        //}
        //  Costructor Chaning, internal Costructor
        public Car(int id, string model, int speed) : this(id, model)
        {
            Speed = speed;
        }
        public Car(int id, string model) : this(id)
        {
            Model = model;
        }
        public Car(int id)
        {
            Id = id;
        }
        // Encapsulation[Full Property]:
        // ID:
        public int Id
        {
            set
            {
                id = value;
            }
            get
            {
                return id;
            }
        }
        // Model:
        public string Model
        {
            set
            {
                model = value;
            }
            get
            {
                return model;
            }
        }
        // Speed:
        public int Speed
        {
            set
            {
                if (value > 0)
                {
                    speed = value;
                }
            }
            get
            {
                return speed;
            }
        }
        // Methods:
        public override string ToString()
        {
            return $"ID: {id} Model: {model} Speed: {speed}";
        }
    }
}
