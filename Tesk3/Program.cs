// Задайте произвольную строку. Выясните, является ли она палиндромом.

string FilterString(string str){
    string res = str.ToLower();
    string count = "";
    foreach(char elem in res){
        if(elem != ' '){
            count += elem;
        }
    }
    return count;
}

string IsPalindrom(string str){
    for(int i=0; i<str.Length/2; i++){
        if(str[i] != str[str.Length-i-1]){
            return("Строка не является Палиндроном");
        }
    }
    return("Строка является Палиндроном");
}

string str = "Ша лаш";
string res = FilterString(str);
Console.WriteLine(IsPalindrom(res));