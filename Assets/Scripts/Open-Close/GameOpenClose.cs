using UnityEngine;

public class GameOpenClose : MonoBehaviour
{
  public Character character;  // Assign this in the Unity Inspector

  void Start()
  {
    if (character == null)
    {
      Debug.LogError("Character reference is not set!");
      return;
    }

    character.UseAbility(0);  // Ensure this is valid, e.g., FireAbility
    character.UseAbility(1);  // Ensure this is valid, e.g., IceAbility

    // Optionally, add a new ability at runtime
    character.AddAbility(new LightningAbility());
    character.UseAbility(2);  // Ensure this is valid, e.g., LightningAbility
  }
}