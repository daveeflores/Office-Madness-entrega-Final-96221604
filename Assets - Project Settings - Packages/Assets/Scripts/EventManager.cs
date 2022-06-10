using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EventManager : MonoBehaviour
{
    public static event Action <int> OpenDoorEvent;
    public static event Action <int> CloseDoorEvent;


    public static void StartDoorEvent(int id)
    {
        OpenDoorEvent?.Invoke(id);
        CloseDoorEvent?.Invoke(id);
    }

}
