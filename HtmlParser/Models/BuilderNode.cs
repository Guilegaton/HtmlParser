using AngleSharp.Dom;
using HtmlParser.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace HtmlParser.Models
{
    public class BuilderNode<TModel> : Node<TModel> where TModel : class, new()
    {
        #region Public Constructors

        public BuilderNode() : base()
        {
        }

        #endregion Public Constructors

        #region Private Constructors

        private BuilderNode(string name,
            List<INode<TModel>> subNodes,
            Dictionary<string, string> attributes,
            IElement element, Expression prop, string innerText) : base(name, subNodes, attributes, element, prop, innerText)
        {
        }

        #endregion Private Constructors

        #region Public Methods

        public override object Clone()
        {
            return new BuilderNode<TModel>(this.Name, this.SubNodes, this.Attributes, this.Element, this.Property, this.InnerText);
        }

        public override MemberExpression GetMemberExpression()
        {
            return (this.Property as Expression<Func<TModel, object>>).Body as MemberExpression;
        }

        #endregion Public Methods
    }
}