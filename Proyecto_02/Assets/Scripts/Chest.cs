using TMPro;
using UnityEngine;

public class Chest : MonoBehaviour
{
    public TextMeshProUGUI gameOverText;
    private void Start()
    {
        gameOverText.gameObject.SetActive(false);
    }
    private void OnCollisionEnter(Collision collision)
    {
        print("Ha' perdio");
        if (collision.gameObject.CompareTag("Enemy"))
        {

            gameOverText.gameObject.SetActive(true);
            Destroy(gameObject);

           

        }
    }
}
