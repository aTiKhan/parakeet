// DO NOT EDIT: Autogenerated file created on 2024-06-29 2:12:43 AM. 
using System;
using System.Linq;

namespace Ara3D.Parakeet.Cst.CombinatorCalculusGrammarNameSpace
{
    /// <summary>This interface exists to make it easy to auto-generate type switches</summary>
    public interface ICombinatorCalculusCstNode { }

    /// <summary>
    /// Rule = Application ::= ((Term+Term)+(Spaces)?)
    /// Nodes = (Term+Term)
    /// </summary>
    public class CstApplication : CstNodeSequence, ICombinatorCalculusCstNode
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.Application;
        public CstApplication(ILocation location, params CstNode[] children) : base(location, children) { }
        public CstNodeFilter<CstTerm> Term => new CstNodeFilter<CstTerm> (Children);
    }

    /// <summary>
    /// Rule = Combinator ::= (Letter+(Spaces)?)
    /// Nodes = 
    /// </summary>
    public class CstCombinator : CstNodeLeaf, ICombinatorCalculusCstNode
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.Combinator;
        public CstCombinator(ILocation location, string text) : base(location, text) { }
    }

    /// <summary>
    /// Rule = Identifier ::= ((IdentifierFirstChar+(IdentifierChar)*)+(Spaces)?)
    /// Nodes = 
    /// </summary>
    public class CstIdentifier : CstNodeLeaf, ICombinatorCalculusCstNode
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.Identifier;
        public CstIdentifier(ILocation location, string text) : base(location, text) { }
    }

    /// <summary>
    /// Rule = Term ::= (('('+(Spaces)?+_UNKNOWN_+(Term|Application|Combinator)+(Spaces)?+')'+(Spaces)?)+(Spaces)?)
    /// Nodes = (Term|Application|Combinator)
    /// </summary>
    public class CstTerm : CstNodeChoice, ICombinatorCalculusCstNode
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.Term;
        public CstTerm(ILocation location, params CstNode[] children) : base(location, children) { }
        public CstNodeFilter<CstTerm> Term => new CstNodeFilter<CstTerm> (Children);
        public CstNodeFilter<CstApplication> Application => new CstNodeFilter<CstApplication> (Children);
        public CstNodeFilter<CstCombinator> Combinator => new CstNodeFilter<CstCombinator> (Children);
    }

}
