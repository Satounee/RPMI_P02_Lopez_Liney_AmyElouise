using UnityEngine;

public class Chest : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        print("Ha' perdio");
        if (collision.gameObject.CompareTag("Enemy"))
        {

          
            Destroy(gameObject);

           

        }
    }
}
