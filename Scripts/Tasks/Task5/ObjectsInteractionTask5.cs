using System.Collections.Generic;
using UnityEngine;
using System;

public class ObjectsInteractionTask5 : MonoBehaviour
{
    [SerializeField] private Transform kitchenRoot; // перетащите Kitchen в инспектор

    private readonly Dictionary<Shelf, Action> _handlers = new();
    private Shelf[] _shelves;

    private void OnEnable()
    {
        _shelves = kitchenRoot != null
            ? kitchenRoot.GetComponentsInChildren<Shelf>(true)
            : FindObjectsOfType<Shelf>(false);

        foreach (var shelf in _shelves)
        {
            // Локальная переменная нужна, чтобы корректно замкнуть именно эту полку
            var localShelf = shelf;
            Action handler = () => OnItemSpawned(localShelf);
            _handlers[localShelf] = handler;
            localShelf.ItemSpawned += handler;
        }
    }

    private void OnDisable()
    {
        foreach (var kv in _handlers)
            kv.Key.ItemSpawned -= kv.Value;

        _handlers.Clear();
    }

    private void OnItemSpawned(Shelf shelf)
    {
        if (shelf.ItemsCount > 3)
            shelf.Fall();
    }
}