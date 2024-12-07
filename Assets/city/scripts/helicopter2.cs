using UnityEngine;
using UnityEngine.Rendering;

public class helicopter2 : MonoBehaviour
{
    public float upDown = 5;
    public float speed = 1;

    // Update is called once per frame
    void Update()
    {//z-вперёд назад
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        transform.Translate(Vector3.up * upDown * Input.GetAxis("Jump") * Time.deltaTime);

        //если нажата клавиша q  то телепортируешься обратно в начало
        if (Input.GetKey(KeyCode.Q))
        {
            transform.position = new Vector3(-50, 60, 10);
        }

        //если нажмёшь leftshift то скорость будет равна 10
        if (Input.GetKey(KeyCode.LeftShift))
        {
            speed = 10;
        }

        //если нажмёшь leftcontrol то скорость будет прежней
        if (Input.GetKey(KeyCode.LeftControl))
        {
            speed = 3;
        }
    }
}