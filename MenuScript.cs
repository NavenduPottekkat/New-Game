using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

using System.Collections;


public class MenuScript : MonoBehaviour {

    public Button StartText;
    public Button ExitText;
	// Use this for initialization
	void Start () {

        StartText = StartText.GetComponent <Button> ();
        ExitText = ExitText.GetComponent<Button>();
	
	}
	
	public void startlevel()
    {
        SceneManager.LoadScene("Scenes/First Test");
    }
    
    public void exitgame()
    {
        if (Application.platform == RuntimePlatform.Android)
        {
            AndroidJavaObject activity = new AndroidJavaClass("com.unity3d.player.UnityPlayer").GetStatic<AndroidJavaObject>("currentActivity");
            activity.Call<bool>("moveTaskToBack", true);
        }
        else
        {
            Application.Quit();
        }

    }
}
