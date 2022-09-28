using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovmentSystem : Observer
{
    private void Start()
    {
        ObserverManager.Instance.RegisterObserver(this, SubjectType.MovmentSystem);
    }
    public override void OnNotify(NotificationType notificationType)
    {
        switch (notificationType)
        {
            case NotificationType.ForwardButton:
                transform.Translate(Vector3.forward);
                break;
            case NotificationType.BackButton:
                transform.Translate(Vector3.back);
                break;
            case NotificationType.LeftButton:
                transform.Translate(Vector3.left);
                break;
            case NotificationType.RightButton:
                transform.Translate(Vector3.right);
                break;
            default:
                break;
        }
    }
}
