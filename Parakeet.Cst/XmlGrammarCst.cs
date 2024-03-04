// DO NOT EDIT: Autogenerated file created on 2024-03-03 10:34:03 PM. 

namespace Ara3D.Parakeet.Cst.XmlGrammarNameSpace
{
    /// <summary>
    /// Rule = Attr ::= ((Name+([\x09\x0A\x0D\x20])*+'='+([\x09\x0A\x0D\x20])*+AttrValue)+WS)
    /// Nodes = (Name+AttrValue)
    /// </summary>
    public class CstAttr : CstNodeSequence
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.Attr;
        public CstAttr(params CstNode[] children) : base(children) { }
        public CstNodeFilter<CstName> Name => new CstNodeFilter<CstName> (Children);
        public CstNodeFilter<CstAttrValue> AttrValue => new CstNodeFilter<CstAttrValue> (Children);
    }

    /// <summary>
    /// Rule = AttrList ::= ((Attr)*+WS)
    /// Nodes = (Attr)*
    /// </summary>
    public class CstAttrList : CstNode
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.AttrList;
        public CstAttrList(params CstNode[] children) : base(children) { }
        public CstNodeFilter<CstAttr> Attr => new CstNodeFilter<CstAttr> (Children);
    }

    /// <summary>
    /// Rule = AttrValue ::= (Identifier+WS)
    /// Nodes = Identifier
    /// </summary>
    public class CstAttrValue : CstNode
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.AttrValue;
        public CstAttrValue(params CstNode[] children) : base(children) { }
        public CstNodeFilter<CstIdentifier> Identifier => new CstNodeFilter<CstIdentifier> (Children);
    }

    /// <summary>
    /// Rule = CData ::= (((!(CDEnd)+AnyChar))*+WS)
    /// Nodes = 
    /// </summary>
    public class CstCData : CstNodeLeaf
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.CData;
        public CstCData(string text) : base(text) { }
        // No children
    }

    /// <summary>
    /// Rule = CDSect ::= ((CDStart+CData+CDEnd)+WS)
    /// Nodes = CData
    /// </summary>
    public class CstCDSect : CstNode
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.CDSect;
        public CstCDSect(params CstNode[] children) : base(children) { }
        public CstNodeFilter<CstCData> CData => new CstNodeFilter<CstCData> (Children);
    }

    /// <summary>
    /// Rule = Content ::= ((Text|XmlStyleComment|CDSect|DTD|Element)+WS)
    /// Nodes = (Text|CDSect|DTD|Element)
    /// </summary>
    public class CstContent : CstNodeChoice
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.Content;
        public CstContent(params CstNode[] children) : base(children) { }
        public CstNodeFilter<CstText> Text => new CstNodeFilter<CstText> (Children);
        public CstNodeFilter<CstCDSect> CDSect => new CstNodeFilter<CstCDSect> (Children);
        public CstNodeFilter<CstDTD> DTD => new CstNodeFilter<CstDTD> (Children);
        public CstNodeFilter<CstElement> Element => new CstNodeFilter<CstElement> (Children);
    }

    /// <summary>
    /// Rule = Document ::= (((Prolog)?+WS+Element+EndOfInput)+WS)
    /// Nodes = ((Prolog)?+Element)
    /// </summary>
    public class CstDocument : CstNodeSequence
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.Document;
        public CstDocument(params CstNode[] children) : base(children) { }
        public CstNodeFilter<CstProlog> Prolog => new CstNodeFilter<CstProlog> (Children);
        public CstNodeFilter<CstElement> Element => new CstNodeFilter<CstElement> (Children);
    }

    /// <summary>
    /// Rule = DTD ::= (("<\x21DOCTYPE"+((!([>\x5B\x5D])+AnyChar))*+(DTDInternalSubset)?+([\x09\x0A\x0D\x20])*+'>')+WS)
    /// Nodes = (DTDInternalSubset)?
    /// </summary>
    public class CstDTD : CstNode
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.DTD;
        public CstDTD(params CstNode[] children) : base(children) { }
        public CstNodeFilter<CstDTDInternalSubset> DTDInternalSubset => new CstNodeFilter<CstDTDInternalSubset> (Children);
    }

    /// <summary>
    /// Rule = DTDInternalSubset ::= (('['+((!(']')+AnyChar))*+']')+WS)
    /// Nodes = 
    /// </summary>
    public class CstDTDInternalSubset : CstNodeLeaf
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.DTDInternalSubset;
        public CstDTDInternalSubset(string text) : base(text) { }
        // No children
    }

    /// <summary>
    /// Rule = Element ::= ((EmptyElementTag|(StartTag+Content+EndTag))+WS)
    /// Nodes = (EmptyElementTag|(StartTag+Content+EndTag))
    /// </summary>
    public class CstElement : CstNodeChoice
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.Element;
        public CstElement(params CstNode[] children) : base(children) { }
        public CstNodeFilter<CstEmptyElementTag> EmptyElementTag => new CstNodeFilter<CstEmptyElementTag> (Children);
        public CstNodeFilter<CstStartTag> StartTag => new CstNodeFilter<CstStartTag> (Children);
        public CstNodeFilter<CstContent> Content => new CstNodeFilter<CstContent> (Children);
        public CstNodeFilter<CstEndTag> EndTag => new CstNodeFilter<CstEndTag> (Children);
    }

    /// <summary>
    /// Rule = EmptyElementTag ::= ((Symbol('<')+Identifier+AttrList+Symbol('/>'))+WS)
    /// Nodes = (Identifier+AttrList)
    /// </summary>
    public class CstEmptyElementTag : CstNodeSequence
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.EmptyElementTag;
        public CstEmptyElementTag(params CstNode[] children) : base(children) { }
        public CstNodeFilter<CstIdentifier> Identifier => new CstNodeFilter<CstIdentifier> (Children);
        public CstNodeFilter<CstAttrList> AttrList => new CstNodeFilter<CstAttrList> (Children);
    }

    /// <summary>
    /// Rule = EndTag ::= ((Symbol('</')+Identifier+Symbol('>'))+WS)
    /// Nodes = Identifier
    /// </summary>
    public class CstEndTag : CstNode
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.EndTag;
        public CstEndTag(params CstNode[] children) : base(children) { }
        public CstNodeFilter<CstIdentifier> Identifier => new CstNodeFilter<CstIdentifier> (Children);
    }

    /// <summary>
    /// Rule = Entity ::= (('&'+(Identifier|HexEntityValue|NumericEntityValue)+';')+WS)
    /// Nodes = (Identifier|HexEntityValue|NumericEntityValue)
    /// </summary>
    public class CstEntity : CstNodeChoice
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.Entity;
        public CstEntity(params CstNode[] children) : base(children) { }
        public CstNodeFilter<CstIdentifier> Identifier => new CstNodeFilter<CstIdentifier> (Children);
        public CstNodeFilter<CstHexEntityValue> HexEntityValue => new CstNodeFilter<CstHexEntityValue> (Children);
        public CstNodeFilter<CstNumericEntityValue> NumericEntityValue => new CstNodeFilter<CstNumericEntityValue> (Children);
    }

    /// <summary>
    /// Rule = HexEntityValue ::= (('x'+(HexDigit)*)+WS)
    /// Nodes = 
    /// </summary>
    public class CstHexEntityValue : CstNodeLeaf
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.HexEntityValue;
        public CstHexEntityValue(string text) : base(text) { }
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
    /// Rule = Misc ::= ((XmlStyleComment|PI|([\x09\x0A\x0D\x20])*)+WS)
    /// Nodes = PI
    /// </summary>
    public class CstMisc : CstNode
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.Misc;
        public CstMisc(params CstNode[] children) : base(children) { }
        public CstNodeFilter<CstPI> PI => new CstNodeFilter<CstPI> (Children);
    }

    /// <summary>
    /// Rule = Name ::= (((Letter|':'|'_'|[À-Ö]|[Ø-ö]|[ø-˿]|[Ͱ-ͽ]|[Ϳ-῿]|[‌-‍]|[⁰-↏]|[Ⰰ-⿯])+((Letter|':'|'_'|[À-Ö]|[Ø-ö]|[ø-˿]|[Ͱ-ͽ]|[Ϳ-῿]|[‌-‍]|[⁰-↏]|[Ⰰ-⿯]|'-'|'.'|Digit|'·'|[̀-ͯ]|[‿-⁀]))*)+WS)
    /// Nodes = 
    /// </summary>
    public class CstName : CstNodeLeaf
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.Name;
        public CstName(string text) : base(text) { }
        // No children
    }

    /// <summary>
    /// Rule = NonEmptyElement ::= ((StartTag+Content+EndTag)+WS)
    /// Nodes = (StartTag+Content+EndTag)
    /// </summary>
    public class CstNonEmptyElement : CstNodeSequence
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.NonEmptyElement;
        public CstNonEmptyElement(params CstNode[] children) : base(children) { }
        public CstNodeFilter<CstStartTag> StartTag => new CstNodeFilter<CstStartTag> (Children);
        public CstNodeFilter<CstContent> Content => new CstNodeFilter<CstContent> (Children);
        public CstNodeFilter<CstEndTag> EndTag => new CstNodeFilter<CstEndTag> (Children);
    }

    /// <summary>
    /// Rule = NSIdent ::= ((Identifier+((':'+Identifier))?)+WS)
    /// Nodes = (Identifier+(Identifier)?)
    /// </summary>
    public class CstNSIdent : CstNodeSequence
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.NSIdent;
        public CstNSIdent(params CstNode[] children) : base(children) { }
        public CstNodeFilter<CstIdentifier> Identifier => new CstNodeFilter<CstIdentifier> (Children);
    }

    /// <summary>
    /// Rule = NumericEntityValue ::= ((Digit)*+WS)
    /// Nodes = 
    /// </summary>
    public class CstNumericEntityValue : CstNodeLeaf
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.NumericEntityValue;
        public CstNumericEntityValue(string text) : base(text) { }
        // No children
    }

    /// <summary>
    /// Rule = PI ::= (("<\x3F"+((!("\x3F>")+AnyChar))*+"\x3F>")+WS)
    /// Nodes = 
    /// </summary>
    public class CstPI : CstNodeLeaf
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.PI;
        public CstPI(string text) : base(text) { }
        // No children
    }

    /// <summary>
    /// Rule = Prolog ::= (((XmlDecl)?+(Misc)*+(DTD)?+(Misc)*)+WS)
    /// Nodes = ((XmlDecl)?+(Misc)*+(DTD)?+(Misc)*)
    /// </summary>
    public class CstProlog : CstNodeSequence
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.Prolog;
        public CstProlog(params CstNode[] children) : base(children) { }
        public CstNodeFilter<CstXmlDecl> XmlDecl => new CstNodeFilter<CstXmlDecl> (Children);
        public CstNodeFilter<CstMisc> Misc => new CstNodeFilter<CstMisc> (Children);
        public CstNodeFilter<CstDTD> DTD => new CstNodeFilter<CstDTD> (Children);
    }

    /// <summary>
    /// Rule = StartTag ::= (('<'+Identifier+AttrList+Symbol('>'))+WS)
    /// Nodes = (Identifier+AttrList)
    /// </summary>
    public class CstStartTag : CstNodeSequence
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.StartTag;
        public CstStartTag(params CstNode[] children) : base(children) { }
        public CstNodeFilter<CstIdentifier> Identifier => new CstNodeFilter<CstIdentifier> (Children);
        public CstNodeFilter<CstAttrList> AttrList => new CstNodeFilter<CstAttrList> (Children);
    }

    /// <summary>
    /// Rule = Tag ::= ((EndTag|EmptyElementTag|StartTag)+WS)
    /// Nodes = (EndTag|EmptyElementTag|StartTag)
    /// </summary>
    public class CstTag : CstNodeChoice
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.Tag;
        public CstTag(params CstNode[] children) : base(children) { }
        public CstNodeFilter<CstEndTag> EndTag => new CstNodeFilter<CstEndTag> (Children);
        public CstNodeFilter<CstEmptyElementTag> EmptyElementTag => new CstNodeFilter<CstEmptyElementTag> (Children);
        public CstNodeFilter<CstStartTag> StartTag => new CstNodeFilter<CstStartTag> (Children);
    }

    /// <summary>
    /// Rule = Text ::= (((!([\x26<])+AnyChar))++WS)
    /// Nodes = 
    /// </summary>
    public class CstText : CstNodeLeaf
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.Text;
        public CstText(string text) : base(text) { }
        // No children
    }

    /// <summary>
    /// Rule = XmlDecl ::= (("<\x3Fxml"+([\x09\x0A\x0D\x20])*+AttrList+([\x09\x0A\x0D\x20])*+"\x3F>")+WS)
    /// Nodes = AttrList
    /// </summary>
    public class CstXmlDecl : CstNode
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.XmlDecl;
        public CstXmlDecl(params CstNode[] children) : base(children) { }
        public CstNodeFilter<CstAttrList> AttrList => new CstNodeFilter<CstAttrList> (Children);
    }

}
