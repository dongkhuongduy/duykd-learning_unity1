using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;

public class Bai3 : MonoBehaviour
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
    int luong = 200;
public int Cong1(int a)
    {
        return a + 1;
    }
    void Start()
    {
        Debug.Log(Cong1(a));

    }

    // Update is called once per frame
    void Update()
    {

    }
}
