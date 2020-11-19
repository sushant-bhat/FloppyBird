using UnityEngine;

public class CanvasInfo : MonoBehaviour
{
    [SerializeField] Constants.CANVAS_TYPE _canvasType;

    public Constants.CANVAS_TYPE CanvasType { get => _canvasType; }
}
