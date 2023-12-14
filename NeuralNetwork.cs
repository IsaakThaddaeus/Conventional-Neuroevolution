using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NeuralNetwork
{
    int input, hidden, output;
    float[,] wih, who;

    public NeuralNetwork(int input, int hidden, int output)
    {
        this.input = input;
        this.hidden = hidden;
        this.output = output;

        wih = randomArray(3, 3);
        who = randomArray(3, 3);
    }

    public float[] query(float[] input)
    {
        float[] hidden_inputs = multiplyArray(wih, input);
        float[] hidden_output = sigmoid(hidden_inputs);

        float[] final_inputs = multiplyArray(who, hidden_output);
        float[] final_outputs = sigmoid(final_inputs);

        return final_outputs;
    }


    private float[,] randomArray(int x, int y){

        float[,] array = new float[x, y];

        for (int i = 0; i < x; i++){
            for (int j = 0; j < y; j++){
                array[i, j] = Random.Range(0f, 1f);
            }
        }

        return array;
    }
    private float[] multiplyArray(float[,] arrayA, float[] arrayB){

        float[] array = new float[arrayB.Length];

        int k = 0;

        for (int i = 0; i < arrayA.GetLength(0); i++){
            float sum = 0;
            for (int j = 0; j < arrayA.GetLength(1); j++){
                sum += arrayA[i, j] * arrayB[j];
            }
            array[k] = sum;
            k++;
        }

        return array;
    }
    private float[] sigmoid(float[] array){

        float[] arrayOut = new float[array.Length];

        for(int i = 0; i < array.Length; i++){
            arrayOut[i] = 1 / (1 + Mathf.Pow(2.71828f, -array[i]));
        }

        return arrayOut;
    }

}
