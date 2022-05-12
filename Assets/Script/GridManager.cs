using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManager : MonoBehaviour
{

    [SerializeField] private Vector3 _CellSize = new Vector3(100, 100, 100);
    [SerializeField] private Vector3 _Spacing = Vector3.zero;


    public float x_Start, y_Start, z_Start;
    public int ColumnLength;
    public int RowLength;
    //public int x_Space, y_Space, z_Space;
    public GameObject prefab;

    public Vector3 spacing
    {
        get { return _Spacing; }
        //set { SetProperty(ref _Spacing, value); }
    }

    void Start()
    {
        for (int i = 0; i < ColumnLength * RowLength; i++)
        {
            Vector3 position;
            position = new Vector3(x_Start + (spacing.x * (i % ColumnLength)), y_Start + (-spacing.y * (i / ColumnLength)), z_Start + (spacing.z * (i / ColumnLength)));

            Instantiate(prefab, position, Quaternion.identity);
        }

    }
}
