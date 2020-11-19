using UnityEngine;

public class PointScorer : MonoBehaviour
{
    private void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.layer == 9)
        {
            FloppyBirdEvents.pointScoreEvent.Invoke();
        }
    }
}
