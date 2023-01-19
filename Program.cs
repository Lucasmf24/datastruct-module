using System;
using System.Collections.Generic;
int x = 1;
int amount = 1;
List<int> num = new List <int>();
Random rnd = new Random();
long Total = 0;
List<int> Values = new List<int>();
IDictionary< Int32, Int32> num_amount = new Dictionary< Int32, Int32>();
Console.WriteLine("This program is made to simulate sorting a stream of data using lists.");
Console.Write("Please input a very large number, or else it would be boring(Not greater than 99,999,999):");
Total = Convert.ToInt64((Console.ReadLine()));
while(x != Total){
    num.Add(rnd.Next(5001));
    Total = Total-1;
}
num.Sort();
for(int i = 1; i < num.Count(); i++){
    num_amount[num[i]]= amount;

    if(num[i] == num[i-1]){
        num_amount[num[i]] = amount+1;
        amount += 1;
    }
    else{
        amount = 1;
    }
}
var sortedDict = (from entry in num_amount orderby entry.Value descending select entry)
               .ToDictionary(pair => pair.Key, pair => pair.Value).Take(10);
Console.WriteLine("The top 10 numbers used between 0 and 5000 were:");
foreach(KeyValuePair<Int32, Int32> op in sortedDict){
    Console.WriteLine("Number: {0}, Uses: {1}",op.Key, op.Value);

}
Console.WriteLine("Done, hit any button to exit.");
Console.ReadKey(); 