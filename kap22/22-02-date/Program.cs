long[] timestampValues = {1000,10000,100000,1000000};

for(int i = 0; i<timestampValues.Length; i++){
    DateTimeOffset timestampOffset = DateTimeOffset.FromUnixTimeMilliseconds(timestampValues[i]);
    DateTime dateTime = timestampOffset.DateTime;
    Console.WriteLine(dateTime);
}

