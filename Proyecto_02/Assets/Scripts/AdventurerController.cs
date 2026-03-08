using UnityEngine;

public class AdventurerController : MonoBehaviour
{
    public GameObject arrow;
    public Transform spawnPoint;
    public int Adventurerlife;
    public int Enemydamage;
    public Animator animator;
    public float distance;
    public bool shooting;

    void Start()
    {
        //para que salga cada x tiempo
        // InvokeRepeating("InstantiateArrow", 2, 3); // Entr comillas porque es una cadena de carácteres

       // 2 = la 1era vez, 3 = cada cuanto para los demás
    }

    //private void Update()
    //{
    //        // RETOCA TODO ESTO EL JUEVES
    //    bool enemyInFront = Physics.Raycast(spawnPoint.position, transform.forward, float.MaxValue, LayerMask.GetMask("Enemy"));

    //    //if (shooting) // Comprobar si es verdadero if (shooting == true)
    //    {
    //       // if (!enemyInFront) // Comprobar si es falso if (enemyInFront == false)
    //        {

    //        //    shooting = false;
    //         //   CancelInvoke("InstantiateArrow");

    //        }

    //    }


    //   // if (!shooting) 
    //    {
    //      //  shooting = true;
    //       // InvokeRepeating("InstantiateArrow", 1f, 1f);


    //    }


    //   
    //}

    private void Update()
    {
        bool enemyInFront = Physics.Raycast(spawnPoint.position, transform.forward, distance, LayerMask.GetMask("Enemies"));

        if (Adventurerlife <= 0)
        {

            animator.SetBool("dead", true);
            Invoke("Muerte", 3);
            CancelInvoke("InstantiateArrow");

        }
        if (shooting)
        {
            if (!enemyInFront)
            {
                shooting = false;
                CancelInvoke("InstantiateArrow");
            }
        }
        else 
        {
            shooting = true;
            InvokeRepeating("InstantiateArrow", 1, 1);
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.hotPink;
        Gizmos.DrawRay(spawnPoint.position, transform.forward * distance);
    }

    private void OnTriggerEnter(Collider other) //esto nada que ver
    {
        // TODO comparar si es enemigo - 
       // if (other.gameObject.CompareTag("Enemy"))
        {
            InvokeRepeating("InstantiateArrow", 1, 1);
        }
          
    }
    private void OnTriggerExit(Collider other) //esto nada k ver
    {
        //if (other.gameObject.CompareTag("Enemy"))
        {
            CancelInvoke("InstantiateArrow");
        }
    }

    private void InstantiateArrow() //Crear una función
    {

        Instantiate(arrow, spawnPoint.position, spawnPoint.rotation);

    }

    public void Muerte()
    {

        Destroy(gameObject);
    }

    // testtt
   
}
