using System;
using UnityEngine;

namespace E.Story
{
    //便签数据
    [Serializable]
    public class NoteData
    {
        [SerializeField] private Rect layout;

        [SerializeField] private string title;
        [SerializeField] private string content;

        // 便签布局
        public Rect Layout { get => layout; set => layout = value; }
        
        // 便签标题
        public string Title { get => title; set => title = value; }

        // 便签内容
        public string Content { get => content; set => content = value; }
    }
}
