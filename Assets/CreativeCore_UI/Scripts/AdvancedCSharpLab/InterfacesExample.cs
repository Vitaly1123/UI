using System.Collections.Generic;
using UnityEngine;

// Interface declaration
// Interface names usually start with 'I'
public interface IDamageable
{
    Vector3 Position { get; }
    void Damage(float damage);
}

// Implementing the interface in a class
public class PlayerHealth : MonoBehaviour, IDamageable
{
    public float startingHealth = 100f;
    private float m_CurrentHealth;

    // Implementing the Position property from interface
    public Vector3 Position
    {
        get { return transform.position; }
    }

    void Start()
    {
        m_CurrentHealth = startingHealth;
    }

    // Implementing the Damage method from interface
    public void Damage(float damage)
    {
        m_CurrentHealth -= damage;
        Debug.Log("Player took damage. Health: " + m_CurrentHealth);
    }
}

// Another class implementing the same interface
[System.Serializable]
public class ProtonShield : IDamageable
{
    public float hitPoints = 50f;
    public Vector3 Position { get { return Vector3.zero; } }

    public void Damage(float damage)
    {
        hitPoints -= damage;
        Debug.Log("Shield absorbed damage. Points left: " + hitPoints);
    }
}

// Using the interface to affect different objects
public class InterfacesExample : MonoBehaviour
{
    public float range = 10f;
    public float explosionDamage = 35f;

    [SerializeReference]
    public IDamageable shield = new ProtonShield();

    private List<IDamageable> m_AllDamageables = new List<IDamageable>();

    void Start()
    {
        // Find all objects that can take damage
        MonoBehaviour[] allScripts = FindObjectsByType<MonoBehaviour>(FindObjectsSortMode.None);

        for (int i = 0; i < allScripts.Length; i++)
        {
            if (allScripts[i] is IDamageable)
                m_AllDamageables.Add(allScripts[i] as IDamageable);
        }
    }

    [ContextMenu("Explode")] // You can run this from the Inspector
    public void Explode()
    {
        for (int i = 0; i < m_AllDamageables.Count; i++)
        {
            float distance = Vector3.Distance(m_AllDamageables[i].Position, transform.position);
            if (distance < range)
            {
                m_AllDamageables[i].Damage(explosionDamage);
            }
        }
    }
}