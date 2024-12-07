using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class about_CAT : MonoBehaviour
{
    private int nunber = 123;
    public string name = "kitiket";
    public float speed = 1.0f;
    void Update()
    {
        print(speed);
        print(name); 
        print(nunber);
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        print("котик на кайфе");
        print("конфета");
    }
}