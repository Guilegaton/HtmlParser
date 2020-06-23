﻿using HtmlParser.Interfaces;
using HtmlParser.Models;
using System.Collections.Generic;

namespace HtmlParser.Builders.Blocks
{
    /// <summary>
    /// Builder for nodes with 'plaintext' tag
    /// </summary>
    /// <typeparam name="TModel">Model type for "HTML to Models" convert</typeparam>
    public class PlainTextBlockBuilder<TModel> : BaseBlockBuilder<TModel>, INodeBuilder<TModel> where TModel : class, new()
    {
        #region Public Constructors

        public PlainTextBlockBuilder()
        {
            _node = new BuilderNode<TModel>
            {
                Name = "plaintext"
            };
            _nodes = new List<INodeBuilder<TModel>>();
        }

        #endregion Public Constructors
    }
}