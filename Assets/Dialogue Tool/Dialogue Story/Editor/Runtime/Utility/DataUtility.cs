using System.Collections.Generic;

namespace E.Story
{
    // 数据处理实用类
    public class DataUtility
    {
        /// <summary>
        /// 克隆选择数据列表
        /// </summary>
        /// <param name="oldDatas">选择数据列表</param>
        /// <returns>选择数据列表</returns>
        public static List<ChoiceData> CloneChoiceDatas(List<ChoiceData> oldDatas)
        {
            List<ChoiceData> newDatas = new List<ChoiceData>();
            foreach (ChoiceData data in oldDatas)
            {
                ChoiceData newData = new ChoiceData(data.Text, data.NextNodeID);
                newDatas.Add(newData);
            }

            return newDatas;
        }

        /// <summary>
        /// 克隆句子数据列表
        /// </summary>
        /// <param name="oldDatas">句子数据</param>
        /// <returns>句子数据</returns>
        public static List<SentenceData> CloneSentenceDatas(List<SentenceData> oldDatas)
        {
            if(oldDatas == null)
            {
                return null;
            }

            List<SentenceData> newDatas = new List<SentenceData>();
            foreach(SentenceData data in oldDatas)
            {
                SentenceData newData = new SentenceData(data.Text);
                newDatas.Add(newData);
            }

            return newDatas;
        }
    }
}