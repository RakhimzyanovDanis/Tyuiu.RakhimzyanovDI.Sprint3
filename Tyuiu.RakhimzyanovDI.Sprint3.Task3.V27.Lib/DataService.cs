using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.RakhimzyanovDI.Sprint3.Task3.V27.Lib
{
    public class DataService : ISprint3Task3V27
    {
        public int ConvertStringToInt(string value)
        {
            {
                if (value == null)
                    throw new ArgumentNullException(nameof(value), "Строка не может быть null.");

                string digitsOnly = "";

                foreach (char c in value)
                {
                    if (char.IsDigit(c))
                    {
                        digitsOnly += c;
                    }
                }

                if (digitsOnly.Length == 0)
                    throw new ArgumentException("В строке нет цифр — преобразовать в число невозможно.");

                return int.Parse(digitsOnly);
            }
        }
    }
}
