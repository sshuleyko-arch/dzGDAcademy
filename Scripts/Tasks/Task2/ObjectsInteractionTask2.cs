using UnityEngine;

public class ObjectsInteractionTask2 : MonoBehaviour
{
    [SerializeField]
    private GameObject gameObject;

    [SerializeField]
    private Transform lapmPosition;
    // TODO: В методе Awake создайте на сцене в точке LampRoot одну из наборов ламп (из папки Prefabs/Lamps)
    private void Awake()
    {
       Instantiate(gameObject, lapmPosition); 
    }
}