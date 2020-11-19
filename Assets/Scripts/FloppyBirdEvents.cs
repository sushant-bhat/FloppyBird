using UnityEngine;
using UnityEngine.Events;

public static class FloppyBirdEvents
{
    public static UnityEvent<GameObject> obstacleDestroyEvent = new UnityEvent<GameObject>();
    public static UnityEvent gameOverEvent = new UnityEvent();
    public static UnityEvent gameStartEvent = new UnityEvent();
    public static UnityEvent pointScoreEvent = new UnityEvent();
    public static UnityEvent<Constants.CANVAS_TYPE> switchCanvasEvent = new UnityEvent<Constants.CANVAS_TYPE>();
}
