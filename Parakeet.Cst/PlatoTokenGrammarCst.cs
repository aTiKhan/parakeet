// DO NOT EDIT: Autogenerated file created on 2024-03-17 11:14:14 AM. 
using System;
using System.Linq;

namespace Ara3D.Parakeet.Cst.PlatoTokenGrammarNameSpace
{
    /// <summary>This interface exists to make it easy to auto-generate type switches</summary>
    public interface IPlatoTokenCstNode { }

    /// <summary>
    /// Rule = BinaryLiteral ::= (("0b"|("0B"+(BinDigit)++(IntegerSuffix)?))+_UNKNOWN_)
    /// Nodes = 
    /// </summary>
    public class CstBinaryLiteral : CstNodeLeaf, IPlatoTokenCstNode
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.BinaryLiteral;
        public CstBinaryLiteral(string text) : base(text) { }
        // No children
    }

    /// <summary>
    /// Rule = BinaryOperator ::= ((Symbol('>>>=')|Symbol('and')|Symbol('>>=')|Symbol('<<=')|Symbol('&&=')|Symbol('||=')|Symbol('or')|Symbol('<<')|Symbol('&&')|Symbol('||')|Symbol('+=')|Symbol('-=')|Symbol('*=')|Symbol('/=')|Symbol('%=')|Symbol('&=')|Symbol('|=')|Symbol('^=')|Symbol('<=')|Symbol('>=')|Symbol('==')|Symbol('!=')|Symbol('+')|Symbol('-')|Symbol('*')|Symbol('/')|Symbol('%')|Symbol('&')|Symbol('|')|Symbol('^')|Symbol('=')|Symbol('<')|Symbol('>'))+_UNKNOWN_)
    /// Nodes = 
    /// </summary>
    public class CstBinaryOperator : CstNodeLeaf, IPlatoTokenCstNode
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.BinaryOperator;
        public CstBinaryOperator(string text) : base(text) { }
        // No children
    }

    /// <summary>
    /// Rule = BooleanLiteral ::= ((Keyword('true')|Keyword('false'))+_UNKNOWN_)
    /// Nodes = 
    /// </summary>
    public class CstBooleanLiteral : CstNodeLeaf, IPlatoTokenCstNode
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.BooleanLiteral;
        public CstBooleanLiteral(string text) : base(text) { }
        // No children
    }

    /// <summary>
    /// Rule = BracedTokenGroup ::= (('{'+_UNKNOWN_+_UNKNOWN_+Token+_UNKNOWN_+'}'+_UNKNOWN_)+_UNKNOWN_)
    /// Nodes = ((TypeKeyword+(Comment)*+TypeName+(Comment)*)|((Comment)*+((FieldName+(Comment)*+TypeName+(Comment)*+((TypeParametersToken+(Comment)*))?+(Comment)*)|(FunctionName+(Comment)*+(((Comment)*+TypeName+(Comment)*+((TypeParametersToken+(Comment)*))?))?)))|Separator|Delimiter|Comment|Operator|Identifier|HexLiteral|BinaryLiteral|FloatLiteral|IntegerLiteral|StringLiteral|CharLiteral|BooleanLiteral|NullLiteral|Unknown)
    /// </summary>
    public class CstBracedTokenGroup : CstNodeChoice, IPlatoTokenCstNode
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.BracedTokenGroup;
        public CstBracedTokenGroup(string text) : base(text) { }
        public CstNodeFilter<CstTypeKeyword> TypeKeyword => new CstNodeFilter<CstTypeKeyword> (Children);
        public CstNodeFilter<CstComment> Comment => new CstNodeFilter<CstComment> (Children);
        public CstNodeFilter<CstTypeName> TypeName => new CstNodeFilter<CstTypeName> (Children);
        public CstNodeFilter<CstFieldName> FieldName => new CstNodeFilter<CstFieldName> (Children);
        public CstNodeFilter<CstTypeParametersToken> TypeParametersToken => new CstNodeFilter<CstTypeParametersToken> (Children);
        public CstNodeFilter<CstFunctionName> FunctionName => new CstNodeFilter<CstFunctionName> (Children);
        public CstNodeFilter<CstSeparator> Separator => new CstNodeFilter<CstSeparator> (Children);
        public CstNodeFilter<CstDelimiter> Delimiter => new CstNodeFilter<CstDelimiter> (Children);
        public CstNodeFilter<CstOperator> Operator => new CstNodeFilter<CstOperator> (Children);
        public CstNodeFilter<CstIdentifier> Identifier => new CstNodeFilter<CstIdentifier> (Children);
        public CstNodeFilter<CstHexLiteral> HexLiteral => new CstNodeFilter<CstHexLiteral> (Children);
        public CstNodeFilter<CstBinaryLiteral> BinaryLiteral => new CstNodeFilter<CstBinaryLiteral> (Children);
        public CstNodeFilter<CstFloatLiteral> FloatLiteral => new CstNodeFilter<CstFloatLiteral> (Children);
        public CstNodeFilter<CstIntegerLiteral> IntegerLiteral => new CstNodeFilter<CstIntegerLiteral> (Children);
        public CstNodeFilter<CstStringLiteral> StringLiteral => new CstNodeFilter<CstStringLiteral> (Children);
        public CstNodeFilter<CstCharLiteral> CharLiteral => new CstNodeFilter<CstCharLiteral> (Children);
        public CstNodeFilter<CstBooleanLiteral> BooleanLiteral => new CstNodeFilter<CstBooleanLiteral> (Children);
        public CstNodeFilter<CstNullLiteral> NullLiteral => new CstNodeFilter<CstNullLiteral> (Children);
        public CstNodeFilter<CstUnknown> Unknown => new CstNodeFilter<CstUnknown> (Children);
    }

    /// <summary>
    /// Rule = BracketedTokenGroup ::= (('['+_UNKNOWN_+_UNKNOWN_+Token+_UNKNOWN_+']'+_UNKNOWN_)+_UNKNOWN_)
    /// Nodes = ((TypeKeyword+(Comment)*+TypeName+(Comment)*)|((Comment)*+((FieldName+(Comment)*+TypeName+(Comment)*+((TypeParametersToken+(Comment)*))?+(Comment)*)|(FunctionName+(Comment)*+(((Comment)*+TypeName+(Comment)*+((TypeParametersToken+(Comment)*))?))?)))|Separator|Delimiter|Comment|Operator|Identifier|HexLiteral|BinaryLiteral|FloatLiteral|IntegerLiteral|StringLiteral|CharLiteral|BooleanLiteral|NullLiteral|Unknown)
    /// </summary>
    public class CstBracketedTokenGroup : CstNodeChoice, IPlatoTokenCstNode
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.BracketedTokenGroup;
        public CstBracketedTokenGroup(string text) : base(text) { }
        public CstNodeFilter<CstTypeKeyword> TypeKeyword => new CstNodeFilter<CstTypeKeyword> (Children);
        public CstNodeFilter<CstComment> Comment => new CstNodeFilter<CstComment> (Children);
        public CstNodeFilter<CstTypeName> TypeName => new CstNodeFilter<CstTypeName> (Children);
        public CstNodeFilter<CstFieldName> FieldName => new CstNodeFilter<CstFieldName> (Children);
        public CstNodeFilter<CstTypeParametersToken> TypeParametersToken => new CstNodeFilter<CstTypeParametersToken> (Children);
        public CstNodeFilter<CstFunctionName> FunctionName => new CstNodeFilter<CstFunctionName> (Children);
        public CstNodeFilter<CstSeparator> Separator => new CstNodeFilter<CstSeparator> (Children);
        public CstNodeFilter<CstDelimiter> Delimiter => new CstNodeFilter<CstDelimiter> (Children);
        public CstNodeFilter<CstOperator> Operator => new CstNodeFilter<CstOperator> (Children);
        public CstNodeFilter<CstIdentifier> Identifier => new CstNodeFilter<CstIdentifier> (Children);
        public CstNodeFilter<CstHexLiteral> HexLiteral => new CstNodeFilter<CstHexLiteral> (Children);
        public CstNodeFilter<CstBinaryLiteral> BinaryLiteral => new CstNodeFilter<CstBinaryLiteral> (Children);
        public CstNodeFilter<CstFloatLiteral> FloatLiteral => new CstNodeFilter<CstFloatLiteral> (Children);
        public CstNodeFilter<CstIntegerLiteral> IntegerLiteral => new CstNodeFilter<CstIntegerLiteral> (Children);
        public CstNodeFilter<CstStringLiteral> StringLiteral => new CstNodeFilter<CstStringLiteral> (Children);
        public CstNodeFilter<CstCharLiteral> CharLiteral => new CstNodeFilter<CstCharLiteral> (Children);
        public CstNodeFilter<CstBooleanLiteral> BooleanLiteral => new CstNodeFilter<CstBooleanLiteral> (Children);
        public CstNodeFilter<CstNullLiteral> NullLiteral => new CstNodeFilter<CstNullLiteral> (Children);
        public CstNodeFilter<CstUnknown> Unknown => new CstNodeFilter<CstUnknown> (Children);
    }

    /// <summary>
    /// Rule = CharLiteral ::= (('''+CharLiteralChar+''')+_UNKNOWN_)
    /// Nodes = 
    /// </summary>
    public class CstCharLiteral : CstNodeLeaf, IPlatoTokenCstNode
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.CharLiteral;
        public CstCharLiteral(string text) : base(text) { }
        // No children
    }

    /// <summary>
    /// Rule = Comment ::= (CppStyleComment+_UNKNOWN_)
    /// Nodes = 
    /// </summary>
    public class CstComment : CstNodeLeaf, IPlatoTokenCstNode
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.Comment;
        public CstComment(string text) : base(text) { }
        // No children
    }

    /// <summary>
    /// Rule = Delimiter ::= ([\x28\x29\x5B\x5D\x7B\x7D]+_UNKNOWN_)
    /// Nodes = 
    /// </summary>
    public class CstDelimiter : CstNodeLeaf, IPlatoTokenCstNode
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.Delimiter;
        public CstDelimiter(string text) : base(text) { }
        // No children
    }

    /// <summary>
    /// Rule = FieldName ::= (Identifier+_UNKNOWN_)
    /// Nodes = Identifier
    /// </summary>
    public class CstFieldName : CstNode, IPlatoTokenCstNode
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.FieldName;
        public CstFieldName(params CstNode[] children) : base(children) { }
        public CstNodeFilter<CstIdentifier> Identifier => new CstNodeFilter<CstIdentifier> (Children);
    }

    /// <summary>
    /// Rule = FloatLiteral ::= ((Float+(FloatSuffix)?)+_UNKNOWN_)
    /// Nodes = 
    /// </summary>
    public class CstFloatLiteral : CstNodeLeaf, IPlatoTokenCstNode
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.FloatLiteral;
        public CstFloatLiteral(string text) : base(text) { }
        // No children
    }

    /// <summary>
    /// Rule = FunctionName ::= (Identifier+_UNKNOWN_)
    /// Nodes = Identifier
    /// </summary>
    public class CstFunctionName : CstNode, IPlatoTokenCstNode
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.FunctionName;
        public CstFunctionName(params CstNode[] children) : base(children) { }
        public CstNodeFilter<CstIdentifier> Identifier => new CstNodeFilter<CstIdentifier> (Children);
    }

    /// <summary>
    /// Rule = HexLiteral ::= ((("0x"|"0X")+(HexDigit)++(IntegerSuffix)?)+_UNKNOWN_)
    /// Nodes = 
    /// </summary>
    public class CstHexLiteral : CstNodeLeaf, IPlatoTokenCstNode
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.HexLiteral;
        public CstHexLiteral(string text) : base(text) { }
        // No children
    }

    /// <summary>
    /// Rule = Identifier ::= ((IdentifierFirstChar+(IdentifierChar)*)+_UNKNOWN_)
    /// Nodes = 
    /// </summary>
    public class CstIdentifier : CstNodeLeaf, IPlatoTokenCstNode
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.Identifier;
        public CstIdentifier(string text) : base(text) { }
        // No children
    }

    /// <summary>
    /// Rule = IntegerLiteral ::= ((Digits+!([DFMdfm])+(IntegerSuffix)?)+_UNKNOWN_)
    /// Nodes = 
    /// </summary>
    public class CstIntegerLiteral : CstNodeLeaf, IPlatoTokenCstNode
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.IntegerLiteral;
        public CstIntegerLiteral(string text) : base(text) { }
        // No children
    }

    /// <summary>
    /// Rule = Literal ::= ((HexLiteral|BinaryLiteral|FloatLiteral|IntegerLiteral|StringLiteral|CharLiteral|BooleanLiteral|NullLiteral)+_UNKNOWN_)
    /// Nodes = (HexLiteral|BinaryLiteral|FloatLiteral|IntegerLiteral|StringLiteral|CharLiteral|BooleanLiteral|NullLiteral)
    /// </summary>
    public class CstLiteral : CstNodeChoice, IPlatoTokenCstNode
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.Literal;
        public CstLiteral(params CstNode[] children) : base(children) { }
        public CstNodeFilter<CstHexLiteral> HexLiteral => new CstNodeFilter<CstHexLiteral> (Children);
        public CstNodeFilter<CstBinaryLiteral> BinaryLiteral => new CstNodeFilter<CstBinaryLiteral> (Children);
        public CstNodeFilter<CstFloatLiteral> FloatLiteral => new CstNodeFilter<CstFloatLiteral> (Children);
        public CstNodeFilter<CstIntegerLiteral> IntegerLiteral => new CstNodeFilter<CstIntegerLiteral> (Children);
        public CstNodeFilter<CstStringLiteral> StringLiteral => new CstNodeFilter<CstStringLiteral> (Children);
        public CstNodeFilter<CstCharLiteral> CharLiteral => new CstNodeFilter<CstCharLiteral> (Children);
        public CstNodeFilter<CstBooleanLiteral> BooleanLiteral => new CstNodeFilter<CstBooleanLiteral> (Children);
        public CstNodeFilter<CstNullLiteral> NullLiteral => new CstNodeFilter<CstNullLiteral> (Children);
    }

    /// <summary>
    /// Rule = NullLiteral ::= (Keyword('null')+_UNKNOWN_)
    /// Nodes = 
    /// </summary>
    public class CstNullLiteral : CstNodeLeaf, IPlatoTokenCstNode
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.NullLiteral;
        public CstNullLiteral(string text) : base(text) { }
        // No children
    }

    /// <summary>
    /// Rule = Operator ::= (([\x21\x23-\x26\x2A+\x2D\x2F\x3A<-\x40^|~])++_UNKNOWN_)
    /// Nodes = 
    /// </summary>
    public class CstOperator : CstNodeLeaf, IPlatoTokenCstNode
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.Operator;
        public CstOperator(string text) : base(text) { }
        // No children
    }

    /// <summary>
    /// Rule = ParameterName ::= (Identifier+_UNKNOWN_)
    /// Nodes = Identifier
    /// </summary>
    public class CstParameterName : CstNode, IPlatoTokenCstNode
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.ParameterName;
        public CstParameterName(params CstNode[] children) : base(children) { }
        public CstNodeFilter<CstIdentifier> Identifier => new CstNodeFilter<CstIdentifier> (Children);
    }

    /// <summary>
    /// Rule = ParenthesizedTokenGroup ::= (('('+_UNKNOWN_+_UNKNOWN_+Token+_UNKNOWN_+')'+_UNKNOWN_)+_UNKNOWN_)
    /// Nodes = ((TypeKeyword+(Comment)*+TypeName+(Comment)*)|((Comment)*+((FieldName+(Comment)*+TypeName+(Comment)*+((TypeParametersToken+(Comment)*))?+(Comment)*)|(FunctionName+(Comment)*+(((Comment)*+TypeName+(Comment)*+((TypeParametersToken+(Comment)*))?))?)))|Separator|Delimiter|Comment|Operator|Identifier|HexLiteral|BinaryLiteral|FloatLiteral|IntegerLiteral|StringLiteral|CharLiteral|BooleanLiteral|NullLiteral|Unknown)
    /// </summary>
    public class CstParenthesizedTokenGroup : CstNodeChoice, IPlatoTokenCstNode
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.ParenthesizedTokenGroup;
        public CstParenthesizedTokenGroup(string text) : base(text) { }
        public CstNodeFilter<CstTypeKeyword> TypeKeyword => new CstNodeFilter<CstTypeKeyword> (Children);
        public CstNodeFilter<CstComment> Comment => new CstNodeFilter<CstComment> (Children);
        public CstNodeFilter<CstTypeName> TypeName => new CstNodeFilter<CstTypeName> (Children);
        public CstNodeFilter<CstFieldName> FieldName => new CstNodeFilter<CstFieldName> (Children);
        public CstNodeFilter<CstTypeParametersToken> TypeParametersToken => new CstNodeFilter<CstTypeParametersToken> (Children);
        public CstNodeFilter<CstFunctionName> FunctionName => new CstNodeFilter<CstFunctionName> (Children);
        public CstNodeFilter<CstSeparator> Separator => new CstNodeFilter<CstSeparator> (Children);
        public CstNodeFilter<CstDelimiter> Delimiter => new CstNodeFilter<CstDelimiter> (Children);
        public CstNodeFilter<CstOperator> Operator => new CstNodeFilter<CstOperator> (Children);
        public CstNodeFilter<CstIdentifier> Identifier => new CstNodeFilter<CstIdentifier> (Children);
        public CstNodeFilter<CstHexLiteral> HexLiteral => new CstNodeFilter<CstHexLiteral> (Children);
        public CstNodeFilter<CstBinaryLiteral> BinaryLiteral => new CstNodeFilter<CstBinaryLiteral> (Children);
        public CstNodeFilter<CstFloatLiteral> FloatLiteral => new CstNodeFilter<CstFloatLiteral> (Children);
        public CstNodeFilter<CstIntegerLiteral> IntegerLiteral => new CstNodeFilter<CstIntegerLiteral> (Children);
        public CstNodeFilter<CstStringLiteral> StringLiteral => new CstNodeFilter<CstStringLiteral> (Children);
        public CstNodeFilter<CstCharLiteral> CharLiteral => new CstNodeFilter<CstCharLiteral> (Children);
        public CstNodeFilter<CstBooleanLiteral> BooleanLiteral => new CstNodeFilter<CstBooleanLiteral> (Children);
        public CstNodeFilter<CstNullLiteral> NullLiteral => new CstNodeFilter<CstNullLiteral> (Children);
        public CstNodeFilter<CstUnknown> Unknown => new CstNodeFilter<CstUnknown> (Children);
    }

    /// <summary>
    /// Rule = Separator ::= (([\x2C\x2E\x3B]|TypeKeyword|StatementKeyword)+_UNKNOWN_)
    /// Nodes = (TypeKeyword|StatementKeyword)
    /// </summary>
    public class CstSeparator : CstNodeChoice, IPlatoTokenCstNode
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.Separator;
        public CstSeparator(params CstNode[] children) : base(children) { }
        public CstNodeFilter<CstTypeKeyword> TypeKeyword => new CstNodeFilter<CstTypeKeyword> (Children);
        public CstNodeFilter<CstStatementKeyword> StatementKeyword => new CstNodeFilter<CstStatementKeyword> (Children);
    }

    /// <summary>
    /// Rule = StatementKeyword ::= ((Keyword('continue')|Keyword('foreach')|Keyword('finally')|Keyword('default')|Keyword('return')|Keyword('switch')|Keyword('break')|Keyword('throw')|Keyword('catch')|Keyword('using')|Keyword('case')|Keyword('for')|Keyword('try')|Keyword('if')|Keyword('do'))+_UNKNOWN_)
    /// Nodes = 
    /// </summary>
    public class CstStatementKeyword : CstNodeLeaf, IPlatoTokenCstNode
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.StatementKeyword;
        public CstStatementKeyword(string text) : base(text) { }
        // No children
    }

    /// <summary>
    /// Rule = StringLiteral ::= ((('@')?+'"'+(StringLiteralChar)*+'"')+_UNKNOWN_)
    /// Nodes = 
    /// </summary>
    public class CstStringLiteral : CstNodeLeaf, IPlatoTokenCstNode
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.StringLiteral;
        public CstStringLiteral(string text) : base(text) { }
        // No children
    }

    /// <summary>
    /// Rule = TokenGroup ::= (((BracedTokenGroup|BracketedTokenGroup|ParenthesizedTokenGroup|Token))++_UNKNOWN_)
    /// Nodes = ((BracedTokenGroup|BracketedTokenGroup|ParenthesizedTokenGroup))+
    /// </summary>
    public class CstTokenGroup : CstNode, IPlatoTokenCstNode
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.TokenGroup;
        public CstTokenGroup(params CstNode[] children) : base(children) { }
        public CstNodeFilter<CstBracedTokenGroup> BracedTokenGroup => new CstNodeFilter<CstBracedTokenGroup> (Children);
        public CstNodeFilter<CstBracketedTokenGroup> BracketedTokenGroup => new CstNodeFilter<CstBracketedTokenGroup> (Children);
        public CstNodeFilter<CstParenthesizedTokenGroup> ParenthesizedTokenGroup => new CstNodeFilter<CstParenthesizedTokenGroup> (Children);
    }

    /// <summary>
    /// Rule = TypeKeyword ::= ((Keyword('concept')|Keyword('library')|Keyword('type'))+_UNKNOWN_)
    /// Nodes = 
    /// </summary>
    public class CstTypeKeyword : CstNodeLeaf, IPlatoTokenCstNode
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.TypeKeyword;
        public CstTypeKeyword(string text) : base(text) { }
        // No children
    }

    /// <summary>
    /// Rule = TypeName ::= (Identifier+_UNKNOWN_)
    /// Nodes = Identifier
    /// </summary>
    public class CstTypeName : CstNode, IPlatoTokenCstNode
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.TypeName;
        public CstTypeName(params CstNode[] children) : base(children) { }
        public CstNodeFilter<CstIdentifier> Identifier => new CstNodeFilter<CstIdentifier> (Children);
    }

    /// <summary>
    /// Rule = TypeParametersToken ::= (('<'+CommentOrSpaces+TypeParameterToken+CommentOrSpaces+((','+CommentOrSpaces+TypeParameterToken))*+'>'+CommentOrSpaces)+_UNKNOWN_)
    /// Nodes = ((Comment)*+TypeParameterToken+(Comment)*+(((Comment)*+TypeParameterToken))*+(Comment)*)
    /// </summary>
    public class CstTypeParametersToken : CstNodeSequence, IPlatoTokenCstNode
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.TypeParametersToken;
        public CstTypeParametersToken(params CstNode[] children) : base(children) { }
        public CstNodeFilter<CstComment> Comment => new CstNodeFilter<CstComment> (Children);
        public CstNodeFilter<CstTypeParameterToken> TypeParameterToken => new CstNodeFilter<CstTypeParameterToken> (Children);
    }

    /// <summary>
    /// Rule = TypeParameterToken ::= ((Identifier+CommentOrSpaces+TypeAnnotationToken)+_UNKNOWN_)
    /// Nodes = (Identifier+(Comment)*)
    /// </summary>
    public class CstTypeParameterToken : CstNodeSequence, IPlatoTokenCstNode
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.TypeParameterToken;
        public CstTypeParameterToken(params CstNode[] children) : base(children) { }
        public CstNodeFilter<CstIdentifier> Identifier => new CstNodeFilter<CstIdentifier> (Children);
        public CstNodeFilter<CstComment> Comment => new CstNodeFilter<CstComment> (Children);
    }

    /// <summary>
    /// Rule = Unknown ::= (AnyChar+_UNKNOWN_)
    /// Nodes = 
    /// </summary>
    public class CstUnknown : CstNodeLeaf, IPlatoTokenCstNode
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.Unknown;
        public CstUnknown(string text) : base(text) { }
        // No children
    }

}
