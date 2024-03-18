// DO NOT EDIT: Autogenerated file created on 2024-03-17 11:14:14 AM. 
using System;
using System.Linq;
using System.Collections.Generic;
using Ara3D.Parakeet.Grammars;

namespace Ara3D.Parakeet.Cst.XmlGrammarNameSpace
{
    public class CstNodeFactory : INodeFactory
    {
        public static XmlGrammar StaticGrammar = XmlGrammar.Instance;
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
                case "Attr": return new CstAttr(node.Children.Select(Create).ToArray());
                case "AttrList": return new CstAttrList(node.Children.Select(Create).ToArray());
                case "AttrValue": return new CstAttrValue(node.Children.Select(Create).ToArray());
                case "CData": return new CstCData(node.Contents);
                case "CDSect": return new CstCDSect(node.Children.Select(Create).ToArray());
                case "Content": return new CstContent(node.Children.Select(Create).ToArray());
                case "Document": return new CstDocument(node.Children.Select(Create).ToArray());
                case "DTD": return new CstDTD(node.Children.Select(Create).ToArray());
                case "DTDInternalSubset": return new CstDTDInternalSubset(node.Contents);
                case "Element": return new CstElement(node.Children.Select(Create).ToArray());
                case "EmptyElementTag": return new CstEmptyElementTag(node.Children.Select(Create).ToArray());
                case "EndTag": return new CstEndTag(node.Children.Select(Create).ToArray());
                case "Entity": return new CstEntity(node.Children.Select(Create).ToArray());
                case "HexEntityValue": return new CstHexEntityValue(node.Contents);
                case "Identifier": return new CstIdentifier(node.Contents);
                case "Misc": return new CstMisc(node.Children.Select(Create).ToArray());
                case "Name": return new CstName(node.Contents);
                case "NonEmptyElement": return new CstNonEmptyElement(node.Children.Select(Create).ToArray());
                case "NSIdent": return new CstNSIdent(node.Children.Select(Create).ToArray());
                case "NumericEntityValue": return new CstNumericEntityValue(node.Contents);
                case "PI": return new CstPI(node.Contents);
                case "Prolog": return new CstProlog(node.Children.Select(Create).ToArray());
                case "StartTag": return new CstStartTag(node.Children.Select(Create).ToArray());
                case "Tag": return new CstTag(node.Children.Select(Create).ToArray());
                case "Text": return new CstText(node.Contents);
                case "XmlDecl": return new CstXmlDecl(node.Children.Select(Create).ToArray());
                default: throw new Exception($"Unrecognized parse node {node.Type}");
            }
        }
    }
}
