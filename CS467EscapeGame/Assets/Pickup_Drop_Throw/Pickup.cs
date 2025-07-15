// author: Brian Swanson
// adapted from: https://www.youtube.com/watch?v=fApXEL0xsx4
// accessed: 7/13/2025
// CS 467, Summer 2025
// Description: A script to enable picking up, dropping, and throwing solid objects
// Note: Any objects being picked up must have a Colider and RigidBody set up for this to work
// Also: ensure the player is set to scale 1, 1, 1 or the object it grabs will get its shape distorted

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
    }

    private void OnMouseDown()
    {
        // upon clicking and holding left mouse button, the object will be picked up
        Debug.Log("Left Mouse Click");

        if (tempParent != null)
        {
            distance = Vector3.Distance(this.transform.position, tempParent.transform.position);

            if(distance <= maxDistance)
            {
                holding = true;
                rb.useGravity = false;
                rb.detectCollisions = true;

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

    private void OnMouseExit()
        // the object moving away from where the mouse is on the screen will drop the object
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

        if (Input.GetMouseButtonDown(1))
        {
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
            rb.useGravity = true;
        }
    }
}

