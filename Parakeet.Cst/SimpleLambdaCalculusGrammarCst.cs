// DO NOT EDIT: Autogenerated file created on 2024-03-03 10:34:03 PM. 

namespace Ara3D.Parakeet.Cst.SimpleLambdaCalculusGrammarNameSpace
{
    /// <summary>
    /// Rule = Abstraction ::= (('('+Parameter+'.'+Term+')')+(Spaces)?)
    /// Nodes = (Parameter+Term)
    /// </summary>
    public class CstAbstraction : CstNodeSequence
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.Abstraction;
        public CstAbstraction(params CstNode[] children) : base(children) { }
        public CstNodeFilter<CstParameter> Parameter => new CstNodeFilter<CstParameter> (Children);
        public CstNodeFilter<CstTerm> Term => new CstNodeFilter<CstTerm> (Children);
    }

    /// <summary>
    /// Rule = Application ::= (('('+Term+(Spaces)?+Term+')')+(Spaces)?)
    /// Nodes = (Term+Term)
    /// </summary>
    public class CstApplication : CstNodeSequence
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.Application;
        public CstApplication(params CstNode[] children) : base(children) { }
        public CstNodeFilter<CstTerm> Term => new CstNodeFilter<CstTerm> (Children);
    }

    /// <summary>
    /// Rule = Identifier ::= ((IdentifierFirstChar+(IdentifierChar)*)+(Spaces)?)
    /// Nodes = 
    /// </summary>
    public class CstIdentifier : CstNodeLeaf
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.Identifier;
        public CstIdentifier(string text) : base(text) { }
        // No children
    }

    /// <summary>
    /// Rule = InnerTerm ::= ((Variable|Abstraction|Application)+(Spaces)?)
    /// Nodes = (Variable|Abstraction|Application)
    /// </summary>
    public class CstInnerTerm : CstNodeChoice
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.InnerTerm;
        public CstInnerTerm(params CstNode[] children) : base(children) { }
        public CstNodeFilter<CstVariable> Variable => new CstNodeFilter<CstVariable> (Children);
        public CstNodeFilter<CstAbstraction> Abstraction => new CstNodeFilter<CstAbstraction> (Children);
        public CstNodeFilter<CstApplication> Application => new CstNodeFilter<CstApplication> (Children);
    }

    /// <summary>
    /// Rule = Parameter ::= (('\'+Variable)+(Spaces)?)
    /// Nodes = Variable
    /// </summary>
    public class CstParameter : CstNode
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.Parameter;
        public CstParameter(params CstNode[] children) : base(children) { }
        public CstNodeFilter<CstVariable> Variable => new CstNodeFilter<CstVariable> (Children);
    }

    /// <summary>
    /// Rule = Term ::= (InnerTerm+(Spaces)?)
    /// Nodes = InnerTerm
    /// </summary>
    public class CstTerm : CstNode
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.Term;
        public CstTerm(params CstNode[] children) : base(children) { }
        public CstNodeFilter<CstInnerTerm> InnerTerm => new CstNodeFilter<CstInnerTerm> (Children);
    }

    /// <summary>
    /// Rule = Variable ::= (Identifier+(Spaces)?)
    /// Nodes = Identifier
    /// </summary>
    public class CstVariable : CstNode
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.Variable;
        public CstVariable(params CstNode[] children) : base(children) { }
        public CstNodeFilter<CstIdentifier> Identifier => new CstNodeFilter<CstIdentifier> (Children);
    }

}
