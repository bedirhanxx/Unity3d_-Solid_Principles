using UnityEngine;

/*
 * Let's consider a scenario where we have a base class
 * Weapon and two derived classes Sword and Bow.
 * The Weapon class defines a method Attack() which is overridden by the subclasses.
 * Both subclasses can be used interchangeably without affecting the code that depends on the Weapon class.
 */



// Base class
public abstract class Weapon
{
  public abstract void Attack();
}

// Derived class for Sword
public class Sword : Weapon
{
  public override void Attack()
  {
    Debug.Log("Swinging the sword!");
  }
}

// Derived class for Bow
public class Bow : Weapon
{
  public override void Attack()
  {
    Debug.Log("Shooting an arrow!");
  }
}

// A class that uses Weapon
public class Player : MonoBehaviour
{
  private Weapon currentWeapon;

  public void EquipWeapon(Weapon weapon)
  {
    currentWeapon = weapon;
  }

  public void PerformAttack()
  {
    if (currentWeapon != null)
    {
      currentWeapon.Attack();
    }
    else
    {
      Debug.Log("No weapon equipped!");
    }
  }
}
