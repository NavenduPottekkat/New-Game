using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class RETRY : MonoBehaviour {

	public void retry()
    {
        SceneManager.LoadScene("Scenes/First Test");
    }
    public void backmenu()
    {
        SceneManager.LoadScene("Scenes/Menu");
    }
}
