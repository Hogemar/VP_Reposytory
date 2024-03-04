using System.Text;
using System.Text.RegularExpressions;

namespace RegexLabLogic
{
	public static class Regulars
	{
		// Подсчёт входящих почтовых индексов (с любыми разделителями)
		public static int CountPostcodes(this string str)
		{
			return Regex.Count(str, @"\b\d{6}\b");
		}

		// Меняет местами первую и последнюю букву каждого слова
		public static string WordToDorw(this string sentence)
		{
			var matches = Regex.Matches(sentence, @"\w+").ToArray(); // Получить все слова
			var words = new string[matches.Length]; // Массив слов
			var dorws = new string[matches.Length]; // Массив обработанных слов
			for (int i = 0; i < matches.Length; i++)
			{
				words[i] = matches.GetValue(i).ToString(); // Получить слово
				StringBuilder dorwSB = new(words[i]);
				dorwSB[0] = words[i][words[i].Length-1]; // Поменять местами первую
				dorwSB[words[i].Length-1] = words[i][0]; // и последнюю буквы
				dorws[i] = dorwSB.ToString(); // Получить обработанное слово
			}
			
			StringBuilder newSentenceSB = new(sentence);   // Изменённое предложение
			for (int i = 0; i < words.Length; i++)
			{
				newSentenceSB.Replace(words[i], dorws[i]); // Замена слов
			}

			return newSentenceSB.ToString();
		}

		// Скрывает городскую часть номера со второй цифры
		public static string HidePhonePart(this string str)
		{
			// Регулярное выражение для телефонов
			string phonePattern = @"\+7 ((\(\d{3}\) \d{3})|(\(\d{4}\) \d{2})|(\(\d{5}\) \d{1}))-\d{2}-\d{2}";

            // Строка со скрытыми номерами
            StringBuilder hiddenSB = new(str); 
			// Количество номеров
			int phonesCount = Regex.Count(str, phonePattern);
			for (int k = 0; k < phonesCount; k++) 
			{
                // Взять телефон
                StringBuilder hiddenPhoneSB = new(Regex.Match(hiddenSB.ToString(), phonePattern).Value);
                // Проход с конца
                for (int i = hiddenPhoneSB.Length - 1; i >= 0; i--) 
				{
                    // Скрывать цифры
                    if (hiddenPhoneSB[i] != '-')
						hiddenPhoneSB[i] = 'x';
                    // До первой цифры после пробела исключительно
                    if (hiddenPhoneSB[i-2] == ' ') 
						break;						
				}
				// Замена телефона на скрытый
				hiddenSB.Replace(Regex.Match(hiddenSB.ToString(), phonePattern).Value, hiddenPhoneSB.ToString());
			}

			return hiddenSB.ToString();
		}

		// Возвращает входящие в строку автономера в виде последовательности с раделителем ';'
		public static string GetLicensePlates(this string str)
		{
			// Регулярное выражение для автономеров
			string platePattern = @"(([АВЕКМНОРСТУХ]{2} \d{3,4})|([АВЕКМНОРСТУХ]{2} \d{3,4} [АВЕКМНОРСТУХ]{1})|([АВЕКМНОРСТУХ]{2} \d{2} [АВЕКМНОРСТУХ]{2})|([АВЕКМНОРСТУХ]{1} ((\d{3} [АВЕКМНОРСТУХ]{2})|(\d{4} )))|(\d{3,4} [АВЕКМНОРСТУХ]{1,2})) \d{2,4}";

			StringBuilder platesSB = new();
			var plates = Regex.Matches(str, platePattern).ToArray();
            foreach (var plate in plates)
            {
				platesSB.Append(plate.Value + "; ");
            }

			return platesSB.ToString();
        }

		// Возвращает строку, содержащую IPv4 адреса в десятичном формате из оригинальной строки,
		// разделённые указанным разделителем
		public static string GetIPv4Adresses(this string str, string separator = "; ")
		{
			// Регулярное выражение для IPv4
			string adressPatern = @"\b(((2(([0-4][0-9])|5[0-5])|(1[0-9][0-9])|([1-9][0-9])|[0-9])\.){3}(2(([0-4][0-9])|5[0-5])|(1[0-9][0-9])|([1-9][0-9])|[0-9]))\b";

            StringBuilder adressesSB = new();

            var adresses = Regex.Matches(str, adressPatern).ToArray();
            foreach (var adress in adresses)
                adressesSB.Append(adress.Value + separator);

            return adressesSB.ToString();
        }
    }
}
