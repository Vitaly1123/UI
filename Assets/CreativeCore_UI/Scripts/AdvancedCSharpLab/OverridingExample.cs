using UnityEngine;
using System.Collections;

// Added "Overriding" prefix to avoid conflict with InheritanceExample classes
public class OverridingFruit
{
    public OverridingFruit()
    {
        Debug.Log("1st Fruit Constructor Called");
    }

    // These methods are virtual, so they can be overridden
    public virtual void Chop()
    {
        Debug.Log("The fruit has been chopped.");
    }

    public virtual void SayHello()
    {
        Debug.Log("Hello, I am a fruit.");
    }
}

public class OverridingApple : OverridingFruit
{
    public OverridingApple()
    {
        Debug.Log("1st Apple Constructor Called");
    }

    // Overriding the parent methods
    public override void Chop()
    {
        // Calling the parent version first
        base.Chop();
        Debug.Log("The apple has been chopped.");
    }

    public override void SayHello()
    {
        base.SayHello();
        Debug.Log("Hello, I am an apple.");
    }
}

public class OverridingExample : MonoBehaviour
{
    void Start()
    {
        OverridingApple myApple = new OverridingApple();

        // Testing overridden methods
        myApple.SayHello();
        myApple.Chop();

        Debug.Log("--- Polymorphism Test ---");

        // Even when upcast to Fruit, the Apple version is called
        OverridingFruit myFruit = new OverridingApple();
        myFruit.SayHello();
        myFruit.Chop();
    }
}