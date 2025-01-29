using UnityEngine;
using DG.Tweening;

public class ObstacleMovemenAnimation : MonoBehaviour
{
    private void Start()
    {
        transform.DOMoveZ(100, 1f).SetEase(Ease.Linear).SetLoops(-1, LoopType.Yoyo);
    }
}
