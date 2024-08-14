using UnityEngine;

/*To add a new ability, simply create a new class implementing the IAbility interface without modifying existing code.*/
public class LightningAbility : IAbility
{
  public void Use()
  {
    Debug.Log("Using Lightning Ability!");
    // Implement lightning ability logic here
  }
}