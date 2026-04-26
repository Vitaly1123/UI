using UnityEngine;
using System;
// Using an alias to fix conflict between namespaces
using Random = UnityEngine.Random;

namespace Player
{
    public class PlayerMovement : MonoBehaviour
    {
        void Start()
        {
            float speed = Random.value;
            Debug.Log("Player speed: " + speed);
        }
    }
}

namespace EditorTools.MapCreation
{
    public class Drawing
    {
        // Class for nested namespace example
    }
}