using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject adventurer;
    public Transform spawnPoint;



    private void OnMouseDown()
    {
        Debug.Log("Spawn"); //pone mensaje

        Instantiate(adventurer, spawnPoint.position , spawnPoint.rotation);
    }
    
    
        
    }




