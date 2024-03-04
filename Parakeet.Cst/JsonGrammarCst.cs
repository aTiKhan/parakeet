// DO NOT EDIT: Autogenerated file created on 2024-03-03 10:34:02 PM. 

namespace Ara3D.Parakeet.Cst.JsonGrammarNameSpace
{
    /// <summary>
    /// Rule = Array ::= (('['+_RECOVER_+WS+(Elements)?+WS+']')+WS)
    /// Nodes = 
    /// </summary>
    public class CstArray : CstNodeLeaf
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.Array;
        public CstArray(string text) : base(text) { }
        // No children
    }

    /// <summary>
    /// Rule = Constant ::= ((("false"|"true"|"null")+!(IdentifierChar))+WS)
    /// Nodes = 
    /// </summary>
    public class CstConstant : CstNodeLeaf
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.Constant;
        public CstConstant(string text) : base(text) { }
        // No children
    }

    /// <summary>
    /// Rule = Identifier ::= ((IdentifierFirstChar+(IdentifierChar)*)+WS)
    /// Nodes = 
    /// </summary>
    public class CstIdentifier : CstNodeLeaf
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.Identifier;
        public CstIdentifier(string text) : base(text) { }
        // No children
    }

    /// <summary>
    /// Rule = Json ::= ((WS+Value+WS)+WS)
    /// Nodes = 
    /// </summary>
    public class CstJson : CstNodeLeaf
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.Json;
        public CstJson(string text) : base(text) { }
        // No children
    }

    /// <summary>
    /// Rule = Member ::= ((String+_RECOVER_+WS+':'+WS+Value)+WS)
    /// Nodes = String
    /// </summary>
    public class CstMember : CstNode
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.Member;
        public CstMember(params CstNode[] children) : base(children) { }
        public CstNodeFilter<CstString> String => new CstNodeFilter<CstString> (Children);
    }

    /// <summary>
    /// Rule = Number ::= ((Integer+(Fraction)?+(Exponent)?)+WS)
    /// Nodes = 
    /// </summary>
    public class CstNumber : CstNodeLeaf
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.Number;
        public CstNumber(string text) : base(text) { }
        // No children
    }

    /// <summary>
    /// Rule = Object ::= (('{'+_RECOVER_+WS+(Members)?+'}')+WS)
    /// Nodes = (Member)*
    /// </summary>
    public class CstObject : CstNodeLeaf
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.Object;
        public CstObject(string text) : base(text) { }
        public CstNodeFilter<CstMember> Member => new CstNodeFilter<CstMember> (Children);
    }

    /// <summary>
    /// Rule = String ::= (('"'+_RECOVER_+(StringChar)*+'"')+WS)
    /// Nodes = 
    /// </summary>
    public class CstString : CstNodeLeaf
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.String;
        public CstString(string text) : base(text) { }
        // No children
    }

}
