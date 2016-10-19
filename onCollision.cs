using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class onCollision : MonoBehaviour {


    public static int flag = 0;

    
    
    void OnCollisionEnter2D(Collision2D col)
    {

        if (col.gameObject.tag == "Player")
        {
            Destroy(col.gameObject);
            flag = 1;
           
        }
    }
}
