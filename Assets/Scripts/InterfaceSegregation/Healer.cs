using UnityEngine;
/*A healer can heal but cannot attack or defend.*/
public class Healer : MonoBehaviour, IHeal
{
  public void Heal()
  {
    Debug.Log("Healer heals!");
    // Implement heal logic
  }
}