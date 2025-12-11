using UnityEngine;

public class CoinClicker : MonoBehaviour
{
    public Inventory inventory;

    private void Start()
    {
       inventory =  GameObject.Find("Inventory").GetComponent<Inventory>(); // buscar y guardar
    }
    private void OnMouseDown()
    {
        inventory.coins += 1;
       // inventory.coins = inventory.coins + 1;
        //inventory.coins = ++ ; (solo suma 1)

        Debug.Log("DINEROO");
        Destroy(gameObject);

    }




}
