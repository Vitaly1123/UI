using UnityEngine;
using System.Collections;

public class Humanoid
{
    // Base version of the Yell method
    public void Yell()
    {
        Debug.Log("Humanoid version of the Yell() method");
    }
}

public class Enemy : Humanoid
{
    // This hides the Humanoid version using 'new'
    new public void Yell()
    {
        Debug.Log("Enemy version of the Yell() method");
    }
}

public class Orc : Enemy
{
    // This hides the Enemy version using 'new'
    new public void Yell()
    {
        Debug.Log("Orc version of the Yell() method");
    }
}

public class MemberHidingExample : MonoBehaviour
{
    void Start()
    {
        Humanoid human = new Humanoid();
        Humanoid enemy = new Enemy();
        Humanoid orc = new Orc();

        // Each variable is of type Humanoid, so they all call 
        // the Humanoid version, even if they hold Enemy or Orc objects.
        human.Yell();
        enemy.Yell();
        orc.Yell();

        // To see the specific versions, we need to use the specific types:
        Orc realOrc = new Orc();
        realOrc.Yell(); // This will call the Orc version
    }
}