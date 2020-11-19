using UnityEngine;

public class TouchDetector : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D col)
    {
        FloppyBirdEvents.gameOverEvent.Invoke();
    }
}
