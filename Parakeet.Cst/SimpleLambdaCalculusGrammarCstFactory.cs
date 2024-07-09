// DO NOT EDIT: Autogenerated file created on 2024-06-29 2:12:48 AM. 
using System;
using System.Linq;
using System.Collections.Generic;
using Ara3D.Parakeet.Grammars;

namespace Ara3D.Parakeet.Cst.SimpleLambdaCalculusGrammarNameSpace
{
    public class CstNodeFactory : INodeFactory
    {
        public static SimpleLambdaCalculusGrammar StaticGrammar = SimpleLambdaCalculusGrammar.Instance;
        public IGrammar Grammar { get; } = StaticGrammar;
        public CstNode Create(ParserTreeNode node)
        {
            switch (node.Type)
            {
                case "Abstraction": return new CstAbstraction(node, node.Children.Select(Create).ToArray());
                case "Application": return new CstApplication(node, node.Children.Select(Create).ToArray());
                case "Identifier": return new CstIdentifier(node, node.Contents);
                case "InnerTerm": return new CstInnerTerm(node, node.Children.Select(Create).ToArray());
                case "Parameter": return new CstParameter(node, node.Children.Select(Create).ToArray());
                case "Term": return new CstTerm(node, node.Children.Select(Create).ToArray());
                case "Variable": return new CstVariable(node, node.Children.Select(Create).ToArray());
                default: throw new Exception($"Unrecognized parse node {node.Type}");
            }
        }
    }
}
