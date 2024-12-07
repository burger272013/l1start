using UnityEngine;

public class PC_helicopter : MonoBehaviour
{
    public float speed = 0;
    public float upDown = 0; //верх вниз
    public float rotateY = 0;
    public float rotateX = 0;
    public float rotateZ = 0;
    void Update()
    {
        //вперёд назад
        transform.Translate(new Vector3(0, 0, 1) * speed * Input.GetAxis("Vertical") * Time.deltaTime);
        //верх вниз

        transform.Translate(new Vector3(0, 1, 0) * upDown * Time.deltaTime);

        //поворот лево право
        transform.Rotate(new Vector3(0, 1, 0) * rotateY * Input.GetAxis("Horizontal") * Time.deltaTime);
        transform.Rotate(new Vector3(1, 0, 0) * rotateX * Time.deltaTime);
        transform.Rotate(new Vector3(0, 0, 1) * rotateZ * Time.deltaTime);
    }
}
