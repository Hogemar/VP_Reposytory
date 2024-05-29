using Microsoft.AspNetCore.Mvc;

namespace CalcWebApp
{
    public class TestController : Controller
    {
        // GET: /Test/
        public string Index()
        {
            return "this is test";
        }
        // GET: /Test/CheckDate
        public string CheckDate()
        {
            return $"today is {DateTime.Now.Date}";
        }

       // GET: /Test/CheckDate
        public string CheckDateWithName(string name)
        {
            return $"hi {name}, today is {DateTime.Now.Date}";
        }


        // GET: /Test/Calculate
        public string Calculate(float num1, float num2, string operation)
        {
            float result;
            string expression = $"{num1} {operation} {num2}";

            switch (operation)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    if (num2 == 0)
                    {
                        return "Ошибка: деление на ноль (математически это → ∞)";
                    }
                    result = num1 / num2;
                    break;
                default:
                    return "Ошибка: недопустимая операция";
            }

            return $"{expression} = {result}";
        }

        // GET: /Test/DeveloperInfo
        public string DeveloperInfo()
        {
            return "Разработчик: Тимохин Евгений. GitHub: https://github.com/1xxxJTxxx1";
        }

    }
}
