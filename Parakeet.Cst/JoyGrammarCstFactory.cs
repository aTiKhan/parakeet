// DO NOT EDIT: Autogenerated file created on 2024-03-28 11:03:53 PM. 
using System;
using System.Linq;
using System.Collections.Generic;
using Ara3D.Parakeet.Grammars;

namespace Ara3D.Parakeet.Cst.JoyGrammarNameSpace
{
    public class CstNodeFactory : INodeFactory
    {
        public static JoyGrammar StaticGrammar = JoyGrammar.Instance;
        public IGrammar Grammar { get; } = StaticGrammar;
        public CstNode Create(ParserTreeNode node)
        {
            switch (node.Type)
            {
                case "Def": return new CstDef(node, node.Children.Select(Create).ToArray());
                case "Expr": return new CstExpr(node, node.Children.Select(Create).ToArray());
                case "Identifier": return new CstIdentifier(node, node.Contents);
                case "Literal": return new CstLiteral(node, node.Contents);
                case "Operator": return new CstOperator(node, node.Contents);
                case "Quotation": return new CstQuotation(node, node.Children.Select(Create).ToArray());
                default: throw new Exception($"Unrecognized parse node {node.Type}");
            }
        }
    }
}
