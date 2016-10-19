using UnityEngine;
using System.Collections;

public class BallMovement : MonoBehaviour {
    public Rigidbody2D ab;

    float xValue, zValue, bouncevalue,maxR,maxL;
  
    float speedConst = 0.3F;
    float bounce = 0.8F;

	// Use this for initialization
	void Start () {
        ab = GetComponent<Rigidbody2D>();
        ab.AddForce(new Vector3(0,- 3, 0), ForceMode2D.Impulse);

    }
	
	// Update is called once per frame
	void Update () {

        xValue =  Input.acceleration.x * speedConst;
        //zValue = -Input.acceleration.z * speedConst;
       // if((xValue>maxL)&&(xValue<maxR))
        transform.Translate(xValue, 0, 0);

       


           
	}

    void OnCollisionEnter2D(Collision2D col)
    {

        if (col.gameObject.tag == "Walls")
        {

            if (xValue > 0) {
                bouncevalue = xValue - bounce;
                maxR = xValue;
            }
        
        else if (xValue < 0) { 

        bouncevalue = xValue + bounce;
            maxL = xValue;
        }
            transform.Translate(bouncevalue, 0, 0);

        }
    }
}
