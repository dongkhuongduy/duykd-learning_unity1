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

    void Start()
    {
        int tong = a + b;

        Debug.Log("tong a + b: " + tong);

        int hieu = a - b;
        
        Debug.Log("hieu a - b: " + hieu);

        int nhan = a * b;
        
        Debug.Log("tich cua a va b:" + nhan);

        int thuong = b / a;
        Debug.Log("thuong cua a va b: " +  thuong);

    }

    // Update is called once per frame
    void Update()
    {

    }
}
