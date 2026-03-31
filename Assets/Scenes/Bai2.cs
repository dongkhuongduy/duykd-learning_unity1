using System.Runtime.InteropServices.WindowsRuntime;
using Unity.VisualScripting;
using UnityEngine;

public class Bai2 : MonoBehaviour
{
    int a = 10;
    byte b = 200;
    long c = 50000000;
    float x = 3.14f;
    double y = 3.1415926;
    decimal monney = 100.50m;
    char letter = 'D';
    bool e = true;
    string Bai1ten = "Duy";
    int[] numbers = { 1, 2, 3 };

    public int sum(int a, int b)
    {
        return a + b;
     }
    public int hieu(int a, int b)
    {
        return a - b;
    }
    public int nhan(int a, int b)
    {
        return a * b;
    }
    public float chia(int a, int b)
    {
        return (float)a / b;
    }
    void Start()
    {
        Debug.Log(sum(a,b));
        Debug.Log(chia(a,b));
        Debug.Log(nhan(a,b));
        Debug.Log(hieu(a,b));

    }

    // Update is called once per frame
    void Update()
    {

    }
}
