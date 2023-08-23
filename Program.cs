static int BinarySearch(int[] array, int searchedValue, int left, int right) {
    int count = 0;
    while (left <= right) {
        var middle = (left + right) / 2;

        if (searchedValue == array[middle]) {
            Console.WriteLine($"We found value: {searchedValue} at index array[{Array.IndexOf(array, searchedValue)}] in {count} steps");
            return middle; 
        }
        else if (searchedValue < array[middle]) {
            right = middle - 1;count++;
        }
        else {
            left = middle + 1;count++;
        }
    }
    Console.WriteLine("We didn't find value: " + searchedValue);
    return -1;
}

Random random = new Random();
int[] nums = new int[100];
for (int i = 0; i < nums.Length; i ++) {
    nums[i] = random.Next(1, 50);
}

string numsStr = string.Join(", ", nums);
Console.WriteLine("nums: " + numsStr);

Console.WriteLine();

BinarySearch (nums, random.Next (1, 50), 0, nums.Length - 1);