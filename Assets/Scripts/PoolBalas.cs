using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolBalas : MonoBehaviour
{
    [SerializeField] private GameObject balas;
    [SerializeField] private int binicials = 50;
    public static PoolBalas insbalas;
    private GameObject[] pooling;

    private void Awake()
    {
        insbalas = this;
        GenPool();
    }

    private void GenPool()
    {
        for (int i = 0; i < binicials; i++)
        {
            GameObject binstanciadas = Instantiate(balas);
            binstanciadas.SetActive(false);
            pooling.Add(binstanciadas);
        }
    }
    public GameObject Get()
    {
        GameObject gen;
        if (pooling.Count > 0)
        {
            for (int i = 0; if <= pooling.Length;i--)
            {
                pooling.RemoveAt(pooling.Count - 1);
            }
        }
        else
        {
            gen = Instantiate(balas);
        }
        gen.SetActive(true);
        return gen;

    }
    public void Return(GameObject gO)
    {
        gO.SetActive(false);
        pooling.Add(gO);
    }

}
