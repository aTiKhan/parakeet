// DO NOT EDIT: Autogenerated file created on 2024-03-11 1:16:54 PM. 
using System;
using System.Linq;

namespace Ara3D.Parakeet.Cst.CssGrammarNameSpace
{
    /// <summary>This interface exists to make it easy to auto-generate type switches</summary>
    public interface ICssCstNode { }

    /// <summary>
    /// Rule = Attrib ::= (('['+WS+_UNKNOWN_+Ident+AttribOperator+(AttribValue)?+WS+']'+WS)+WS)
    /// Nodes = (AttribOperator+(AttribValue)?)
    /// </summary>
    public class CstAttrib : CstNodeSequence, ICssCstNode
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.Attrib;
        public CstAttrib(params CstNode[] children) : base(children) { }
        public CstNodeFilter<CstAttribOperator> AttribOperator => new CstNodeFilter<CstAttribOperator> (Children);
        public CstNodeFilter<CstAttribValue> AttribValue => new CstNodeFilter<CstAttribValue> (Children);
    }

    /// <summary>
    /// Rule = AttribOperator ::= (('='|Includes|DashMatch)+WS)
    /// Nodes = 
    /// </summary>
    public class CstAttribOperator : CstNodeLeaf, ICssCstNode
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.AttribOperator;
        public CstAttribOperator(string text) : base(text) { }
        // No children
    }

    /// <summary>
    /// Rule = AttribValue ::= ((Ident|String)+WS)
    /// Nodes = 
    /// </summary>
    public class CstAttribValue : CstNodeLeaf, ICssCstNode
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.AttribValue;
        public CstAttribValue(string text) : base(text) { }
        // No children
    }

    /// <summary>
    /// Rule = CharSet ::= ((CharSetSym+String+';')+WS)
    /// Nodes = 
    /// </summary>
    public class CstCharSet : CstNodeLeaf, ICssCstNode
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.CharSet;
        public CstCharSet(string text) : base(text) { }
        // No children
    }

    /// <summary>
    /// Rule = Class ::= (('.'+Ident)+WS)
    /// Nodes = 
    /// </summary>
    public class CstClass : CstNodeLeaf, ICssCstNode
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.Class;
        public CstClass(string text) : base(text) { }
        // No children
    }

    /// <summary>
    /// Rule = Combinator ::= ((Symbol('+')|Symbol('>'))+WS)
    /// Nodes = 
    /// </summary>
    public class CstCombinator : CstNodeLeaf, ICssCstNode
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.Combinator;
        public CstCombinator(string text) : base(text) { }
        // No children
    }

    /// <summary>
    /// Rule = CombinedSelector ::= (((Combinator)?+Selector)+WS)
    /// Nodes = ((Combinator)?+Selector)
    /// </summary>
    public class CstCombinedSelector : CstNodeSequence, ICssCstNode
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.CombinedSelector;
        public CstCombinedSelector(params CstNode[] children) : base(children) { }
        public CstNodeFilter<CstCombinator> Combinator => new CstNodeFilter<CstCombinator> (Children);
        public CstNodeFilter<CstSelector> Selector => new CstNodeFilter<CstSelector> (Children);
    }

    /// <summary>
    /// Rule = Content ::= ((RuleSet|MediaList|Page)+WS)
    /// Nodes = (RuleSet|MediaList|Page)
    /// </summary>
    public class CstContent : CstNodeChoice, ICssCstNode
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.Content;
        public CstContent(params CstNode[] children) : base(children) { }
        public CstNodeFilter<CstRuleSet> RuleSet => new CstNodeFilter<CstRuleSet> (Children);
        public CstNodeFilter<CstMediaList> MediaList => new CstNodeFilter<CstMediaList> (Children);
        public CstNodeFilter<CstPage> Page => new CstNodeFilter<CstPage> (Children);
    }

    /// <summary>
    /// Rule = Contents ::= (((Content+CommentParts))*+WS)
    /// Nodes = (Content)*
    /// </summary>
    public class CstContents : CstNode, ICssCstNode
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.Contents;
        public CstContents(params CstNode[] children) : base(children) { }
        public CstNodeFilter<CstContent> Content => new CstNodeFilter<CstContent> (Children);
    }

    /// <summary>
    /// Rule = Declaration ::= ((Property+Symbol(':')+Expr+(Prio)?)+WS)
    /// Nodes = (Property+Expr+(Prio)?)
    /// </summary>
    public class CstDeclaration : CstNodeSequence, ICssCstNode
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.Declaration;
        public CstDeclaration(params CstNode[] children) : base(children) { }
        public CstNodeFilter<CstProperty> Property => new CstNodeFilter<CstProperty> (Children);
        public CstNodeFilter<CstExpr> Expr => new CstNodeFilter<CstExpr> (Children);
        public CstNodeFilter<CstPrio> Prio => new CstNodeFilter<CstPrio> (Children);
    }

    /// <summary>
    /// Rule = Declarations ::= ((((Selector+WS+((Symbol(';')+Selector+WS))*)+(Symbol(';'))?))?+WS)
    /// Nodes = (Selector)*
    /// </summary>
    public class CstDeclarations : CstNode, ICssCstNode
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.Declarations;
        public CstDeclarations(params CstNode[] children) : base(children) { }
        public CstNodeFilter<CstSelector> Selector => new CstNodeFilter<CstSelector> (Children);
    }

    /// <summary>
    /// Rule = ElementName ::= ((Ident|'*')+WS)
    /// Nodes = 
    /// </summary>
    public class CstElementName : CstNodeLeaf, ICssCstNode
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.ElementName;
        public CstElementName(string text) : base(text) { }
        // No children
    }

    /// <summary>
    /// Rule = Expr ::= (((Term+WS+(((Operator)?+Term+WS))*)+((Operator)?)?)+WS)
    /// Nodes = (Term+(((Operator)?+Term))*+Operator)
    /// </summary>
    public class CstExpr : CstNodeSequence, ICssCstNode
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.Expr;
        public CstExpr(params CstNode[] children) : base(children) { }
        public CstNodeFilter<CstTerm> Term => new CstNodeFilter<CstTerm> (Children);
        public CstNodeFilter<CstOperator> Operator => new CstNodeFilter<CstOperator> (Children);
    }

    /// <summary>
    /// Rule = Function ::= ((Ident+'('+WS+_UNKNOWN_+(Expr)?+WS+')'+WS)+WS)
    /// Nodes = (Expr)?
    /// </summary>
    public class CstFunction : CstNode, ICssCstNode
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.Function;
        public CstFunction(params CstNode[] children) : base(children) { }
        public CstNodeFilter<CstExpr> Expr => new CstNodeFilter<CstExpr> (Children);
    }

    /// <summary>
    /// Rule = HexColor ::= ((('#'+(HexDigit){6,6})|(HexDigit){3,3})+WS)
    /// Nodes = 
    /// </summary>
    public class CstHexColor : CstNodeLeaf, ICssCstNode
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.HexColor;
        public CstHexColor(string text) : base(text) { }
        // No children
    }

    /// <summary>
    /// Rule = Identifier ::= ((IdentifierFirstChar+(IdentifierChar)*)+WS)
    /// Nodes = 
    /// </summary>
    public class CstIdentifier : CstNodeLeaf, ICssCstNode
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.Identifier;
        public CstIdentifier(string text) : base(text) { }
        // No children
    }

    /// <summary>
    /// Rule = Import ::= ((ImportSym+WS+(String|Uri)+WS+(MediaList)?+';')+WS)
    /// Nodes = (MediaList)?
    /// </summary>
    public class CstImport : CstNode, ICssCstNode
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.Import;
        public CstImport(params CstNode[] children) : base(children) { }
        public CstNodeFilter<CstMediaList> MediaList => new CstNodeFilter<CstMediaList> (Children);
    }

    /// <summary>
    /// Rule = Imports ::= (((Import+CommentParts))*+WS)
    /// Nodes = (Import)*
    /// </summary>
    public class CstImports : CstNode, ICssCstNode
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.Imports;
        public CstImports(params CstNode[] children) : base(children) { }
        public CstNodeFilter<CstImport> Import => new CstNodeFilter<CstImport> (Children);
    }

    /// <summary>
    /// Rule = MediaList ::= ((((Medium+WS+((Comma+Medium+WS))*)+(Comma)?))?+WS)
    /// Nodes = (Medium)*
    /// </summary>
    public class CstMediaList : CstNode, ICssCstNode
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.MediaList;
        public CstMediaList(params CstNode[] children) : base(children) { }
        public CstNodeFilter<CstMedium> Medium => new CstNodeFilter<CstMedium> (Children);
    }

    /// <summary>
    /// Rule = Medium ::= (Ident+WS)
    /// Nodes = 
    /// </summary>
    public class CstMedium : CstNodeLeaf, ICssCstNode
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.Medium;
        public CstMedium(string text) : base(text) { }
        // No children
    }

    /// <summary>
    /// Rule = Operator ::= ((Symbol('//')|Symbol(','))+WS)
    /// Nodes = 
    /// </summary>
    public class CstOperator : CstNodeLeaf, ICssCstNode
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.Operator;
        public CstOperator(string text) : base(text) { }
        // No children
    }

    /// <summary>
    /// Rule = Page ::= ((PageSym+WS+(PseudoPage)?+PageDeclarations)+WS)
    /// Nodes = ((PseudoPage)?+PageDeclarations)
    /// </summary>
    public class CstPage : CstNodeSequence, ICssCstNode
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.Page;
        public CstPage(params CstNode[] children) : base(children) { }
        public CstNodeFilter<CstPseudoPage> PseudoPage => new CstNodeFilter<CstPseudoPage> (Children);
        public CstNodeFilter<CstPageDeclarations> PageDeclarations => new CstNodeFilter<CstPageDeclarations> (Children);
    }

    /// <summary>
    /// Rule = PageDeclarations ::= (('{'+WS+_UNKNOWN_+(((Declaration+WS+((Symbol(';')+Declaration+WS))*)+(Symbol(';'))?))?+WS+'}'+WS)+WS)
    /// Nodes = (Declaration)*
    /// </summary>
    public class CstPageDeclarations : CstNode, ICssCstNode
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.PageDeclarations;
        public CstPageDeclarations(params CstNode[] children) : base(children) { }
        public CstNodeFilter<CstDeclaration> Declaration => new CstNodeFilter<CstDeclaration> (Children);
    }

    /// <summary>
    /// Rule = Prio ::= (ImportantSym+WS)
    /// Nodes = 
    /// </summary>
    public class CstPrio : CstNodeLeaf, ICssCstNode
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.Prio;
        public CstPrio(string text) : base(text) { }
        // No children
    }

    /// <summary>
    /// Rule = Property ::= (Ident+WS)
    /// Nodes = 
    /// </summary>
    public class CstProperty : CstNodeLeaf, ICssCstNode
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.Property;
        public CstProperty(string text) : base(text) { }
        // No children
    }

    /// <summary>
    /// Rule = Pseudo ::= ((':'+(Function|Ident))+WS)
    /// Nodes = Function
    /// </summary>
    public class CstPseudo : CstNode, ICssCstNode
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.Pseudo;
        public CstPseudo(params CstNode[] children) : base(children) { }
        public CstNodeFilter<CstFunction> Function => new CstNodeFilter<CstFunction> (Children);
    }

    /// <summary>
    /// Rule = PseudoPage ::= ((':'+Ident)+WS)
    /// Nodes = 
    /// </summary>
    public class CstPseudoPage : CstNodeLeaf, ICssCstNode
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.PseudoPage;
        public CstPseudoPage(string text) : base(text) { }
        // No children
    }

    /// <summary>
    /// Rule = RuleSet ::= ((Selectors+'{'+WS+_UNKNOWN_+Declarations+WS+'}'+WS)+WS)
    /// Nodes = (Selectors+Declarations)
    /// </summary>
    public class CstRuleSet : CstNodeSequence, ICssCstNode
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.RuleSet;
        public CstRuleSet(params CstNode[] children) : base(children) { }
        public CstNodeFilter<CstSelectors> Selectors => new CstNodeFilter<CstSelectors> (Children);
        public CstNodeFilter<CstDeclarations> Declarations => new CstNodeFilter<CstDeclarations> (Children);
    }

    /// <summary>
    /// Rule = Selector ::= ((SimpleSelector+(CombinedSelector)?)+WS)
    /// Nodes = (SimpleSelector+(CombinedSelector)?)
    /// </summary>
    public class CstSelector : CstNodeSequence, ICssCstNode
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.Selector;
        public CstSelector(params CstNode[] children) : base(children) { }
        public CstNodeFilter<CstSimpleSelector> SimpleSelector => new CstNodeFilter<CstSimpleSelector> (Children);
        public CstNodeFilter<CstCombinedSelector> CombinedSelector => new CstNodeFilter<CstCombinedSelector> (Children);
    }

    /// <summary>
    /// Rule = SelectorPart ::= ((Hash|Class|Attrib|Pseudo)+WS)
    /// Nodes = (Class|Attrib|Pseudo)
    /// </summary>
    public class CstSelectorPart : CstNodeChoice, ICssCstNode
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.SelectorPart;
        public CstSelectorPart(params CstNode[] children) : base(children) { }
        public CstNodeFilter<CstClass> Class => new CstNodeFilter<CstClass> (Children);
        public CstNodeFilter<CstAttrib> Attrib => new CstNodeFilter<CstAttrib> (Children);
        public CstNodeFilter<CstPseudo> Pseudo => new CstNodeFilter<CstPseudo> (Children);
    }

    /// <summary>
    /// Rule = Selectors ::= ((((Selector+WS+((Comma+Selector+WS))*)+(Comma)?))?+WS)
    /// Nodes = (Selector)*
    /// </summary>
    public class CstSelectors : CstNode, ICssCstNode
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.Selectors;
        public CstSelectors(params CstNode[] children) : base(children) { }
        public CstNodeFilter<CstSelector> Selector => new CstNodeFilter<CstSelector> (Children);
    }

    /// <summary>
    /// Rule = SimpleSelector ::= (((ElementName+(SelectorPart)*)|(SelectorPart)+)+WS)
    /// Nodes = ((ElementName+(SelectorPart)*)|(SelectorPart)+)
    /// </summary>
    public class CstSimpleSelector : CstNodeChoice, ICssCstNode
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.SimpleSelector;
        public CstSimpleSelector(params CstNode[] children) : base(children) { }
        public CstNodeFilter<CstElementName> ElementName => new CstNodeFilter<CstElementName> (Children);
        public CstNodeFilter<CstSelectorPart> SelectorPart => new CstNodeFilter<CstSelectorPart> (Children);
    }

    /// <summary>
    /// Rule = StyleSheet ::= (((CharSet)?+((S|Cdo|Cdc))*+Imports+Contents)+WS)
    /// Nodes = ((CharSet)?+Imports+Contents)
    /// </summary>
    public class CstStyleSheet : CstNodeSequence, ICssCstNode
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.StyleSheet;
        public CstStyleSheet(params CstNode[] children) : base(children) { }
        public CstNodeFilter<CstCharSet> CharSet => new CstNodeFilter<CstCharSet> (Children);
        public CstNodeFilter<CstImports> Imports => new CstNodeFilter<CstImports> (Children);
        public CstNodeFilter<CstContents> Contents => new CstNodeFilter<CstContents> (Children);
    }

    /// <summary>
    /// Rule = Term ::= (((UnaryOperator)?+(Percentage|Length|Ems|Exs|Angle|Time|Freq|String|Ident|Number|Uri|HexColor|Function))+WS)
    /// Nodes = ((UnaryOperator)?+(HexColor|Function))
    /// </summary>
    public class CstTerm : CstNodeSequence, ICssCstNode
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.Term;
        public CstTerm(params CstNode[] children) : base(children) { }
        public CstNodeFilter<CstUnaryOperator> UnaryOperator => new CstNodeFilter<CstUnaryOperator> (Children);
        public CstNodeFilter<CstHexColor> HexColor => new CstNodeFilter<CstHexColor> (Children);
        public CstNodeFilter<CstFunction> Function => new CstNodeFilter<CstFunction> (Children);
    }

    /// <summary>
    /// Rule = UnaryOperator ::= (("+"|'-')+WS)
    /// Nodes = 
    /// </summary>
    public class CstUnaryOperator : CstNodeLeaf, ICssCstNode
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.UnaryOperator;
        public CstUnaryOperator(string text) : base(text) { }
        // No children
    }

}
