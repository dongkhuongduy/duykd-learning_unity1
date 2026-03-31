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

    public Person person1 = new Person();
    public Person person2 = new Person();

    public float TongLuong(Person p1, Person p2)
    {
        return p1.luong + p2.luong;
    }

    void Start()
    {
        Debug.Log(a);
        Debug.Log(b);
        Debug.Log(c);
        Debug.Log(x);
        Debug.Log(y);
        Debug.Log(monney);
        Debug.Log(letter);
        Debug.Log(e);
        Debug.Log(Bai1ten);

       
        person1.ten = "Duy";
        person1.age = 22;
        person1.diachi = "HaNoi";
        person1.luong = 10.0f;
        person1.nyc = 2;

        person2.ten = "Chi";
        person2.age = 25;
        person2.diachi = "Nghe An";
        person2.luong = 12.5f;
        person2.nyc = 1;

        Debug.Log("Tong luong: " + TongLuong(person1, person2));
    }

    void Update()
    {

    }
}