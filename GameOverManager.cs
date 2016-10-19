using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour
{
         // Reference to the player's health.
    public float restartDelay = 5f;         // Time to wait before restarting the level
    public  GameObject restartbutton;
    public GameObject backmenubutton;
    Animator anim;                          // Reference to the animator component.
    float restartTimer;                     // Timer to count up to restarting the level


    void Awake()
    {
      
        // Set up the reference.
        anim = GetComponent<Animator>();
        restartbutton.SetActive(false);
        backmenubutton.SetActive(false);
    }


    void Update()
    {
        // If the player has run out of health...
        if (onCollision.flag == 1)
        {
            // ... tell the animator the game is over.
            anim.SetTrigger("GameOver");
            onCollision.flag = 0;
           // if (this.anim.GetCurrentAnimatorStateInfo(0).IsName("GameOver"))
            
            restartbutton.SetActive(true);
            backmenubutton.SetActive(true);


            // .. increment a timer to count up to restarting.
            restartTimer += Time.deltaTime;

            // .. if it reaches the restart delay...
            if (restartTimer >= restartDelay)
            {
                // .. then reload the currently loaded level.
                SceneManager.LoadScene("First Test");
            }
        }
    }
}