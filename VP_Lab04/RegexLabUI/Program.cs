using RegexLabLogic;

#region 1
Console.WriteLine("\t--- Задание 1 ---\n\n");

string postcodes = "146249 489214, 741367;412634 - 142014\r\n456124791465\r\n145621+462149-621367\\614657;513954,54\r\n165546\r\n236342.542345.345132.435634";
Console.WriteLine($"{postcodes}\n\nЧисло почтовых индексов = {postcodes.CountPostcodes()}\n\n");
#endregion

#region 2
Console.WriteLine("\t--- Задание 2 ---\n\n");

string sentence = "Как только солнце заходит за горизонт,\n" +
	" начинается магия вечера - природа окутывается таинственным полумраком,\n" +
	" а небо наполняется мерцающими звездами:\n" +
	" это время, когда сердце наполняется умиротворением и вдохновением.";

Console.WriteLine($"{sentence}\n\n{sentence.WordToDorw()}\n\n");
#endregion

#region 3
Console.WriteLine("\t--- Задание 3 ---\n\n");

string phones = "+7 (495) 123-78-15\n+7 (8474) 45-78-97\n+7 (49112) 5-43-33";
Console.WriteLine($"{phones}\n\n{phones.HidePhonePart()}\n\n");
#endregion
	
#region 4
Console.WriteLine("\t--- Задание 4 ---\n\n");

string licensePlates = "С 227 НА 94;В 555 РХ 095\nАО 365 789,УА 124 А 3547-АН 7331 47\n3146 УВ 64";

Console.WriteLine($"{licensePlates}\n\n{licensePlates.GetLicensePlates()}\n\n");
#endregion

#region 5
Console.WriteLine("\t--- Задание 5 ---\n\n");

// Здесь 9 адресов и один неправильный
string textWithAdressesV4 = 
	"Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed at 192.168.1.1, ante.\n" +
	" Nulla facilisi. Integer nec 10.20.30.40 justo. Fusce 172.16.0.1 ac mauris auctor, 8.8.8.8 in commodo nisl.\n" +
	" Etiam tincidunt 255.255.255.0; turpis vel semper. Duis 123.45.67.89 vitae velit at 192.0.2.1 congue.\n" +
	" Phasellus 100.200.300.400 eget mauris id 172.31.255.254 dictum. Sed 1.2.3.4 vel turpis";

Console.WriteLine($"{textWithAdressesV4}\n\n{textWithAdressesV4.GetIPv4Adresses("\n")}\n\n");
#endregion

#region Доп_IPv6
Console.WriteLine("\t--- Доп задание – IPv6 адреса ---\n\n");

// Здесь 4 адреса
string textWithAdressesV6 =
    "Сегодня решил посетить долгожданную выставку про IPv6. Я прошел мимо стен с IPv6-адресом 2001:0db8::8a2e:0370:7334,\n" +
	" где отображались самые последние достижения в разработке сетей. Увидев интересный стенд с IPv6-адресом\n" +
	" 2001:0db8:85a3:0000:0000:8a2e:0370:7335, который демонстрировал различные особенности нового протокола,\n" +
	" я решил ознакомиться с более подробной информацией. В этой области большой прогресс,\n" +
	" и даже удаленные регионы начинают оснащаться такими сетями — например, в моем родном городе уже активно внедряются IPv6-адреса,\n" +
	" они начинают с 5ed1::9cd2:0000:7336. Я удивлен, насколько широким становится применение этой технологии,\n" +
	" и даже задумываюсь о том, чтобы перевести свою домашнюю сеть на IPv6 адрес c67b:1262:0b47:0000:0000:0000:0ab0:ff45,\n" +
	" чтобы быть в курсе новейших технологий.";

Console.WriteLine($"{textWithAdressesV6}\n\n{textWithAdressesV6.GetIPv6Adresses("\n")}\n\n");

#endregion