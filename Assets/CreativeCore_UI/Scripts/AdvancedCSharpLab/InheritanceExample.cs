using UnityEngine;
using System.Collections;

// Base class (Parent)
public class Fruit
{
    public string color;

    // First constructor
    public Fruit()
    {
        color = "orange";
        Debug.Log("1st Fruit Constructor Called");
    }

    // Second constructor with parameter
    public Fruit(string newColor)
    {
        color = newColor;
        Debug.Log("2nd Fruit Constructor Called");
    }

    public void Chop()
    {
        Debug.Log("The " + color + " fruit has been chopped.");
    }

    public void SayHello()
    {
        Debug.Log("Hello, I am a fruit.");
    }
}

// Derived class (Child)
public class Apple : Fruit
{
    public Apple()
    {
        // Accessing public variable from parent
        color = "red";
        Debug.Log("1st Apple Constructor Called");
    }

    // Using "base" to call specific parent constructor
    public Apple(string newColor) : base(newColor)
    {
        Debug.Log("2nd Apple Constructor Called");
    }
}

public class InheritanceExample : MonoBehaviour
{
    void Start()
    {
        Debug.Log("--- Default Constructors ---");
        Fruit myFruit = new Fruit();
        Apple myApple = new Apple();

        myFruit.SayHello();
        myApple.SayHello(); // Apple has access to Fruit methods

        Debug.Log("--- Constructors with string ---");
        myFruit = new Fruit("yellow");
        myApple = new Apple("green");

        myFruit.Chop();
        myApple.Chop();
    }
}