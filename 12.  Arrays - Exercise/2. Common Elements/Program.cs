string[] inputOne = Console.ReadLine().Split();
string[] inputTwo = Console.ReadLine().Split();

// 1.
//if (inputOne.Length == inputTwo.Length)
//{
//    for (int i = 0; i < inputOne.Length; i++)
//    {
//        foreach (var item in inputOne)
//        {
//            if (item == inputTwo[i])
//            {
//                Console.Write(item + " ");
//            }
//        }
//    }
//}
//else
//{
//    for (int i = 0; i < inputTwo.Length; i++)
//    {
//        foreach (var item in inputOne)
//        {
//            if (item == inputTwo[i])
//            {
//                Console.Write(item + " ");
//            }
//        }
//    }
//}
for (int i = 0; i < inputTwo.Length; i++)
{
    // 2.
    //for (int j = 0; j < inputOne.Length; j++)
    //{
    //    if (inputTwo[i] == inputOne[j])
    //    Console.Write(inputTwo[i] + " ");
    //}
    
    // 3. 
    string currentElement = inputTwo[i];
    if (inputOne.Contains(currentElement))
    {
        Console.Write(currentElement + " ");
    }
}