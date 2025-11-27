using UnityEngine;

public class AdventurerController : MonoBehaviour
{
    public GameObject arrow;
    public Transform spawnPoint;
    public int Adventurerlife;
    public int Enemydamage;
    
    void Start()
    {
        //para que salga cada x tiempo
        InvokeRepeating("InstantiateArrow", 2, 3); // Entr comillas porque es una cadena de carácteres

       // 2 = la 1era vez, 3 = cada cuanto para los demás
    }

    private void InstantiateArrow() //Crear una función
    {

        Instantiate(arrow, spawnPoint.position, spawnPoint.rotation);

    }
   
}
