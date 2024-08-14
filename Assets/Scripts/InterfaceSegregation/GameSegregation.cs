using UnityEngine;
/*You can now use these classes in your game depending on what abilities each character should have.*/
public class GameSegregation : MonoBehaviour
{
    public Warrior warrior;
    public Healer healer;
    public Paladin paladin;

    void Start()
    {
        warrior.Attack(); // Output: "Warrior attacks!"
        warrior.Defend(); // Output: "Warrior defends!"

        healer.Heal();    // Output: "Healer heals!"

        paladin.Attack(); // Output: "Paladin attacks!"
        paladin.Heal();   // Output: "Paladin heals!"
        paladin.Defend(); // Output: "Paladin defends!"
    }
}
