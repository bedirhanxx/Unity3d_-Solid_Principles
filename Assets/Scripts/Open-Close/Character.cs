using UnityEngine;
using System.Collections.Generic;

/*he character class uses the abilities without knowing their specific implementations.
 You can easily extend it with new abilities by adding instances of new classes that implement IAbility.*/
public class Character : MonoBehaviour
{
  private List<IAbility> abilities;

  void Awake()
  {
    // Initialize the abilities list
    abilities = new List<IAbility>();

    // Initial abilities - these should be initialized after the list is created
    abilities.Add(new FireAbility());
    abilities.Add(new IceAbility());
    
  }

  public void UseAbility(int index)
  {
    if (index < 0 || index >= abilities.Count)
    {
      Debug.LogError("Invalid ability index!");
      return;
    }

    if (abilities[index] != null)
    {
      abilities[index].Use();
    }
    else
    {
      Debug.LogError("Ability not found!");
    }
  }

  // Method to add new abilities at runtime
  public void AddAbility(IAbility newAbility)
  {
    abilities.Add(newAbility);
  }
}
