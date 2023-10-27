using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForeachStatementCheck : MonoBehaviour
{
    //intŒ^‚Ì•Ï”20ŒÂ•ª‚ğintArray‚Æ‚µ‚Ä’è‹`‚·‚é
    int[] intArray = new int[20];

    void Start()
    {
        // intŒ^‚ÌList‚ğì¬‚·‚é
        List<int> intList = new List<int>();

        // 0‚©‚ç20‚Ü‚Å‚Ì’l‚ÅintArray‚ÌŠe—v‘f‚Ì’l‚ğ‘ã“ü‚·‚é
        for (var count = 0;
            count < intArray.Length;
            count++)
        {
            // intArray‚Ìcount”Ô–Ú‚Ì’l‚ğcount‚Æ‚·‚é
            // —á‚¦‚ÎintArray‚Ì2”Ô–Ú‚Ì—v‘f‚ğ2‚Æ‚·‚é
            intArray[count] = count;
            // intList‚Ì—v‘f‚Æ‚µ‚Äcount‚ğ’Ç‰Á
            intList.Add(count);
        }

        // intList‚Ì’†‚ğ‘{¸‚·‚é
        foreach (var intValue in intList)
        {
            if (intValue == 19)
            {
                Debug.Log("‚±‚ÌintList‚É19‚ÍŠÜ‚Ü‚ê‚Ä‚¢‚é");
            }
        }
    }
}


