using UnityEditor;
using UnityEngine; //��� ������� ���������, � ��� ��������� ��� �������� ������ ��� ������������ ������, ����������


public class Basics : MonoBehaviour   

{
    //public GameObject obj;  // GameObject - ��� ��� ������, � ���� �� ����� ��������� ����� ������, obj - ��� ���.

    public GameObject[] objs = new GameObject[3];  // GameObject - ��� ��� ������, � ���� �� ����� ��������� ����� ������, objs - ��� ���.
                                                  // � ���� ���� �� ��������� �� ���� �������� � ������ ������� ��������. new GameObject[3] -
                                                  //��� �� ������ �������� ������

   public Transform target; // ���� ������� ����� ����� ����� ������ ��������� � ������� �������. 

    public BoxCollider box;

    public Light _light;       //������� ���� ������� ��������� �� ����������  Light ������� ��������� � Unity � DirectionLight.
                               //��� �� ������� ��� ����. � ����, � ������ ��� ���������� � ����� ����. 

    public Transform[] transforms = new Transform[3];

    public float speed = 5.0f, rotateSpeed = 10f;   //���������� ����� �������� ����� �������
    

    private void Start()
    {
        //  obj.SetActive(false);

        // obj.GetComponent<Transform>().position = new Vector3(10,0,5);   //obj-��� ������, ����� GetComponent ��� ��������� � �������
                                                                             // ����������: ���������� � Transform
                                                                            //��� ����� ������ ��������� � ��������� ���������� � Unity..
                                                                            //� ����� ����� ���������� � position
                                                                            //� ������������� Vector3 -��� ����������� ������ � ������� ����
                                                                            //����� ��� ���������. 

        //target.position = new Vector3(10, 0, 5); //������ ����� ����������������� � ����������� Transform ������� �������
                                                 //����� ������ ���������� � ������� ���� � ���������� ����������.
        //_light.intensity = 0.5f; //���������� � ���� � ��������� ��� �������������


        //for (int i = 0; i < objs.Length; i++)
          //  objs[i].SetActive(false);
    }
    private void Update() {
        for (int i = 0; i < transforms.Length; i++)
        {


            if (transforms[i] == null)  // ��������: ���� ������� ������ ���� nall,�� ���������� ������� ��������
                continue;

            transforms[i].Translate(new Vector3(1,0,0) * speed * Time.deltaTime); //����������� ����� Translate � ������� �������� �� ����� ���������  
                                                                                  //����������� ������ �� �����-�� ������������ ����������
                                                                                  //� �������� ������� ��������� ��������� ���� ����������,
                                                                                  //� ����� ���������� ����� Vector3 �� ���� �������� ����� �������
                                                                                  //����� 3 ����������. speed-��� ��������, �� ������ ���������� ������ 
                                                                                  //Time.deltaTime - ����� Time � ������� ���������� � deltaTime ����
                                                                                  //����������� �������� ����������, ���������

            transforms[i].Rotate(new Vector3(1, 0, 0) * rotateSpeed * Time.deltaTime); //����������� ����� Rotate � ������� �������� �� ����� ������� ������
            
            float posX = transforms[i].position.x;   //�������� ������� �� x ������� ������ �������

            if (posX < -10f && transforms[i].gameObject.name == "Cube")  //���� ������� �������� �������� � ���������� ������ "Cube" ����� ������ -10f ��
                Destroy(transforms[i].gameObject); // ����� �������� ����� ������� ���������� ��� ������, .gameObject-� ��� �� �������� ��� ������� ������
        }                                          
    }
}
