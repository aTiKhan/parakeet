// DO NOT EDIT: Autogenerated file created on 2024-03-11 1:16:58 PM. 
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
                case "Abstraction": return new CstAbstraction(node.Children.Select(Create).ToArray());
                case "Application": return new CstApplication(node.Children.Select(Create).ToArray());
                case "Identifier": return new CstIdentifier(node.Contents);
                case "InnerTerm": return new CstInnerTerm(node.Children.Select(Create).ToArray());
                case "Parameter": return new CstParameter(node.Children.Select(Create).ToArray());
                case "Term": return new CstTerm(node.Children.Select(Create).ToArray());
                case "Variable": return new CstVariable(node.Children.Select(Create).ToArray());
                default: throw new Exception($"Unrecognized parse node {node.Type}");
            }
        }
    }
}
