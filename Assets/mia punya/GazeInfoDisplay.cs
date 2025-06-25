using UnityEngine;

public class GazeInfoDisplay : MonoBehaviour
{
    public GameObject infoText;  // Assign your TextMeshPro object here

    public void OnGazeEnter()
    {
        if (infoText != null)
            infoText.SetActive(true);
    }

    public void OnGazeExit()
    {
        if (infoText != null)
            infoText.SetActive(false);
    }
}
