using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Subject : MonoBehaviour
{
    private List<Observer> observers;
    [SerializeField] private SubjectType _subjectType;
    public SubjectType subjectType => _subjectType;
    void Start()
    {
        ObserverManager.Instance.RegisterSubject(this);
    }
    public void RegiserObserver(Observer observer)
    {
        if (observers == null)
        {
            observers = new List<Observer>();
        }
        observers.Add(observer);
    }
    public void OnNotife(NotificationType notificationType)
    {
        foreach (var _observer in observers)
        {
            _observer.OnNotify(notificationType);
        }
    }
}
