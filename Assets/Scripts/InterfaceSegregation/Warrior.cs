using UnityEngine;
/*
 * Now, let’s create classes that implement these interfaces based on what abilities they need. 
 * A warrior can attack and defend, but cannot heal.
 */

public class Warrior : MonoBehaviour, IAttack, IDefend
{
  public void Attack()
  {
    Debug.Log("Warrior attacks!");
    // Implement attack logic
  }

  public void Defend()
  {
    Debug.Log("Warrior defends!");
    // Implement defend logic
  }
}