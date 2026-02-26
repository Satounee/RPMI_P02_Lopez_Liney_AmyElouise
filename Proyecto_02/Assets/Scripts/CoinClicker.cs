using TMPro;
using UnityEngine;

public class CoinClicker : MonoBehaviour
{
    public Inventory inventory;
    // private TextMeshProUGUI coinstext;

    private void Start()
    {
       inventory =  GameObject.Find("Inventory").GetComponent<Inventory>(); // buscar y guardar

        // coinstext = GameObject.Find("Contador Coin").GetComponent<TextMeshProUGUI>();
    }
    private void OnMouseDown()
    {
        
        Debug.Log("DINEROO");
        inventory.AddCoins(5);
        Destroy(gameObject);
       

        //print(inventory.coins);
        //coinstext.text = inventory.coins.ToString();
        //inventory.coins += 1;
        // inventory.coins = inventory.coins + 1;
        //inventory.coins = ++ ; (solo suma 1)
    }




}
