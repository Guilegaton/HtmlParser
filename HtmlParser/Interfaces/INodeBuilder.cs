using System;
using System.Linq.Expressions;

namespace HtmlParser.Interfaces
{
    public interface INodeBuilder<TModel> where TModel : class, new()
    {
        #region Public Methods

        #region Add Block

        #region Without Parameters

        /// <summary>
        /// Add a new builder for the nodes with a 'abbr' tag to the subnodes tree
        /// </summary>
        INodeBuilder<TModel> AddAbbreviationBlock();

        /// <summary>
        /// Add a new builder for the nodes with a 'acronym' tag to the subnodes tree
        /// </summary>
        INodeBuilder<TModel> AddAcronymBlock();

        /// <summary>
        /// Add a new builder for the nodes with a 'address' tag to the subnodes tree
        /// </summary>
        INodeBuilder<TModel> AddAddressBlock();

        /// <summary>
        /// Add a new builder for the nodes with a 'applet' tag to the subnodes tree
        /// </summary>
        INodeBuilder<TModel> AddAppletBlock();

        /// <summary>
        /// Add a new builder for the nodes with a 'area' tag to the subnodes tree
        /// </summary>
        INodeBuilder<TModel> AddAreaBlock();

        /// <summary>
        /// Add a new builder for the nodes with a 'article' tag to the subnodes tree
        /// </summary>
        INodeBuilder<TModel> AddArticleBlock();

        /// <summary>
        /// Add a new builder for the nodes with a 'aside' tag to the aside tree
        /// </summary>
        INodeBuilder<TModel> AddAsideBlock();

        /// <summary>
        /// Add a new builder for the nodes with a 'audio' tag to the aside tree
        /// </summary>
        INodeBuilder<TModel> AddAudioBlock();

        /// <summary>
        /// Add a new builder for the nodes with a 'body' tag to the aside tree
        /// </summary>
        INodeBuilder<TModel> AddBodyBlock();

        /// <summary>
        /// Add a new builder for the nodes with a 'b' tag to the aside tree
        /// </summary>
        INodeBuilder<TModel> AddBoldTextBlock();

        /// <summary>
        /// Add a new builder for the nodes with a 'button' tag to the aside tree
        /// </summary>
        INodeBuilder<TModel> AddButtonBlock();

        /// <summary>
        /// Add a new builder for the nodes with a 'canvas' tag to the aside tree
        /// </summary>
        INodeBuilder<TModel> AddCanvasBlock();

        /// <summary>
        /// Add a new builder for the nodes with a 'caption' tag to the aside tree
        /// </summary>
        INodeBuilder<TModel> AddCaptionBlock();

        /// <summary>
        /// Add a new builder for the nodes with a 'center' tag to the aside tree
        /// </summary>
        INodeBuilder<TModel> AddCentredTextBlock();

        /// <summary>
        /// Add a new builder for the nodes with a 'cite' tag to the aside tree
        /// </summary>
        INodeBuilder<TModel> AddCiteTextBlock();

        /// <summary>
        /// Add a new builder for the nodes with a 'code' tag to the aside tree
        /// </summary>
        INodeBuilder<TModel> AddCodeTextBlock();

        /// <summary>
        /// Add a new builder for the nodes with a 'comment' tag to the aside tree
        /// </summary>
        INodeBuilder<TModel> AddCommentBlock();

        /// <summary>
        /// Add a new builder for the nodes with a 'div' tag to the subnodes tree
        /// </summary>
        INodeBuilder<TModel> AddContainerBlock();

        /// <summary>
        /// Add a new builder for the nodes with a custom tag to the subnodes tree
        /// </summary>
        INodeBuilder<TModel> AddCustomBlock(string blockName, Func<INodeBuilder<TModel>, INodeBuilder<TModel>> node);

        /// <summary>
        /// Add a new builder for the nodes with a 'datalist' tag to the aside tree
        /// </summary>
        INodeBuilder<TModel> AddDatalistBlock();

        /// <summary>
        /// Add a new builder for the nodes with a 'details' tag to the aside tree
        /// </summary>
        INodeBuilder<TModel> AddDetailsBlock();

        /// <summary>
        /// Add a new builder for the nodes with a 'dir' tag to the aside tree
        /// </summary>
        INodeBuilder<TModel> AddDirectoryBlock();

        /// <summary>
        /// Add a new builder for the nodes with a 'footer' tag to the aside tree
        /// </summary>
        INodeBuilder<TModel> AddFooterBlock();

        /// <summary>
        /// Add a new builder for the nodes with a 'form' tag to the aside tree
        /// </summary>
        INodeBuilder<TModel> AddFormBlock();

        /// <summary>
        /// Add a new builder for the nodes with a 'frame' tag to the aside tree
        /// </summary>
        INodeBuilder<TModel> AddFrameBlock();

        /// <summary>
        /// Add a new builder for the nodes with a 'frameset' tag to the aside tree
        /// </summary>
        INodeBuilder<TModel> AddFrameSetBlock();

        /// <summary>
        /// Add a new builder for the nodes with a 'h1' tag to the aside tree
        /// </summary>
        INodeBuilder<TModel> AddH1TextBlock();

        /// <summary>
        /// Add a new builder for the nodes with a 'h2' tag to the aside tree
        /// </summary>
        INodeBuilder<TModel> AddH2TextBlock();

        /// <summary>
        /// Add a new builder for the nodes with a 'h3' tag to the aside tree
        /// </summary>
        INodeBuilder<TModel> AddH3TextBlock();

        /// <summary>
        /// Add a new builder for the nodes with a 'h4' tag to the aside tree
        /// </summary>
        INodeBuilder<TModel> AddH4TextBlock();

        /// <summary>
        /// Add a new builder for the nodes with a 'h5' tag to the aside tree
        /// </summary>
        INodeBuilder<TModel> AddH5TextBlock();

        /// <summary>
        /// Add a new builder for the nodes with a 'h6' tag to the aside tree
        /// </summary>
        INodeBuilder<TModel> AddH6TextBlock();

        /// <summary>
        /// Add a new builder for the nodes with a 'hr' tag to the aside tree
        /// </summary>
        INodeBuilder<TModel> AddHorizontalLineBlock();

        /// <summary>
        /// Add a new builder for the nodes with a 'iframe' tag to the aside tree
        /// </summary>
        INodeBuilder<TModel> AddIframeBlock();

        /// <summary>
        /// Add a new builder for the nodes with a 'img' tag to the aside tree
        /// </summary>
        INodeBuilder<TModel> AddImageBlock();

        /// <summary>
        /// Add a new builder for the nodes with a 'input' tag to the aside tree
        /// </summary>
        INodeBuilder<TModel> AddInputBlock();

        /// <summary>
        /// Add a new builder for the nodes with a 'i' tag to the aside tree
        /// </summary>
        INodeBuilder<TModel> AddItalicTextBlock();

        /// <summary>
        /// Add a new builder for the nodes with a 'label' tag to the aside tree
        /// </summary>
        INodeBuilder<TModel> AddLabelBlock();

        /// <summary>
        /// Add a new builder for the nodes with a 'a' tag to the subnodes tree
        /// </summary>
        INodeBuilder<TModel> AddLinkBlock();

        /// <summary>
        /// Add a new builder for the nodes with a 'li' tag to the aside tree
        /// </summary>
        INodeBuilder<TModel> AddListItemBlock();

        /// <summary>
        /// Add a new builder for the nodes with a 'main' tag to the aside tree
        /// </summary>
        INodeBuilder<TModel> AddMainBlock();

        /// <summary>
        /// Add a new builder for the nodes with a 'map' tag to the aside tree
        /// </summary>
        INodeBuilder<TModel> AddMapBlock();

        /// <summary>
        /// Add a new builder for the nodes with a 'marquee' tag to the aside tree
        /// </summary>
        INodeBuilder<TModel> AddMarqueeBlock();

        /// <summary>
        /// Add a new builder for the nodes with a 'menu' tag to the aside tree
        /// </summary>
        INodeBuilder<TModel> AddMenuBlock();

        /// <summary>
        /// Add a new builder for the nodes with a 'nav' tag to the aside tree
        /// </summary>
        INodeBuilder<TModel> AddNavigationBlock();

        /// <summary>
        /// Add a new builder for the nodes with a 'ol' tag to the aside tree
        /// </summary>
        INodeBuilder<TModel> AddNumeratedListBlock();

        /// <summary>
        /// Add a new builder for the nodes with a 'option' tag to the aside tree
        /// </summary>
        INodeBuilder<TModel> AddOptionElementBlock();

        /// <summary>
        /// Add a new builder for the nodes with a 'optgroup' tag to the aside tree
        /// </summary>
        INodeBuilder<TModel> AddOptionsGroupBlock();

        /// <summary>
        /// Add a new builder for the nodes with a 'p' tag to the subnodes tree
        /// </summary>
        INodeBuilder<TModel> AddParagraphBlock();

        /// <summary>
        /// Add a new builder for the nodes with a 'param' tag to the aside tree
        /// </summary>
        INodeBuilder<TModel> AddParamBlock();

        /// <summary>
        /// Add a new builder for the nodes with a 'plaintext' tag to the aside tree
        /// </summary>
        INodeBuilder<TModel> AddPlainTextBlock();

        /// <summary>
        /// Add a new builder for the nodes with a 'q' tag to the aside tree
        /// </summary>
        INodeBuilder<TModel> AddQuoteBlock();

        /// <summary>
        /// Add a new builder for the nodes with a 'ruby' tag to the aside tree
        /// </summary>
        INodeBuilder<TModel> AddRubyBlock();

        /// <summary>
        /// Add a new builder for the nodes with a 'rt' tag to the aside tree
        /// </summary>
        INodeBuilder<TModel> AddRubyTitleBlock();

        /// <summary>
        /// Add a new builder for the nodes with a 'section' tag to the aside tree
        /// </summary>
        INodeBuilder<TModel> AddSectionBlock();

        /// <summary>
        /// Add a new builder for the nodes with a 'select' tag to the aside tree
        /// </summary>
        INodeBuilder<TModel> AddSelectBlock();

        /// <summary>
        /// Add a new builder for the nodes with a 'bdi' tag to the aside tree
        /// </summary>
        INodeBuilder<TModel> AddSeparateTextBlock();

        /// <summary>
        /// Add a new builder for the nodes with a 'small' tag to the aside tree
        /// </summary>
        INodeBuilder<TModel> AddSmallTextBlock();

        /// <summary>
        /// Add a new builder for the nodes with a 'span' tag to the aside tree
        /// </summary>
        INodeBuilder<TModel> AddSpanBlock();

        /// <summary>
        /// Add a new builder for the nodes with a 's' tag to the aside tree
        /// </summary>
        INodeBuilder<TModel> AddStrikeTextBlock();

        /// <summary>
        /// Add a new builder for the nodes with a 'strong' tag to the aside tree
        /// </summary>
        INodeBuilder<TModel> AddStrongTextBlock();

        /// <summary>
        /// Add a new builder for the nodes with a 'sub' tag to the aside tree
        /// </summary>
        INodeBuilder<TModel> AddSubTextBlock();

        /// <summary>
        /// Add a new builder for the nodes with a 'summary' tag to the aside tree
        /// </summary>
        INodeBuilder<TModel> AddSummaryBlock();

        /// <summary>
        /// Add a new builder for the nodes with a 'sup' tag to the aside tree
        /// </summary>
        INodeBuilder<TModel> AddSupTextBlock();

        /// <summary>
        /// Add a new builder for the nodes with a 'table' tag to the aside tree
        /// </summary>
        INodeBuilder<TModel> AddTableBlock();

        /// <summary>
        /// Add a new builder for the nodes with a 'tbody' tag to the aside tree
        /// </summary>
        INodeBuilder<TModel> AddTableBodyBlock();

        /// <summary>
        /// Add a new builder for the nodes with a 'td' tag to the aside tree
        /// </summary>
        INodeBuilder<TModel> AddTableDataBlock();

        /// <summary>
        /// Add a new builder for the nodes with a 'tfoot' tag to the aside tree
        /// </summary>
        INodeBuilder<TModel> AddTableFootBlock();

        /// <summary>
        /// Add a new builder for the nodes with a 'thead' tag to the aside tree
        /// </summary>
        INodeBuilder<TModel> AddTableHeaderBlock();

        /// <summary>
        /// Add a new builder for the nodes with a 'th' tag to the aside tree
        /// </summary>
        INodeBuilder<TModel> AddTableHeaderDataBlock();

        /// <summary>
        /// Add a new builder for the nodes with a 'tr' tag to the aside tree
        /// </summary>
        INodeBuilder<TModel> AddTableRowBlock();

        /// <summary>
        /// Add a new builder for the nodes with a 'tt' tag to the aside tree
        /// </summary>
        INodeBuilder<TModel> AddTeletypeTextBlock();

        /// <summary>
        /// Add a new builder for the nodes with a 'textarea' tag to the aside tree
        /// </summary>
        INodeBuilder<TModel> AddTextAreaBlock();

        /// <summary>
        /// Add a new builder for the nodes with a 'bdo' tag to the aside tree
        /// </summary>
        INodeBuilder<TModel> AddTextDirectionBlock();

        /// <summary>
        /// Add a new builder for the nodes with a 'u' tag to the aside tree
        /// </summary>
        INodeBuilder<TModel> AddUnderlineTextBlock();

        /// <summary>
        /// Add a new builder for the nodes with a 'ul' tag to the aside tree
        /// </summary>
        INodeBuilder<TModel> AddUnorderedListBlock();

        /// <summary>
        /// Add a new builder for the nodes with a 'var' tag to the aside tree
        /// </summary>
        INodeBuilder<TModel> AddVariableTextBlock();

        /// <summary>
        /// Add a new builder for the nodes with a 'video' tag to the aside tree
        /// </summary>
        INodeBuilder<TModel> AddVideoBlock();

        #endregion Without Parameters

        #region With Parameters

        /// <summary>
        /// Add a new builder for the nodes with a 'abbr' tag to the subnodes tree
        /// </summary>
        INodeBuilder<TModel> AddAbbreviationBlock(Func<INodeBuilder<TModel>, INodeBuilder<TModel>> nodeFunc);

        /// <summary>
        /// Add a new builder for the nodes with a 'acronym' tag to the subnodes tree
        /// </summary>
        INodeBuilder<TModel> AddAcronymBlock(Func<INodeBuilder<TModel>, INodeBuilder<TModel>> nodeFunc);

        /// <summary>
        /// Add a new builder for the nodes with a 'address' tag to the subnodes tree
        /// </summary>
        INodeBuilder<TModel> AddAddressBlock(Func<INodeBuilder<TModel>, INodeBuilder<TModel>> nodeFunc);

        /// <summary>
        /// Add a new builder for the nodes with a 'applet' tag to the subnodes tree
        /// </summary>
        INodeBuilder<TModel> AddAppletBlock(Func<INodeBuilder<TModel>, INodeBuilder<TModel>> nodeFunc);

        /// <summary>
        /// Add a new builder for the nodes with a 'area' tag to the subnodes tree
        /// </summary>
        INodeBuilder<TModel> AddAreaBlock(Func<INodeBuilder<TModel>, INodeBuilder<TModel>> nodeFunc);

        /// <summary>
        /// Add a new builder for the nodes with a 'article' tag to the subnodes tree
        /// </summary>
        INodeBuilder<TModel> AddArticleBlock(Func<INodeBuilder<TModel>, INodeBuilder<TModel>> nodeFunc);

        /// <summary>
        /// Add a new builder for the nodes with a 'aside' tag to the aside tree
        /// </summary>
        INodeBuilder<TModel> AddAsideBlock(Func<INodeBuilder<TModel>, INodeBuilder<TModel>> nodeFunc);

        /// <summary>
        /// Add a new builder for the nodes with a 'audio' tag to the aside tree
        /// </summary>
        INodeBuilder<TModel> AddAudioBlock(Func<INodeBuilder<TModel>, INodeBuilder<TModel>> nodeFunc);

        /// <summary>
        /// Add a new builder for the nodes with a 'body' tag to the aside tree
        /// </summary>
        INodeBuilder<TModel> AddBodyBlock(Func<INodeBuilder<TModel>, INodeBuilder<TModel>> nodeFunc);

        /// <summary>
        /// Add a new builder for the nodes with a 'b' tag to the aside tree
        /// </summary>
        INodeBuilder<TModel> AddBoldTextBlock(Func<INodeBuilder<TModel>, INodeBuilder<TModel>> nodeFunc);

        /// <summary>
        /// Add a new builder for the nodes with a 'button' tag to the aside tree
        /// </summary>
        INodeBuilder<TModel> AddButtonBlock(Func<INodeBuilder<TModel>, INodeBuilder<TModel>> nodeFunc);

        /// <summary>
        /// Add a new builder for the nodes with a 'canvas' tag to the aside tree
        /// </summary>
        INodeBuilder<TModel> AddCanvasBlock(Func<INodeBuilder<TModel>, INodeBuilder<TModel>> nodeFunc);

        /// <summary>
        /// Add a new builder for the nodes with a 'caption' tag to the aside tree
        /// </summary>
        INodeBuilder<TModel> AddCaptionBlock(Func<INodeBuilder<TModel>, INodeBuilder<TModel>> nodeFunc);

        /// <summary>
        /// Add a new builder for the nodes with a 'center' tag to the aside tree
        /// </summary>
        INodeBuilder<TModel> AddCentredTextBlock(Func<INodeBuilder<TModel>, INodeBuilder<TModel>> nodeFunc);

        /// <summary>
        /// Add a new builder for the nodes with a 'cite' tag to the aside tree
        /// </summary>
        INodeBuilder<TModel> AddCiteTextBlock(Func<INodeBuilder<TModel>, INodeBuilder<TModel>> nodeFunc);

        /// <summary>
        /// Add a new builder for the nodes with a 'code' tag to the aside tree
        /// </summary>
        INodeBuilder<TModel> AddCodeTextBlock(Func<INodeBuilder<TModel>, INodeBuilder<TModel>> nodeFunc);

        /// <summary>
        /// Add a new builder for the nodes with a 'comment' tag to the aside tree
        /// </summary>
        INodeBuilder<TModel> AddCommentBlock(Func<INodeBuilder<TModel>, INodeBuilder<TModel>> nodeFunc);

        /// <summary>
        /// Add a new builder for the nodes with a 'div' tag to the subnodes tree
        /// </summary>
        INodeBuilder<TModel> AddContainerBlock(Func<INodeBuilder<TModel>, INodeBuilder<TModel>> nodeFunc);

        /// <summary>
        /// Add a new builder for the nodes with a 'datalist' tag to the aside tree
        /// </summary>
        INodeBuilder<TModel> AddDatalistBlock(Func<INodeBuilder<TModel>, INodeBuilder<TModel>> nodeFunc);

        /// <summary>
        /// Add a new builder for the nodes with a 'details' tag to the aside tree
        /// </summary>
        INodeBuilder<TModel> AddDetailsBlock(Func<INodeBuilder<TModel>, INodeBuilder<TModel>> nodeFunc);

        /// <summary>
        /// Add a new builder for the nodes with a 'dir' tag to the aside tree
        /// </summary>
        INodeBuilder<TModel> AddDirectoryBlock(Func<INodeBuilder<TModel>, INodeBuilder<TModel>> nodeFunc);

        /// <summary>
        /// Add a new builder for the nodes with a 'footer' tag to the aside tree
        /// </summary>
        INodeBuilder<TModel> AddFooterBlock(Func<INodeBuilder<TModel>, INodeBuilder<TModel>> nodeFunc);

        /// <summary>
        /// Add a new builder for the nodes with a 'form' tag to the aside tree
        /// </summary>
        INodeBuilder<TModel> AddFormBlock(Func<INodeBuilder<TModel>, INodeBuilder<TModel>> nodeFunc);

        /// <summary>
        /// Add a new builder for the nodes with a 'frame' tag to the aside tree
        /// </summary>
        INodeBuilder<TModel> AddFrameBlock(Func<INodeBuilder<TModel>, INodeBuilder<TModel>> nodeFunc);

        /// <summary>
        /// Add a new builder for the nodes with a 'frameset' tag to the aside tree
        /// </summary>
        INodeBuilder<TModel> AddFrameSetBlock(Func<INodeBuilder<TModel>, INodeBuilder<TModel>> nodeFunc);

        /// <summary>
        /// Add a new builder for the nodes with a 'h1' tag to the aside tree
        /// </summary>
        INodeBuilder<TModel> AddH1TextBlock(Func<INodeBuilder<TModel>, INodeBuilder<TModel>> nodeFunc);

        /// <summary>
        /// Add a new builder for the nodes with a 'h2' tag to the aside tree
        /// </summary>
        INodeBuilder<TModel> AddH2TextBlock(Func<INodeBuilder<TModel>, INodeBuilder<TModel>> nodeFunc);

        /// <summary>
        /// Add a new builder for the nodes with a 'h3' tag to the aside tree
        /// </summary>
        INodeBuilder<TModel> AddH3TextBlock(Func<INodeBuilder<TModel>, INodeBuilder<TModel>> nodeFunc);

        /// <summary>
        /// Add a new builder for the nodes with a 'h4' tag to the aside tree
        /// </summary>
        INodeBuilder<TModel> AddH4TextBlock(Func<INodeBuilder<TModel>, INodeBuilder<TModel>> nodeFunc);

        /// <summary>
        /// Add a new builder for the nodes with a 'h5' tag to the aside tree
        /// </summary>
        INodeBuilder<TModel> AddH5TextBlock(Func<INodeBuilder<TModel>, INodeBuilder<TModel>> nodeFunc);

        /// <summary>
        /// Add a new builder for the nodes with a 'h6' tag to the aside tree
        /// </summary>
        INodeBuilder<TModel> AddH6TextBlock(Func<INodeBuilder<TModel>, INodeBuilder<TModel>> nodeFunc);

        /// <summary>
        /// Add a new builder for the nodes with a 'hr' tag to the aside tree
        /// </summary>
        INodeBuilder<TModel> AddHorizontalLineBlock(Func<INodeBuilder<TModel>, INodeBuilder<TModel>> nodeFunc);

        /// <summary>
        /// Add a new builder for the nodes with a 'iframe' tag to the aside tree
        /// </summary>
        INodeBuilder<TModel> AddIframeBlock(Func<INodeBuilder<TModel>, INodeBuilder<TModel>> nodeFunc);

        /// <summary>
        /// Add a new builder for the nodes with a 'img' tag to the aside tree
        /// </summary>
        INodeBuilder<TModel> AddImageBlock(Func<INodeBuilder<TModel>, INodeBuilder<TModel>> nodeFunc);

        /// <summary>
        /// Add a new builder for the nodes with a 'input' tag to the aside tree
        /// </summary>
        INodeBuilder<TModel> AddInputBlock(Func<INodeBuilder<TModel>, INodeBuilder<TModel>> nodeFunc);

        /// <summary>
        /// Add a new builder for the nodes with a 'i' tag to the aside tree
        /// </summary>
        INodeBuilder<TModel> AddItalicTextBlock(Func<INodeBuilder<TModel>, INodeBuilder<TModel>> nodeFunc);

        /// <summary>
        /// Add a new builder for the nodes with a 'label' tag to the aside tree
        /// </summary>
        INodeBuilder<TModel> AddLabelBlock(Func<INodeBuilder<TModel>, INodeBuilder<TModel>> nodeFunc);

        /// <summary>
        /// Add a new builder for the nodes with a 'a' tag to the subnodes tree
        /// </summary>
        INodeBuilder<TModel> AddLinkBlock(Func<INodeBuilder<TModel>, INodeBuilder<TModel>> nodeFunc);

        /// <summary>
        /// Add a new builder for the nodes with a 'li' tag to the aside tree
        /// </summary>
        INodeBuilder<TModel> AddListItemBlock(Func<INodeBuilder<TModel>, INodeBuilder<TModel>> nodeFunc);

        /// <summary>
        /// Add a new builder for the nodes with a 'main' tag to the aside tree
        /// </summary>
        INodeBuilder<TModel> AddMainBlock(Func<INodeBuilder<TModel>, INodeBuilder<TModel>> nodeFunc);

        /// <summary>
        /// Add a new builder for the nodes with a 'map' tag to the aside tree
        /// </summary>
        INodeBuilder<TModel> AddMapBlock(Func<INodeBuilder<TModel>, INodeBuilder<TModel>> nodeFunc);

        /// <summary>
        /// Add a new builder for the nodes with a 'marquee' tag to the aside tree
        /// </summary>
        INodeBuilder<TModel> AddMarqueeBlock(Func<INodeBuilder<TModel>, INodeBuilder<TModel>> nodeFunc);

        /// <summary>
        /// Add a new builder for the nodes with a 'menu' tag to the aside tree
        /// </summary>
        INodeBuilder<TModel> AddMenuBlock(Func<INodeBuilder<TModel>, INodeBuilder<TModel>> nodeFunc);

        /// <summary>
        /// Add a new builder for the nodes with a 'nav' tag to the aside tree
        /// </summary>
        INodeBuilder<TModel> AddNavigationBlock(Func<INodeBuilder<TModel>, INodeBuilder<TModel>> nodeFunc);

        /// <summary>
        /// Add a new builder for the nodes with a 'ol' tag to the aside tree
        /// </summary>
        INodeBuilder<TModel> AddNumeratedListBlock(Func<INodeBuilder<TModel>, INodeBuilder<TModel>> nodeFunc);

        /// <summary>
        /// Add a new builder for the nodes with a 'option' tag to the aside tree
        /// </summary>
        INodeBuilder<TModel> AddOptionElementBlock(Func<INodeBuilder<TModel>, INodeBuilder<TModel>> nodeFunc);

        /// <summary>
        /// Add a new builder for the nodes with a 'optgroup' tag to the aside tree
        /// </summary>
        INodeBuilder<TModel> AddOptionsGroupBlock(Func<INodeBuilder<TModel>, INodeBuilder<TModel>> nodeFunc);

        /// <summary>
        /// Add a new builder for the nodes with a 'p' tag to the subnodes tree
        /// </summary>
        INodeBuilder<TModel> AddParagraphBlock(Func<INodeBuilder<TModel>, INodeBuilder<TModel>> nodeFunc);

        /// <summary>
        /// Add a new builder for the nodes with a 'param' tag to the aside tree
        /// </summary>
        INodeBuilder<TModel> AddParamBlock(Func<INodeBuilder<TModel>, INodeBuilder<TModel>> nodeFunc);

        /// <summary>
        /// Add a new builder for the nodes with a 'plaintext' tag to the aside tree
        /// </summary>
        INodeBuilder<TModel> AddPlainTextBlock(Func<INodeBuilder<TModel>, INodeBuilder<TModel>> nodeFunc);

        /// <summary>
        /// Add a new builder for the nodes with a 'q' tag to the aside tree
        /// </summary>
        INodeBuilder<TModel> AddQuoteBlock(Func<INodeBuilder<TModel>, INodeBuilder<TModel>> nodeFunc);

        /// <summary>
        /// Add a new builder for the nodes with a 'ruby' tag to the aside tree
        /// </summary>
        INodeBuilder<TModel> AddRubyBlock(Func<INodeBuilder<TModel>, INodeBuilder<TModel>> nodeFunc);

        /// <summary>
        /// Add a new builder for the nodes with a 'rt' tag to the aside tree
        /// </summary>
        INodeBuilder<TModel> AddRubyTitleBlock(Func<INodeBuilder<TModel>, INodeBuilder<TModel>> nodeFunc);

        /// <summary>
        /// Add a new builder for the nodes with a 'section' tag to the aside tree
        /// </summary>
        INodeBuilder<TModel> AddSectionBlock(Func<INodeBuilder<TModel>, INodeBuilder<TModel>> nodeFunc);

        /// <summary>
        /// Add a new builder for the nodes with a 'select' tag to the aside tree
        /// </summary>
        INodeBuilder<TModel> AddSelectBlock(Func<INodeBuilder<TModel>, INodeBuilder<TModel>> nodeFunc);

        /// <summary>
        /// Add a new builder for the nodes with a 'bdi' tag to the aside tree
        /// </summary>
        INodeBuilder<TModel> AddSeparateTextBlock(Func<INodeBuilder<TModel>, INodeBuilder<TModel>> nodeFunc);

        /// <summary>
        /// Add a new builder for the nodes with a 'small' tag to the aside tree
        /// </summary>
        INodeBuilder<TModel> AddSmallTextBlock(Func<INodeBuilder<TModel>, INodeBuilder<TModel>> nodeFunc);

        /// <summary>
        /// Add a new builder for the nodes with a 'span' tag to the aside tree
        /// </summary>
        INodeBuilder<TModel> AddSpanBlock(Func<INodeBuilder<TModel>, INodeBuilder<TModel>> nodeFunc);

        /// <summary>
        /// Add a new builder for the nodes with a 's' tag to the aside tree
        /// </summary>
        INodeBuilder<TModel> AddStrikeTextBlock(Func<INodeBuilder<TModel>, INodeBuilder<TModel>> nodeFunc);

        /// <summary>
        /// Add a new builder for the nodes with a 'strong' tag to the aside tree
        /// </summary>
        INodeBuilder<TModel> AddStrongTextBlock(Func<INodeBuilder<TModel>, INodeBuilder<TModel>> nodeFunc);

        /// <summary>
        /// Add a new builder for the nodes with a 'sub' tag to the aside tree
        /// </summary>
        INodeBuilder<TModel> AddSubTextBlock(Func<INodeBuilder<TModel>, INodeBuilder<TModel>> nodeFunc);

        /// <summary>
        /// Add a new builder for the nodes with a 'summary' tag to the aside tree
        /// </summary>
        INodeBuilder<TModel> AddSummaryBlock(Func<INodeBuilder<TModel>, INodeBuilder<TModel>> nodeFunc);

        /// <summary>
        /// Add a new builder for the nodes with a 'sup' tag to the aside tree
        /// </summary>
        INodeBuilder<TModel> AddSupTextBlock(Func<INodeBuilder<TModel>, INodeBuilder<TModel>> nodeFunc);

        /// <summary>
        /// Add a new builder for the nodes with a 'table' tag to the aside tree
        /// </summary>
        INodeBuilder<TModel> AddTableBlock(Func<INodeBuilder<TModel>, INodeBuilder<TModel>> nodeFunc);

        /// <summary>
        /// Add a new builder for the nodes with a 'tbody' tag to the aside tree
        /// </summary>
        INodeBuilder<TModel> AddTableBodyBlock(Func<INodeBuilder<TModel>, INodeBuilder<TModel>> nodeFunc);

        /// <summary>
        /// Add a new builder for the nodes with a 'td' tag to the aside tree
        /// </summary>
        INodeBuilder<TModel> AddTableDataBlock(Func<INodeBuilder<TModel>, INodeBuilder<TModel>> nodeFunc);

        /// <summary>
        /// Add a new builder for the nodes with a 'tfoot' tag to the aside tree
        /// </summary>
        INodeBuilder<TModel> AddTableFootBlock(Func<INodeBuilder<TModel>, INodeBuilder<TModel>> nodeFunc);

        /// <summary>
        /// Add a new builder for the nodes with a 'thead' tag to the aside tree
        /// </summary>
        INodeBuilder<TModel> AddTableHeaderBlock(Func<INodeBuilder<TModel>, INodeBuilder<TModel>> nodeFunc);

        /// <summary>
        /// Add a new builder for the nodes with a 'th' tag to the aside tree
        /// </summary>
        INodeBuilder<TModel> AddTableHeaderDataBlock(Func<INodeBuilder<TModel>, INodeBuilder<TModel>> nodeFunc);

        /// <summary>
        /// Add a new builder for the nodes with a 'tr' tag to the aside tree
        /// </summary>
        INodeBuilder<TModel> AddTableRowBlock(Func<INodeBuilder<TModel>, INodeBuilder<TModel>> nodeFunc);

        /// <summary>
        /// Add a new builder for the nodes with a 'tt' tag to the aside tree
        /// </summary>
        INodeBuilder<TModel> AddTeletypeTextBlock(Func<INodeBuilder<TModel>, INodeBuilder<TModel>> nodeFunc);

        /// <summary>
        /// Add a new builder for the nodes with a 'textarea' tag to the aside tree
        /// </summary>
        INodeBuilder<TModel> AddTextAreaBlock(Func<INodeBuilder<TModel>, INodeBuilder<TModel>> nodeFunc);

        /// <summary>
        /// Add a new builder for the nodes with a 'bdo' tag to the aside tree
        /// </summary>
        INodeBuilder<TModel> AddTextDirectionBlock(Func<INodeBuilder<TModel>, INodeBuilder<TModel>> nodeFunc);

        /// <summary>
        /// Add a new builder for the nodes with a 'u' tag to the aside tree
        /// </summary>
        INodeBuilder<TModel> AddUnderlineTextBlock(Func<INodeBuilder<TModel>, INodeBuilder<TModel>> nodeFunc);

        /// <summary>
        /// Add a new builder for the nodes with a 'ul' tag to the aside tree
        /// </summary>
        INodeBuilder<TModel> AddUnorderedListBlock(Func<INodeBuilder<TModel>, INodeBuilder<TModel>> nodeFunc);

        /// <summary>
        /// Add a new builder for the nodes with a 'var' tag to the aside tree
        /// </summary>
        INodeBuilder<TModel> AddVariableTextBlock(Func<INodeBuilder<TModel>, INodeBuilder<TModel>> nodeFunc);

        /// <summary>
        /// Add a new builder for the nodes with a 'video' tag to the aside tree
        /// </summary>
        INodeBuilder<TModel> AddVideoBlock(Func<INodeBuilder<TModel>, INodeBuilder<TModel>> nodeFunc);

        #endregion With Parameters

        #endregion Add Block

        INode<TModel> GetResult();

        INodeBuilder<TModel> WithAttribute(string name, string value);

        INodeBuilder<TModel> WithInnerText(string text);

        INodeBuilder<TModel> WithProperty(Expression<Func<TModel, object>> property);

        #endregion Public Methods
    }
}