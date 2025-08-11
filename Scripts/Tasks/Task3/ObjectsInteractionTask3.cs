using System.Linq;
using UnityEngine;

public class ObjectsInteractionTask3 : MonoBehaviour
{
    [SerializeField]
    private Lamp[] gameObjects; 

    // TODO: Получите доступ ко всем объектам сцены со скриптом Lamp
    void Start()
    {
           gameObjects = FindObjectsOfType<Lamp>();
    }

    // TODO: При нажатии на кнопку 2 на клавиатуре вызывайте у всех полученных объектов метод Interact

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            foreach (Lamp lamp in gameObjects)
            {
                lamp.Interact();
            }
        }
    }
}