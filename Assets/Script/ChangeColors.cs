using UnityEngine;

public class ChangeColors : MonoBehaviour
{
    private MeshRenderer _mesh;  //указываем нужный класс MeshRenderer(он как и в Unity) и создаем имя поля _mesh

    private void Awake() {     //в этом методе ищем нужный компонент и присваиваем к полю _mesh
                               //Awake - это самый первый метод который срабатывает, еще перед методом Start в нем
                               //обычно устанавливаются все значения которые нужны будут в будущем
        _mesh = GetComponent<MeshRenderer>();   //обращаемся к GetComponent и указываем то что ищем такой компонент как MeshRenderer
                                                //таким образом у нас при старте игры будет верный компонент 
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))   //будем проверять различные нажатия пользователя
                                           //Обращаемся к классу Input методу GetKeyDown(срабатывает в момент нажатия на кнопку)
                                           //обращаемся к KeyCode и если нажимаем на букву G то делаем объект зеленым)
            _mesh.material.color = Color.green; //обращаемся к св-ву material после к св-ву color и устанавливаем новый цвет через
                                                //встроенное перечисление Color и к цвету green
        if (Input.GetKeyDown(KeyCode.R))   
            _mesh.material.color = Color.red;

        if (Input.GetKeyDown(KeyCode.B))
            _mesh.material.color = Color.blue;
    }

}
