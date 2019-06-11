using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermovement : MonoBehaviour
{
    public int speed = 1;
    public int rotationSpeed = 1;
    private float translation;

    private void PlayerMovement()
    {
        //i give the object forward/backward translation, rotation and then assign them to the object.

        float translation = Input.GetAxis("Vertical") * speed;
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed;
        translation *= (speed) * Time.deltaTime;
        rotation *= Time.deltaTime;
        Vector3 lookhere = new Vector3(0, rotation, 0);
        transform.Translate(0, 0, translation);
        transform.Rotate(lookhere);
    }
    private void OnCollisionEnter(Collision collision)
    {
        transform.Translate(0, 0, (translation - 1));
    }
}
