//Brute Force Solution: Any Sorting Algorithm
//Merge Sort = Complexity O(nlogn)

//Better Solution

int cnt0 = 0, cnt1 = 0, cnt2 = 0;

string input = Console.ReadLine();

//int[] arr = input.Split(' ')
//            .Select(int.Parse)
//            .ToArray();

int[] arr = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

int length = arr.Length;
//Console.WriteLine("Print arr length: " + length + "\n");

for (int i=0; i<length; i++)
{
    if (arr[i] == 0) cnt0++;
    if (arr[i] == 1) cnt1++;
    if (arr[i] == 2) cnt2++;
}
//Console.WriteLine("Print Result 0: " + cnt0 + "\n");
//Console.WriteLine("Print Result 1: " + cnt1 + "\n");
//Console.WriteLine("Print Result 2: " + cnt2 + "\n");

for (int i = 0; i < cnt0; i++)
{
    arr[i] = 0;
}

//Console.WriteLine("Arr 1 Start: " + cnt0 + "Arr 1 End: " + (cnt0 + cnt1) + "\n");

for (int i = cnt0; i < cnt0+cnt1; i++)
{
    arr[i] = 1;
}

for (int i = cnt0+cnt1; i < length; i++)
{
    arr[i] = 2;
}

//Console.WriteLine("Print Result: ");
for (int i = 0; i < length; i++)
{
    Console.WriteLine(" " + arr[i]);
}

// Sort an array of 0s, 1s and 2s - Dutch National Flag Problem ...The Dutch National Flag algorithm

string inputArr = Console.ReadLine();

int[] arrValue = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

int n = arrValue.Length;

int low = 0, mid = 0, high = n - 1;

while(mid <= high)
{
    if (arrValue[mid] == 0)
    {

    }
}