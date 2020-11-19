using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class CanvasController : MonoBehaviour
{
    List<CanvasInfo> _canvasInfos;
    CanvasInfo _lastCanvasInfo;

    private void Awake()
    {
        _canvasInfos = GetComponentsInChildren<CanvasInfo>().ToList();
        _canvasInfos.ForEach(x => x.gameObject.SetActive(false));

        FloppyBirdEvents.switchCanvasEvent.AddListener(SwitchCanvas);
    }

    public void SwitchCanvas(Constants.CANVAS_TYPE canvasType)
    {
        if (_lastCanvasInfo != null)
        {
            _lastCanvasInfo.gameObject.SetActive(false);
        }
        CanvasInfo desiredCanvas = _canvasInfos.Find(x => x.CanvasType == canvasType);
        if (desiredCanvas != null)
        {
            desiredCanvas.gameObject.SetActive(true);
            _lastCanvasInfo = desiredCanvas;
        }
    }
}
