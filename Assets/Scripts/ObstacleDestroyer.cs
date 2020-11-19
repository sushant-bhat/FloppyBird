using UnityEngine;

public class ObstacleDestroyer : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("Destroy " + col.gameObject.name);
        FloppyBirdEvents.obstacleDestroyEvent.Invoke(col.transform.root.gameObject);
    }
}
