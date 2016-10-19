using UnityEngine;
using System.Collections;

public class Spawn : MonoBehaviour {
    public GameObject[] obj;
    public float spawnMin = 4f;
    public float spawnMax = 6f;
    void Start() { 
        
        Spawner();
	
	}
	
     void Spawner()
    {
        Invoke("Spawner", Random.Range(spawnMin, spawnMax));
        Instantiate(obj[Random.Range(0, obj.GetLength(0))], transform.position, Quaternion.identity);
        spawnMax = spawnMax - 0.01f;
        spawnMin = spawnMin - 0.01f;
       
    }

	
}
