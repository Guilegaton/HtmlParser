using HtmlParser.Interfaces;
using HtmlParser.Models;
using System.Collections.Generic;

namespace HtmlParser.Builders
{
    /// <summary>
    /// Builder for nodes with 'div' tag
    /// </summary>
    /// <typeparam name="TModel">Model type for "HTML to Models" convert</typeparam>
    public class ContainerBlockBuilder<TModel> : BaseBlockBuilder<TModel>, INodeBuilder<TModel> where TModel : class, new()
    {
        #region Public Constructors

        public ContainerBlockBuilder()
        {
            _node = new BuilderNode<TModel>
            {
                Name = "div"
            };
            _nodes = new List<INodeBuilder<TModel>>();
        }

        #endregion Private Constructors
    }
}
