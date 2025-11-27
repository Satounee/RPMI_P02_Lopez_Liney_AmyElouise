using TMPro;
using UnityEngine;

public class Enemies : MonoBehaviour
{
    public float enemyspeed;
    public int enemylife;
    public GameObject prize;
    public Transform prizeSpawn;
    public TextMeshProUGUI gameOverText;
    private void OnCollisionEnter(Collision collision)
    {

        

        print("choqueLMAO");

       //if (collision.gameObject.CompareTag("Bullet"))
        {

          //  Destroy(collision.gameObject); 

        }

        

        if (collision.gameObject.CompareTag("Bullet"))
        {

            enemylife = enemylife - 25;
        
        }

     

        if (collision.gameObject.CompareTag("Endgame")) 
        
        {

            enemyspeed = 0;
            gameOverText.gameObject.SetActive(true);

        }




    }
     void Start()
    {
        gameOverText.gameObject.SetActive(false);


    }


    void Update()
    {
        transform.Translate(0, 0,enemyspeed);

        if (enemylife <= 0)
        {


            Destroy(gameObject);
            Instantiate(prize, prizeSpawn.position, prizeSpawn.rotation);

        }

    }

}
