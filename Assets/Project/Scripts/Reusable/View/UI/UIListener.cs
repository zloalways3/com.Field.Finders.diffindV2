using UnityEngine;

public abstract class UIListener : MonoBehaviour
{
    protected abstract void Subscribe();
    protected virtual void HandleInitialized() { }
    protected virtual void Listen() { }

    private void Start()
    {
        Subscribe();
        HandleInitialized();
    }
}