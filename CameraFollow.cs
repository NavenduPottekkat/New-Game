using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {
    int a;
    public Transform Player ;

    void Update () {


        transform.position = new Vector3(0, Player.position.y - 1, -10);
        a = (int)(Player.position.y);
        ScoreManager.score = -10 * a;

	}
}
