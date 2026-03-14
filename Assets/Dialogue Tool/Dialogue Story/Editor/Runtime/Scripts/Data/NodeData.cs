using System;
using System.Collections.Generic;
using UnityEngine;

namespace E.Story
{
    // 节点数据
    [Serializable]
    public class NodeData
    {
        [SerializeField] private string title;
        [SerializeField] private string guid;
        [SerializeField] private NodeType type;
        [SerializeField] private Vector2 position;

        [SerializeField] private string note;
        [SerializeField] private List<ChoiceData> choiceDatas;
        [SerializeField] private string groupID;

        [SerializeField] private Sprite bgi;
        [SerializeField] private Sprite portrait; //TODO：给对话节点添加玩家立绘
        [SerializeField] private string roleName;
        [SerializeField] private List<SentenceData> sentenceDatas;


        // 节点标题
        public string Title { get => title; set => title = value; }
        
        // 节点GUID
        public string GUID { get => guid; set => guid = value; }

        // 节点类型
        public NodeType Type { get => type; set => type = value; }

        // 节点坐标
        public Vector2 Position { get => position; set => position = value; }

        // 节点文本内容
        public string Note { get => note; set => note = value; }

        // 选项视图列表
        public List<ChoiceData> ChoiceDatas { get => choiceDatas; set => choiceDatas = value; }

        // 所属分组GUID
        public string GroupID { get => groupID; set => groupID = value; }

        // 背景图片
        public Sprite BGI { get => bgi; set => bgi = value; }

        // 立绘
        public Sprite Portrait { get => portrait; set => portrait = value; }

        // 节点角色名称
        public string RoleName { get => roleName; set => roleName = value; }

        // 句子列表
        public List<SentenceData> SentenceDatas { get => sentenceDatas; set => sentenceDatas = value; }
    }
}