using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Types;

[CreateAssetMenuAttribute(fileName = "New Warrior Data", menuName = "Character Data/Rogue")]
public class RogueData : CharacterData
{
    RogueStrategyType strategyType;
    RogueWpnType wpnType;
}
