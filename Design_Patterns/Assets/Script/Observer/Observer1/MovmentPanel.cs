using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovmentPanel : Subject
{
    public void ForwardOnClick()
    {
        OnNotife(NotificationType.ForwardButton);
    }
    public void BackOnClick()
    {
        OnNotife(NotificationType.BackButton);
    }
    public void LeftOnClick()
    {
        OnNotife(NotificationType.LeftButton);
    }
    public void RightOnClick()
    {
        OnNotife(NotificationType.RightButton);
    }
}
