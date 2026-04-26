using UnityEngine;
using System;

// Base classes for serialization example
[Serializable]
public class Animal { }

[Serializable]
public class Mammal : Animal
{
    public void GrowFur() { }
}

public class Cat : Mammal
{
    public void Meow() { Debug.Log("Meow!"); }
}

public class Dog : Mammal
{
    public void Woof() { Debug.Log("Woof!"); }
}

public class PolymorphismExample : MonoBehaviour
{
    // Serialize actual instance instead of variable type
    [SerializeReference]
    public Mammal myPet = new Cat();

    void Start()
    {
        // Upcasting: storing child classes in a parent array
        Mammal[] mammals = new Mammal[2];
        mammals[0] = new Cat();
        mammals[1] = new Dog();

        // Type checking and safe downcasting
        if (mammals[0] is Cat)
        {
            Cat myCat = mammals[0] as Cat;
            myCat.Meow();
        }

        // Direct downcasting
        if (mammals[1] is Dog)
        {
            Dog myDog = (Dog)mammals[1];
            myDog.Woof();
        }

        // Parent method is available for all inherited classes
        foreach (Mammal m in mammals)
        {
            m.GrowFur();
        }
    }
}