using UnityEngine;
/*A paladin can attack, heal, and defend.*/
public class Paladin : MonoBehaviour, IAttack, IHeal, IDefend
{
  public void Attack()
  {
    Debug.Log("Paladin attacks!");
    // Implement attack logic
  }

  public void Heal()
  {
    Debug.Log("Paladin heals!");
    // Implement heal logic
  }

  public void Defend()
  {
    Debug.Log("Paladin defends!");
    // Implement defend logic
  }
}