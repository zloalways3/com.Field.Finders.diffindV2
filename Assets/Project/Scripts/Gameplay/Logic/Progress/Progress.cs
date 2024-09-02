using System;
using UnityEngine;

public class Progress : MonoBehaviour
{
    private const int Goal = 12;

    public static Action<int> Changed;

    [SerializeField] private Gamefield _gamefield;

    public static int Value { get; private set; }
    public static int Target => Goal * Level.Value;

    public static bool Completed => Value >= Target;

    private void Start()
    {
        Value = 0;

        foreach (var itemView in _gamefield.Items)
            itemView.Item.Clicked += Increase;
    }

    private void Increase()
    {
        Value++;
        Changed?.Invoke(Value);
    }

    private void OnDestroy()
    {
        foreach (var itemView in _gamefield.Items)
            itemView.Item.Clicked += Increase;
    }
}