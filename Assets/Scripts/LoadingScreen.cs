using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadingScreen : MonoBehaviour
{
    public string levelToLoad;

    public GameObject loadingBar;
    public GameObject loadingText;
    public Text loadingTextInfo;
    public GameObject loadingBackground;
    public GameObject loadingButton;
    public GameObject logoImage;
    public GameObject firstLoadImage;
    
    private int loadProgress = 0;
   
    void Start()
    {
        loadingTextInfo = GetComponentInChildren<Text>();
        loadingBar.SetActive(false);
        loadingBackground.SetActive(false);
        loadingText.SetActive(false);
        loadingButton.SetActive(true);
        logoImage.SetActive(false);
        firstLoadImage.SetActive(true);
    }

    public void LoadTheLevel()
    {
        StartCoroutine(DisplayLoadingScreen(levelToLoad));
    }


    IEnumerator DisplayLoadingScreen(string level)
    {
        loadingBar.SetActive(true);
        loadingBackground.SetActive(true);
        loadingText.SetActive(true);
        loadingButton.SetActive(false);
        logoImage.SetActive(true);
        firstLoadImage.SetActive(false);
        loadingBar.transform.localScale = new Vector3(loadProgress, loadingBar.transform.localScale.y, loadingBar.transform.localScale.z);

       // AsyncOperation async = Application.LoadLevelAsync(level);
        AsyncOperation async = SceneManager.LoadSceneAsync(level);
        while (!async.isDone)
        {
            loadProgress = (int)(async.progress * 100);
            loadingTextInfo.text = "Load Progress " + loadProgress + "%";
            loadingBar.transform.localScale = new Vector3(async.progress, loadingBar.transform.localScale.y, loadingBar.transform.localScale.z);
            //logoImage.transform.Rotate(Vector3.right, Time.deltaTime*async.progress);
            yield return null;
        }
    
    }
}
 