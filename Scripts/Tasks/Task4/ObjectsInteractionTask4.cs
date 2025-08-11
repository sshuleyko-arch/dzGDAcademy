using UnityEngine;

public class ObjectsInteractionTask4 : MonoBehaviour
{
    [SerializeField]
    private GameObject waffleObject;
    [SerializeField]
    private Transform waffleTransform;

    private Toaster toaster;
    // TODO: Подпишитесь на событие TimerIsUp класса Toaster созданием объекта Waffle в точке WaffleRoot (из папки Prefabs) 

    private void Awake()
    {
        toaster = FindObjectOfType<Toaster>().GetComponent<Toaster>();
    }

    private void OnEnable()
    {
        toaster.TimerIsUp += InstantiateWaffle;
    }

    private void OnDisable()
    {
        toaster.TimerIsUp -= InstantiateWaffle;
    }

    public void InstantiateWaffle()
    {
        Instantiate(waffleObject, waffleTransform);
    }
}