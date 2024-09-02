using System;
using System.Collections;
using UnityEngine;

public class PureAnimation
{
    private readonly MonoBehaviour _context;

    public PureAnimation(MonoBehaviour context) => _context = context;

    public void Play(float duration, Action<float> progressCallback)
    {
        _context.StartCoroutine(PlayCoroutine(duration, progressCallback, null));
    }

    public void Play(float duration, Action<float> progressCallback, Action endedCallback)
    {
        _context.StartCoroutine(PlayCoroutine(duration, progressCallback, endedCallback));
    }

    private IEnumerator PlayCoroutine(float duration, Action<float> progressCallback, Action endedCallback)
    {
        if (duration < 0) throw new ArgumentOutOfRangeException();

        float progress = 0;

        while (progress < duration)
        {
            progress += Time.deltaTime;
            progressCallback?.Invoke(progress / duration);
            yield return null;
        }

        endedCallback?.Invoke();
    }
}