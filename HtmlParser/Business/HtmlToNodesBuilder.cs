using AngleSharp;
using AngleSharp.Dom;
using HtmlParser.Interfaces;
using HtmlParser.Models;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace HtmlParser
{
    public static class HtmlToNodesBuilder<TModel> where TModel : class, new()
    {
        /// <summary>
        /// Get Nodes from HTML template
        /// </summary>
        /// <param name="html">
        /// HTML template that contains a representation for search models. 
        /// You need to add attribute "@@model" with value "[property invocation chain]" to tag that contains a value for model property.
        /// (e.g. "@@model='SubTitle.Text'" where "SubTitle" is a class that contains property "Text") 
        /// </param>
        /// <returns></returns>
        public static IEnumerable<INode<TModel>> ConvertHtmlToNodes(string html)
        {
            var result = new List<INode<TModel>>();
            var config = Configuration.Default;
            var document = new AngleSharp.Html.Parser.HtmlParser().ParseDocument(html);
            foreach (IElement item in document.ChildNodes[0].ChildNodes[1].ChildNodes.Where(node => node.NodeName != "#text"))
            {
                result.Add(GetNode(item));
            }

            return result;
        }


        private static INode<TModel> GetNode(IElement element)
        {
            var node = new HtmlNode<TModel>
            {
                Name = element.TagName.ToLower(),
                Attributes = GetAttributes(element),
                SubNodes = GetSubNodes(element),
                Property = element.Attributes.Any(attr => attr.Name == "@@model") && element.ChildNodes.Any() ? GetProperty(element.Attributes.FirstOrDefault(attr => attr.Name == "@@model").Value) : null
            };
            return node;
        }

        private static Dictionary<string, string> GetAttributes(IElement element)
        {
            var result = new Dictionary<string, string>();
            foreach (var attr in element.Attributes.Where(pair => pair.Name != "@@model"))
            {
                result.Add(attr.Name.ToLower(), attr.Value.ToLower());
            }

            return result;
        }

        private static List<INode<TModel>> GetSubNodes(IElement element)
        {
            var result = new List<INode<TModel>>();

            foreach (var item in element.Children)
            {
                result.Add(GetNode(item));
            }

            return result;
        }

        private static Expression GetProperty(string propCall)
        {
            var properties = propCall.Split('.');
            ParameterExpression pe = Expression.Parameter(typeof(TModel), "source");

            Expression lastMember = pe;

            for (int i = 0; i < properties.Length; i++)
            {
                MemberExpression member = Expression.Property(lastMember, properties[i]);
                lastMember = member;
            }

            return lastMember;
        }
    }
}
