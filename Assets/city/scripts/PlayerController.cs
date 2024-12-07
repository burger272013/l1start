using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 0;
    public float horiz = 5;
    public float rotat = 4;
    public float jump = 5;
    void Update()
    {
        //вперёд назад
        transform.Translate(new Vector3(0, 0, 1) * speed * Input.GetAxis("Vertical") * Time.deltaTime);
        //поворот лево право
        transform.Translate(new Vector3(1, 0, 0) * horiz * Input.GetAxis("Horizontal") * Time.deltaTime);
        //поворачивать камерой
        transform.Rotate(new Vector3(0, 1, 0) * rotat * Input.GetAxis("Fire1") * Time.deltaTime);
        //прыжок
        transform.Translate(new Vector3(0, 1, 0) * jump * Input.GetAxis("Jump") * Time.deltaTime);
    }
}