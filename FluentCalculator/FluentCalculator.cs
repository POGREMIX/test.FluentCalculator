using System;

namespace Calculator
{
    public enum OperationType
    {
        plus, minus, times, dividedBy
    }

    public class FluentCalculator
    {
        public static Operations zero => new Operations(0);

        public static Operations one => new Operations(1);

        public static Operations two => new Operations(2);

        public static Operations three => new Operations(3);

        public static Operations four => new Operations(4);

        public static Operations five => new Operations(5);

        public static Operations six => new Operations(6);

        public static Operations seven => new Operations(7);

        public static Operations eight => new Operations(8);

        public static Operations nine => new Operations(9);

        public static Operations ten => new Operations(10);
    }

    public class Operations
    {
        private int _value;

        public Values plus => new Values(_value, OperationType.plus);

        public Values minus => new Values(_value, OperationType.minus);

        public Values times => new Values(_value, OperationType.times);

        public Values dividedBy => new Values(_value, OperationType.dividedBy);

        public Operations(int value)
        {
            _value = value;
        }

        public static implicit operator int(Operations value)
        {
            return value._value;
        }
    }

    public class Values
    {
        private int _value;
        private OperationType _type;

        public Operations zero => DoOperation(_type, 0);

        public Operations one => DoOperation(_type, 1);

        public Operations two => DoOperation(_type, 2);

        public Operations three => DoOperation(_type, 3);

        public Operations four => DoOperation(_type, 4);

        public Operations five => DoOperation(_type, 5);

        public Operations six => DoOperation(_type, 6);

        public Operations seven => DoOperation(_type, 7);

        public Operations eight => DoOperation(_type, 8);

        public Operations nine => DoOperation(_type, 9);

        public Operations ten => DoOperation(_type, 10);

        private Operations DoOperation(OperationType type, int value)
        {
            switch (type)
            {
                case OperationType.plus:
                    return new Operations(_value + value);
                case OperationType.minus:
                    return new Operations(_value - value);
                case OperationType.times:
                    return new Operations(_value * value);
                case OperationType.dividedBy:
                    return new Operations(_value / value);
                default:
                    throw new NotImplementedException();
            }
        }

        public Values(int value, OperationType type)
        {
            _value = value;
            _type = type;
        }
    }
}
