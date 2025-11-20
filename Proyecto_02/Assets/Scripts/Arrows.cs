using UnityEngine;
using UnityEngine.Rendering;

public class Arrows : MonoBehaviour
{
    public float arrowspeed;
    private void OnCollisionEnter(Collision collision)
    {

        print("choqueLMAO");
        
        if (collision.gameObject.CompareTag("Enemy"))
        {

            Destroy(gameObject);
        
        }

    }

  

   
    void Update()
    {
        {
            transform.Translate(0, 0, arrowspeed);
        }
    }
}
