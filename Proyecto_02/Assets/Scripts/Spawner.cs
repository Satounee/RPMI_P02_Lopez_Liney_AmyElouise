using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject adventurer;
    public Transform spawnPoint;
    public Inventory inventory;



    private void Start()
    {
         // inventory = GameObject.Find("Inventory").GetComponent<Inventory>();
    }



    private void OnMouseDown()
    {
        Debug.Log("Spawn"); //pone mensaje
        if (inventory.coins >= 5)
        {
            Instantiate(adventurer, spawnPoint.position, spawnPoint.rotation);
            inventory.AddCoins(-5);
        }
    }
    
    
        
}




