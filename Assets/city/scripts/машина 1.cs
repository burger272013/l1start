using UnityEngine;

public class машина1 : MonoBehaviour
{
    public float speed = 6f;
    public float rotate = 0;
    public float upDown= 0;
    void Update()
    {
        transform.Translate(new Vector3(rotate, upDown, speed) * Time.deltaTime);
        
    }
}
