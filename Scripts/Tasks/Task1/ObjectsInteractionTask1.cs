using UnityEngine;

public class ObjectsInteractionTask1 : MonoBehaviour
{
    // TODO: Получите доступ к объекту со скриптом Refrigerator при помощи атрибута [SerializeField]
    [SerializeField]
    private Refrigerator refrigerator;
    // TODO: При нажатии на кнопку 1 на клавиатуре вызывайте у него метод Interact

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            refrigerator.Interact();
        }
    }
}
