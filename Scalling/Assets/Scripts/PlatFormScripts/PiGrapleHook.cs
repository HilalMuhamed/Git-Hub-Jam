using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PiGrapleHook : MonoBehaviour
{
    public Camera mainCamera;
    public LineRenderer _lineRenderer;
    public DistanceJoint2D _distanceJoint;
    public PlayerMove playerMovement;

    public float maxDistance = 10f; 
    public float grapplingHookSpeedMultiplier = 2f; 
    public float grapplingHookGravityMultiplier = 2f; 
    private Rigidbody2D playerRigidbody;
    public GameObject GrapelParticle,sound1;
    void Start()
    {
        _distanceJoint.enabled = false;
        playerRigidbody = GetComponent<Rigidbody2D>();
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
        Collider2D piCollider = FindPiWithinRange();
        if (piCollider != null)
            {
                Vector2 piPos = piCollider.transform.position;
                Instantiate(GrapelParticle,piCollider.transform.position,Quaternion.identity);
                Instantiate(sound1,transform.position,Quaternion.identity);
                _lineRenderer.SetPosition(0, piPos);
                _lineRenderer.SetPosition(1, transform.position);
                _distanceJoint.connectedAnchor = piPos;
                _distanceJoint.enabled = true;
                _lineRenderer.enabled = true;

                // // Increase player speed during grappling
                // playerMovement.runSpeed *= grapplingHookSpeedMultiplier;
                // playerRigidbody.gravityScale *= grapplingHookGravityMultiplier;
            }
        }
        else if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            _distanceJoint.enabled = false;
            _lineRenderer.enabled = false;

            // // Reset player speed after grappling
            // playerMovement.runSpeed /= grapplingHookSpeedMultiplier;
            // playerRigidbody.gravityScale /= grapplingHookGravityMultiplier;
        }
        if (_distanceJoint.enabled)
        {
            _lineRenderer.SetPosition(1, transform.position);
        }
    }

    Collider2D FindPiWithinRange()
    {
        Collider2D[] colliders = Physics2D.OverlapCircleAll(transform.position, maxDistance);
        foreach (Collider2D collider in colliders)
        {
            if (collider.CompareTag("PI"))
            {
                return collider;
            }
        }
        return null;
    }
}
