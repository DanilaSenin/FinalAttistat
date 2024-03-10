string [] Array = {"27", "354", "365", "-1", "354223"};
string [] Result = new string[Array.Length];
int h = Array.Length;
int NumElem = 0;

for (int i = 0; i<h; i+=1) {
    if (Array[i].Length <= 3) {
        Result[NumElem] = Array[i];
        NumElem += 1;
    }
}

for (int i = 0; i<Result.Length; i++) {
    Console.WriteLine(Result[i]);
}  