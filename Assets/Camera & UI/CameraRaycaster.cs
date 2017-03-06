using UnityEngine;

public class CameraRaycaster : MonoBehaviour
{
	public int[] layerPriorities;

    [SerializeField] float distanceToBackground = 100f;
    Camera viewCamera;

	public int layerHit;

    RaycastHit raycastHit;
    public RaycastHit hit
    {
        get { return raycastHit; }
    }

    public delegate void OnLayerChange(int newLayer); // declare new delegate type
    public event OnLayerChange onLayerChange; // instantiate an observer set

    void Start()
    {
        viewCamera = Camera.main;
    }

    void Update()
    {
        // Look for and return priority layer hit
        foreach (int layer in layerPriorities)
        {
            var hit = RaycastForLayer(layer);
            if (hit.HasValue)
            {
                raycastHit = hit.Value;
                if (layerHit != layer) // if layer has changed
                {
                    layerHit = layer;
                    onLayerChange(layer); // call the delegates
                }
                layerHit = layer;
                return;
            }
        }

        // Otherwise return background hit
        raycastHit.distance = distanceToBackground;
		onLayerChange (layerHit);
    }

    RaycastHit? RaycastForLayer(int layer)
    {
        int layerMask = 1 << (int)layer; // See Unity docs for mask formation
        Ray ray = viewCamera.ScreenPointToRay(Input.mousePosition);

        RaycastHit hit; // used as an out parameter
        bool hasHit = Physics.Raycast(ray, out hit, distanceToBackground, layerMask);
        if (hasHit)
        {
            return hit;
        }
        return null;
    }
}
