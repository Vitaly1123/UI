using UnityEngine;
using System.Collections;

// Generic method example
public class GenericMethods
{
    // The 'T' is a placeholder that will be replaced 
    // with an actual type at runtime.
    public T GenericMethod<T>(T param)
    {
        return param;
    }
}

// Generic class example
// This class can hold and update an item of any type 'T'
public class GenericClass<T>
{
    T item;

    public void UpdateItem(T newItem)
    {
        item = newItem;
    }
}

public class GenericsExample : MonoBehaviour
{
    void Start()
    {
        // --- Testing Generic Method ---
        GenericMethods myMethods = new GenericMethods();

        // We tell the method to replace 'T' with 'int'
        int number = myMethods.GenericMethod<int>(5);

        // We tell the method to replace 'T' with 'string'
        string text = myMethods.GenericMethod<string>("Hello Generics");

        Debug.Log("Generic Method (int): " + number);
        Debug.Log("Generic Method (string): " + text);


        // --- Testing Generic Class ---
        // We specify the type 'int' when creating the object
        GenericClass<int> myIntClass = new GenericClass<int>();
        myIntClass.UpdateItem(10);

        // We can also create a version for strings
        GenericClass<string> myStringClass = new GenericClass<string>();
        myStringClass.UpdateItem("Generic Class is working");

        Debug.Log("Generic classes created and updated successfully.");
    }
}