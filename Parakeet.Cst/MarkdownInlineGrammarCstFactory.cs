// DO NOT EDIT: Autogenerated file created on 2024-03-11 1:16:55 PM. 
using System;
using System.Linq;
using System.Collections.Generic;
using Ara3D.Parakeet.Grammars;

namespace Ara3D.Parakeet.Cst.MarkdownInlineGrammarNameSpace
{
    public class CstNodeFactory : INodeFactory
    {
        public static MarkdownInlineGrammar StaticGrammar = MarkdownInlineGrammar.Instance;
        public IGrammar Grammar { get; } = StaticGrammar;
        public Dictionary<CstNode, ParserTreeNode> Lookup { get;} = new Dictionary<CstNode, ParserTreeNode>();
        public CstNode Create(ParserTreeNode node)
        {
            var r = InternalCreate(node);
            Lookup.Add(r, node);
            return r;
        }
        public CstNode InternalCreate(ParserTreeNode node)
        {
            switch (node.Type)
            {
                case "AltText": return new CstAltText(node.Contents);
                case "Bold": return new CstBold(node.Children.Select(Create).ToArray());
                case "BoldAndItalic": return new CstBoldAndItalic(node.Children.Select(Create).ToArray());
                case "Code": return new CstCode(node.Children.Select(Create).ToArray());
                case "Content": return new CstContent(node.Children.Select(Create).ToArray());
                case "Email": return new CstEmail(node.Contents);
                case "EmailLink": return new CstEmailLink(node.Children.Select(Create).ToArray());
                case "EscapedChar": return new CstEscapedChar(node.Contents);
                case "HtmlTag": return new CstHtmlTag(node.Contents);
                case "Identifier": return new CstIdentifier(node.Contents);
                case "Img": return new CstImg(node.Children.Select(Create).ToArray());
                case "InnerText": return new CstInnerText(node.Children.Select(Create).ToArray());
                case "Italic": return new CstItalic(node.Children.Select(Create).ToArray());
                case "Link": return new CstLink(node.Children.Select(Create).ToArray());
                case "PlainText": return new CstPlainText(node.Contents);
                case "PlainTextUrl": return new CstPlainTextUrl(node.Contents);
                case "Strikethrough": return new CstStrikethrough(node.Children.Select(Create).ToArray());
                case "Url": return new CstUrl(node.Contents);
                case "UrlLink": return new CstUrlLink(node.Children.Select(Create).ToArray());
                case "UrlTitle": return new CstUrlTitle(node.Contents);
                default: throw new Exception($"Unrecognized parse node {node.Type}");
            }
        }
    }
}
