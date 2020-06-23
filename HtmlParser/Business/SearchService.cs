using AngleSharp.Dom;
using HtmlParser.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace HtmlParser.Business
{
    public static class SearchService
    {
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

        public static INode<TModel> ContainsThisBlocks<TModel>(IElement element, INode<TModel> node)
        {
            if (element?.TagName?.ToLower() == node.Name && 
                (!node.Attributes.Any() || node.Attributes.All(pair => element.Attributes.Any(attr => attr.Name == pair.Key && 
                                                                                                     attr.Value == pair.Value))) &&
                (string.IsNullOrWhiteSpace(node.InnerText) || element.TextContent.Contains(node.InnerText)))
            {
                if(!node.SubNodes.Any())
                {
                    node.Element = element;
                    return node;
                }
                var pairs = new List<KeyValuePair<IElement, INode<TModel>>>();
                var children = new List<IElement>(element.Children);
                foreach (var subNode in node.SubNodes)
                {
                    var elem = children.FirstOrDefault(el => el.TagName.ToLower() == subNode.Name && 
                                                             (!subNode.Attributes.Any() || subNode.Attributes.All(pair => el.Attributes.Any(attr => attr.Name.ToLower() == pair.Key &&
                                                                                                                          attr.Value.ToLower() == pair.Value))) &&
                                                             (string.IsNullOrWhiteSpace(subNode.InnerText) || el.TextContent.Contains(subNode.InnerText)));
                    if (elem != null)
                    {
                        pairs.Add(new KeyValuePair<IElement, INode<TModel>>(elem, subNode));
                        children.Remove(elem);
                    }
                }
                if(pairs.Count == node.SubNodes.Count)
                {
                    var result = new List<INode<TModel>>();
                    for (int i = 0; i < pairs.Count && result.Count == i; i++)
                    {
                        var res = ContainsThisBlocks(pairs[i].Key, pairs[i].Value);
                        if(res != null)
                        {
                            result.Add((INode<TModel>)res.Clone());
                        }
                    }
                    
                    if (result.Count == pairs.Count)
                    {
                        node.Element = element;
                        node.SubNodes = result;
                        node = (INode<TModel>)node.Clone();
                    }
                    else
                    {
                        node = null;
                    }

                    return node;
                }
            }

            return null;
        }
    }
}
