using UnityEngine;
using System.Collections;

// 1. Static variable in a standard class
public class EnemyStatic
{
    public static int enemyCount = 0;

    public EnemyStatic()
    {
        // Increment the shared counter
        enemyCount++;
    }
}

// 2. Static variable in a MonoBehaviour class
public class PlayerStatic : MonoBehaviour
{
    public static int playerCount = 0;

    void Start()
    {
        // Shared counter for all players
        playerCount++;
    }
}

// 3. Entirely static class for utility methods
public static class Utilities
{
    // Static method can be called without an object
    public static int Add(int num1, int num2)
    {
        return num1 + num2;
    }
}

// Main class to run the examples
public class StaticsExample : MonoBehaviour
{
    void Start()
    {
        // Testing EnemyStatic
        EnemyStatic e1 = new EnemyStatic();
        EnemyStatic e2 = new EnemyStatic();
        EnemyStatic e3 = new EnemyStatic();
        int totalEnemies = EnemyStatic.enemyCount;

        // Testing Utilities static method
        int sum = Utilities.Add(5, 6);

        Debug.Log("Total enemies: " + totalEnemies);
        Debug.Log("Sum from Utilities: " + sum);

    }
}