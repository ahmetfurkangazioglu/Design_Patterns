using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObserverManager : MonoSingleton<ObserverManager>
{
    [HideInInspector] public List<Subject> subjects=null;

    public void RegisterSubject(Subject subject)
    {
        if (subject == null)
        {
            subjects = new List<Subject>();
        }
        subjects.Add(subject);
    } 
    public void RegisterObserver(Observer observer,SubjectType subjectType)
    {
        foreach (var Sub in subjects)
        {
            if (Sub.subjectType==subjectType)
            {
                Sub.RegiserObserver(observer);
            }
        }
    }
}
public enum NotificationType
{
    ForwardButton,
    BackButton,
    LeftButton,
    RightButton
}
public enum SubjectType{
    MovmentSystem
}
