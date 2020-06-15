using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum EdgeType
{
    Up,
    Right,
    Down,
    Left
}

public class Edge
{
    public int activeType = 0;
    public Bounds bounds;
    public EdgeObject edgeObject;

    public Edge() { }

    public Edge(Edge edge)
    {
        activeType = edge.activeType;
        bounds = edge.bounds;
    }
}

public class GameBox
{
    public List<int> edges;
    public int activeType = 0;
    public Vector3 position;
    public BoxObject boxObject;

    public GameBox()
    {
        edges = new List<int>(4);
        for (int i = 0; i < 4; i++)
            edges.Add(-1);
    }

    public GameBox(GameBox gameBox)
    {
        edges = new List<int>(gameBox.edges.Count);
        for(int i = 0; i < gameBox.edges.Count; i++)
        {
            edges.Add(gameBox.edges[i]);
        }
        activeType = gameBox.activeType;
        position = gameBox.position;
    }

    public int GetEdge(EdgeType edgeType)
    {
        return edges[(int)edgeType];
    }

    public void SetEdge(int edge, EdgeType edgeType)
    {
        edges[(int)edgeType] = edge;
    }

    public bool AllEdgeSet(List<Edge> edgesList)
    {
        for(int i = 0; i < edges.Count; i++)
        {
            if (edgesList[edges[i]].activeType == 0) return false;
        }
        return true;
    }
}

public class RuntimeData
{
    public List<Edge> edges;
    public List<GameBox> boxes;

    public int playerScore = 0;
    public int enemyScroe = 1;

}
