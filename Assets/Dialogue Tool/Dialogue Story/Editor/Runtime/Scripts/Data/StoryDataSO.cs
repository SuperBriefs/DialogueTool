using System.Collections.Generic;
using UnityEngine;

namespace E.Story
{
    // 故事数据
    public class StoryDataSO : ScriptableObject
    {
        [SerializeField] private string fileName;
        [SerializeField] private List<GroupData> groupDatas;
        [SerializeField] private List<NodeData> nodeDatas;
        [SerializeField] private List<NoteData> noteDatas;

        // 文件名称
        public string FileName { get => fileName; set => fileName = value; }

        // 分组数据列表
        public List<GroupData> GroupDatas { get => groupDatas; set => groupDatas = value; }

        // 节点数据列表
        public List<NodeData> NodeDatas { get => nodeDatas; set => nodeDatas = value; }
        
        // 标签数据列表
        public List<NoteData> NoteDatas { get => noteDatas ; set => NoteDatas = value; }
        
        /// <summary>
        /// 初始化
        /// </summary>
        public void Init(string fileName)
        {
            this.fileName = fileName;
            groupDatas = new List<GroupData>();
            nodeDatas = new List<NodeData>();
            noteDatas = new List<NoteData>();
        }
    }
}