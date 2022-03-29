using UnityEngine;

public class FlPlayer : MonoBehaviour
{
    public Transform fl;

    public Vector3 offset;


    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = fl.position + offset;
    }
}
