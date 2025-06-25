using UnityEngine;
using UnityEngine.SceneManagement;

public class GazeSceneLoaderWithDelay : MonoBehaviour
{
    public string sceneToLoad;
    public float gazeDuration = 2f; // Time to gaze before switching scenes

    private float gazeTimer = 0f;
    private bool isGazing = false;

    void Update()
    {
        if (isGazing)
        {
            gazeTimer += Time.deltaTime;

            if (gazeTimer >= gazeDuration)
            {
                SceneManager.LoadScene(sceneToLoad);
            }
        }
    }

    public void OnGazeEnter()
    {
        isGazing = true;
        gazeTimer = 0f;
    }

    public void OnGazeExit()
    {
        isGazing = false;
        gazeTimer = 0f;
    }
}