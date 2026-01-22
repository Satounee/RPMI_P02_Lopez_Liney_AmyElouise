using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class Enemies : MonoBehaviour
{
    public float enemyspeed;
    public int enemylife;
    public GameObject prize;
    public Transform prizeSpawn;
    public Animator animator;
    private bool isDead;
    private bool movement;

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
        }


        if (enemylife <= 0)
        {
            isDead = true;
            animator.SetBool("dead", true);
            //Destroy(gameObject);
            Invoke("DestroyEnemy", 2);

        }
    }
    void Start()
    {
        movement = false;

        // gameOverText = GameObject.Find("GameOver").GetComponent<TextMeshProUGUI>();        
    }
    void Update()
    {
        //if (!isDead)
        if (isDead == false)
        {
            if (movement == true)
            {

                transform.Translate(-enemyspeed * Time.deltaTime, 0, 0, Space.World);
            }

        }
        //if (isDead == true) - no hace falta ponerlo
        if (isDead == true)
        {
            enemyspeed = 0;

        }


    }

    public void SpawnAnimationEnded() 
    {
        movement = true;
    }

    public void DestroyEnemy()
    {
        Destroy(gameObject);
        Instantiate(prize, prizeSpawn.position, prizeSpawn.rotation);
    }


}
