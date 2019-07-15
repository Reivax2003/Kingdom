﻿using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class GenerateBoard : MonoBehaviour
{	private GameObject[,] Map;
	private GameObject[,] NewMap;
	public GameObject Ground;
	public GameObject MapHold;
	public int Xmin;
	public int Xmax;
	public int Ymin;
	public int Ymax;
	public int X;
	public int Y;
    //Map Size//
    void Start(){
		float xscale = Ground.transform.localScale.x;
		float yscale = Ground.transform.localScale.y;
		System.Random rand = new System.Random();
		X= rand.Next(Xmin,Xmax);
		Y= rand.Next(Ymin,Ymax);
		Map = new GameObject[X, Y];
		NewMap = new GameObject[X, Y];
		for (int x = 0; x <X; x++){
			for (int y = 0; y <Y; y++){
				Ground.transform.position=new Vector2((x+y)*xscale/2,(x-y)*yscale/2);
				Map[x, y] = Ground;
				NewMap[x,y]=Instantiate(Map[x,y]);
				NewMap[x, y].transform.parent = MapHold.transform;
				if(x == 0){
					NewMap[x, y].AddComponent<PolygonCollider2D>();
				}
				if (y == 0)
				{
					NewMap[x, y].AddComponent<PolygonCollider2D>();
				}
				if (y+1 == Y)
				{
					NewMap[x, y].AddComponent<PolygonCollider2D>();
				}
				if (x+1 == X)
				{
					NewMap[x, y].AddComponent<PolygonCollider2D>();
				}
			}
		}
	}

}
