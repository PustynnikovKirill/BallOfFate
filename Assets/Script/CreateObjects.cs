using System;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

public class CreateObjects : MonoBehaviour
{
  public GameObject[] obj;   //������� ��� ���� ������ ����� ��������


    private void Update()
    {
        //Invoke("Create", 2f); //Invoke - �����, ������� ��������� �������� ����� ����� ������������ ���������� �������
        //������ ���������� �������� ��� ����� � ������� ������, ������ ����� ������� ������
        //���� ����� ���� ��� ���������� �.�. ��������� ������ ����� ���������� ������ � �������� ������
        //������ ���� ���������� ��������

        if(Input.GetKeyUp(KeyCode.U)) // �� ����� U ����� ����������� �������� 
            StartCoroutine(Create3dObjects(2f)); //�������� �������� ��� ������ ������������ ������ StartCoroutine � �������� �������� 2���.
                                               // ����� ����� ���������� ��� ���������� using System; using System.Collections;

    }
    private void Create()
    {
        for(int i=0; i < 5; i++) {  // ������� ���� � ������� �������, ��� �������� 5 ��������� 
                               // GameObject newObject = Instantiate(obj, new Vector3(0,5,0), Quaternion.Euler(12f,-15f,40f)) as GameObject;
                               // Instantiate - ����� �� Unity � ������� ������ 
                               // ����� ������: ������ �������� ��� ��� ������(������),
                               // ������ �������� ��� ����������,������� ����������
                               // ��� ������ ������ Quaternion � ������ Euler ���������
                               // �������� �� x,y,z
                               // ����������������� ����� ����� ���������� newObject
                               // � ����� ���������� ��� as GameObject
            Instantiate(obj[UnityEngine.Random.Range(0, obj.Length)], new Vector3(RandomNumber(), RandomNumber(), RandomNumber()),Quaternion.Euler(RandomNumber(), -15f, 40f));
                               //����� �� ������� ������ � ���������� � ������ Random c ������� Range � ����� �������� �� 0 �� ���.��. � �������
        }

    }
    private int RandomNumber(){       //����� ������� ������� �����, ������� ���������� ����� ����� �� 0 �� 10
        return UnityEngine.Random.Range(0, 10);
    }

    private IEnumerator Create3dObjects(float wait) {   // ������� ��������: � �������� ���� ������ IEnumerator � ������ �������� Create3dObjects, �� ���� ������� �����,��
                                              // ���������� ���� ������
        //yield return new WaitForSeconds(wait); // ��������� ���� ������� �� �������� ����� ����� 3 �������, WaitForSeconds - ����������� ����� ������� ��������
                                             // ��������� 3�. �������� �� �������� � ������ Start.
        //Create();

        while(true)   //����������� ����. ���������� ���� ����� ������������ ���������� �������:
        { 
            Instantiate(obj[UnityEngine.Random.Range(0, obj.Length)], new Vector3(RandomNumber(), RandomNumber(), RandomNumber()), Quaternion.Euler(RandomNumber(), -15f, 40f));
            yield return new WaitForSeconds(wait);
        }
    }
}   
