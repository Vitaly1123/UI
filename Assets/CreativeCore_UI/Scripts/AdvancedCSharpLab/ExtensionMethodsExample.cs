using UnityEngine;
using System.Collections;

// It is common to create a class to contain all of your
// extension methods. This class must be static.
public static class ExtensionMethods
{
    // Extension methods must be declared static. 
    // The 'this' keyword before the first parameter tells C# 
    // that this method "attaches" to the Transform class.
    public static void ResetTransformation(this Transform trans)
    {
        trans.position = Vector3.zero;
        trans.localRotation = Quaternion.identity;
        trans.localScale = new Vector3(1, 1, 1);
    }
}

public class ExtensionMethodsExample : MonoBehaviour
{
    void Start()
    {
        // Now you can call ResetTransformation() directly 
        // on any Transform object, just like a built-in method.
        transform.ResetTransformation();

        Debug.Log("Transform has been reset using an Extension Method!");
    }
}