using System;
using System.Collections.Generic;
using System.Text;

namespace KNNPING.Models
{
    public class DoubleContainer<T, U>
    {
        private T _value;
        private U _otherValue;

        public T Value
        {
            get
            {
                return this._value;
            }
            set
            {
                this._value = value;
            }
        }

        public U OtherValue
        {
            get
            {
                return this._otherValue;
            }
            set
            {
                this._otherValue = value;
            }
        }

        public DoubleContainer(T value, U otherValue)
        {
            this._value = value;
            this._otherValue = otherValue;
        }
    }
}
