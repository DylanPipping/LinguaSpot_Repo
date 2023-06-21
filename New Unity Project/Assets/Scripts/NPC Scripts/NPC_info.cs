using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Occupation
{
    Supermarkt_medewerker,
    Bakker,
    Kassamedewerker,
    Filiaal_manager,
    Vakkenvuller
}

public enum Talents
{
    Zingen,
    Tekenen,
    Acteren,
    Koken,
    Coderen
}

public enum Personality
{
    Sociaal,
    Meelevend,
    Hyper_actief,
    Verlegen
}

public class NPC_info : MonoBehaviour
{
    [SerializeField] private string employeeName = "";
    [SerializeField] private Occupation employeeOccupation;
    [SerializeField] private Talents employeeTalents;
    [SerializeField] private Personality employeePersonality;

    public string GetPrompt()
    {
        return $"NPC Name: {employeeName}\n" +
            $"NPC Occupation: {employeeOccupation.ToString()}\n" +
            $"NPC Talents: {employeeTalents.ToString()}\n" +
            $"NPC Personality: {employeePersonality}\n";
    }
}
