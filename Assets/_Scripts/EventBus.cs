using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public static class EventBus
{
    public static Action<int> onSceneChange;
    public static Action<Unit> onUnitDeath;
}