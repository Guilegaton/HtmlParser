using AngleSharp.Dom;
using HtmlParser.Builders.Blocks;
using HtmlParser.Interfaces;
using HtmlParser.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace HtmlParser.Builders
{
    public abstract class BaseBlockBuilder<TModel> : INodeBuilder<TModel> where TModel : class, new()
    {
        #region Private Properties

        protected Node<TModel> _node { get; set; }
        protected List<INodeBuilder<TModel>> _nodes { get; set; }

        #endregion Private Properties

        #region Public Methods

        #region Add Blocks

        #region Without Parameters


        /// <summary>
        /// Add a new builder for the nodes with a 'abbr' tag to the subnodes tree
        /// </summary>
        public virtual INodeBuilder<TModel> AddAbbreviationBlock()
        {
            var result = new AbbreviationBlockBuilder<TModel>();
            _nodes.Add(result);

            return this;
        }

        /// <summary>
        /// Add a new builder for the nodes with a 'acronym' tag to the subnodes tree
        /// </summary>
        public virtual INodeBuilder<TModel> AddAcronymBlock()
        {
            var result = new AcronymBlockBuilder<TModel>();
            _nodes.Add(result);

            return this;
        }

        /// <summary>
        /// Add a new builder for the nodes with a 'address' tag to the subnodes tree
        /// </summary>
        public virtual INodeBuilder<TModel> AddAddressBlock()
        {
            var result = new AddressBlockBuilder<TModel>();
            _nodes.Add(result);

            return this;
        }

        /// <summary>
        /// Add a new builder for the nodes with a 'applet' tag to the subnodes tree
        /// </summary>
        public virtual INodeBuilder<TModel> AddAppletBlock()
        {
            var result = new AppletBlockBuilder<TModel>();
            _nodes.Add(result);

            return this;
        }

        /// <summary>
        /// Add a new builder for the nodes with a 'area' tag to the subnodes tree
        /// </summary>
        public virtual INodeBuilder<TModel> AddAreaBlock()
        {
            var result = new AppletBlockBuilder<TModel>();
            _nodes.Add(result);

            return this;
        }

        /// <summary>
        /// Add a new builder for the nodes with a 'article' tag to the subnodes tree
        /// </summary>
        public virtual INodeBuilder<TModel> AddArticleBlock()
        {
            var result =  new ArticleBlockContainer<TModel>();
            _nodes.Add(result);

            return this;
        }

        /// <summary>
        /// Add a new builder for the nodes with a 'aside' tag to the aside tree
        /// </summary>
        public virtual INodeBuilder<TModel> AddAsideBlock()
        {
            var result =  new AsideBlockBuilder<TModel>();
            _nodes.Add(result);

            return this;
        }

        /// <summary>
        /// Add a new builder for the nodes with a 'audio' tag to the aside tree
        /// </summary>
        public virtual INodeBuilder<TModel> AddAudioBlock()
        {
            var result =  new AudioBlockBuilder<TModel>();
            _nodes.Add(result);

            return this;
        }

        /// <summary>
        /// Add a new builder for the nodes with a 'body' tag to the aside tree
        /// </summary>
        public virtual INodeBuilder<TModel> AddBodyBlock()
        {
            var result =  new BodyBlockBuilder<TModel>();
            _nodes.Add(result);

            return this;
        }

        /// <summary>
        /// Add a new builder for the nodes with a 'b' tag to the aside tree
        /// </summary>
        public virtual INodeBuilder<TModel> AddBoldTextBlock()
        {
            var result =  new BoldTextBlockBuilder<TModel>();
            
            _nodes.Add(result);
            return this;
        }

        /// <summary>
        /// Add a new builder for the nodes with a 'button' tag to the aside tree
        /// </summary>
        public virtual INodeBuilder<TModel> AddButtonBlock()
        {
            var result =  new ButtonBlockBuilder<TModel>();
            _nodes.Add(result);

            return this;
        }

        /// <summary>
        /// Add a new builder for the nodes with a 'canvas' tag to the aside tree
        /// </summary>
        public virtual INodeBuilder<TModel> AddCanvasBlock()
        {
            var result =  new CanvasBlockBuilder<TModel>();
            _nodes.Add(result);

            return this;
        }

        /// <summary>
        /// Add a new builder for the nodes with a 'caption' tag to the aside tree
        /// </summary>
        public virtual INodeBuilder<TModel> AddCaptionBlock()
        {
            var result =  new CaptionBlockBuilder<TModel>();
            _nodes.Add(result);

            return this;
        }

        /// <summary>
        /// Add a new builder for the nodes with a 'center' tag to the aside tree
        /// </summary>
        public virtual INodeBuilder<TModel> AddCentredTextBlock()
        {
            var result =  new CentredTextBlockBuilder<TModel>();
            _nodes.Add(result);

            return this;
        }

        /// <summary>
        /// Add a new builder for the nodes with a 'cite' tag to the aside tree
        /// </summary>
        public virtual INodeBuilder<TModel> AddCiteTextBlock()
        {
            var result =  new CiteTextBlockBuilder<TModel>();
            _nodes.Add(result);

            return this;
        }

        /// <summary>
        /// Add a new builder for the nodes with a 'code' tag to the aside tree
        /// </summary>
        public virtual INodeBuilder<TModel> AddCodeTextBlock()
        {
            var result =  new CodeTextBlockBuilder<TModel>();
            _nodes.Add(result);

            return this;
        }

        /// <summary>
        /// Add a new builder for the nodes with a 'comment' tag to the aside tree
        /// </summary>
        public virtual INodeBuilder<TModel> AddCommentBlock()
        {
            var result =  new CommentBlockBuilder<TModel>();
            _nodes.Add(result);

            return this;
        }

        /// <summary>
        /// Add a new builder for the nodes with a 'div' tag to the subnodes tree
        /// </summary>
        public virtual INodeBuilder<TModel> AddContainerBlock()
        {
            var result =  new ContainerBlockBuilder<TModel>();
            _nodes.Add(result);

            return this;
        }

        /// <summary>
        /// Add a new builder for the nodes with a 'datalist' tag to the aside tree
        /// </summary>
        public virtual INodeBuilder<TModel> AddDatalistBlock()
        {
            var result =  new DatalistBlockBuilder<TModel>();
            _nodes.Add(result);

            return this;
        }

        /// <summary>
        /// Add a new builder for the nodes with a 'details' tag to the aside tree
        /// </summary>
        public INodeBuilder<TModel> AddDetailsBlock()
        {
            var result =  new DetailsBlockBuilder<TModel>();
            _nodes.Add(result);

            return this;
        }

        /// <summary>
        /// Add a new builder for the nodes with a 'dir' tag to the aside tree
        /// </summary>
        public INodeBuilder<TModel> AddDirectoryBlock()
        {
            var result =  new DirectoryBlockBuilder<TModel>();
            _nodes.Add(result);

            return this;
        }

        /// <summary>
        /// Add a new builder for the nodes with a 'footer' tag to the aside tree
        /// </summary>
        public INodeBuilder<TModel> AddFooterBlock()
        {
            var result =  new FooterBlockBuilder<TModel>();
            _nodes.Add(result);

            return this;
        }

        /// <summary>
        /// Add a new builder for the nodes with a 'form' tag to the aside tree
        /// </summary>
        public INodeBuilder<TModel> AddFormBlock()
        {
            var result =  new FormBlockBuilder<TModel>();
            _nodes.Add(result);

            return this;
        }

        /// <summary>
        /// Add a new builder for the nodes with a 'frame' tag to the aside tree
        /// </summary>
        public INodeBuilder<TModel> AddFrameBlock()
        {
            var result =  new FrameBlockBuilder<TModel>();
            _nodes.Add(result);

            return this;
        }

        /// <summary>
        /// Add a new builder for the nodes with a 'frameset' tag to the aside tree
        /// </summary>
        public INodeBuilder<TModel> AddFrameSetBlock()
        {
            var result =  new FrameSetBlockBuilder<TModel>();
            _nodes.Add(result);

            return this;
        }

        /// <summary>
        /// Add a new builder for the nodes with a 'h1' tag to the aside tree
        /// </summary>
        public INodeBuilder<TModel> AddH1TextBlock()
        {
            var result =  new H1TextBlockBuilder<TModel>();
            _nodes.Add(result);

            return this;
        }

        /// <summary>
        /// Add a new builder for the nodes with a 'h2' tag to the aside tree
        /// </summary>
        public INodeBuilder<TModel> AddH2TextBlock()
        {
            var result =  new H2TextBlockBuilder<TModel>();
            _nodes.Add(result);

            return this;
        }

        /// <summary>
        /// Add a new builder for the nodes with a 'h3' tag to the aside tree
        /// </summary>
        public INodeBuilder<TModel> AddH3TextBlock()
        {
            var result =  new H3TextBlockBuilder<TModel>();
            _nodes.Add(result);

            return this;
        }

        /// <summary>
        /// Add a new builder for the nodes with a 'h4' tag to the aside tree
        /// </summary>
        public INodeBuilder<TModel> AddH4TextBlock()
        {
            var result =  new H4TextBlockBuilder<TModel>();
            _nodes.Add(result);

            return this;
        }

        /// <summary>
        /// Add a new builder for the nodes with a 'h5' tag to the aside tree
        /// </summary>
        public INodeBuilder<TModel> AddH5TextBlock()
        {
            var result =  new H5TextBlockBuilder<TModel>();
            
            _nodes.Add(result);
            return this;
        }

        /// <summary>
        /// Add a new builder for the nodes with a 'h6' tag to the aside tree
        /// </summary>
        public INodeBuilder<TModel> AddH6TextBlock()
        {
            var result =  new H6TextBlockBuilder<TModel>();
            _nodes.Add(result);

            return this;
        }

        /// <summary>
        /// Add a new builder for the nodes with a 'hr' tag to the aside tree
        /// </summary>
        public INodeBuilder<TModel> AddHorizontalLineBlock()
        {
            var result =  new HorizontalLineBlockBuilder<TModel>();
            _nodes.Add(result);

            return this;
        }

        /// <summary>
        /// Add a new builder for the nodes with a 'iframe' tag to the aside tree
        /// </summary>
        public INodeBuilder<TModel> AddIframeBlock()
        {
            var result =  new IframeBlockBuilder<TModel>();
            _nodes.Add(result);

            return this;
        }

        /// <summary>
        /// Add a new builder for the nodes with a 'img' tag to the aside tree
        /// </summary>
        public INodeBuilder<TModel> AddImageBlock()
        {
            var result =  new ImageBlockBuilder<TModel>();
            _nodes.Add(result);

            return this;
        }

        /// <summary>
        /// Add a new builder for the nodes with a 'input' tag to the aside tree
        /// </summary>
        public INodeBuilder<TModel> AddInputBlock()
        {
            var result =  new InputBlockBuilder<TModel>();
            _nodes.Add(result);

            return this;
        }

        /// <summary>
        /// Add a new builder for the nodes with a 'i' tag to the aside tree
        /// </summary>
        public INodeBuilder<TModel> AddItalicTextBlock()
        {
            var result =  new ItalicTextBlockBuilder<TModel>();
            _nodes.Add(result);

            return this;
        }

        /// <summary>
        /// Add a new builder for the nodes with a 'label' tag to the aside tree
        /// </summary>
        public INodeBuilder<TModel> AddLabelBlock()
        {
            var result =  new LabelBlockBuilder<TModel>();
            _nodes.Add(result);

            return this;
        }

        /// <summary>
        /// Add a new builder for the nodes with a 'a' tag to the subnodes tree
        /// </summary>
        public virtual INodeBuilder<TModel> AddLinkBlock()
        {
            var result =  new LinkBlockBuilder<TModel>();
            _nodes.Add(result);

            return this;
        }

        /// <summary>
        /// Add a new builder for the nodes with a 'li' tag to the aside tree
        /// </summary>
        public INodeBuilder<TModel> AddListItemBlock()
        {
            var result =  new ListItemBlockBuilder<TModel>();
            _nodes.Add(result);

            return this;
        }

        /// <summary>
        /// Add a new builder for the nodes with a 'main' tag to the aside tree
        /// </summary>
        public INodeBuilder<TModel> AddMainBlock()
        {
            var result =  new MainBlockBuilder<TModel>();
            _nodes.Add(result);

            return this;
        }

        /// <summary>
        /// Add a new builder for the nodes with a 'map' tag to the aside tree
        /// </summary>
        public INodeBuilder<TModel> AddMapBlock()
        {
            var result =  new MapBlockBuilder<TModel>();
            
            _nodes.Add(result);

            return this;
        }

        /// <summary>
        /// Add a new builder for the nodes with a 'marquee' tag to the aside tree
        /// </summary>
        public INodeBuilder<TModel> AddMarqueeBlock()
        {
            var result =  new MarqueeBlockBuilder<TModel>();
            _nodes.Add(result);

            return this;
        }

        /// <summary>
        /// Add a new builder for the nodes with a 'menu' tag to the aside tree
        /// </summary>
        public INodeBuilder<TModel> AddMenuBlock()
        {
            var result =  new MenuBlockBuilder<TModel>();
            _nodes.Add(result);

            return this;
        }

        /// <summary>
        /// Add a new builder for the nodes with a 'nav' tag to the aside tree
        /// </summary>
        public INodeBuilder<TModel> AddNavigationBlock()
        {
            var result =  new NavigationBlockBuilder<TModel>();
            _nodes.Add(result);

            return this;
        }

        /// <summary>
        /// Add a new builder for the nodes with a 'ol' tag to the aside tree
        /// </summary>
        public INodeBuilder<TModel> AddNumeratedListBlock()
        {
            var result =  new NumeratedListBlockBuilder<TModel>();
            _nodes.Add(result);

            return this;
        }

        /// <summary>
        /// Add a new builder for the nodes with a 'option' tag to the aside tree
        /// </summary>
        public INodeBuilder<TModel> AddOptionElementBlock()
        {
            var result =  new OptionElementBlockBuilder<TModel>();
            _nodes.Add(result);

            return this;
        }

        /// <summary>
        /// Add a new builder for the nodes with a 'optgroup' tag to the aside tree
        /// </summary>
        public INodeBuilder<TModel> AddOptionsGroupBlock()
        {
            var result =  new OptionsGroupBlockBuilder<TModel>();
            _nodes.Add(result);

            return this;
        }

        /// <summary>
        /// Add a new builder for the nodes with a 'p' tag to the subnodes tree
        /// </summary>
        public virtual INodeBuilder<TModel> AddParagraphBlock()
        {
            var result =  new ParagraphBlockBuilder<TModel>();
            _nodes.Add(result);

            return this;
        }

        /// <summary>
        /// Add a new builder for the nodes with a 'param' tag to the aside tree
        /// </summary>
        public INodeBuilder<TModel> AddParamBlock()
        {
            var result =  new ParamBlockBuilder<TModel>();
            _nodes.Add(result);

            return this;
        }

        /// <summary>
        /// Add a new builder for the nodes with a 'plaintext' tag to the aside tree
        /// </summary>
        public INodeBuilder<TModel> AddPlainTextBlock()
        {
            var result =  new PlainTextBlockBuilder<TModel>();
            _nodes.Add(result);

            return this;
        }

        /// <summary>
        /// Add a new builder for the nodes with a 'q' tag to the aside tree
        /// </summary>
        public virtual INodeBuilder<TModel> AddQuoteBlock()
        {
            var result =  new QuoteBlockBuilder<TModel>();
            _nodes.Add(result);

            return this;
        }

        /// <summary>
        /// Add a new builder for the nodes with a 'ruby' tag to the aside tree
        /// </summary>
        public virtual INodeBuilder<TModel> AddRubyBlock()
        {
            var result =  new RubyBlockBuilder<TModel>();
            _nodes.Add(result);

            return this;
        }

        /// <summary>
        /// Add a new builder for the nodes with a 'rt' tag to the aside tree
        /// </summary>
        public virtual INodeBuilder<TModel> AddRubyTitleBlock()
        {
            var result =  new RubyTitleBlockBuilder<TModel>();
            _nodes.Add(result);

            return this;
        }

        /// <summary>
        /// Add a new builder for the nodes with a 'section' tag to the aside tree
        /// </summary>
        public virtual INodeBuilder<TModel> AddSectionBlock()
        {
            var result =  new SectionBlockBuilder<TModel>();
            _nodes.Add(result);

            return this;
        }

        /// <summary>
        /// Add a new builder for the nodes with a 'select' tag to the aside tree
        /// </summary>
        public virtual INodeBuilder<TModel> AddSelectBlock()
        {
            var result =  new SelectBlockBuilder<TModel>();
            _nodes.Add(result);

            return this;
        }

        /// <summary>
        /// Add a new builder for the nodes with a 'bdi' tag to the aside tree
        /// </summary>
        public virtual INodeBuilder<TModel> AddSeparateTextBlock()
        {
            var result =  new SeparateTextBlockBuilder<TModel>();
            _nodes.Add(result);

            return this;
        }

        /// <summary>
        /// Add a new builder for the nodes with a 'small' tag to the aside tree
        /// </summary>
        public virtual INodeBuilder<TModel> AddSmallTextBlock()
        {
            var result =  new SmallTextBlockBuilder<TModel>();
            _nodes.Add(result);

            return this;
        }

        /// <summary>
        /// Add a new builder for the nodes with a 'span' tag to the aside tree
        /// </summary>
        public virtual INodeBuilder<TModel> AddSpanBlock()
        {
            var result =  new SpanBlockBuilder<TModel>();
            _nodes.Add(result);

            return this;
        }

        /// <summary>
        /// Add a new builder for the nodes with a 's' tag to the aside tree
        /// </summary>
        public virtual INodeBuilder<TModel> AddStrikeTextBlock()
        {
            var result =  new StrikeTextBlockBuilder<TModel>();
            _nodes.Add(result);

            return this;
        }

        /// <summary>
        /// Add a new builder for the nodes with a 'strong' tag to the aside tree
        /// </summary>
        public virtual INodeBuilder<TModel> AddStrongTextBlock()
        {
            var result =  new StrongTextBlockBuilder<TModel>();
            _nodes.Add(result);

            return this;
        }

        /// <summary>
        /// Add a new builder for the nodes with a 'sub' tag to the aside tree
        /// </summary>
        public virtual INodeBuilder<TModel> AddSubTextBlock()
        {
            var result =  new SubTextBlockBuilder<TModel>();
            _nodes.Add(result);

            return this;
        }

        /// <summary>
        /// Add a new builder for the nodes with a 'summary' tag to the aside tree
        /// </summary>
        public virtual INodeBuilder<TModel> AddSummaryBlock()
        {
            var result =  new SummaryBlockBuilder<TModel>();
            _nodes.Add(result);

            return this;
        }

        /// <summary>
        /// Add a new builder for the nodes with a 'sup' tag to the aside tree
        /// </summary>
        public virtual INodeBuilder<TModel> AddSupTextBlock()
        {
            var result =  new SupTextBlockBuilder<TModel>();
            _nodes.Add(result);

            return this;
        }

        /// <summary>
        /// Add a new builder for the nodes with a 'table' tag to the aside tree
        /// </summary>
        public virtual INodeBuilder<TModel> AddTableBlock()
        {
            var result =  new TableBlockBuilder<TModel>();
            _nodes.Add(result);

            return this;
        }

        /// <summary>
        /// Add a new builder for the nodes with a 'tbody' tag to the aside tree
        /// </summary>
        public virtual INodeBuilder<TModel> AddTableBodyBlock()
        {
            var result =  new TableBodyBlockBuilder<TModel>();
            _nodes.Add(result);

            return this;
        }

        /// <summary>
        /// Add a new builder for the nodes with a 'td' tag to the aside tree
        /// </summary>
        public virtual INodeBuilder<TModel> AddTableDataBlock()
        {
            var result =  new TableDataBlockBuilder<TModel>();
            _nodes.Add(result);

            return this;
        }

        /// <summary>
        /// Add a new builder for the nodes with a 'tfoot' tag to the aside tree
        /// </summary>
        public virtual INodeBuilder<TModel> AddTableFootBlock()
        {
            var result =  new TableFootBlockBuilder<TModel>();
            _nodes.Add(result);

            return this;
        }

        /// <summary>
        /// Add a new builder for the nodes with a 'thead' tag to the aside tree
        /// </summary>
        public virtual INodeBuilder<TModel> AddTableHeaderBlock()
        {
            var result =  new TableHeaderBlockBuilder<TModel>();
            _nodes.Add(result);

            return this;
        }

        /// <summary>
        /// Add a new builder for the nodes with a 'th' tag to the aside tree
        /// </summary>
        public virtual INodeBuilder<TModel> AddTableHeaderDataBlock()
        {
            var result =  new TableHeaderDataBlockBuilder<TModel>();
            _nodes.Add(result);

            return this;
        }

        /// <summary>
        /// Add a new builder for the nodes with a 'tr' tag to the aside tree
        /// </summary>
        public virtual INodeBuilder<TModel> AddTableRowBlock()
        {
            var result =  new TableRowBlockBuilder<TModel>();
            _nodes.Add(result);

            return this;
        }

        /// <summary>
        /// Add a new builder for the nodes with a 'tt' tag to the aside tree
        /// </summary>
        public virtual INodeBuilder<TModel> AddTeletypeTextBlock()
        {
            var result =  new TeletypeTextBlockBuilder<TModel>();
            _nodes.Add(result);

            return this;
        }

        /// <summary>
        /// Add a new builder for the nodes with a 'textarea' tag to the aside tree
        /// </summary>
        public virtual INodeBuilder<TModel> AddTextAreaBlock()
        {
            var result =  new TextAreaBlockBuilder<TModel>();
            _nodes.Add(result);

            return this;
        }

        /// <summary>
        /// Add a new builder for the nodes with a 'bdo' tag to the aside tree
        /// </summary>
        public virtual INodeBuilder<TModel> AddTextDirectionBlock()
        {
            var result =  new TextDirectionBlockBuilder<TModel>();
            _nodes.Add(result);

            return this;
        }

        /// <summary>
        /// Add a new builder for the nodes with a 'u' tag to the aside tree
        /// </summary>
        public virtual INodeBuilder<TModel> AddUnderlineTextBlock()
        {
            var result =  new UnderlineTextBlockBuilder<TModel>();
            _nodes.Add(result);

            return this;
        }

        /// <summary>
        /// Add a new builder for the nodes with a 'ul' tag to the aside tree
        /// </summary>
        public virtual INodeBuilder<TModel> AddUnorderedListBlock()
        {
            var result =  new UnorderedListBlockBuilder<TModel>();
            _nodes.Add(result);

            return this;
        }

        /// <summary>
        /// Add a new builder for the nodes with a 'var' tag to the aside tree
        /// </summary>
        public virtual INodeBuilder<TModel> AddVariableTextBlock()
        {
            var result =  new VariableTextBlockBuilder<TModel>();
            _nodes.Add(result);

            return this;
        }

        /// <summary>
        /// Add a new builder for the nodes with a 'video' tag to the aside tree
        /// </summary>
        public virtual INodeBuilder<TModel> AddVideoBlock()
        {
            var result =  new VideoBlockBuilder<TModel>();
            _nodes.Add(result);

            return this;
        }

        #endregion Without Parameters

        #region With Parameters

        /// <summary>
        /// Add a new builder for the nodes with a 'abbr' tag to the subnodes tree
        /// </summary>
        public virtual INodeBuilder<TModel> AddAbbreviationBlock(Func<INodeBuilder<TModel>, INodeBuilder<TModel>> nodeFunc)
        {
            var nodeBuilder = new AbbreviationBlockBuilder<TModel>();
            var result = nodeFunc.Invoke(nodeBuilder);
            _nodes.Add(result);

            return this;
        }

        /// <summary>
        /// Add a new builder for the nodes with a 'acronym' tag to the subnodes tree
        /// </summary>
        public virtual INodeBuilder<TModel> AddAcronymBlock(Func<INodeBuilder<TModel>, INodeBuilder<TModel>> nodeFunc)
        {
            var nodeBuilder = new AcronymBlockBuilder<TModel>();
            var result = nodeFunc.Invoke(nodeBuilder);
            _nodes.Add(result);

            return this;
        }

        /// <summary>
        /// Add a new builder for the nodes with a 'address' tag to the subnodes tree
        /// </summary>
        public virtual INodeBuilder<TModel> AddAddressBlock(Func<INodeBuilder<TModel>, INodeBuilder<TModel>> nodeFunc)
        {
            var nodeBuilder = new AddressBlockBuilder<TModel>();
            var result = nodeFunc.Invoke(nodeBuilder);
            _nodes.Add(result);

            return this;
        }

        /// <summary>
        /// Add a new builder for the nodes with a 'applet' tag to the subnodes tree
        /// </summary>
        public virtual INodeBuilder<TModel> AddAppletBlock(Func<INodeBuilder<TModel>, INodeBuilder<TModel>> nodeFunc)
        {
            var nodeBuilder = new AppletBlockBuilder<TModel>();
            var result = nodeFunc.Invoke(nodeBuilder);
            _nodes.Add(result);

            return this;
        }

        /// <summary>
        /// Add a new builder for the nodes with a 'area' tag to the subnodes tree
        /// </summary>
        public virtual INodeBuilder<TModel> AddAreaBlock(Func<INodeBuilder<TModel>, INodeBuilder<TModel>> nodeFunc)
        {
            var nodeBuilder = new AppletBlockBuilder<TModel>();
            var result = nodeFunc.Invoke(nodeBuilder);
            _nodes.Add(result);

            return this;
        }

        /// <summary>
        /// Add a new builder for the nodes with a 'article' tag to the subnodes tree
        /// </summary>
        public virtual INodeBuilder<TModel> AddArticleBlock(Func<INodeBuilder<TModel>, INodeBuilder<TModel>> nodeFunc)
        {
            var nodeBuilder = new ArticleBlockContainer<TModel>();
            var result = nodeFunc.Invoke(nodeBuilder);
            _nodes.Add(result);

            return this;
        }

        /// <summary>
        /// Add a new builder for the nodes with a 'aside' tag to the aside tree
        /// </summary>
        public virtual INodeBuilder<TModel> AddAsideBlock(Func<INodeBuilder<TModel>, INodeBuilder<TModel>> nodeFunc)
        {
            var nodeBuilder = new AsideBlockBuilder<TModel>();
            var result = nodeFunc.Invoke(nodeBuilder);
            _nodes.Add(result);

            return this;
        }

        /// <summary>
        /// Add a new builder for the nodes with a 'audio' tag to the aside tree
        /// </summary>
        public virtual INodeBuilder<TModel> AddAudioBlock(Func<INodeBuilder<TModel>, INodeBuilder<TModel>> nodeFunc)
        {
            var nodeBuilder = new AudioBlockBuilder<TModel>();
            var result = nodeFunc.Invoke(nodeBuilder);
            _nodes.Add(result);

            return this;
        }

        /// <summary>
        /// Add a new builder for the nodes with a 'body' tag to the aside tree
        /// </summary>
        public virtual INodeBuilder<TModel> AddBodyBlock(Func<INodeBuilder<TModel>, INodeBuilder<TModel>> nodeFunc)
        {
            var nodeBuilder = new BodyBlockBuilder<TModel>();
            var result = nodeFunc.Invoke(nodeBuilder);
            _nodes.Add(result);

            return this;
        }

        /// <summary>
        /// Add a new builder for the nodes with a 'b' tag to the aside tree
        /// </summary>
        public virtual INodeBuilder<TModel> AddBoldTextBlock(Func<INodeBuilder<TModel>, INodeBuilder<TModel>> nodeFunc)
        {
            var nodeBuilder = new BoldTextBlockBuilder<TModel>();
            var result = nodeFunc.Invoke(nodeBuilder);
            _nodes.Add(result);

            return this;
        }

        /// <summary>
        /// Add a new builder for the nodes with a 'button' tag to the aside tree
        /// </summary>
        public virtual INodeBuilder<TModel> AddButtonBlock(Func<INodeBuilder<TModel>, INodeBuilder<TModel>> nodeFunc)
        {
            var nodeBuilder = new ButtonBlockBuilder<TModel>();
            var result = nodeFunc.Invoke(nodeBuilder);
            _nodes.Add(result);

            return this;
        }

        /// <summary>
        /// Add a new builder for the nodes with a 'canvas' tag to the aside tree
        /// </summary>
        public virtual INodeBuilder<TModel> AddCanvasBlock(Func<INodeBuilder<TModel>, INodeBuilder<TModel>> nodeFunc)
        {
            var nodeBuilder = new CanvasBlockBuilder<TModel>();
            var result = nodeFunc.Invoke(nodeBuilder);
            _nodes.Add(result);

            return this;
        }

        /// <summary>
        /// Add a new builder for the nodes with a 'caption' tag to the aside tree
        /// </summary>
        public virtual INodeBuilder<TModel> AddCaptionBlock(Func<INodeBuilder<TModel>, INodeBuilder<TModel>> nodeFunc)
        {
            var nodeBuilder = new CaptionBlockBuilder<TModel>();
            var result = nodeFunc.Invoke(nodeBuilder);
            _nodes.Add(result);

            return this;
        }

        /// <summary>
        /// Add a new builder for the nodes with a 'center' tag to the aside tree
        /// </summary>
        public virtual INodeBuilder<TModel> AddCentredTextBlock(Func<INodeBuilder<TModel>, INodeBuilder<TModel>> nodeFunc)
        {
            var nodeBuilder = new CentredTextBlockBuilder<TModel>();
            var result = nodeFunc.Invoke(nodeBuilder);
            _nodes.Add(result);

            return this;
        }

        /// <summary>
        /// Add a new builder for the nodes with a 'cite' tag to the aside tree
        /// </summary>
        public virtual INodeBuilder<TModel> AddCiteTextBlock(Func<INodeBuilder<TModel>, INodeBuilder<TModel>> nodeFunc)
        {
            var nodeBuilder = new CiteTextBlockBuilder<TModel>();
            var result = nodeFunc.Invoke(nodeBuilder);
            _nodes.Add(result);

            return this;
        }

        /// <summary>
        /// Add a new builder for the nodes with a 'code' tag to the aside tree
        /// </summary>
        public virtual INodeBuilder<TModel> AddCodeTextBlock(Func<INodeBuilder<TModel>, INodeBuilder<TModel>> nodeFunc)
        {
            var nodeBuilder = new CodeTextBlockBuilder<TModel>();
            var result = nodeFunc.Invoke(nodeBuilder);
            _nodes.Add(result);

            return this;
        }

        /// <summary>
        /// Add a new builder for the nodes with a 'comment' tag to the aside tree
        /// </summary>
        public virtual INodeBuilder<TModel> AddCommentBlock(Func<INodeBuilder<TModel>, INodeBuilder<TModel>> nodeFunc)
        {
            var nodeBuilder = new CommentBlockBuilder<TModel>();
            var result = nodeFunc.Invoke(nodeBuilder);
            _nodes.Add(result);

            return this;
        }

        /// <summary>
        /// Add a new builder for the nodes with a 'div' tag to the subnodes tree
        /// </summary>
        public virtual INodeBuilder<TModel> AddContainerBlock(Func<INodeBuilder<TModel>, INodeBuilder<TModel>> nodeFunc)
        {
            var nodeBuilder = new ContainerBlockBuilder<TModel>();
            var result = nodeFunc.Invoke(nodeBuilder);
            _nodes.Add(result);

            return this;
        }

        /// <summary>
        /// Add a new builder for the nodes with a custom tag to the subnodes tree
        /// </summary>
        public virtual INodeBuilder<TModel> AddCustomBlock(string blockName, Func<INodeBuilder<TModel>, INodeBuilder<TModel>> nodeFunc)
        {
            var nodeBuilder = new CustomBlockBuilder<TModel>(blockName);
            var result = nodeFunc.Invoke(nodeBuilder);
            _nodes.Add(result);

            return this;
        }

        /// <summary>
        /// Add a new builder for the nodes with a 'datalist' tag to the aside tree
        /// </summary>
        public virtual INodeBuilder<TModel> AddDatalistBlock(Func<INodeBuilder<TModel>, INodeBuilder<TModel>> nodeFunc)
        {
            var nodeBuilder = new DatalistBlockBuilder<TModel>();
            var result = nodeFunc.Invoke(nodeBuilder);
            _nodes.Add(result);

            return this;
        }

        /// <summary>
        /// Add a new builder for the nodes with a 'details' tag to the aside tree
        /// </summary>
        public INodeBuilder<TModel> AddDetailsBlock(Func<INodeBuilder<TModel>, INodeBuilder<TModel>> nodeFunc)
        {
            var nodeBuilder = new DetailsBlockBuilder<TModel>();
            var result = nodeFunc.Invoke(nodeBuilder);
            _nodes.Add(result);

            return this;
        }

        /// <summary>
        /// Add a new builder for the nodes with a 'dir' tag to the aside tree
        /// </summary>
        public INodeBuilder<TModel> AddDirectoryBlock(Func<INodeBuilder<TModel>, INodeBuilder<TModel>> nodeFunc)
        {
            var nodeBuilder = new DirectoryBlockBuilder<TModel>();
            var result = nodeFunc.Invoke(nodeBuilder);
            _nodes.Add(result);

            return this;
        }

        /// <summary>
        /// Add a new builder for the nodes with a 'footer' tag to the aside tree
        /// </summary>
        public INodeBuilder<TModel> AddFooterBlock(Func<INodeBuilder<TModel>, INodeBuilder<TModel>> nodeFunc)
        {
            var nodeBuilder = new FooterBlockBuilder<TModel>();
            var result = nodeFunc.Invoke(nodeBuilder);
            _nodes.Add(result);

            return this;
        }

        /// <summary>
        /// Add a new builder for the nodes with a 'form' tag to the aside tree
        /// </summary>
        public INodeBuilder<TModel> AddFormBlock(Func<INodeBuilder<TModel>, INodeBuilder<TModel>> nodeFunc)
        {
            var nodeBuilder = new FormBlockBuilder<TModel>();
            var result = nodeFunc.Invoke(nodeBuilder);
            _nodes.Add(result);

            return this;
        }

        /// <summary>
        /// Add a new builder for the nodes with a 'frame' tag to the aside tree
        /// </summary>
        public INodeBuilder<TModel> AddFrameBlock(Func<INodeBuilder<TModel>, INodeBuilder<TModel>> nodeFunc)
        {
            var nodeBuilder = new FrameBlockBuilder<TModel>();
            var result = nodeFunc.Invoke(nodeBuilder);
            _nodes.Add(result);

            return this;
        }

        /// <summary>
        /// Add a new builder for the nodes with a 'frameset' tag to the aside tree
        /// </summary>
        public INodeBuilder<TModel> AddFrameSetBlock(Func<INodeBuilder<TModel>, INodeBuilder<TModel>> nodeFunc)
        {
            var nodeBuilder = new FrameSetBlockBuilder<TModel>();
            var result = nodeFunc.Invoke(nodeBuilder);
            _nodes.Add(result);

            return this;
        }

        /// <summary>
        /// Add a new builder for the nodes with a 'h1' tag to the aside tree
        /// </summary>
        public INodeBuilder<TModel> AddH1TextBlock(Func<INodeBuilder<TModel>, INodeBuilder<TModel>> nodeFunc)
        {
            var nodeBuilder = new H1TextBlockBuilder<TModel>();
            var result = nodeFunc.Invoke(nodeBuilder);
            _nodes.Add(result);

            return this;
        }

        /// <summary>
        /// Add a new builder for the nodes with a 'h2' tag to the aside tree
        /// </summary>
        public INodeBuilder<TModel> AddH2TextBlock(Func<INodeBuilder<TModel>, INodeBuilder<TModel>> nodeFunc)
        {
            var nodeBuilder = new H2TextBlockBuilder<TModel>();
            var result = nodeFunc.Invoke(nodeBuilder);
            _nodes.Add(result);

            return this;
        }

        /// <summary>
        /// Add a new builder for the nodes with a 'h3' tag to the aside tree
        /// </summary>
        public INodeBuilder<TModel> AddH3TextBlock(Func<INodeBuilder<TModel>, INodeBuilder<TModel>> nodeFunc)
        {
            var nodeBuilder = new H3TextBlockBuilder<TModel>();
            var result = nodeFunc.Invoke(nodeBuilder);
            _nodes.Add(result);

            return this;
        }

        /// <summary>
        /// Add a new builder for the nodes with a 'h4' tag to the aside tree
        /// </summary>
        public INodeBuilder<TModel> AddH4TextBlock(Func<INodeBuilder<TModel>, INodeBuilder<TModel>> nodeFunc)
        {
            var nodeBuilder = new H4TextBlockBuilder<TModel>();
            var result = nodeFunc.Invoke(nodeBuilder);
            _nodes.Add(result);

            return this;
        }

        /// <summary>
        /// Add a new builder for the nodes with a 'h5' tag to the aside tree
        /// </summary>
        public INodeBuilder<TModel> AddH5TextBlock(Func<INodeBuilder<TModel>, INodeBuilder<TModel>> nodeFunc)
        {
            var nodeBuilder = new H5TextBlockBuilder<TModel>();
            var result = nodeFunc.Invoke(nodeBuilder);
            _nodes.Add(result);

            return this;
        }

        /// <summary>
        /// Add a new builder for the nodes with a 'h6' tag to the aside tree
        /// </summary>
        public INodeBuilder<TModel> AddH6TextBlock(Func<INodeBuilder<TModel>, INodeBuilder<TModel>> nodeFunc)
        {
            var nodeBuilder = new H6TextBlockBuilder<TModel>();
            var result = nodeFunc.Invoke(nodeBuilder);
            _nodes.Add(result);

            return this;
        }

        /// <summary>
        /// Add a new builder for the nodes with a 'hr' tag to the aside tree
        /// </summary>
        public INodeBuilder<TModel> AddHorizontalLineBlock(Func<INodeBuilder<TModel>, INodeBuilder<TModel>> nodeFunc)
        {
            var nodeBuilder = new HorizontalLineBlockBuilder<TModel>();
            var result = nodeFunc.Invoke(nodeBuilder);
            _nodes.Add(result);

            return this;
        }

        /// <summary>
        /// Add a new builder for the nodes with a 'iframe' tag to the aside tree
        /// </summary>
        public INodeBuilder<TModel> AddIframeBlock(Func<INodeBuilder<TModel>, INodeBuilder<TModel>> nodeFunc)
        {
            var nodeBuilder = new IframeBlockBuilder<TModel>();
            var result = nodeFunc.Invoke(nodeBuilder);
            _nodes.Add(result);

            return this;
        }

        /// <summary>
        /// Add a new builder for the nodes with a 'img' tag to the aside tree
        /// </summary>
        public INodeBuilder<TModel> AddImageBlock(Func<INodeBuilder<TModel>, INodeBuilder<TModel>> nodeFunc)
        {
            var nodeBuilder = new ImageBlockBuilder<TModel>();
            var result = nodeFunc.Invoke(nodeBuilder);
            _nodes.Add(result);

            return this;
        }

        /// <summary>
        /// Add a new builder for the nodes with a 'input' tag to the aside tree
        /// </summary>
        public INodeBuilder<TModel> AddInputBlock(Func<INodeBuilder<TModel>, INodeBuilder<TModel>> nodeFunc)
        {
            var nodeBuilder = new InputBlockBuilder<TModel>();
            var result = nodeFunc.Invoke(nodeBuilder);
            _nodes.Add(result);

            return this;
        }

        /// <summary>
        /// Add a new builder for the nodes with a 'i' tag to the aside tree
        /// </summary>
        public INodeBuilder<TModel> AddItalicTextBlock(Func<INodeBuilder<TModel>, INodeBuilder<TModel>> nodeFunc)
        {
            var nodeBuilder = new ItalicTextBlockBuilder<TModel>();
            var result = nodeFunc.Invoke(nodeBuilder);
            _nodes.Add(result);

            return this;
        }

        /// <summary>
        /// Add a new builder for the nodes with a 'label' tag to the aside tree
        /// </summary>
        public INodeBuilder<TModel> AddLabelBlock(Func<INodeBuilder<TModel>, INodeBuilder<TModel>> nodeFunc)
        {
            var nodeBuilder = new LabelBlockBuilder<TModel>();
            var result = nodeFunc.Invoke(nodeBuilder);
            _nodes.Add(result);

            return this;
        }

        /// <summary>
        /// Add a new builder for the nodes with a 'a' tag to the subnodes tree
        /// </summary>
        public virtual INodeBuilder<TModel> AddLinkBlock(Func<INodeBuilder<TModel>, INodeBuilder<TModel>> nodeFunc)
        {
            var nodeBuilder = new LinkBlockBuilder<TModel>();
            var result = nodeFunc.Invoke(nodeBuilder);
            _nodes.Add(result);

            return this;
        }

        /// <summary>
        /// Add a new builder for the nodes with a 'li' tag to the aside tree
        /// </summary>
        public INodeBuilder<TModel> AddListItemBlock(Func<INodeBuilder<TModel>, INodeBuilder<TModel>> nodeFunc)
        {
            var nodeBuilder = new ListItemBlockBuilder<TModel>();
            var result = nodeFunc.Invoke(nodeBuilder);
            _nodes.Add(result);

            return this;
        }

        /// <summary>
        /// Add a new builder for the nodes with a 'main' tag to the aside tree
        /// </summary>
        public INodeBuilder<TModel> AddMainBlock(Func<INodeBuilder<TModel>, INodeBuilder<TModel>> nodeFunc)
        {
            var nodeBuilder = new MainBlockBuilder<TModel>();
            var result = nodeFunc.Invoke(nodeBuilder);
            _nodes.Add(result);

            return this;
        }

        /// <summary>
        /// Add a new builder for the nodes with a 'map' tag to the aside tree
        /// </summary>
        public INodeBuilder<TModel> AddMapBlock(Func<INodeBuilder<TModel>, INodeBuilder<TModel>> nodeFunc)
        {
            var nodeBuilder = new MapBlockBuilder<TModel>();
            var result = nodeFunc.Invoke(nodeBuilder);
            _nodes.Add(result);

            return this;
        }

        /// <summary>
        /// Add a new builder for the nodes with a 'marquee' tag to the aside tree
        /// </summary>
        public INodeBuilder<TModel> AddMarqueeBlock(Func<INodeBuilder<TModel>, INodeBuilder<TModel>> nodeFunc)
        {
            var nodeBuilder = new MarqueeBlockBuilder<TModel>();
            var result = nodeFunc.Invoke(nodeBuilder);
            _nodes.Add(result);

            return this;
        }

        /// <summary>
        /// Add a new builder for the nodes with a 'menu' tag to the aside tree
        /// </summary>
        public INodeBuilder<TModel> AddMenuBlock(Func<INodeBuilder<TModel>, INodeBuilder<TModel>> nodeFunc)
        {
            var nodeBuilder = new MenuBlockBuilder<TModel>();
            var result = nodeFunc.Invoke(nodeBuilder);
            _nodes.Add(result);

            return this;
        }

        /// <summary>
        /// Add a new builder for the nodes with a 'nav' tag to the aside tree
        /// </summary>
        public INodeBuilder<TModel> AddNavigationBlock(Func<INodeBuilder<TModel>, INodeBuilder<TModel>> nodeFunc)
        {
            var nodeBuilder = new NavigationBlockBuilder<TModel>();
            var result = nodeFunc.Invoke(nodeBuilder);
            _nodes.Add(result);

            return this;
        }

        /// <summary>
        /// Add a new builder for the nodes with a 'ol' tag to the aside tree
        /// </summary>
        public INodeBuilder<TModel> AddNumeratedListBlock(Func<INodeBuilder<TModel>, INodeBuilder<TModel>> nodeFunc)
        {
            var nodeBuilder = new NumeratedListBlockBuilder<TModel>();
            var result = nodeFunc.Invoke(nodeBuilder);
            _nodes.Add(result);

            return this;
        }

        /// <summary>
        /// Add a new builder for the nodes with a 'option' tag to the aside tree
        /// </summary>
        public INodeBuilder<TModel> AddOptionElementBlock(Func<INodeBuilder<TModel>, INodeBuilder<TModel>> nodeFunc)
        {
            var nodeBuilder = new OptionElementBlockBuilder<TModel>();
            var result = nodeFunc.Invoke(nodeBuilder);
            _nodes.Add(result);

            return this;
        }

        /// <summary>
        /// Add a new builder for the nodes with a 'optgroup' tag to the aside tree
        /// </summary>
        public INodeBuilder<TModel> AddOptionsGroupBlock(Func<INodeBuilder<TModel>, INodeBuilder<TModel>> nodeFunc)
        {
            var nodeBuilder = new OptionsGroupBlockBuilder<TModel>();
            var result = nodeFunc.Invoke(nodeBuilder);
            _nodes.Add(result);

            return this;
        }

        /// <summary>
        /// Add a new builder for the nodes with a 'p' tag to the subnodes tree
        /// </summary>
        public virtual INodeBuilder<TModel> AddParagraphBlock(Func<INodeBuilder<TModel>, INodeBuilder<TModel>> nodeFunc)
        {
            var nodeBuilder = new ParagraphBlockBuilder<TModel>();
            var result = nodeFunc.Invoke(nodeBuilder);
            _nodes.Add(result);

            return this;
        }

        /// <summary>
        /// Add a new builder for the nodes with a 'param' tag to the aside tree
        /// </summary>
        public INodeBuilder<TModel> AddParamBlock(Func<INodeBuilder<TModel>, INodeBuilder<TModel>> nodeFunc)
        {
            var nodeBuilder = new ParamBlockBuilder<TModel>();
            var result = nodeFunc.Invoke(nodeBuilder);
            _nodes.Add(result);

            return this;
        }

        /// <summary>
        /// Add a new builder for the nodes with a 'plaintext' tag to the aside tree
        /// </summary>
        public INodeBuilder<TModel> AddPlainTextBlock(Func<INodeBuilder<TModel>, INodeBuilder<TModel>> nodeFunc)
        {
            var nodeBuilder = new PlainTextBlockBuilder<TModel>();
            var result = nodeFunc.Invoke(nodeBuilder);
            _nodes.Add(result);

            return this;
        }

        /// <summary>
        /// Add a new builder for the nodes with a 'q' tag to the aside tree
        /// </summary>
        public virtual INodeBuilder<TModel> AddQuoteBlock(Func<INodeBuilder<TModel>, INodeBuilder<TModel>> nodeFunc)
        {
            var nodeBuilder = new QuoteBlockBuilder<TModel>();
            var result = nodeFunc.Invoke(nodeBuilder);
            _nodes.Add(result);

            return this;
        }

        /// <summary>
        /// Add a new builder for the nodes with a 'ruby' tag to the aside tree
        /// </summary>
        public virtual INodeBuilder<TModel> AddRubyBlock(Func<INodeBuilder<TModel>, INodeBuilder<TModel>> nodeFunc)
        {
            var nodeBuilder = new RubyBlockBuilder<TModel>();
            var result = nodeFunc.Invoke(nodeBuilder);
            _nodes.Add(result);

            return this;
        }

        /// <summary>
        /// Add a new builder for the nodes with a 'rt' tag to the aside tree
        /// </summary>
        public virtual INodeBuilder<TModel> AddRubyTitleBlock(Func<INodeBuilder<TModel>, INodeBuilder<TModel>> nodeFunc)
        {
            var nodeBuilder = new RubyTitleBlockBuilder<TModel>();
            var result = nodeFunc.Invoke(nodeBuilder);
            _nodes.Add(result);

            return this;
        }

        /// <summary>
        /// Add a new builder for the nodes with a 'section' tag to the aside tree
        /// </summary>
        public virtual INodeBuilder<TModel> AddSectionBlock(Func<INodeBuilder<TModel>, INodeBuilder<TModel>> nodeFunc)
        {
            var nodeBuilder = new SectionBlockBuilder<TModel>();
            var result = nodeFunc.Invoke(nodeBuilder);
            _nodes.Add(result);

            return this;
        }

        /// <summary>
        /// Add a new builder for the nodes with a 'select' tag to the aside tree
        /// </summary>
        public virtual INodeBuilder<TModel> AddSelectBlock(Func<INodeBuilder<TModel>, INodeBuilder<TModel>> nodeFunc)
        {
            var nodeBuilder = new SelectBlockBuilder<TModel>();
            var result = nodeFunc.Invoke(nodeBuilder);
            _nodes.Add(result);

            return this;
        }

        /// <summary>
        /// Add a new builder for the nodes with a 'bdi' tag to the aside tree
        /// </summary>
        public virtual INodeBuilder<TModel> AddSeparateTextBlock(Func<INodeBuilder<TModel>, INodeBuilder<TModel>> nodeFunc)
        {
            var nodeBuilder = new SeparateTextBlockBuilder<TModel>();
            var result = nodeFunc.Invoke(nodeBuilder);
            _nodes.Add(result);

            return this;
        }

        /// <summary>
        /// Add a new builder for the nodes with a 'small' tag to the aside tree
        /// </summary>
        public virtual INodeBuilder<TModel> AddSmallTextBlock(Func<INodeBuilder<TModel>, INodeBuilder<TModel>> nodeFunc)
        {
            var nodeBuilder = new SmallTextBlockBuilder<TModel>();
            var result = nodeFunc.Invoke(nodeBuilder);
            _nodes.Add(result);

            return this;
        }

        /// <summary>
        /// Add a new builder for the nodes with a 'span' tag to the aside tree
        /// </summary>
        public virtual INodeBuilder<TModel> AddSpanBlock(Func<INodeBuilder<TModel>, INodeBuilder<TModel>> nodeFunc)
        {
            var nodeBuilder = new SpanBlockBuilder<TModel>();
            var result = nodeFunc.Invoke(nodeBuilder);
            _nodes.Add(result);

            return this;
        }

        /// <summary>
        /// Add a new builder for the nodes with a 's' tag to the aside tree
        /// </summary>
        public virtual INodeBuilder<TModel> AddStrikeTextBlock(Func<INodeBuilder<TModel>, INodeBuilder<TModel>> nodeFunc)
        {
            var nodeBuilder = new StrikeTextBlockBuilder<TModel>();
            var result = nodeFunc.Invoke(nodeBuilder);
            _nodes.Add(result);

            return this;
        }

        /// <summary>
        /// Add a new builder for the nodes with a 'strong' tag to the aside tree
        /// </summary>
        public virtual INodeBuilder<TModel> AddStrongTextBlock(Func<INodeBuilder<TModel>, INodeBuilder<TModel>> nodeFunc)
        {
            var nodeBuilder = new StrongTextBlockBuilder<TModel>();
            var result = nodeFunc.Invoke(nodeBuilder);
            _nodes.Add(result);

            return this;
        }

        /// <summary>
        /// Add a new builder for the nodes with a 'sub' tag to the aside tree
        /// </summary>
        public virtual INodeBuilder<TModel> AddSubTextBlock(Func<INodeBuilder<TModel>, INodeBuilder<TModel>> nodeFunc)
        {
            var nodeBuilder = new SubTextBlockBuilder<TModel>();
            var result = nodeFunc.Invoke(nodeBuilder);
            _nodes.Add(result);

            return this;
        }

        /// <summary>
        /// Add a new builder for the nodes with a 'summary' tag to the aside tree
        /// </summary>
        public virtual INodeBuilder<TModel> AddSummaryBlock(Func<INodeBuilder<TModel>, INodeBuilder<TModel>> nodeFunc)
        {
            var nodeBuilder = new SummaryBlockBuilder<TModel>();
            var result = nodeFunc.Invoke(nodeBuilder);
            _nodes.Add(result);

            return this;
        }

        /// <summary>
        /// Add a new builder for the nodes with a 'sup' tag to the aside tree
        /// </summary>
        public virtual INodeBuilder<TModel> AddSupTextBlock(Func<INodeBuilder<TModel>, INodeBuilder<TModel>> nodeFunc)
        {
            var nodeBuilder = new SupTextBlockBuilder<TModel>();
            var result = nodeFunc.Invoke(nodeBuilder);
            _nodes.Add(result);

            return this;
        }

        /// <summary>
        /// Add a new builder for the nodes with a 'table' tag to the aside tree
        /// </summary>
        public virtual INodeBuilder<TModel> AddTableBlock(Func<INodeBuilder<TModel>, INodeBuilder<TModel>> nodeFunc)
        {
            var nodeBuilder = new TableBlockBuilder<TModel>();
            var result = nodeFunc.Invoke(nodeBuilder);
            _nodes.Add(result);

            return this;
        }

        /// <summary>
        /// Add a new builder for the nodes with a 'tbody' tag to the aside tree
        /// </summary>
        public virtual INodeBuilder<TModel> AddTableBodyBlock(Func<INodeBuilder<TModel>, INodeBuilder<TModel>> nodeFunc)
        {
            var nodeBuilder = new TableBodyBlockBuilder<TModel>();
            var result = nodeFunc.Invoke(nodeBuilder);
            _nodes.Add(result);

            return this;
        }

        /// <summary>
        /// Add a new builder for the nodes with a 'td' tag to the aside tree
        /// </summary>
        public virtual INodeBuilder<TModel> AddTableDataBlock(Func<INodeBuilder<TModel>, INodeBuilder<TModel>> nodeFunc)
        {
            var nodeBuilder = new TableDataBlockBuilder<TModel>();
            var result = nodeFunc.Invoke(nodeBuilder);
            _nodes.Add(result);

            return this;
        }

        /// <summary>
        /// Add a new builder for the nodes with a 'tfoot' tag to the aside tree
        /// </summary>
        public virtual INodeBuilder<TModel> AddTableFootBlock(Func<INodeBuilder<TModel>, INodeBuilder<TModel>> nodeFunc)
        {
            var nodeBuilder = new TableFootBlockBuilder<TModel>();
            var result = nodeFunc.Invoke(nodeBuilder);
            _nodes.Add(result);

            return this;
        }

        /// <summary>
        /// Add a new builder for the nodes with a 'thead' tag to the aside tree
        /// </summary>
        public virtual INodeBuilder<TModel> AddTableHeaderBlock(Func<INodeBuilder<TModel>, INodeBuilder<TModel>> nodeFunc)
        {
            var nodeBuilder = new TableHeaderBlockBuilder<TModel>();
            var result = nodeFunc.Invoke(nodeBuilder);
            _nodes.Add(result);

            return this;
        }

        /// <summary>
        /// Add a new builder for the nodes with a 'th' tag to the aside tree
        /// </summary>
        public virtual INodeBuilder<TModel> AddTableHeaderDataBlock(Func<INodeBuilder<TModel>, INodeBuilder<TModel>> nodeFunc)
        {
            var nodeBuilder = new TableHeaderDataBlockBuilder<TModel>();
            var result = nodeFunc.Invoke(nodeBuilder);
            _nodes.Add(result);

            return this;
        }

        /// <summary>
        /// Add a new builder for the nodes with a 'tr' tag to the aside tree
        /// </summary>
        public virtual INodeBuilder<TModel> AddTableRowBlock(Func<INodeBuilder<TModel>, INodeBuilder<TModel>> nodeFunc)
        {
            var nodeBuilder = new TableRowBlockBuilder<TModel>();
            var result = nodeFunc.Invoke(nodeBuilder);
            _nodes.Add(result);

            return this;
        }

        /// <summary>
        /// Add a new builder for the nodes with a 'tt' tag to the aside tree
        /// </summary>
        public virtual INodeBuilder<TModel> AddTeletypeTextBlock(Func<INodeBuilder<TModel>, INodeBuilder<TModel>> nodeFunc)
        {
            var nodeBuilder = new TeletypeTextBlockBuilder<TModel>();
            var result = nodeFunc.Invoke(nodeBuilder);
            _nodes.Add(result);

            return this;
        }

        /// <summary>
        /// Add a new builder for the nodes with a 'textarea' tag to the aside tree
        /// </summary>
        public virtual INodeBuilder<TModel> AddTextAreaBlock(Func<INodeBuilder<TModel>, INodeBuilder<TModel>> nodeFunc)
        {
            var nodeBuilder = new TextAreaBlockBuilder<TModel>();
            var result = nodeFunc.Invoke(nodeBuilder);
            _nodes.Add(result);

            return this;
        }

        /// <summary>
        /// Add a new builder for the nodes with a 'bdo' tag to the aside tree
        /// </summary>
        public virtual INodeBuilder<TModel> AddTextDirectionBlock(Func<INodeBuilder<TModel>, INodeBuilder<TModel>> nodeFunc)
        {
            var nodeBuilder = new TextDirectionBlockBuilder<TModel>();
            var result = nodeFunc.Invoke(nodeBuilder);
            _nodes.Add(result);

            return this;
        }

        /// <summary>
        /// Add a new builder for the nodes with a 'u' tag to the aside tree
        /// </summary>
        public virtual INodeBuilder<TModel> AddUnderlineTextBlock(Func<INodeBuilder<TModel>, INodeBuilder<TModel>> nodeFunc)
        {
            var nodeBuilder = new UnderlineTextBlockBuilder<TModel>();
            var result = nodeFunc.Invoke(nodeBuilder);
            _nodes.Add(result);

            return this;
        }

        /// <summary>
        /// Add a new builder for the nodes with a 'ul' tag to the aside tree
        /// </summary>
        public virtual INodeBuilder<TModel> AddUnorderedListBlock(Func<INodeBuilder<TModel>, INodeBuilder<TModel>> nodeFunc)
        {
            var nodeBuilder = new UnorderedListBlockBuilder<TModel>();
            var result = nodeFunc.Invoke(nodeBuilder);
            _nodes.Add(result);

            return this;
        }

        /// <summary>
        /// Add a new builder for the nodes with a 'var' tag to the aside tree
        /// </summary>
        public virtual INodeBuilder<TModel> AddVariableTextBlock(Func<INodeBuilder<TModel>, INodeBuilder<TModel>> nodeFunc)
        {
            var nodeBuilder = new VariableTextBlockBuilder<TModel>();
            var result = nodeFunc.Invoke(nodeBuilder);
            _nodes.Add(result);

            return this;
        }

        /// <summary>
        /// Add a new builder for the nodes with a 'video' tag to the aside tree
        /// </summary>
        public virtual INodeBuilder<TModel> AddVideoBlock(Func<INodeBuilder<TModel>, INodeBuilder<TModel>> nodeFunc)
        {
            var nodeBuilder = new VideoBlockBuilder<TModel>();
            var result = nodeFunc.Invoke(nodeBuilder);
            _nodes.Add(result);

            return this;
        }

        #endregion With Parameters

        #endregion Add Blocks

        public virtual INode<TModel> GetResult()
        {
            foreach (var node in _nodes)
            {
                _node.SubNodes.Add(node.GetResult());
            }
            return _node;
        }

        public virtual INodeBuilder<TModel> WithAttribute(string name, string value)
        {
            _node.Attributes.Add(name, value);
            return this;
        }

        public virtual INodeBuilder<TModel> WithInnerText(string text)
        {
            _node.InnerText = text;
            return this;
        }

        public virtual INodeBuilder<TModel> WithProperty(Expression<Func<TModel, object>> property)
        {
            _node.Property = property;
            return this;
        }

        public virtual INodeBuilder<TModel> WithProperty(string attributeName, Expression<Func<TModel, object>> property)
        {
            _node.AttributeOfProperty = attributeName;
            _node.Property = property;
            return this;
        }

        #endregion Public Methods
    }
}