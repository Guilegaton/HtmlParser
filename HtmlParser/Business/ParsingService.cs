using HtmlParser.Extensions;
using HtmlParser.Interfaces;
using System;
using System.Reflection;

namespace HtmlParser.Business
{
    public class ParsingService<TModel> where TModel : class, new()
    {
        #region Public Methods

        /// <summary>
        /// Convert nodes to models
        /// </summary>
        /// <param name="node">The Node that was returned from SearchService</param>
        /// <returns></returns>
        public static TModel Parse(INode<TModel> node)
        {
            var model = new TModel();
            model = FillProperty(model, node);
            foreach (var subNode in node.SubNodes)
            {
                model = Parse(subNode, model);
            }

            return model;
        }

        private static TModel Parse(INode<TModel> node, TModel model)
        {
            model = FillProperty(model, node);
            foreach (var subNode in node.SubNodes)
            {
                model = Parse(subNode, model);
            }

            return model;
        }

        #endregion Public Methods

        #region Private Methods

        private static TModel FillProperty(TModel model, INode<TModel> node)
        {
            if (node.Property != null)
            {
                var property = node.GetMemberExpression();
                if (property != null &&
                    property.Member is PropertyInfo propInfo)
                {
                    var value = string.IsNullOrWhiteSpace(node.AttributeOfProperty) ? Convert.ChangeType(node.Element.TextContent.Trim(), propInfo.PropertyType) 
                                                                                    : Convert.ChangeType(node.Element.Attributes[node.AttributeOfProperty].Value.Trim(), propInfo.PropertyType);
                    if (value != null)
                    {
                        model.Set(property , value);
                    }
                }
            }

            return model;
        }

        #endregion Private Methods

    }
}