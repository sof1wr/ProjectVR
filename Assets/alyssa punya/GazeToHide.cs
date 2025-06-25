using UnityEngine;

public class GazeToHide : MonoBehaviour
{
    public float gazeDuration = 1.5f;  // Time in seconds to trigger disappearance
    private float gazeTimer = 0f;
    private bool isGazedAt = false;

    void Update()
    {
        if (isGazedAt)
        {
            gazeTimer += Time.deltaTime;

            if (gazeTimer >= gazeDuration)
            {
                gameObject.SetActive(false);  // Makes the object disappear
                // OR use Destroy(gameObject); if you want it removed permanently
            }
        }
    }

    public void OnGazeEnter()
    {
        isGazedAt = true;
        gazeTimer = 0f;
    }

    public void OnGazeExit()
    {
        isGazedAt = false;
        gazeTimer = 0f;
    }
}
