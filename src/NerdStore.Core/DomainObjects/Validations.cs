using System.Text.RegularExpressions;

namespace NerdStore.Core.DomainObjects
{
    public class Validations
    {
        public static void ValidateIsEqual(object obj1, object obj2, string message)
        {
            if (!obj1.Equals(obj2)) throw new DomainException(message);
        }

        public static void ValidateIsDifferent(object obj1, object obj2, string message)
        {
            if (obj1.Equals(obj2)) throw new DomainException(message);
        }

        public static void ValidateCharacters(string value, int max, string message)
        {
            var length = value.Trim().Length;

            if (length > max) throw new DomainException(message);
        }

        public static void ValidateCharacters(string value, int min, int max, string message)
        {
            var length = value.Trim().Length;

            if (length < min || length > max) throw new DomainException(message);
        }

        public static void ValidateExpression(string pattern, string value, string message)
        {
            var rgx = new Regex(pattern);

            if (!rgx.IsMatch(value)) throw new DomainException(message);
        }

        public static void ValidateIsEmpty(string value, string message)
        {
            if (value == null || value.Trim().Length == 0) throw new DomainException(message);
        }

        public static void ValidateIsNull(object obj1, string message)
        {
            if (obj1 == null) throw new DomainException(message);
        }

        public static void ValidateMinMax(double value, double min, double max, string message)
        {
            if (value < min || value > max) throw new DomainException(message);
        }

        public static void ValidateMinMax(float value, float min, float max, string message)
        {
            if (value < min || value > max) throw new DomainException(message);
        }

        public static void ValidateMinMax(int value, int min, int max, string message)
        {
            if (value < min || value > max) throw new DomainException(message);
        }

        public static void ValidateMinMax(long value, long min, long max, string message)
        {
            if (value < min || value > max) throw new DomainException(message);
        }

        public static void ValidateMinMax(decimal value, decimal min, decimal max, string message)
        {
            if (value < min || value > max) throw new DomainException(message);
        }

        public static void ValidateIfMinEqualMax(long value, long min, string message)
        {
            if (value <= min) throw new DomainException(message);
        }

        public static void ValidateIfMinEqualMax(decimal value, decimal min, string message)
        {
            if (value <= min) throw new DomainException(message);
        }

        public static void ValidateIfMinEqualMax(int value, int min, string message)
        {
            if (value <= min) throw new DomainException(message);
        }

        public static void ValidateIfMinEqualMax(double value, double min, string message)
        {
            if (value <= min) throw new DomainException(message);
        }

        public static void ValidateIsFalse(bool boolvalue, string message)
        {
            if (boolvalue) throw new DomainException(message);
        }

        public static void ValidateIsTrue(bool boolvalue, string message)
        {
            if (!boolvalue) throw new DomainException(message);
        }
    }
}
