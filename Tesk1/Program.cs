// Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива.

string GetStringFromCharArray(char [,] chars){
    string res = "";
    foreach (char elem in chars){
        res += elem;
    }
    return res;
}

char [,] chars = {
    {'a','b','c'},
    {'d','e','f'},
    {'g','h','i'},
};    
string str = GetStringFromCharArray(chars);
Console.WriteLine(str);