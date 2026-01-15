using TMPro;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    private int coins;
    public TextMeshProUGUI coinsText;

    //private void Update()
    //{
    //    coinsText.text = coins.ToString();
    //}
    // seleccionar + ctrl k y c (borrar igual pero con u)
    
    public void AddCoins(int coinsToAdd) 
    {

        coins += coinsToAdd;
        coinsText.text = coins.ToString();

    }

    
    
    
}
