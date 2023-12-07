// Задайте строку, содержащую латинские буквы в обоих регистрах. Сформируйте строку,
// в которой все заглавные буквы заменены на строчные

void FilterString(string str){
    string res = str.ToLower();
    Console.WriteLine(res);
}

string str = "HeLlO, WoRd!";
FilterString(str);