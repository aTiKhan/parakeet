// DO NOT EDIT: Autogenerated file created on 2024-03-11 1:16:54 PM. 
using System;
using System.Linq;
using System.Collections.Generic;
using Ara3D.Parakeet.Grammars;

namespace Ara3D.Parakeet.Cst.EmailGrammarNameSpace
{
    public class CstNodeFactory : INodeFactory
    {
        public static EmailGrammar StaticGrammar = EmailGrammar.Instance;
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
                case "Address": return new CstAddress(node.Children.Select(Create).ToArray());
                case "AddressList": return new CstAddressList(node.Children.Select(Create).ToArray());
                case "AddrSpec": return new CstAddrSpec(node.Children.Select(Create).ToArray());
                case "AngleAddr": return new CstAngleAddr(node.Children.Select(Create).ToArray());
                case "Atom": return new CstAtom(node.Children.Select(Create).ToArray());
                case "CContent": return new CstCContent(node.Children.Select(Create).ToArray());
                case "CFWS": return new CstCFWS(node.Children.Select(Create).ToArray());
                case "Comment": return new CstComment(node.Children.Select(Create).ToArray());
                case "CText": return new CstCText(node.Contents);
                case "DisplayName": return new CstDisplayName(node.Children.Select(Create).ToArray());
                case "Domain": return new CstDomain(node.Children.Select(Create).ToArray());
                case "DomainLiteral": return new CstDomainLiteral(node.Children.Select(Create).ToArray());
                case "DotAtom": return new CstDotAtom(node.Children.Select(Create).ToArray());
                case "DotAtomText": return new CstDotAtomText(node.Contents);
                case "DText": return new CstDText(node.Contents);
                case "Group": return new CstGroup(node.Children.Select(Create).ToArray());
                case "GroupList": return new CstGroupList(node.Children.Select(Create).ToArray());
                case "Identifier": return new CstIdentifier(node.Contents);
                case "LocalPart": return new CstLocalPart(node.Children.Select(Create).ToArray());
                case "Mailbox": return new CstMailbox(node.Children.Select(Create).ToArray());
                case "MailboxList": return new CstMailboxList(node.Children.Select(Create).ToArray());
                case "NameAddr": return new CstNameAddr(node.Children.Select(Create).ToArray());
                case "Phrase": return new CstPhrase(node.Children.Select(Create).ToArray());
                case "QContent": return new CstQContent(node.Children.Select(Create).ToArray());
                case "QuotedPair": return new CstQuotedPair(node.Contents);
                case "QuotedString": return new CstQuotedString(node.Children.Select(Create).ToArray());
                case "Unstructured": return new CstUnstructured(node.Contents);
                case "Word": return new CstWord(node.Children.Select(Create).ToArray());
                default: throw new Exception($"Unrecognized parse node {node.Type}");
            }
        }
    }
}
