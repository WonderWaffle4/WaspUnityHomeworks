using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameLogic : MonoBehaviour
{
    public static int lives;
    public GameObject korzina;
    private static Color[] lifeColors =
    {
        Color.red,
        Color.yellow,
        Color.green
    };
    // Start is called before the first frame update
    void Start()
    {
        lives = 2;
        Renderer renderer = korzina.GetComponent<Renderer>();
        renderer.sharedMaterial.color = lifeColors[lives];
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void loseLife()
    {
        Renderer renderer = korzina.GetComponent<Renderer>();
        if (lives > 0)
        {
            renderer.sharedMaterial.color = lifeColors[lives - 1];
            lives--;
        }
        else if (lives == 0)
            SceneManager.LoadScene("SampleScene");
    }
}
