using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Evolution : MonoBehaviour
{
    NeuralNetwork nn;
    void Start()
    {
        nn = new NeuralNetwork(3, 3, 3);

        float[] inputs = { 1, 1, 1 };
        nn.query(inputs);
        Debug.Log("adawd");
    }




    void Update()
    {
        
    }
}
