// DO NOT EDIT: Autogenerated file created on 2024-03-28 11:03:53 PM. 
using System;
using System.Linq;
using System.Collections.Generic;
using Ara3D.Parakeet.Grammars;

namespace Ara3D.Parakeet.Cst.MustacheGrammarNameSpace
{
    public class CstNodeFactory : INodeFactory
    {
        public static MustacheGrammar StaticGrammar = MustacheGrammar.Instance;
        public IGrammar Grammar { get; } = StaticGrammar;
        public CstNode Create(ParserTreeNode node)
        {
            switch (node.Type)
            {
                case "Block": return new CstBlock(node, node.Children.Select(Create).ToArray());
                case "Comment": return new CstComment(node, node.Children.Select(Create).ToArray());
                case "Content": return new CstContent(node, node.Children.Select(Create).ToArray());
                case "Document": return new CstDocument(node, node.Children.Select(Create).ToArray());
                case "EndSection": return new CstEndSection(node, node.Children.Select(Create).ToArray());
                case "Identifier": return new CstIdentifier(node, node.Contents);
                case "InvertedSection": return new CstInvertedSection(node, node.Children.Select(Create).ToArray());
                case "Key": return new CstKey(node, node.Contents);
                case "Partial": return new CstPartial(node, node.Children.Select(Create).ToArray());
                case "PlainText": return new CstPlainText(node, node.Contents);
                case "RestOfLine": return new CstRestOfLine(node, node.Contents);
                case "Section": return new CstSection(node, node.Children.Select(Create).ToArray());
                case "StartInvertedSection": return new CstStartInvertedSection(node, node.Children.Select(Create).ToArray());
                case "StartSection": return new CstStartSection(node, node.Children.Select(Create).ToArray());
                case "UnescapedVariable": return new CstUnescapedVariable(node, node.Children.Select(Create).ToArray());
                case "Variable": return new CstVariable(node, node.Children.Select(Create).ToArray());
                default: throw new Exception($"Unrecognized parse node {node.Type}");
            }
        }
    }
}
