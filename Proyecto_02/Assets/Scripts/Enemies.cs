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
    private AdventurerController adventurerToAttack;
    private Inventory inventory;
    
   

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Adventurer")) 
        { 
        
            movement = false;
            animator.SetBool("attack", true);
            other.GetComponent<AdventurerController>().Adventurerlife -= 100; // = 0 es igual :)
            Invoke("Continuar", 3);
        }
    }

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
            Invoke("EndGame", 0);

            
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
        inventory = GameObject.Find("Inventory").GetComponent<Inventory>();
        movement = false;
        animator.SetBool("gameover", false);


        // gameOverText = GameObject.Find("GameOver").GetComponent<TextMeshProUGUI>();        
    }
    void Update()
    {
        //if (!isDead)
        if (isDead == false)
        {
            if (movement == true)
            {
                RaycastHit hitInfo;
                if (Physics.Raycast(transform.position, transform.forward, out hitInfo, 0.5f, LayerMask.GetMask("Heroes")))
                {
                    if (hitInfo.collider != null)
                    {
                        adventurerToAttack = hitInfo.collider.GetComponent<AdventurerController>();
                    }
                    movement = false;
                    
                }

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
        inventory.AddEnemies(1);
        Instantiate(prize, prizeSpawn.position, prizeSpawn.rotation);
        
        
    }

    public void Continuar() 
    {
        animator.SetBool("attack", false);
        movement = true;
       
    }
    public void EndGame()
    {
        animator.SetBool("gameover", true);
        movement= false;
    }
}
