// DO NOT EDIT: Autogenerated file created on 2024-03-28 11:03:53 PM. 
using System;
using System.Linq;

namespace Ara3D.Parakeet.Cst.PhoneNumberGrammarNameSpace
{
    /// <summary>This interface exists to make it easy to auto-generate type switches</summary>
    public interface IPhoneNumberCstNode { }

    /// <summary>
    /// Rule = AreaCode ::= ((('('+(Spaces)?+_UNKNOWN_+AreaCodeDigits+(Spaces)?+')'+(Spaces)?)|AreaCodeDigits)+(Spaces)?)
    /// Nodes = (AreaCodeDigits|AreaCodeDigits)
    /// </summary>
    public class CstAreaCode : CstNodeChoice, IPhoneNumberCstNode
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.AreaCode;
        public CstAreaCode(ILocation location, params CstNode[] children) : base(location, children) { }
        public CstNodeFilter<CstAreaCodeDigits> AreaCodeDigits => new CstNodeFilter<CstAreaCodeDigits> (Children);
    }

    /// <summary>
    /// Rule = AreaCodeDigits ::= ((Digit){3,3}+(Spaces)?)
    /// Nodes = 
    /// </summary>
    public class CstAreaCodeDigits : CstNodeLeaf, IPhoneNumberCstNode
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.AreaCodeDigits;
        public CstAreaCodeDigits(ILocation location, string text) : base(location, text) { }
    }

    /// <summary>
    /// Rule = CountryCode ::= (((('+'+Spaces))?+(Digit){1,3})+(Spaces)?)
    /// Nodes = 
    /// </summary>
    public class CstCountryCode : CstNodeLeaf, IPhoneNumberCstNode
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.CountryCode;
        public CstCountryCode(ILocation location, string text) : base(location, text) { }
    }

    /// <summary>
    /// Rule = Exchange ::= ((Digit){3,3}+(Spaces)?)
    /// Nodes = 
    /// </summary>
    public class CstExchange : CstNodeLeaf, IPhoneNumberCstNode
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.Exchange;
        public CstExchange(ILocation location, string text) : base(location, text) { }
    }

    /// <summary>
    /// Rule = Identifier ::= ((IdentifierFirstChar+(IdentifierChar)*)+(Spaces)?)
    /// Nodes = 
    /// </summary>
    public class CstIdentifier : CstNodeLeaf, IPhoneNumberCstNode
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.Identifier;
        public CstIdentifier(ILocation location, string text) : base(location, text) { }
    }

    /// <summary>
    /// Rule = PhoneNumber ::= ((((CountryCode+Separators))?+AreaCode+Separators+Exchange+Separators+Subscriber)+(Spaces)?)
    /// Nodes = ((CountryCode)?+AreaCode+Exchange+Subscriber)
    /// </summary>
    public class CstPhoneNumber : CstNodeSequence, IPhoneNumberCstNode
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.PhoneNumber;
        public CstPhoneNumber(ILocation location, params CstNode[] children) : base(location, children) { }
        public CstNodeFilter<CstCountryCode> CountryCode => new CstNodeFilter<CstCountryCode> (Children);
        public CstNodeFilter<CstAreaCode> AreaCode => new CstNodeFilter<CstAreaCode> (Children);
        public CstNodeFilter<CstExchange> Exchange => new CstNodeFilter<CstExchange> (Children);
        public CstNodeFilter<CstSubscriber> Subscriber => new CstNodeFilter<CstSubscriber> (Children);
    }

    /// <summary>
    /// Rule = Subscriber ::= ((Digit){4,4}+(Spaces)?)
    /// Nodes = 
    /// </summary>
    public class CstSubscriber : CstNodeLeaf, IPhoneNumberCstNode
    {
        public static Rule Rule = CstNodeFactory.StaticGrammar.Subscriber;
        public CstSubscriber(ILocation location, string text) : base(location, text) { }
    }

}
