using UnityEngine;
using System.Collections;

public class SomeClass
{
    // First version of Add: works with integers
    // Signature: Add(int, int)
    public int Add(int num1, int num2)
    {
        return num1 + num2;
    }

    // Second version of Add: works with strings
    // Signature: Add(string, string)
    public string Add(string str1, string str2)
    {
        return str1 + str2;
    }
}

public class OverloadingExample : MonoBehaviour
{
    void Start()
    {
        SomeClass myClass = new SomeClass();

        // Calls the integer version
        int sum = myClass.Add(1, 2);
        Debug.Log("Sum of ints: " + sum);

        // Calls the string version
        string fullText = myClass.Add("Hello ", "World");
        Debug.Log("Full text: " + fullText);
    }
}