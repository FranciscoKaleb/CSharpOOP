using CSharpOOP.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP.Units.Movable
{
    public abstract class Movable : Unit
    {
        private const int DEFAULT_MOVEMENT_SPEED = 100;
        private const MovementType DEFAULT_MOVEMENT_TYPE = MovementType.Land;

        private int movementSpeed;
        private MovementType movementType;

        public int MovementSpeed
        {
            get
            {
                return this.movementSpeed;
            }
            set
            {
                this.movementSpeed = value; 
            }
        }
        public MovementType MovementType
        {
            get
            {
                return movementType;
            }
            set
            {
                this.movementType = value;
            }
        }

        public Movable()
            :this(DEFAULT_MOVEMENT_SPEED,DEFAULT_MOVEMENT_TYPE)
        {

        }
        public Movable(int movementSpeed, MovementType movementType)
        {
            MovementSpeed = movementSpeed;
            MovementType = movementType;
        }

        public abstract void Move(int pauseBetweenMove);
        public abstract void Stop(Unit unit);

    }
}
