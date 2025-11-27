using UnityEngine;

public class SpawnerEnemies : MonoBehaviour
{
    public GameObject skeletonOne;
    public Transform skeletonSpawn;
    public float spawnSpeed1;
    public float spawnSpeed2;
    void Start()
    {
        InvokeRepeating("InstantiateSkeleton", spawnSpeed1, spawnSpeed2);
    }

    private void InstantiateSkeleton()
    {
        Instantiate(skeletonOne,skeletonSpawn.position, skeletonSpawn.rotation);
    }
}
