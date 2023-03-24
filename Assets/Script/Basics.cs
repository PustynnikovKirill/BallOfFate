using UnityEditor;
using UnityEngine; //это сновной нэймспэйс, в нем прописаны все основные классы это подключаемые модули, библиотеки


public class Basics : MonoBehaviour   

{
    //public GameObject obj;  // GameObject - это тип данных, в него мы можем поместить любой объект, obj - это имя.

    public GameObject[] objs = new GameObject[3];  // GameObject - это тип данных, в него мы можем поместить любой объект, objs - это имя.
                                                  // в этом поле мы принимаем не одно значение а массив игровых объектов. new GameObject[3] -
                                                  //это мы просто выделяем память

   public Transform target; // Поле которое будет брать сразу нужный компонент в игровом объекте. 

    public BoxCollider box;

    public Light _light;       //Создаем поле которое ссылается на компоненту  Light которая находится в Unity в DirectionLight.
                               //Так мы создали своё поле. А ниже, в методе уже обращаемся к этому полю. 

    public Transform[] transforms = new Transform[3];

    public float speed = 5.0f, rotateSpeed = 10f;   //переменные можно задавать через запятую
    

    private void Start()
    {
        //  obj.SetActive(false);

        // obj.GetComponent<Transform>().position = new Vector3(10,0,5);   //obj-наш объект, Метод GetComponent для обращение к нужному
                                                                             // компоненту: обращаемся к Transform
                                                                            //имя этого класса совпадает с названием компонента в Unity..
                                                                            //и через точку обращаемся к position
                                                                            //и устанавливаем Vector3 -это специальный объект в котором есть
                                                                            //сразу три кординаты. 

        //target.position = new Vector3(10, 0, 5); //теперь чтобы взаимодействовать с компонентом Transform нужного объекта
                                                 //нужно просто обратиться к нужному полю и установить координаты.
        //_light.intensity = 0.5f; //обращаемся к полю и указываем его интенсивность


        //for (int i = 0; i < objs.Length; i++)
          //  objs[i].SetActive(false);
    }
    private void Update() {
        for (int i = 0; i < transforms.Length; i++)
        {


            if (transforms[i] == null)  // проверка: если текущий объект буде nall,то пропускаем текущую итерацию
                continue;

            transforms[i].Translate(new Vector3(1,0,0) * speed * Time.deltaTime); //Специальный метод Translate с помощью которого мы можем постоянно  
                                                                                  //передвигать объект по какой-то определенной координате
                                                                                  //в качестве первого параметра указываем саму координату,
                                                                                  //и здесь используем класс Vector3 за счет которого можем указать
                                                                                  //сразу 3 координаты. speed-это скорость, ее задаем переменной вверху 
                                                                                  //Time.deltaTime - класс Time в котором обращаемся к deltaTime дает
                                                                                  //сглаживание процесса добавления, умножения

            transforms[i].Rotate(new Vector3(1, 0, 0) * rotateSpeed * Time.deltaTime); //Специальный метод Rotate с помощью которого мы можем вращать объект
            
            float posX = transforms[i].position.x;   //помещаем позицию по x каждого нашего объекта

            if (posX < -10f && transforms[i].gameObject.name == "Cube")  //если позиция текущего элемента с конкретным именем "Cube" будет меньше -10f то
                Destroy(transforms[i].gameObject); // будем вызывать метод который уничтожает сам объект, .gameObject-а это мы получаем сам игровой объект
        }                                          
    }
}
