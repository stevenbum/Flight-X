using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextChange : MonoBehaviour
{
    public Text instructions;
    float instructionStartTime = 5;

   



    void Start () { 
        LaunchInstructions();
       
    }

    void LaunchInstructions()
    {
        instructionStartTime = Time.time;
    }

    void Update()

    {
        string[] biomes = new string[] { "grasslands", "rainforest", "desert", "rocky", "swamp", "tundra" };
        System.Random random = new System.Random();
        int useBiome = random.Next(biomes.Length);
        string pickBiome = biomes[useBiome]; 

        if (instructionStartTime > 0 && Time.time >= instructionStartTime)
        {
            if (Time.time - instructionStartTime < 5)
                instructions.text = pickBiome;
            else if (Time.time - instructionStartTime < 10)
                instructions.text = pickBiome;
            else
            {
                instructionStartTime = -1;
                instructions.text = pickBiome;
            }
        }
    }
}
