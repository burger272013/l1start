using UnityEngine;

public class propeler : MonoBehaviour
{
    private float rotateY = 500;
 
    void Update()
    {
        transform.Rotate(new Vector3(0, 1, 0) * rotateY *  Time.deltaTime);

    }
}
