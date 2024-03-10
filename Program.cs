string [] Array = {"Rus", "rk", "Kazan"};
string [] Result = new string[Array.Length];
int h = Array.Length;
int NumElem = 0;

for (int i = 0; i<h; i+=1) {
    if (Array[i].Length <= 3) {
        Result[NumElem] = Array[i];
        NumElem += 1;
    }
}