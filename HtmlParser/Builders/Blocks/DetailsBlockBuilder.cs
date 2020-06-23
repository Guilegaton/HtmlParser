﻿using HtmlParser.Interfaces;
using HtmlParser.Models;
using System.Collections.Generic;

namespace HtmlParser.Builders.Blocks
{
    /// <summary>
    /// Builder for nodes with 'details' tag
    /// </summary>
    /// <typeparam name="TModel">Model type for "HTML to Models" convert</typeparam>
    public class DetailsBlockBuilder<TModel> : BaseBlockBuilder<TModel>, INodeBuilder<TModel> where TModel : class, new()
    {
        #region Public Constructors

        public DetailsBlockBuilder()
        {
            _node = new BuilderNode<TModel>
            {
                Name = "details"
            };
            _nodes = new List<INodeBuilder<TModel>>();
        }

        #endregion Public Constructors
    }
}