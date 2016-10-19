/*using UnityEngine;
using System.Collections;

public class BallOnTouch : MonoBehaviour {
    public Rigidbody2D rb;


    void Start () {
        rb = GetComponent<Rigidbody2D>();
	}

    void Jump()

    {
        rb.AddForce(new Vector3(0, 3 ,0), ForceMode2D.Impulse);


    }
    void Update()
    {
        int nbTouches = Input.touchCount;

        if (nbTouches > 0)
        {
            for (int i = 0; i < nbTouches; i++)
            {
                Touch touch = Input.GetTouch(i);

                if (touch.phase == TouchPhase.Began)
                {
                    if (touch.tapCount == 1)
                    {
                        Jump();
                        break;
                    }
                   
                }

            }
        }
        
    }
}
*/