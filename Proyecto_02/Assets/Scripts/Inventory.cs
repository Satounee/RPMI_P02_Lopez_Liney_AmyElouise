using TMPro;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public int coins;
    public TextMeshProUGUI coinsText;

    public int enemies;
    public TextMeshProUGUI enemiesText;

    public int enemyCount;

    //private void Update()
    //{
    //    coinsText.text = coins.ToString();
    //}
    // seleccionar + ctrl k y c (borrar igual pero con u)
    private void Start()
    {
        coinsText.text = coins.ToString();
    }
    public void AddCoins(int coinsToAdd) 
    {

        coins += coinsToAdd;
        coinsText.text = coins.ToString();

    }

    public void AddEnemies(int enemiesToAdd)
    {
        enemies += enemiesToAdd;
        enemiesText.text = enemies.ToString();
    }
    
    public void Reload(int enemyToAdd)
    {
        enemyCount += enemyToAdd;
    }
    
}
