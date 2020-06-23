using AngleSharp;
using AngleSharp.Dom;
using HtmlParser.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace HtmlParser.Business
{
    public static class SearchService
    {
        #region Public Methods

        /// <summary>
        /// Search html subtrees by source html code and template.
        /// </summary>
        /// <typeparam name="TModel">Parsing Model. Must be a class with a default constructor.</typeparam>
        /// <param name="html">The source html code.</param>
        /// <param name="node">The parsing template.</param>
        /// <returns>Returns a collection of nodes containing html nodes with desired characteristics.</returns>
        public static IEnumerable<INode<TModel>> SearchBlock<TModel>(string html, INode<TModel> node) where TModel : class, new()
        {
            var config = Configuration.Default;
            var context = BrowsingContext.New(config);
            var document = context.OpenAsync(req => req.Content(html)).GetAwaiter().GetResult();

            return SearchBlock(document, node);
        }

        /// <summary>
        /// Search html subtrees by anglesharp source document and template.
        /// </summary>
        /// <typeparam name="TModel">Parsing Model. Must be a class with a default constructor.</typeparam>
        /// <param name="document">The AngelSharp resource document.</param>
        /// <param name="node">The parsing template.</param>
        /// <returns>Returns a collection of nodes containing html nodes with desired characteristics.</returns>
        public static IEnumerable<INode<TModel>> SearchBlock<TModel>(INode document, INode<TModel> node) where TModel : class, new()
        {
            var result = new List<INode<TModel>>();
            if (document is IElement element)
            {
                var resultNode = ContainsThisBlocks(element, node);
                if (resultNode != null)
                {
                    result.Add((INode<TModel>)resultNode.Clone());
                }
            }
            foreach (var item in document.ChildNodes)
            {

                var res = SearchBlock(item, node);
                if (res != null)
                {
                    result.AddRange(res);
                }
            }

            return result;
        }

        /// <summary>
        /// Search html subtrees by source html and collection of templates.
        /// </summary>
        /// <typeparam name="TModel">Parsing Model. Must be a class with a default constructor.</typeparam>
        /// <param name="document">The AngelSharp resource document.</param>
        /// <param name="nodes">The collection of parsing templates</param>
        /// <returns>Returns a collection of nodes containing html nodes with desired characteristics.</returns>
        public static IEnumerable<INode<TModel>> SearchBlock<TModel>(string html, IEnumerable<INode<TModel>> nodes) where TModel : class, new()
        {
            var config = Configuration.Default;
            var context = BrowsingContext.New(config);
            var document = context.OpenAsync(req => req.Content(html)).GetAwaiter().GetResult();

            return SearchBlock(document, nodes);
        }

        /// <summary>
        /// Search html subtrees by anglesharp source document and collection of templates.
        /// </summary>
        /// <typeparam name="TModel">Parsing Model. Must be a class with a default constructor.</typeparam>
        /// <param name="document">The AngelSharp resource document.</param>
        /// <param name="nodes">The collection of parsing templates</param>
        /// <returns>Returns a collection of nodes containing html nodes with desired characteristics.</returns>
        public static IEnumerable<INode<TModel>> SearchBlock<TModel>(INode document, IEnumerable<INode<TModel>> nodes) where TModel : class, new()
        {
            var result = new List<INode<TModel>>();
            foreach (var node in nodes)
            {
                if (document is IElement element)
                {
                    var resultNode = ContainsThisBlocks(element, node);
                    if (resultNode != null)
                    {
                        result.Add((INode<TModel>)resultNode.Clone());
                    }
                }
                foreach (var item in document.ChildNodes)
                {
                    var res = SearchBlock(item, node);
                    if (res != null)
                    {
                        result.AddRange(res);
                    }
                }
            }
            return result;
        }

        /// <summary>
        /// Search the subtree in the anglesharp element by node template.
        /// </summary>
        /// <typeparam name="TModel">Parsing Model. Must be a class with a default constructor</typeparam>
        /// <param name="element">The AngleSharp resource element.</param>
        /// <param name="node">The template node.</param>
        /// <returns>Returns a node with desired characteristics.</returns>
        public static INode<TModel> ContainsThisBlocks<TModel>(IElement element, INode<TModel> node) where TModel : class, new()
        {
            var result = default(INode<TModel>);

            if (VerifyElement(element, node))
            {
                if(!node.SubNodes.Any())
                {
                    node.Element = element;
                    result = node;
                }
                else 
                { 
                    var pairs = new List<KeyValuePair<IElement, INode<TModel>>>();
                    var children = new List<IElement>(element.Children);

                    foreach (var subNode in node.SubNodes)
                    {
                        var elem = children.FirstOrDefault(el => VerifyElement(el, subNode));
                        if (elem != null)
                        {
                            pairs.Add(new KeyValuePair<IElement, INode<TModel>>(elem, subNode));
                            children.Remove(elem);
                        }
                    }

                    if (pairs.Count == node.SubNodes.Count)
                    {
                        var subnodes = new List<INode<TModel>>();
                        for (int i = 0; i < pairs.Count && subnodes.Count == i; i++)
                        {
                            INode<TModel> res = ContainsThisBlocks(pairs[i].Key, pairs[i].Value);
                            if (res != null)
                            {
                                subnodes.Add((INode<TModel>)res.Clone());
                            }
                        }

                        if (subnodes.Count == pairs.Count)
                        {
                            node.Element = element;
                            node.SubNodes = subnodes;
                            node = (INode<TModel>)node.Clone();
                        }
                        else
                        {
                            node = null;
                        }

                        result = node;
                    }
                }
            }

            return result;
        }

        #endregion Public Methods

        #region Private Methods

        private static bool VerifyElement<TModel>(IElement element, INode<TModel> node) where TModel : class, new() =>
            element?.TagName?.ToLower() == node.Name &&
            (!node.Attributes.Any() || node.Attributes.All(pair => element.Attributes.Any(attr => attr.Name == pair.Key &&
                                                                                                  attr.Value == pair.Value))) &&
            (string.IsNullOrWhiteSpace(node.InnerText) || element.TextContent.Contains(node.InnerText));

        #endregion Private Methods

    }
}
