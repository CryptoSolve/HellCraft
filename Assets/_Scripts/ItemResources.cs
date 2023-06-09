using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu]
public class ItemResources : ScriptableObject 
{
    public List<ItemSO> items = new List<ItemSO>();
    public string FullName;
    public string ShortName;
    public Sprite icon;
}