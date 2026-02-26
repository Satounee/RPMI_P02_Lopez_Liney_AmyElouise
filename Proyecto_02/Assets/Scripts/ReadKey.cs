using UnityEngine;

public class ReadKey : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (PlayerPrefs.GetInt("tecla h", -1) == 5)
        {
            print("el jugador pulsó h");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {
            PlayerPrefs.SetInt("tecla h", 5);
            PlayerPrefs.Save();
        }
    }
}
