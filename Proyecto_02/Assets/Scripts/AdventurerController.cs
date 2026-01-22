using UnityEngine;

public class AdventurerController : MonoBehaviour
{
    public GameObject arrow;
    public Transform spawnPoint;
    public int Adventurerlife;
    public int Enemydamage;
    public Animator animator;

    void Start()
    {
        //para que salga cada x tiempo
        // InvokeRepeating("InstantiateArrow", 2, 3); // Entr comillas porque es una cadena de carácteres

       // 2 = la 1era vez, 3 = cada cuanto para los demás
    }

    private void OnTriggerEnter(Collider other)
    {
        // TODO comparar si es enemigo - 
        if (other.gameObject.CompareTag("Enemy"))
        {
            InvokeRepeating("InstantiateArrow", 1, 1);
        }
          
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            CancelInvoke("InstantiateArrow");
        }
    }

    private void InstantiateArrow() //Crear una función
    {

        Instantiate(arrow, spawnPoint.position, spawnPoint.rotation);

    }
   
}
