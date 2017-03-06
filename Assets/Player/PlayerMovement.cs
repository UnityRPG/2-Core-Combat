using System;
using UnityEngine;
using UnityStandardAssets.Characters.ThirdPerson;

[RequireComponent(typeof (ThirdPersonCharacter))]
public class PlayerMovement : MonoBehaviour
{
	public static bool isInDirectMode = false;

    [SerializeField] float walkMoveStopRadius = 0.2f;

    ThirdPersonCharacter thirdPersonCharacter;   // A reference to the ThirdPersonCharacter on the object
    CameraRaycaster cameraRaycaster;
    Vector3 currentDestination, clickPoint;


    private void Start()
    {
        cameraRaycaster = Camera.main.GetComponent<CameraRaycaster>();
		cameraRaycaster.notifyMouseClickObservers += OnMouseClicked; // registering
        thirdPersonCharacter = GetComponent<ThirdPersonCharacter>();
		currentDestination = transform.position;
		clickPoint = transform.position;
    }

    // Fixed update is called in sync with physics
    private void FixedUpdate()
    {
		float h = Input.GetAxis("Horizontal");
		float v = Input.GetAxis("Vertical");

		if (h > 0 || v > 0)
		{
			isInDirectMode = true;
		}

		if (isInDirectMode)
		{
			Cursor.visible = false;
			ProcessDirectMovement (h, v);
		}
		else
		{
			Cursor.visible = true;
			WalkToLastClickPoint ();
		}
	}

	void ProcessDirectMovement(float horizontal, float vertical)
    {
		if (RangedWeapon.isStandingAndDelivering)
		{
			thirdPersonCharacter.Move (Vector3.zero, false, false);
		}
		else
		{
			// calculate camera relative direction to move:
			Vector3 cameraForward = Vector3.Scale (Camera.main.transform.forward, new Vector3 (1, 0, 1)).normalized;
			Vector3 movement = vertical * cameraForward + horizontal * Camera.main.transform.right;
			thirdPersonCharacter.Move (movement, false, false);
			currentDestination = transform.position;
		}
    }

	void OnMouseClicked(RaycastHit hit, int layerHit)
    {
		isInDirectMode = false;

		if (layerHit == 8)
		{
			clickPoint = hit.point;
			currentDestination = ShortDestination (clickPoint, walkMoveStopRadius);
		}
    }

    void WalkToLastClickPoint()
    {
        var playerToClickPoint = currentDestination - transform.position;
        if (playerToClickPoint.magnitude >= 0)
        {
            thirdPersonCharacter.Move(playerToClickPoint, false, false);
        }
        else
        {
            thirdPersonCharacter.Move(Vector3.zero, false, false);
        }
    }

    Vector3 ShortDestination(Vector3 destination, float shortening)
    {
        Vector3 reductionVector = (destination - transform.position).normalized * shortening;
        return destination - reductionVector;
    }

    void OnDrawGizmos()
    {
        // Draw movement gizmos
		if (!isInDirectMode)
		{
			Gizmos.color = Color.black;
			Gizmos.DrawLine (transform.position, clickPoint);
			Gizmos.DrawSphere (currentDestination, 0.15f);
			Gizmos.DrawSphere (clickPoint, 0.1f);
		}
    }
}

