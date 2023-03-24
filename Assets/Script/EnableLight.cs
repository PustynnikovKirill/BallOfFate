using UnityEngine;

public class EnableLight : MonoBehaviour
{
    public Light _mainLight;//����� ���������, ��� ����������� ��������� Light � �������� ��� � ���������� _mainLight

    private void Update() //����� ���������� ����������� ����� �� ������������ �� �����-���� �������
    {
        if (Input.GetKeyUp(KeyCode.Space)) //��� �������� ���������� �� ����������� ������ Input c ������� GetKeyUp -
                                           //���� ����� ����������� ���� ��� ����� ������������ ������� ����� � �������
                                           //����� GetKeyDown() �������� ����������� � ������ �������
                                           // ����� ���������� � ������������ KeyCode, ������� ����������� ����� �������
                                           // � ������ ������ ������

            _mainLight.enabled = !_mainLight.enabled;  //����� �� ���������� � ���������� _mainLight � � ������������ �������� enable
                                                       //������� ��������� ������� ����� ��������� �������� ��� ���.
                                                       //����� ��������� false, �� ����� ����������� ���������� ������ !
    }
}