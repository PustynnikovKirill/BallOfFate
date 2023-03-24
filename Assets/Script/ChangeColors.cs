using UnityEngine;

public class ChangeColors : MonoBehaviour
{
    private MeshRenderer _mesh;  //��������� ������ ����� MeshRenderer(�� ��� � � Unity) � ������� ��� ���� _mesh

    private void Awake() {     //� ���� ������ ���� ������ ��������� � ����������� � ���� _mesh
                               //Awake - ��� ����� ������ ����� ������� �����������, ��� ����� ������� Start � ���
                               //������ ��������������� ��� �������� ������� ����� ����� � �������
        _mesh = GetComponent<MeshRenderer>();   //���������� � GetComponent � ��������� �� ��� ���� ����� ��������� ��� MeshRenderer
                                                //����� ������� � ��� ��� ������ ���� ����� ������ ��������� 
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))   //����� ��������� ��������� ������� ������������
                                           //���������� � ������ Input ������ GetKeyDown(����������� � ������ ������� �� ������)
                                           //���������� � KeyCode � ���� �������� �� ����� G �� ������ ������ �������)
            _mesh.material.color = Color.green; //���������� � ��-�� material ����� � ��-�� color � ������������� ����� ���� �����
                                                //���������� ������������ Color � � ����� green
        if (Input.GetKeyDown(KeyCode.R))   
            _mesh.material.color = Color.red;

        if (Input.GetKeyDown(KeyCode.B))
            _mesh.material.color = Color.blue;
    }

}
