using UnityEngine;

public class GazeRaycaster : MonoBehaviour
{
    private GameObject lastHitObject;

    void Update()
    {
        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            GameObject hitObj = hit.collider.gameObject;

            if (hitObj != lastHitObject)
            {
                if (lastHitObject != null)
                    lastHitObject.SendMessage("OnGazeExit", SendMessageOptions.DontRequireReceiver);

                hitObj.SendMessage("OnGazeEnter", SendMessageOptions.DontRequireReceiver);
                lastHitObject = hitObj;
            }
        }
        else
        {
            if (lastHitObject != null)
            {
                lastHitObject.SendMessage("OnGazeExit", SendMessageOptions.DontRequireReceiver);
                lastHitObject = null;
            }
        }
    }
}
