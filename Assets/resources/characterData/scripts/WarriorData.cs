using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Types;

[CreateAssetMenuAttribute(fileName = "New Warrior Data", menuName = "Character Data/Warrior")]
public class WarriorData : CharacterData
{
    WarriorClassType classType;
    WarriorWpnType wpnType;
}
