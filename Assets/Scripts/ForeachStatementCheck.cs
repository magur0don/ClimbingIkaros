using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ForeachStatementCheck : MonoBehaviour
{
    //intŒ^‚Ì•Ï”20ŒÂ•ª‚ğintArray‚Æ‚µ‚Ä’è‹`‚·‚é
    int[] intArray = new int[100];

    void Start()
    {
        // intŒ^‚ÌList‚ğì¬‚·‚é
        List<int> intList = new List<int>();

        // 0‚©‚ç100‚Ü‚Å‚Ì’l‚ÅintArray‚ÌŠe—v‘f‚Ì’l‚ğ‘ã“ü‚·‚é
        for (var count = 0;
            count < intArray.Length;
            count++)
        {
            // intArray‚Ìcount”Ô–Ú‚Ì’l‚ğcount‚Æ‚·‚é
            // —á‚¦‚ÎintArray‚Ì2”Ô–Ú‚Ì—v‘f‚ğ2‚Æ‚·‚é
            intArray[count] = count;
            // intList‚Ì—v‘f‚Æ‚µ‚Äcount‚ğ’Ç‰Á
            intList.Add(count);
            // ‘f”‚¶‚á‚È‚¢ƒtƒ‰ƒO
            bool isNotPrime = false;
            if (count <= 1)
            {
                continue;
            }
            for (int i = 2; i * i <= count; i++)
            {
                if (count % i == 0)
                {
                    Debug.Log($"{count}‚Í{i}" +
                        "‚ÅŠ„‚èØ‚ê‚é‚Ì‚Å‘f”‚Å‚Í‚È‚¢");
                    isNotPrime = true;
                    continue;
                }
            }
            if (isNotPrime)
            {
                continue;
            }
            Debug.Log($"{count}‚Í‘f”");
        }

        // intList‚Ì’†‚ğ‘{¸‚·‚é
        // intArray‚Ì—v‘f”‚ğ100‚Æ‚·‚é
        foreach (var intValue in intList)
        {
            if (intValue == 19)
            {
                Debug.Log("‚±‚ÌintList‚É19‚ÍŠÜ‚Ü‚ê‚Ä‚¢‚é");
            }
            if (intValue == 5)
            {
                Debug.Log($"{intValue}");
            }
            if (intValue == 90)
            {
                Debug.Log($"{intValue}");
            }
        }
    }
}


