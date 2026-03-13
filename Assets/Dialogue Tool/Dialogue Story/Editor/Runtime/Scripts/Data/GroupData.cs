using System;
using UnityEngine;

namespace E.Story
{
    // 分组数据
    [Serializable]
    public class GroupData
    {
        [SerializeField] private string title;
        [SerializeField] private string guid;
        [SerializeField] private Vector2 position;

        // 分组标题
        public string Title { get => title; set => title = value; }

        // 分组GUID
        public string GUID { get => guid; set => guid = value; }

        // 分组坐标
        public Vector2 Position { get => position; set => position = value; }
    }
}