using UnityEngine;

public class GazeColorChanger : MonoBehaviour
{
    private Renderer objRenderer;
    public Color gazeColor = Color.green;
    private Color originalColor;

    void Start()
    {
        objRenderer = GetComponent<Renderer>();
        originalColor = objRenderer.material.color;
    }

    public void OnGazeEnter()
    {
        objRenderer.material.color = gazeColor;
    }

    public void OnGazeExit()
    {
        objRenderer.material.color = originalColor;
    }
}