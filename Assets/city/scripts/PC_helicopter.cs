using UnityEngine;

public class PC_helicopter : MonoBehaviour
{
    public float speed = 0;
    public float upDown = 0; //���� ����
    public float rotateY = 0;
    public float rotateX = 0;
    public float rotateZ = 0;
    void Update()
    {
        //����� �����
        transform.Translate(new Vector3(0, 0, 1) * speed * Input.GetAxis("Vertical") * Time.deltaTime);
        //���� ����

        transform.Translate(new Vector3(0, 1, 0) * upDown * Time.deltaTime);

        //������� ���� �����
        transform.Rotate(new Vector3(0, 1, 0) * rotateY * Input.GetAxis("Horizontal") * Time.deltaTime);
        transform.Rotate(new Vector3(1, 0, 0) * rotateX * Time.deltaTime);
        transform.Rotate(new Vector3(0, 0, 1) * rotateZ * Time.deltaTime);
    }
}
