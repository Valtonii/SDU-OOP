int size = 12;
int[] threesArr = new int[size];

for (int i = 0; i<threesArr.Length; i++) {
    threesArr[i] = i*3;
}

Console.WriteLine(threesArr[0]);
Console.WriteLine(threesArr[threesArr.Length-1]);