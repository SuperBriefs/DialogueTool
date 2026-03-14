using System;
using UnityEditor.Experimental.GraphView;
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.UIElements;

namespace E.Story{
    public static class ElementUtility
    {
        /// <summary>
        /// 创建按钮
        /// </summary>
        public static Button CreateButton(string text, Action onClick = null)
        {
            Button button = new Button(onClick)
            {
                text = text,
            };

            return button;
        }
        
        /// <summary>
        /// 创建折叠组
        /// </summary>
        public static Foldout CreateFoldout(string title, bool collapsed = false)
        {
            Foldout foldout = new Foldout()
            {
                text = title,
                value = !collapsed
            };

            return foldout;
        }

        /// <summary>
        /// 创建单行文本输入框
        /// </summary>
        public static TextField CreateTextField(string value = null, string label = null, EventCallback<ChangeEvent<string>> onValueChanged = null)
        {
            TextField textField = new TextField()
            {
                value = value,
                label = label
            };

            if(onValueChanged != null)
            {
                textField.RegisterValueChangedCallback(onValueChanged);
            }

            return textField;
        }

        /// <summary>
        /// 创建多行文本输入框
        /// </summary>
        public static TextField CreateTextArea(string value = null, string label = null, EventCallback<ChangeEvent<string>> onValueChanged = null)
        {
            TextField textArea = CreateTextField(value, label, onValueChanged);
            textArea.multiline = true;
            return textArea;
        }

        /// <summary>
        /// 创建对象选择字段
        /// </summary>
        /// <param name="type">对象类型</param>
        /// <param name="obj">对象默认值</param>
        /// <param name="label">标签</param>
        /// <param name="onValueChanged">值变化事件</param>
        /// <returns>对象选择字段</returns>
        public static ObjectField CreateObjectField(Type type, UnityEngine.Object obj, string label = null, EventCallback<ChangeEvent<UnityEngine.Object>> onValueChanged = null)
        {
            ObjectField field = new ObjectField(label)
            {
                objectType = type,
                allowSceneObjects = false,
                value = obj
            };

            if (onValueChanged != null)
            {
                field.RegisterValueChangedCallback(onValueChanged);
            }

            return field;
        }

        /// <summary>
        /// 创建图片预览区域
        /// </summary>
        /// <param name="sprite">图片</param>
        /// <returns>图片预览区域</returns>
        public static Image CreateaImage(Sprite sprite)
        {
            Image image = new Image()
            {
                sprite = sprite,
            };

            return image;
        }
        
        /// <summary>
        /// 创建端口
        /// </summary>
        /// <param name="node">当前的节点</param>
        /// <param name="portName">端口名称</param>
        /// <param name="orientation">连线的方式（默认水平）</param>
        /// <param name="direction">连线的方向（默认输出）</param>
        /// <param name="capacity">允许连线数量（默认单条连接）</param>
        /// <returns>端口</returns>
        public static Port CreatePort(this BaseNode node, string portName = "", Orientation orientation = Orientation.Horizontal, Direction direction = Direction.Output, Port.Capacity capacity = Port.Capacity.Single)
        {
            Port port = node.InstantiatePort(orientation, direction, capacity, typeof(bool));
            port.portName = portName;
            
            return port;
        }
    }
}
