using System;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

public class CreateObjects : MonoBehaviour
{
  public GameObject[] obj;   //говорим что этот объект будет массивом


    private void Update()
    {
        //Invoke("Create", 2f); //Invoke - метод, который позволяет вызывать метод через определенный промежуток времени
        //первым аргументом передаем сам метод в формате строки, вторым через сколько секунд
        //этот метод мало кто использует т.к. считается дурным тоном передавать методы в качестве строки
        //вместо него используют куратины

        if(Input.GetKeyUp(KeyCode.U)) // на букву U будет запускаться куратина 
            StartCoroutine(Create3dObjects(2f)); //Стартуем куратину при помощи специального метода StartCoroutine в параметр передаем 2сек.
                                               // также нужно подключить две библиотеки using System; using System.Collections;

    }
    private void Create()
    {
        for(int i=0; i < 5; i++) {  // обычный цикл в котором говорим, что создадим 5 элементов 
                               // GameObject newObject = Instantiate(obj, new Vector3(0,5,0), Quaternion.Euler(12f,-15f,40f)) as GameObject;
                               // Instantiate - метод из Unity в который кладем 
                               // новый объект: первый параметр это сам объект(прифаб),
                               // второй параметр это координаты,третьим параметром
                               // при помощи класса Quaternion и метода Euler указываем
                               // вращение по x,y,z
                               // Взаимодействовать нужно через переменную newObject
                               // в конце типизируем как as GameObject
            Instantiate(obj[UnityEngine.Random.Range(0, obj.Length)], new Vector3(RandomNumber(), RandomNumber(), RandomNumber()),Quaternion.Euler(RandomNumber(), -15f, 40f));
                               //здесь мы создаем объект и обращаемся к классу Random c методом Range и берем значения от 0 до кол.эл. в массиве
        }

    }
    private int RandomNumber(){       //здесь создаем обычный метод, который возвращает целое число от 0 до 10
        return UnityEngine.Random.Range(0, 10);
    }

    private IEnumerator Create3dObjects(float wait) {   // создаем куратину: в качестве типа данных IEnumerator и дальше название Create3dObjects, по сути обычный метод,за
                                              // исклюением типа данных
        //yield return new WaitForSeconds(wait); // благодаря этой строчке мы вызываем метод через 3 секунды, WaitForSeconds - специальный класс который помогает
                                             // дождаться 3с. Куратину мы стартуем в методе Start.
        //Create();

        while(true)   //бесконечный цикл. Выполнение кода через определенные промежутки времени:
        { 
            Instantiate(obj[UnityEngine.Random.Range(0, obj.Length)], new Vector3(RandomNumber(), RandomNumber(), RandomNumber()), Quaternion.Euler(RandomNumber(), -15f, 40f));
            yield return new WaitForSeconds(wait);
        }
    }
}   
