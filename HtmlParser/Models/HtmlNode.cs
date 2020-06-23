using AngleSharp.Dom;
using HtmlParser.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace HtmlParser.Models
{
    public class HtmlNode<TModel> : Node<TModel> where TModel : class, new()
    {
        #region Public Constructors

        public HtmlNode() : base()
        {
        }

        #endregion Public Constructors

        #region Private Constructors

        private HtmlNode(string name,
            List<INode<TModel>> subNodes,
            Dictionary<string, string> attributes,
            IElement element, Expression prop, string innerText) : base(name, subNodes, attributes, element, prop, innerText)
        {
        }

        #endregion Private Constructors

        #region Public Methods

        public override object Clone()
        {
            return new HtmlNode<TModel>(this.Name, this.SubNodes, this.Attributes, this.Element, this.Property, this.InnerText);
        }

        public override MemberExpression GetMemberExpression()
        {
            return this.Property as MemberExpression;
        }

        #endregion Public Methods
    }
}