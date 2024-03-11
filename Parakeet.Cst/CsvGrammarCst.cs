// DO NOT EDIT: Autogenerated file created on 2024-03-11 1:16:54 PM. 
using System;
using System.Linq;

namespace Ara3D.Parakeet.Cst.CsvGrammarNameSpace
{
    /// <summary>This interface exists to make it easy to auto-generate type switches</summary>
    public interface ICsvCstNode { }

    /// <summary>
    /// Rule = Field ::= ((Text|String)+(Spaces)?)
    /// Nodes = (Text|String)
    /// </summary>
    public class CstField : CstNodeChoice, ICsvCstNode
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.Field;
        public CstField(params CstNode[] children) : base(children) { }
        public CstNodeFilter<CstText> Text => new CstNodeFilter<CstText> (Children);
        public CstNodeFilter<CstString> String => new CstNodeFilter<CstString> (Children);
    }

    /// <summary>
    /// Rule = File ::= ((Row)*+(Spaces)?)
    /// Nodes = (Row)*
    /// </summary>
    public class CstFile : CstNode, ICsvCstNode
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.File;
        public CstFile(params CstNode[] children) : base(children) { }
        public CstNodeFilter<CstRow> Row => new CstNodeFilter<CstRow> (Children);
    }

    /// <summary>
    /// Rule = Identifier ::= ((IdentifierFirstChar+(IdentifierChar)*)+(Spaces)?)
    /// Nodes = 
    /// </summary>
    public class CstIdentifier : CstNodeLeaf, ICsvCstNode
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.Identifier;
        public CstIdentifier(string text) : base(text) { }
        // No children
    }

    /// <summary>
    /// Rule = Row ::= (((Field)*+('\r')?+'\n')+(Spaces)?)
    /// Nodes = (Field)*
    /// </summary>
    public class CstRow : CstNode, ICsvCstNode
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.Row;
        public CstRow(params CstNode[] children) : base(children) { }
        public CstNodeFilter<CstField> Field => new CstNodeFilter<CstField> (Children);
    }

    /// <summary>
    /// Rule = String ::= (('"'+(Spaces)?+_UNKNOWN_+(StringChar)*+(Spaces)?+'"'+(Spaces)?)+(Spaces)?)
    /// Nodes = 
    /// </summary>
    public class CstString : CstNodeLeaf, ICsvCstNode
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.String;
        public CstString(string text) : base(text) { }
        // No children
    }

    /// <summary>
    /// Rule = Text ::= (((!("\x2C\x0A\x0D\x22")+AnyChar))++(Spaces)?)
    /// Nodes = 
    /// </summary>
    public class CstText : CstNodeLeaf, ICsvCstNode
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.Text;
        public CstText(string text) : base(text) { }
        // No children
    }

}
