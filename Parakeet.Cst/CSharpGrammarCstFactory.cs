// DO NOT EDIT: Autogenerated file created on 2024-03-17 11:14:11 AM. 
using System;
using System.Linq;
using System.Collections.Generic;
using Ara3D.Parakeet.Grammars;

namespace Ara3D.Parakeet.Cst.CSharpGrammarNameSpace
{
    public class CstNodeFactory : INodeFactory
    {
        public static CSharpGrammar StaticGrammar = CSharpGrammar.Instance;
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
                case "AccessSpecifier": return new CstAccessSpecifier(node.Contents);
                case "ArrayInitializationValue": return new CstArrayInitializationValue(node.Children.Select(Create).ToArray());
                case "ArrayRankSpecifier": return new CstArrayRankSpecifier(node.Contents);
                case "ArrayRankSpecifiers": return new CstArrayRankSpecifiers(node.Children.Select(Create).ToArray());
                case "ArraySizeSpecifier": return new CstArraySizeSpecifier(node.Children.Select(Create).ToArray());
                case "AsOperation": return new CstAsOperation(node.Children.Select(Create).ToArray());
                case "Attribute": return new CstAttribute(node.Children.Select(Create).ToArray());
                case "AttributeGroup": return new CstAttributeGroup(node.Children.Select(Create).ToArray());
                case "AttributeList": return new CstAttributeList(node.Children.Select(Create).ToArray());
                case "BaseCall": return new CstBaseCall(node.Children.Select(Create).ToArray());
                case "BaseClassList": return new CstBaseClassList(node.Children.Select(Create).ToArray());
                case "BaseOrThisCall": return new CstBaseOrThisCall(node.Children.Select(Create).ToArray());
                case "BinaryLiteral": return new CstBinaryLiteral(node.Contents);
                case "BinaryOperation": return new CstBinaryOperation(node.Children.Select(Create).ToArray());
                case "BinaryOperator": return new CstBinaryOperator(node.Contents);
                case "BooleanLiteral": return new CstBooleanLiteral(node.Contents);
                case "BracedStructure": return new CstBracedStructure(node.Children.Select(Create).ToArray());
                case "BracketedStructure": return new CstBracketedStructure(node.Children.Select(Create).ToArray());
                case "BreakStatement": return new CstBreakStatement(node.Contents);
                case "CaseClause": return new CstCaseClause(node.Children.Select(Create).ToArray());
                case "CastExpression": return new CstCastExpression(node.Children.Select(Create).ToArray());
                case "CatchClause": return new CstCatchClause(node.Children.Select(Create).ToArray());
                case "CharLiteral": return new CstCharLiteral(node.Contents);
                case "CompoundOrSimpleTypeExpr": return new CstCompoundOrSimpleTypeExpr(node.Children.Select(Create).ToArray());
                case "CompoundStatement": return new CstCompoundStatement(node.Children.Select(Create).ToArray());
                case "CompoundTypeExpr": return new CstCompoundTypeExpr(node.Children.Select(Create).ToArray());
                case "ConditionalMemberAccess": return new CstConditionalMemberAccess(node.Children.Select(Create).ToArray());
                case "Constraint": return new CstConstraint(node.Children.Select(Create).ToArray());
                case "ConstraintClause": return new CstConstraintClause(node.Children.Select(Create).ToArray());
                case "ConstraintList": return new CstConstraintList(node.Children.Select(Create).ToArray());
                case "ConstructorDeclaration": return new CstConstructorDeclaration(node.Children.Select(Create).ToArray());
                case "ContinueStatement": return new CstContinueStatement(node.Contents);
                case "ConverterDeclaration": return new CstConverterDeclaration(node.Children.Select(Create).ToArray());
                case "DeclarationPreamble": return new CstDeclarationPreamble(node.Children.Select(Create).ToArray());
                case "Default": return new CstDefault(node.Children.Select(Create).ToArray());
                case "DoWhileStatement": return new CstDoWhileStatement(node.Children.Select(Create).ToArray());
                case "Element": return new CstElement(node.Children.Select(Create).ToArray());
                case "ElseClause": return new CstElseClause(node.Children.Select(Create).ToArray());
                case "Expression": return new CstExpression(node.Children.Select(Create).ToArray());
                case "ExpressionBody": return new CstExpressionBody(node.Children.Select(Create).ToArray());
                case "ExpressionStatement": return new CstExpressionStatement(node.Children.Select(Create).ToArray());
                case "FieldDeclaration": return new CstFieldDeclaration(node.Children.Select(Create).ToArray());
                case "File": return new CstFile(node.Children.Select(Create).ToArray());
                case "FileStructure": return new CstFileStructure(node.Children.Select(Create).ToArray());
                case "FinallyClause": return new CstFinallyClause(node.Children.Select(Create).ToArray());
                case "FloatLiteral": return new CstFloatLiteral(node.Contents);
                case "ForEachStatement": return new CstForEachStatement(node.Children.Select(Create).ToArray());
                case "ForLoopInit": return new CstForLoopInit(node.Children.Select(Create).ToArray());
                case "ForLoopInvariant": return new CstForLoopInvariant(node.Children.Select(Create).ToArray());
                case "ForLoopVariant": return new CstForLoopVariant(node.Children.Select(Create).ToArray());
                case "ForStatement": return new CstForStatement(node.Children.Select(Create).ToArray());
                case "FunctionArg": return new CstFunctionArg(node.Children.Select(Create).ToArray());
                case "FunctionArgKeyword": return new CstFunctionArgKeyword(node.Contents);
                case "FunctionArgs": return new CstFunctionArgs(node.Children.Select(Create).ToArray());
                case "FunctionBody": return new CstFunctionBody(node.Children.Select(Create).ToArray());
                case "FunctionDeclStatement": return new CstFunctionDeclStatement(node.Children.Select(Create).ToArray());
                case "FunctionParameter": return new CstFunctionParameter(node.Children.Select(Create).ToArray());
                case "FunctionParameterDefaultValue": return new CstFunctionParameterDefaultValue(node.Children.Select(Create).ToArray());
                case "FunctionParameterKeywords": return new CstFunctionParameterKeywords(node.Contents);
                case "FunctionParameterList": return new CstFunctionParameterList(node.Children.Select(Create).ToArray());
                case "Getter": return new CstGetter(node.Children.Select(Create).ToArray());
                case "HexLiteral": return new CstHexLiteral(node.Contents);
                case "Identifier": return new CstIdentifier(node.Contents);
                case "IfStatement": return new CstIfStatement(node.Children.Select(Create).ToArray());
                case "ImplicitOrExplicit": return new CstImplicitOrExplicit(node.Contents);
                case "Indexer": return new CstIndexer(node.Children.Select(Create).ToArray());
                case "IndexerDeclaration": return new CstIndexerDeclaration(node.Children.Select(Create).ToArray());
                case "Initialization": return new CstInitialization(node.Children.Select(Create).ToArray());
                case "InitializationValue": return new CstInitializationValue(node.Children.Select(Create).ToArray());
                case "Initializer": return new CstInitializer(node.Children.Select(Create).ToArray());
                case "InitializerClause": return new CstInitializerClause(node.Children.Select(Create).ToArray());
                case "Initter": return new CstInitter(node.Children.Select(Create).ToArray());
                case "InnerExpression": return new CstInnerExpression(node.Children.Select(Create).ToArray());
                case "InnerTypeExpr": return new CstInnerTypeExpr(node.Children.Select(Create).ToArray());
                case "IntegerLiteral": return new CstIntegerLiteral(node.Contents);
                case "IsOperation": return new CstIsOperation(node.Children.Select(Create).ToArray());
                case "Kind": return new CstKind(node.Contents);
                case "LambdaBody": return new CstLambdaBody(node.Children.Select(Create).ToArray());
                case "LambdaExpr": return new CstLambdaExpr(node.Children.Select(Create).ToArray());
                case "LambdaParameter": return new CstLambdaParameter(node.Children.Select(Create).ToArray());
                case "LambdaParameters": return new CstLambdaParameters(node.Children.Select(Create).ToArray());
                case "LeafExpression": return new CstLeafExpression(node.Children.Select(Create).ToArray());
                case "Literal": return new CstLiteral(node.Children.Select(Create).ToArray());
                case "MemberAccess": return new CstMemberAccess(node.Children.Select(Create).ToArray());
                case "MemberDeclaration": return new CstMemberDeclaration(node.Children.Select(Create).ToArray());
                case "MethodDeclaration": return new CstMethodDeclaration(node.Children.Select(Create).ToArray());
                case "Modifier": return new CstModifier(node.Contents);
                case "NameOf": return new CstNameOf(node.Children.Select(Create).ToArray());
                case "NamespaceDeclaration": return new CstNamespaceDeclaration(node.Children.Select(Create).ToArray());
                case "NewOperation": return new CstNewOperation(node.Children.Select(Create).ToArray());
                case "Nullable": return new CstNullable(node.Contents);
                case "NullLiteral": return new CstNullLiteral(node.Contents);
                case "OperatorDeclaration": return new CstOperatorDeclaration(node.Children.Select(Create).ToArray());
                case "OverloadableOperator": return new CstOverloadableOperator(node.Contents);
                case "ParenthesizedExpression": return new CstParenthesizedExpression(node.Children.Select(Create).ToArray());
                case "ParenthesizedStructure": return new CstParenthesizedStructure(node.Children.Select(Create).ToArray());
                case "PostfixOperator": return new CstPostfixOperator(node.Children.Select(Create).ToArray());
                case "PrefixOperator": return new CstPrefixOperator(node.Contents);
                case "PropertyBody": return new CstPropertyBody(node.Children.Select(Create).ToArray());
                case "PropertyClauses": return new CstPropertyClauses(node.Children.Select(Create).ToArray());
                case "PropertyDeclaration": return new CstPropertyDeclaration(node.Children.Select(Create).ToArray());
                case "PropertyExpression": return new CstPropertyExpression(node.Children.Select(Create).ToArray());
                case "PropertyWithClauses": return new CstPropertyWithClauses(node.Children.Select(Create).ToArray());
                case "QualifiedIdentifier": return new CstQualifiedIdentifier(node.Children.Select(Create).ToArray());
                case "ReturnStatement": return new CstReturnStatement(node.Children.Select(Create).ToArray());
                case "Script": return new CstScript(node.Children.Select(Create).ToArray());
                case "Separator": return new CstSeparator(node.Children.Select(Create).ToArray());
                case "Setter": return new CstSetter(node.Children.Select(Create).ToArray());
                case "SimpleTypExpr": return new CstSimpleTypExpr(node.Children.Select(Create).ToArray());
                case "Statement": return new CstStatement(node.Contents);
                case "StatementKeyword": return new CstStatementKeyword(node.Contents);
                case "StatementStructure": return new CstStatementStructure(node.Children.Select(Create).ToArray());
                case "Static": return new CstStatic(node.Contents);
                case "StringInterpolation": return new CstStringInterpolation(node.Children.Select(Create).ToArray());
                case "StringInterpolationContent": return new CstStringInterpolationContent(node.Children.Select(Create).ToArray());
                case "StringLiteral": return new CstStringLiteral(node.Contents);
                case "Structure": return new CstStructure(node.Contents);
                case "SwitchStatement": return new CstSwitchStatement(node.Children.Select(Create).ToArray());
                case "TernaryOperation": return new CstTernaryOperation(node.Children.Select(Create).ToArray());
                case "ThisCall": return new CstThisCall(node.Children.Select(Create).ToArray());
                case "ThrowExpression": return new CstThrowExpression(node.Children.Select(Create).ToArray());
                case "Token": return new CstToken(node.Children.Select(Create).ToArray());
                case "TokenGroup": return new CstTokenGroup(node.Children.Select(Create).ToArray());
                case "TryStatement": return new CstTryStatement(node.Children.Select(Create).ToArray());
                case "TypeArgList": return new CstTypeArgList(node.Children.Select(Create).ToArray());
                case "TypeDeclaration": return new CstTypeDeclaration(node.Contents);
                case "TypeDeclarationWithPreamble": return new CstTypeDeclarationWithPreamble(node.Children.Select(Create).ToArray());
                case "TypeDirectiveOrStatement": return new CstTypeDirectiveOrStatement(node.Children.Select(Create).ToArray());
                case "TypeExpr": return new CstTypeExpr(node.Children.Select(Create).ToArray());
                case "TypeKeyword": return new CstTypeKeyword(node.Contents);
                case "TypeOf": return new CstTypeOf(node.Children.Select(Create).ToArray());
                case "TypeParameter": return new CstTypeParameter(node.Children.Select(Create).ToArray());
                case "TypeParameterList": return new CstTypeParameterList(node.Children.Select(Create).ToArray());
                case "TypeStructure": return new CstTypeStructure(node.Children.Select(Create).ToArray());
                case "TypeVariance": return new CstTypeVariance(node.Contents);
                case "UsingDirective": return new CstUsingDirective(node.Children.Select(Create).ToArray());
                case "VarDecl": return new CstVarDecl(node.Children.Select(Create).ToArray());
                case "VarDeclStatement": return new CstVarDeclStatement(node.Children.Select(Create).ToArray());
                case "VarWithInitialization": return new CstVarWithInitialization(node.Children.Select(Create).ToArray());
                case "WhileStatement": return new CstWhileStatement(node.Children.Select(Create).ToArray());
                case "YieldBreak": return new CstYieldBreak(node.Contents);
                case "YieldReturn": return new CstYieldReturn(node.Children.Select(Create).ToArray());
                case "YieldStatement": return new CstYieldStatement(node.Children.Select(Create).ToArray());
                default: throw new Exception($"Unrecognized parse node {node.Type}");
            }
        }
    }
}
