// DO NOT EDIT: Autogenerated file created on 2024-06-29 2:12:45 AM. 
using System;
using System.Linq;

namespace Ara3D.Parakeet.Cst.JoyGrammarNameSpace
{
    /// <summary>This interface exists to make it easy to auto-generate type switches</summary>
    public interface IJoyCstNode { }

    /// <summary>
    /// Rule = Def ::= ((Symbol('DEFINE')+Operator+Symbol('==')+(Expr)*+'.')+(Spaces)?)
    /// Nodes = (Operator+(Expr)*)
    /// </summary>
    public class CstDef : CstNodeSequence, IJoyCstNode
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.Def;
        public CstDef(ILocation location, params CstNode[] children) : base(location, children) { }
        public CstNodeFilter<CstOperator> Operator => new CstNodeFilter<CstOperator> (Children);
        public CstNodeFilter<CstExpr> Expr => new CstNodeFilter<CstExpr> (Children);
    }

    /// <summary>
    /// Rule = Expr ::= ((Quotation|Literal|Operator|Identifier)+(Spaces)?)
    /// Nodes = (Quotation|Literal|Operator|Identifier)
    /// </summary>
    public class CstExpr : CstNodeChoice, IJoyCstNode
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.Expr;
        public CstExpr(ILocation location, params CstNode[] children) : base(location, children) { }
        public CstNodeFilter<CstQuotation> Quotation => new CstNodeFilter<CstQuotation> (Children);
        public CstNodeFilter<CstLiteral> Literal => new CstNodeFilter<CstLiteral> (Children);
        public CstNodeFilter<CstOperator> Operator => new CstNodeFilter<CstOperator> (Children);
        public CstNodeFilter<CstIdentifier> Identifier => new CstNodeFilter<CstIdentifier> (Children);
    }

    /// <summary>
    /// Rule = Identifier ::= ((IdentifierFirstChar+(IdentifierChar)*)+(Spaces)?)
    /// Nodes = 
    /// </summary>
    public class CstIdentifier : CstNodeLeaf, IJoyCstNode
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.Identifier;
        public CstIdentifier(ILocation location, string text) : base(location, text) { }
    }

    /// <summary>
    /// Rule = Literal ::= ((Float|Integer|DoubleQuoteBasicString)+(Spaces)?)
    /// Nodes = 
    /// </summary>
    public class CstLiteral : CstNodeLeaf, IJoyCstNode
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.Literal;
        public CstLiteral(ILocation location, string text) : base(location, text) { }
    }

    /// <summary>
    /// Rule = Operator ::= ((([\x21$-\x26\x2A+\x2D\x2F<->\x40^|~])*|Identifier)+(Spaces)?)
    /// Nodes = 
    /// </summary>
    public class CstOperator : CstNodeLeaf, IJoyCstNode
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.Operator;
        public CstOperator(ILocation location, string text) : base(location, text) { }
    }

    /// <summary>
    /// Rule = Quotation ::= ((Symbol('[')+(Expr)*+Symbol(']'))+(Spaces)?)
    /// Nodes = (Expr)*
    /// </summary>
    public class CstQuotation : CstNode, IJoyCstNode
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.Quotation;
        public CstQuotation(ILocation location, params CstNode[] children) : base(location, children) { }
        public CstNodeFilter<CstExpr> Expr => new CstNodeFilter<CstExpr> (Children);
    }

}
