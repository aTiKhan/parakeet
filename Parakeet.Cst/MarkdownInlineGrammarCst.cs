// DO NOT EDIT: Autogenerated file created on 2024-03-28 11:03:53 PM. 
using System;
using System.Linq;

namespace Ara3D.Parakeet.Cst.MarkdownInlineGrammarNameSpace
{
    /// <summary>This interface exists to make it easy to auto-generate type switches</summary>
    public interface IMarkdownInlineCstNode { }

    /// <summary>
    /// Rule = AltText ::= (('['+WS+_UNKNOWN_+((!(']')+AnyChar))*+WS+']'+WS)+WS)
    /// Nodes = 
    /// </summary>
    public class CstAltText : CstNodeLeaf, IMarkdownInlineCstNode
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.AltText;
        public CstAltText(ILocation location, string text) : base(location, text) { }
    }

    /// <summary>
    /// Rule = Bold ::= ((("\x2A\x2A"+((!("\x2A\x2A")+InnerText))*+"\x2A\x2A")|("\x5F\x5F"+((!("\x5F\x5F")+InnerText))*+"\x5F\x5F"))+WS)
    /// Nodes = (InnerText)*
    /// </summary>
    public class CstBold : CstNode, IMarkdownInlineCstNode
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.Bold;
        public CstBold(ILocation location, params CstNode[] children) : base(location, children) { }
        public CstNodeFilter<CstInnerText> InnerText => new CstNodeFilter<CstInnerText> (Children);
    }

    /// <summary>
    /// Rule = BoldAndItalic ::= ((("\x2A\x2A\x2A"+((!("\x2A\x2A\x2A")+InnerText))*+"\x2A\x2A\x2A")|("\x5F\x5F\x5F"+((!("\x5F\x5F\x5F")+InnerText))*+"\x5F\x5F\x5F"))+WS)
    /// Nodes = (InnerText)*
    /// </summary>
    public class CstBoldAndItalic : CstNode, IMarkdownInlineCstNode
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.BoldAndItalic;
        public CstBoldAndItalic(ILocation location, params CstNode[] children) : base(location, children) { }
        public CstNodeFilter<CstInnerText> InnerText => new CstNodeFilter<CstInnerText> (Children);
    }

    /// <summary>
    /// Rule = Code ::= (('`'+((!('`')+InnerText))*+'`')+WS)
    /// Nodes = (InnerText)*
    /// </summary>
    public class CstCode : CstNode, IMarkdownInlineCstNode
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.Code;
        public CstCode(ILocation location, params CstNode[] children) : base(location, children) { }
        public CstNodeFilter<CstInnerText> InnerText => new CstNodeFilter<CstInnerText> (Children);
    }

    /// <summary>
    /// Rule = Content ::= ((InnerText)*+WS)
    /// Nodes = (InnerText)*
    /// </summary>
    public class CstContent : CstNode, IMarkdownInlineCstNode
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.Content;
        public CstContent(ILocation location, params CstNode[] children) : base(location, children) { }
        public CstNodeFilter<CstInnerText> InnerText => new CstNodeFilter<CstInnerText> (Children);
    }

    /// <summary>
    /// Rule = Email ::= (((EmailChar)*+'@'+(EmailChar)*)+WS)
    /// Nodes = 
    /// </summary>
    public class CstEmail : CstNodeLeaf, IMarkdownInlineCstNode
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.Email;
        public CstEmail(ILocation location, string text) : base(location, text) { }
    }

    /// <summary>
    /// Rule = EmailLink ::= (('<'+Email+'>')+WS)
    /// Nodes = Email
    /// </summary>
    public class CstEmailLink : CstNode, IMarkdownInlineCstNode
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.EmailLink;
        public CstEmailLink(ILocation location, params CstNode[] children) : base(location, children) { }
        public CstNodeFilter<CstEmail> Email => new CstNodeFilter<CstEmail> (Children);
    }

    /// <summary>
    /// Rule = EscapedChar ::= (('\'+[\x21\x23\x28-+\x2D\x2E<>\x5B-\x5D`\x7B-\x7D])+WS)
    /// Nodes = 
    /// </summary>
    public class CstEscapedChar : CstNodeLeaf, IMarkdownInlineCstNode
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.EscapedChar;
        public CstEscapedChar(ILocation location, string text) : base(location, text) { }
    }

    /// <summary>
    /// Rule = HtmlTag ::= (('<'+_RECOVER_+((!('>')+AnyChar))*+'>')+WS)
    /// Nodes = 
    /// </summary>
    public class CstHtmlTag : CstNodeLeaf, IMarkdownInlineCstNode
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.HtmlTag;
        public CstHtmlTag(ILocation location, string text) : base(location, text) { }
    }

    /// <summary>
    /// Rule = Identifier ::= ((IdentifierFirstChar+(IdentifierChar)*)+WS)
    /// Nodes = 
    /// </summary>
    public class CstIdentifier : CstNodeLeaf, IMarkdownInlineCstNode
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.Identifier;
        public CstIdentifier(ILocation location, string text) : base(location, text) { }
    }

    /// <summary>
    /// Rule = Img ::= (('!'+AltText+'('+WS+_UNKNOWN_+Url+WS+(UrlTitle)?+WS+')'+WS)+WS)
    /// Nodes = (AltText+Url+(UrlTitle)?)
    /// </summary>
    public class CstImg : CstNodeSequence, IMarkdownInlineCstNode
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.Img;
        public CstImg(ILocation location, params CstNode[] children) : base(location, children) { }
        public CstNodeFilter<CstAltText> AltText => new CstNodeFilter<CstAltText> (Children);
        public CstNodeFilter<CstUrl> Url => new CstNodeFilter<CstUrl> (Children);
        public CstNodeFilter<CstUrlTitle> UrlTitle => new CstNodeFilter<CstUrlTitle> (Children);
    }

    /// <summary>
    /// Rule = InnerText ::= ((BoldAndItalic|Strikethrough|Bold|Italic|Code|Link|Img|EmailLink|UrlLink|HtmlTag|EscapedChar|PlainText|AnyChar)+WS)
    /// Nodes = (BoldAndItalic|Strikethrough|Bold|Italic|Code|Link|Img|EmailLink|UrlLink|HtmlTag|EscapedChar|PlainText)
    /// </summary>
    public class CstInnerText : CstNodeChoice, IMarkdownInlineCstNode
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.InnerText;
        public CstInnerText(ILocation location, params CstNode[] children) : base(location, children) { }
        public CstNodeFilter<CstBoldAndItalic> BoldAndItalic => new CstNodeFilter<CstBoldAndItalic> (Children);
        public CstNodeFilter<CstStrikethrough> Strikethrough => new CstNodeFilter<CstStrikethrough> (Children);
        public CstNodeFilter<CstBold> Bold => new CstNodeFilter<CstBold> (Children);
        public CstNodeFilter<CstItalic> Italic => new CstNodeFilter<CstItalic> (Children);
        public CstNodeFilter<CstCode> Code => new CstNodeFilter<CstCode> (Children);
        public CstNodeFilter<CstLink> Link => new CstNodeFilter<CstLink> (Children);
        public CstNodeFilter<CstImg> Img => new CstNodeFilter<CstImg> (Children);
        public CstNodeFilter<CstEmailLink> EmailLink => new CstNodeFilter<CstEmailLink> (Children);
        public CstNodeFilter<CstUrlLink> UrlLink => new CstNodeFilter<CstUrlLink> (Children);
        public CstNodeFilter<CstHtmlTag> HtmlTag => new CstNodeFilter<CstHtmlTag> (Children);
        public CstNodeFilter<CstEscapedChar> EscapedChar => new CstNodeFilter<CstEscapedChar> (Children);
        public CstNodeFilter<CstPlainText> PlainText => new CstNodeFilter<CstPlainText> (Children);
    }

    /// <summary>
    /// Rule = Italic ::= ((('*'+((!('*')+InnerText))*+'*')|('_'+((!('_')+InnerText))*+'_'))+WS)
    /// Nodes = (InnerText)*
    /// </summary>
    public class CstItalic : CstNode, IMarkdownInlineCstNode
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.Italic;
        public CstItalic(ILocation location, params CstNode[] children) : base(location, children) { }
        public CstNodeFilter<CstInnerText> InnerText => new CstNodeFilter<CstInnerText> (Children);
    }

    /// <summary>
    /// Rule = Link ::= (('['+LinkedText+']'+WS+'('+WS+_UNKNOWN_+Url+WS+(UrlTitle)?+WS+')'+WS)+WS)
    /// Nodes = (LinkedText+Url+(UrlTitle)?)
    /// </summary>
    public class CstLink : CstNodeSequence, IMarkdownInlineCstNode
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.Link;
        public CstLink(ILocation location, params CstNode[] children) : base(location, children) { }
        public CstNodeFilter<CstLinkedText> LinkedText => new CstNodeFilter<CstLinkedText> (Children);
        public CstNodeFilter<CstUrl> Url => new CstNodeFilter<CstUrl> (Children);
        public CstNodeFilter<CstUrlTitle> UrlTitle => new CstNodeFilter<CstUrlTitle> (Children);
    }

    /// <summary>
    /// Rule = LinkedText ::= (((!(']')+InnerText))*+WS)
    /// Nodes = (InnerText)*
    /// </summary>
    public class CstLinkedText : CstNode, IMarkdownInlineCstNode
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.LinkedText;
        public CstLinkedText(ILocation location, params CstNode[] children) : base(location, children) { }
        public CstNodeFilter<CstInnerText> InnerText => new CstNodeFilter<CstInnerText> (Children);
    }

    /// <summary>
    /// Rule = PlainText ::= (((!([\x21\x2A<>\x5B-\x5D\x5F`~])+AnyChar))++WS)
    /// Nodes = 
    /// </summary>
    public class CstPlainText : CstNodeLeaf, IMarkdownInlineCstNode
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.PlainText;
        public CstPlainText(ILocation location, string text) : base(location, text) { }
    }

    /// <summary>
    /// Rule = PlainTextUrl ::= (("http\x3A\x2F\x2F"+(UrlChar)*)+WS)
    /// Nodes = 
    /// </summary>
    public class CstPlainTextUrl : CstNodeLeaf, IMarkdownInlineCstNode
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.PlainTextUrl;
        public CstPlainTextUrl(ILocation location, string text) : base(location, text) { }
    }

    /// <summary>
    /// Rule = Strikethrough ::= (("~~"+((!("~~")+InnerText))*+"~~")+WS)
    /// Nodes = (InnerText)*
    /// </summary>
    public class CstStrikethrough : CstNode, IMarkdownInlineCstNode
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.Strikethrough;
        public CstStrikethrough(ILocation location, params CstNode[] children) : base(location, children) { }
        public CstNodeFilter<CstInnerText> InnerText => new CstNodeFilter<CstInnerText> (Children);
    }

    /// <summary>
    /// Rule = Url ::= ((UrlChar)*+WS)
    /// Nodes = 
    /// </summary>
    public class CstUrl : CstNodeLeaf, IMarkdownInlineCstNode
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.Url;
        public CstUrl(ILocation location, string text) : base(location, text) { }
    }

    /// <summary>
    /// Rule = UrlLink ::= ((('<'+Url+'>')|PlainTextUrl)+WS)
    /// Nodes = (Url|PlainTextUrl)
    /// </summary>
    public class CstUrlLink : CstNodeChoice, IMarkdownInlineCstNode
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.UrlLink;
        public CstUrlLink(ILocation location, params CstNode[] children) : base(location, children) { }
        public CstNodeFilter<CstUrl> Url => new CstNodeFilter<CstUrl> (Children);
        public CstNodeFilter<CstPlainTextUrl> PlainTextUrl => new CstNodeFilter<CstPlainTextUrl> (Children);
    }

    /// <summary>
    /// Rule = UrlTitle ::= (DoubleQuoteBasicString+WS)
    /// Nodes = 
    /// </summary>
    public class CstUrlTitle : CstNodeLeaf, IMarkdownInlineCstNode
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.UrlTitle;
        public CstUrlTitle(ILocation location, string text) : base(location, text) { }
    }

}
