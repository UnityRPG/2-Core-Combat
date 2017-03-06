using UnityEngine;
using System.Linq;
using System.Collections.Generic;

public class CameraRaycaster : MonoBehaviour
{
	// INSPECTOR PROPERTIES RENDERED BY CUSTOM EDITOR SCRIPT
	[SerializeField] int[] layerPriorities;

	float maxRaycastDepth = 100f;
	Camera viewCamera;

    public delegate void OnLayerChange(int newLayer); // declare new delegate type
    public event OnLayerChange onLayerChange; // instantiate an observer set

    void Start()
    {
        viewCamera = Camera.main;
    }

    void Update()
    {
		// Raycast to max depth
		Ray ray = viewCamera.ScreenPointToRay(Input.mousePosition);
		RaycastHit[] raycastHits = Physics.RaycastAll (ray, maxRaycastDepth);

		// Form list of layer numbers hit
		List<int> layersHit = new List<int> ();
		foreach (RaycastHit hit in raycastHits) {
			layersHit.Add (hit.collider.gameObject.layer);
		}

		// Broadcast highest priority layer hit
		foreach (int layer in layerPriorities)
		{
			if (layersHit.Contains (layer))
			{
				onLayerChange (layer);
				return; // stop looking
			}
			else
			{
				onLayerChange (0);
			}
		}
	}
}