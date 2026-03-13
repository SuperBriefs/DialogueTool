using System;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.UIElements;

namespace E.Story
{
    public class BranchNode : SingleInMultiOutNode
    {
        public override void Init(StoryGraphView graphView, string title, Vector2 position)
        {
            base.Init(graphView, title, position);

            // 重设属性默认值
            Type = NodeType.Branch;

            ChoiceDatas.Clear();
            ChoiceDatas.Add(new ChoiceData("选项文本一"));
            ChoiceDatas.Add(new ChoiceData("选项文本二"));
        }

        protected override void DrawOutputContainer()
        {
            // 遍历选项视图列表：创建对应端口
            for(int i = 0; i < ChoiceDatas.Count; i++)
            {
                ChoiceData choiceData = ChoiceDatas[i];
                output = this.CreatePort(choiceData.Text);
                output.userData = choiceData;
                outputContainer.Add(output);
            }
        }

        protected override void DrawExtensionContainer()
        {
            // 创建自定义容器
            customDataContainer = new VisualElement();
            // 创建折叠框
            foldout = ElementUtility.CreateFoldout("节点内容");
            // 创建添加按钮
            Button btnAdd = ElementUtility.CreateButton("添加选项", () =>
            {
                ChoiceData choiceData = new ChoiceData("选项文本");
                ChoiceDatas.Add(choiceData);

                VisualElement lineContainer = CreateChoiceData(choiceData);
                foldout.Add(lineContainer);
                
                OnAddChoiceText(choiceData);
            });

            // 放置UI元素
            foldout.Add(btnAdd);
            customDataContainer.Add(foldout);
            extensionContainer.Add(customDataContainer);

            // 遍历列表并创建选项条目
            foreach(ChoiceData choiceData in ChoiceDatas)
            {
                VisualElement lineContainer = CreateChoiceData(choiceData);
                foldout.Add(lineContainer);
            }

            // 添加USS类名
            btnAdd.AddClasses(
                "foldout-item"
            );
            customDataContainer.AddClasses(
                "node__custom-data-container"
            );

            RefreshExpandedState();
        }

        /// <summary>
        /// 创建选项数据UI
        /// </summary>
        private VisualElement CreateChoiceData(object userData)
        {
            // 获取选项数据
            ChoiceData choiceData = (ChoiceData)userData;

            // 创建选项容器
            VisualElement choiceContainer = new VisualElement();
            // 创建行容器
            VisualElement lineContainer = new VisualElement();
            // 创建句子输入框
            TextField tfdChoice = ElementUtility.CreateTextArea(choiceData.Text, null, callback =>
            {
                choiceData.Text = callback.newValue;
                OnEditChoiceText(choiceData);
            });

            // 创建删除按钮
            Button btnDelete = ElementUtility.CreateButton("X", () =>
            {
                if(ChoiceDatas.Count == 1)
                {
                    Debug.Log("请至少保留一个选项");
                    return;
                }

                // 从数据列表移除
                ChoiceDatas.Remove(choiceData);
                // 从UI移除
                foldout.Remove(choiceContainer);
                
                OnRemoveChoiceText(choiceData);
            });

            // 放置UI元素
            lineContainer.Add(tfdChoice);
            lineContainer.Add(btnDelete);
            choiceContainer.Add(lineContainer);

            // 添加USS类名
            choiceContainer.AddClasses
            (
                "foldout-item"
            );
            lineContainer.AddClasses
            (
                "row-container"
            );
            tfdChoice.AddClasses
            (
                "textfield",
                "textfield__quote",
                "row-item__left-center"
            );
            btnDelete.AddClasses
            (
                "row-item__right"
            );

            return choiceContainer;
        }

        /// <summary>
        /// 当编辑选项文本时
        /// </summary>
        private void OnEditChoiceText(ChoiceData choiceData)
        {
            // 遍历获取端口元素
            foreach(Port port in outputContainer.Children())
            {
                if(port.userData == choiceData)
                {
                    port.portName = choiceData.Text;
                    break;
                }
            }
        }

        /// <summary>
        /// 当添加选项文本时
        /// </summary>
        private void OnAddChoiceText(ChoiceData choiceData)
        {
            Port newPort = this.CreatePort(choiceData.Text);
            newPort.userData = choiceData;
            outputContainer.Add(newPort);
        }

        /// <summary>
        /// 当删除选项文本时
        /// </summary>
        private void OnRemoveChoiceText(ChoiceData choiceData)
        {
            Port portToRemove = null;
            // 遍历获取端口元素
            foreach(Port port in outputContainer.Children())
            {
                if(port.userData == choiceData)
                {
                    portToRemove = port;
                    break;
                }
            }

            // 删除多余端口
            outputContainer.Remove(portToRemove);
        }
    }
}