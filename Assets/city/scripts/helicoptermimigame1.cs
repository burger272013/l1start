using UnityEngine;

public class helicoptermimigame1 : MonoBehaviour
{
    public float upDown = 5;
    public float speed = 1;
    // Update is called once per frame
    void Update()
    {//z-����� �����
        transform.Translate(new Vector3(0, 0, 1) * speed *  Time.deltaTime);
        transform.Translate(new Vector3(0, 1, 0) * upDown * Input.GetAxis("Vertical") * Time.deltaTime);

        //���� ������ ������� q  �� ���������������� ������� � ������
        if (Input.GetKey(KeyCode.Q))
        {
            transform.position = new Vector3(-50, 60, 10);
        }

        //���� ������ leftshift �� �������� ����� ����� 10
        if (Input.GetKey(KeyCode.LeftShift))
        { 
        speed = 10;
        }

        //���� ������ leftcontrol �� �������� ����� �������
        if(Input.GetKey(KeyCode.LeftControl))
        {
            speed = 3; 
        }
    }
}
