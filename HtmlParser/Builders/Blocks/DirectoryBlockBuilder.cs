using HtmlParser.Interfaces;
using HtmlParser.Models;
using System.Collections.Generic;

namespace HtmlParser.Builders.Blocks
{
    /// <summary>
    /// Builder for nodes with 'dir' tag
    /// </summary>
    /// <typeparam name="TModel">Model type for "HTML to Models" convert</typeparam>
    public class DirectoryBlockBuilder<TModel> : BaseBlockBuilder<TModel>, INodeBuilder<TModel> where TModel : class, new()
    {
        #region Public Constructors

        public DirectoryBlockBuilder()
        {
            _node = new BuilderNode<TModel>
            {
                Name = "dir"
            };
            _nodes = new List<INodeBuilder<TModel>>();
        }

        #endregion Public Constructors
    }
}