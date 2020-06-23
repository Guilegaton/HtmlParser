using AngleSharp.Dom;
using HtmlParser.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace HtmlParser.Models
{
    public abstract class Node<TModel> : INode<TModel> where TModel : class, new()
    {
        #region Public Constructors

        public Node()
        {
            SubNodes = new List<INode<TModel>>();
            Attributes = new Dictionary<string, string>();
        }

        public Node(string name, List<INode<TModel>> subNodes, Dictionary<string, string> attributes, IElement element, Expression prop, string innerText)
        {
            var subNodeList = new List<INode<TModel>>();
            foreach (var item in subNodes)
            {
                subNodeList.Add((INode<TModel>)item.Clone());
            }
            SubNodes = subNodeList;

            var attrs = new Dictionary<string, string>();
            foreach (var pair in attributes)
            {
                attrs.Add(new string(pair.Key.ToArray()), new string(pair.Value.ToArray()));
            }
            Attributes = attrs;
            InnerText = innerText;
            Element = element;
            Property = prop;
            Name = new string(name.ToArray());
        }


        #endregion Public Constructors

        #region Public Properties

        public Dictionary<string, string> Attributes { get; set; }
        public IElement Element { get; set; }
        public string Name { get; set; }
        public string InnerText { get; set; }
        public Expression Property { get; set; }
        public string AttributeOfProperty { get; set; }
        public List<INode<TModel>> SubNodes { get; set; }

        #endregion Public Properties

        #region Public Methods

        public abstract object Clone();
        public abstract MemberExpression GetMemberExpression();

        #endregion Public Methods
    }
}