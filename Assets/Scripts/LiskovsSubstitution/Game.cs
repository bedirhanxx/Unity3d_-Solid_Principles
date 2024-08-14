using UnityEngine;

// Usage example
public class Game : MonoBehaviour
{
    void Start()
    {
        Player player = new Player();

        Weapon sword = new Sword();
        Weapon bow = new Bow();

        player.EquipWeapon(sword);
        player.PerformAttack();  // Output: "Swinging the sword!"

        player.EquipWeapon(bow);
        player.PerformAttack();  // Output: "Shooting an arrow!"
    }
}