using System.Collections.Generic;
using HtmlParser.Interfaces;
using HtmlParser.Models;

namespace HtmlParser.Builders
{
    public class CustomBlockBuilder<TModel> : BaseBlockBuilder<TModel>, INodeBuilder<TModel> where TModel : class, new()
    {
        #region Public Constructors

        public CustomBlockBuilder(string blockName)
        {
            _node = new BuilderNode<TModel>
            {
                Name = blockName
            };
            _nodes = new List<INodeBuilder<TModel>>();
        }

        #endregion Private Constructors
    }
}