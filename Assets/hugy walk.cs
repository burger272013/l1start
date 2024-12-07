using UnityEngine;

public class hugywalk : MonoBehaviour
{
   
    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0, 0, 1) * Time.deltaTime);
        transform.Translate(new Vector3(0, 3, 0) * Time.deltaTime);
    }
}
