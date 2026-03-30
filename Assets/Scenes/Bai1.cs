using Unity.VisualScripting;
using UnityEngine;

public class Bai1 : MonoBehaviour
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
        Debug.Log(a);
        Debug.Log(b);
        Debug.Log(c);
        Debug.Log(x);
        Debug.Log(y);
        Debug.Log(monney);
        Debug.Log(letter);
        Debug.Log(name);
        Debug.Log(e);
        Debug.Log(Bai1ten);
        Debug.Log(numbers);
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
