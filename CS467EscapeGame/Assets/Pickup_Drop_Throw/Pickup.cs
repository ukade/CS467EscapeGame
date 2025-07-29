// author: Brian Swanson
// accessed: 7/13/2025
// CS 467, Summer 2025
// Description: A script to enable picking up, dropping, and throwing solid objects
// Note: Any objects being picked up must have a Colider and RigidBody set up for this to work
// Also: ensure the player is set to scale 1, 1, 1 or the object it grabs will get its shape distorted
// Adapted from source: Pick Up and Throw Stuff in Unity 6! 2024 Tutorial. (2024, December 15). [Video]. YouTube. https://www.youtube.com/watch?v=fApXEL0xsx4
using UnityEngine;

public class Pickup : MonoBehaviour
{

    bool holding = false;

    [SerializeField]
    // adjusts force of throw
    float throwForce = 600f;
    [SerializeField]
    // adjusts pickup distance
    float maxDistance = 3f;
    float distance;

    TempParent tempParent;
    Rigidbody rb;

    Vector3 objectPos;

    private Vector3 originalPickupPosition;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        tempParent = TempParent.Instance;


    }

    // Update is called once per frame
    void Update()
    {
        if (holding)
            Hold();

        if (!holding & transform.position.y < -50f)
        {
            ResetPosition();
        }
    }

    private void ResetPosition()
    {
        // this resets objects that fall through the world by tracking and updating their position if they fall below a certain y-distance
        rb.linearVelocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;
        rb.useGravity = true;
        rb.isKinematic = false;
        transform.position = originalPickupPosition;
    }

    private void OnMouseDown()
    {
        // upon clicking and holding left mouse button, the object will be picked up
        //Debug.Log("Left Mouse Click");

        if (tempParent != null)
        {
            distance = Vector3.Distance(this.transform.position, tempParent.transform.position);

            if(distance <= maxDistance)
            {
                holding = true;
                rb.useGravity = false;
                rb.isKinematic = false;
                rb.detectCollisions = true;
                gameObject.layer = LayerMask.NameToLayer("HeldObject");

                originalPickupPosition = transform.position;

                this.transform.SetParent(tempParent.transform);
            }

        }

        else
        {
            Debug.Log("Temp Parent item not found in scene");
        }
    }
    private void OnMouseUp()
        // releasing left mouse button will drop the object
    {
        Drop();
    }

    private void Hold()
        // function that defines what behavior should be checked every frame while holding an object
    {
        distance = Vector3.Distance(this.transform.position, tempParent.transform.position);

        if (distance >= maxDistance)
        {
            Drop();
        }

        rb.linearVelocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;

        rb.isKinematic = true;

        if (Input.GetMouseButtonDown(1))
        {
            rb.isKinematic = false;
            rb.AddForce(tempParent.transform.forward * throwForce);
            Drop();
        }

    }

    private void Drop()
        // function that defines how to drop the object
    {
        if (holding)
        {
            holding = false;
            objectPos = this.transform.position;
            this.transform.position = objectPos;
            this.transform.SetParent(null);
            rb.isKinematic = false;
            rb.useGravity = true;
            gameObject.layer = LayerMask.NameToLayer("Default");
        }
    }
}

