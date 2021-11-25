﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

#nullable enable

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Framework.Metadata;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Validation.Schema;
using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.IO.Packaging;

namespace DocumentFormat.OpenXml.Math
{
    /// <summary>
    /// <para>Script.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:scr.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("m:scr")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class Script : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the Script class.
        /// </summary>
        public Script() : base()
        {
        }

        /// <summary>
        /// <para>Value</para>
        /// <para>Represents the following attribute in the schema: m:val</para>
        /// </summary>
        /// <remark>
        /// xmlns:m=http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("m:val")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Math.ScriptValues>? Val
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Math.ScriptValues>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("m:scr");
            builder.AddElement<Script>()
.AddAttribute("m:val", a => a.Val, aBuilder =>
{
    aBuilder.AddValidator(RequiredValidator.Instance);
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Script>(deep);
    }

    /// <summary>
    /// <para>style.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:sty.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("m:sty")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class Style : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the Style class.
        /// </summary>
        public Style() : base()
        {
        }

        /// <summary>
        /// <para>Value</para>
        /// <para>Represents the following attribute in the schema: m:val</para>
        /// </summary>
        /// <remark>
        /// xmlns:m=http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("m:val")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Math.StyleValues>? Val
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Math.StyleValues>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("m:sty");
            builder.AddElement<Style>()
.AddAttribute("m:val", a => a.Val, aBuilder =>
{
    aBuilder.AddValidator(RequiredValidator.Instance);
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Style>(deep);
    }

    /// <summary>
    /// <para>Defines the Run Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:r.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.RunProperties" /> <c>&lt;m:rPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.Text" /> <c>&lt;m:t></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.Break" /> <c>&lt;w:br></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.Drawing" /> <c>&lt;w:drawing></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.NoBreakHyphen" /> <c>&lt;w:noBreakHyphen></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.SoftHyphen" /> <c>&lt;w:softHyphen></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.DayShort" /> <c>&lt;w:dayShort></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.MonthShort" /> <c>&lt;w:monthShort></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.YearShort" /> <c>&lt;w:yearShort></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.DayLong" /> <c>&lt;w:dayLong></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.MonthLong" /> <c>&lt;w:monthLong></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.YearLong" /> <c>&lt;w:yearLong></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.AnnotationReferenceMark" /> <c>&lt;w:annotationRef></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.FootnoteReferenceMark" /> <c>&lt;w:footnoteRef></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.EndnoteReferenceMark" /> <c>&lt;w:endnoteRef></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.SeparatorMark" /> <c>&lt;w:separator></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.ContinuationSeparatorMark" /> <c>&lt;w:continuationSeparator></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.PageNumber" /> <c>&lt;w:pgNum></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.CarriageReturn" /> <c>&lt;w:cr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.TabChar" /> <c>&lt;w:tab></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.LastRenderedPageBreak" /> <c>&lt;w:lastRenderedPageBreak></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.FieldChar" /> <c>&lt;w:fldChar></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.FootnoteReference" /> <c>&lt;w:footnoteReference></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.EndnoteReference" /> <c>&lt;w:endnoteReference></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.CommentReference" /> <c>&lt;w:commentReference></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.EmbeddedObject" /> <c>&lt;w:object></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.Picture" /> <c>&lt;w:pict></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.PositionalTab" /> <c>&lt;w:ptab></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.RunProperties" /> <c>&lt;w:rPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.Ruby" /> <c>&lt;w:ruby></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.SymbolChar" /> <c>&lt;w:sym></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.Text" /> <c>&lt;w:t></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.DeletedText" /> <c>&lt;w:delText></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.FieldCode" /> <c>&lt;w:instrText></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.DeletedFieldCode" /> <c>&lt;w:delInstrText></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("m:r")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class Run : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Run class.
        /// </summary>
        public Run() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Run class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Run(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Run class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Run(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Run class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Run(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("m:r");
            builder.AddChild<DocumentFormat.OpenXml.Math.RunProperties>();
            builder.AddChild<DocumentFormat.OpenXml.Math.Text>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.Break>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.Drawing>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.NoBreakHyphen>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.SoftHyphen>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.DayShort>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.MonthShort>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.YearShort>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.DayLong>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.MonthLong>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.YearLong>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.AnnotationReferenceMark>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.FootnoteReferenceMark>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.EndnoteReferenceMark>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.SeparatorMark>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.ContinuationSeparatorMark>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.PageNumber>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.CarriageReturn>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.TabChar>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.LastRenderedPageBreak>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.FieldChar>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.FootnoteReference>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.EndnoteReference>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.CommentReference>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.EmbeddedObject>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.Picture>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.PositionalTab>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.RunProperties>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.Ruby>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.SymbolChar>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.Text>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.DeletedText>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.FieldCode>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.DeletedFieldCode>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.RunProperties), 0, 1),
                new CompositeParticle.Builder(ParticleType.Group, 0, 1)
                {
                    new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.RunProperties), 0, 1)
                    }
                },
                new CompositeParticle.Builder(ParticleType.Choice, 0, 0)
                {
                    new CompositeParticle.Builder(ParticleType.Group, 1, 1)
                    {
                        new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                        {
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.Break), 1, 1),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.Text), 1, 1),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.DeletedText), 1, 1),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.FieldCode), 1, 1),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.DeletedFieldCode), 1, 1),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.NoBreakHyphen), 1, 1),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.SoftHyphen), 0, 1),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.DayShort), 0, 1),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.MonthShort), 0, 1),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.YearShort), 0, 1),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.DayLong), 0, 1),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.MonthLong), 0, 1),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.YearLong), 0, 1),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.AnnotationReferenceMark), 0, 1),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.FootnoteReferenceMark), 0, 1),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.EndnoteReferenceMark), 0, 1),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.SeparatorMark), 0, 1),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.ContinuationSeparatorMark), 0, 1),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.SymbolChar), 0, 1),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.PageNumber), 0, 1),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CarriageReturn), 0, 1),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.TabChar), 0, 1),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.EmbeddedObject), 1, 1),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.Picture), 1, 1),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.FieldChar), 1, 1),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.Ruby), 1, 1),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.FootnoteReference), 1, 1),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.EndnoteReference), 1, 1),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CommentReference), 1, 1),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.Drawing), 1, 1),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.PositionalTab), 0, 1),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.LastRenderedPageBreak), 0, 1)
                        }
                    },
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Text), 0, 1)
                }
            };
        }

        /// <summary>
        /// <para>Run Properties.</para>
        /// <para>Represents the following element tag in the schema: m:rPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public DocumentFormat.OpenXml.Math.RunProperties? MathRunProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Math.RunProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Run Properties.</para>
        /// <para>Represents the following element tag in the schema: w:rPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:w = http://schemas.openxmlformats.org/wordprocessingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Wordprocessing.RunProperties? RunProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Wordprocessing.RunProperties>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Run>(deep);
    }

    /// <summary>
    /// <para>Accent.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:acc.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.AccentProperties" /> <c>&lt;m:accPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.Base" /> <c>&lt;m:e></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("m:acc")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class Accent : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Accent class.
        /// </summary>
        public Accent() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Accent class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Accent(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Accent class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Accent(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Accent class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Accent(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("m:acc");
            builder.AddChild<DocumentFormat.OpenXml.Math.AccentProperties>();
            builder.AddChild<DocumentFormat.OpenXml.Math.Base>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.AccentProperties), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Base), 1, 1)
            };
        }

        /// <summary>
        /// <para>Accent Properties.</para>
        /// <para>Represents the following element tag in the schema: m:accPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public DocumentFormat.OpenXml.Math.AccentProperties? AccentProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Math.AccentProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Base.</para>
        /// <para>Represents the following element tag in the schema: m:e.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public DocumentFormat.OpenXml.Math.Base? Base
        {
            get => GetElement<DocumentFormat.OpenXml.Math.Base>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Accent>(deep);
    }

    /// <summary>
    /// <para>Bar.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:bar.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.BarProperties" /> <c>&lt;m:barPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.Base" /> <c>&lt;m:e></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("m:bar")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class Bar : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Bar class.
        /// </summary>
        public Bar() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Bar class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Bar(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Bar class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Bar(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Bar class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Bar(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("m:bar");
            builder.AddChild<DocumentFormat.OpenXml.Math.BarProperties>();
            builder.AddChild<DocumentFormat.OpenXml.Math.Base>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.BarProperties), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Base), 1, 1)
            };
        }

        /// <summary>
        /// <para>Bar Properties.</para>
        /// <para>Represents the following element tag in the schema: m:barPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public DocumentFormat.OpenXml.Math.BarProperties? BarProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Math.BarProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Base.</para>
        /// <para>Represents the following element tag in the schema: m:e.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public DocumentFormat.OpenXml.Math.Base? Base
        {
            get => GetElement<DocumentFormat.OpenXml.Math.Base>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Bar>(deep);
    }

    /// <summary>
    /// <para>Box Function.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:box.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.BoxProperties" /> <c>&lt;m:boxPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.Base" /> <c>&lt;m:e></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("m:box")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class Box : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Box class.
        /// </summary>
        public Box() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Box class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Box(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Box class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Box(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Box class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Box(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("m:box");
            builder.AddChild<DocumentFormat.OpenXml.Math.BoxProperties>();
            builder.AddChild<DocumentFormat.OpenXml.Math.Base>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.BoxProperties), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Base), 1, 1)
            };
        }

        /// <summary>
        /// <para>Box Properties.</para>
        /// <para>Represents the following element tag in the schema: m:boxPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public DocumentFormat.OpenXml.Math.BoxProperties? BoxProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Math.BoxProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Base.</para>
        /// <para>Represents the following element tag in the schema: m:e.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public DocumentFormat.OpenXml.Math.Base? Base
        {
            get => GetElement<DocumentFormat.OpenXml.Math.Base>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Box>(deep);
    }

    /// <summary>
    /// <para>Border-Box Function.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:borderBox.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.BorderBoxProperties" /> <c>&lt;m:borderBoxPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.Base" /> <c>&lt;m:e></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("m:borderBox")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class BorderBox : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the BorderBox class.
        /// </summary>
        public BorderBox() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the BorderBox class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public BorderBox(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the BorderBox class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public BorderBox(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the BorderBox class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public BorderBox(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("m:borderBox");
            builder.AddChild<DocumentFormat.OpenXml.Math.BorderBoxProperties>();
            builder.AddChild<DocumentFormat.OpenXml.Math.Base>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.BorderBoxProperties), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Base), 1, 1)
            };
        }

        /// <summary>
        /// <para>Border Box Properties.</para>
        /// <para>Represents the following element tag in the schema: m:borderBoxPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public DocumentFormat.OpenXml.Math.BorderBoxProperties? BorderBoxProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Math.BorderBoxProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Base.</para>
        /// <para>Represents the following element tag in the schema: m:e.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public DocumentFormat.OpenXml.Math.Base? Base
        {
            get => GetElement<DocumentFormat.OpenXml.Math.Base>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<BorderBox>(deep);
    }

    /// <summary>
    /// <para>Delimiter Function.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:d.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.DelimiterProperties" /> <c>&lt;m:dPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.Base" /> <c>&lt;m:e></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("m:d")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class Delimiter : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Delimiter class.
        /// </summary>
        public Delimiter() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Delimiter class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Delimiter(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Delimiter class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Delimiter(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Delimiter class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Delimiter(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("m:d");
            builder.AddChild<DocumentFormat.OpenXml.Math.DelimiterProperties>();
            builder.AddChild<DocumentFormat.OpenXml.Math.Base>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.DelimiterProperties), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Base), 1, 64)
            };
        }

        /// <summary>
        /// <para>Delimiter Properties.</para>
        /// <para>Represents the following element tag in the schema: m:dPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public DocumentFormat.OpenXml.Math.DelimiterProperties? DelimiterProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Math.DelimiterProperties>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Delimiter>(deep);
    }

    /// <summary>
    /// <para>Equation-Array Function.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:eqArr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.EquationArrayProperties" /> <c>&lt;m:eqArrPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.Base" /> <c>&lt;m:e></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("m:eqArr")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class EquationArray : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the EquationArray class.
        /// </summary>
        public EquationArray() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the EquationArray class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public EquationArray(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the EquationArray class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public EquationArray(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the EquationArray class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public EquationArray(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("m:eqArr");
            builder.AddChild<DocumentFormat.OpenXml.Math.EquationArrayProperties>();
            builder.AddChild<DocumentFormat.OpenXml.Math.Base>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.EquationArrayProperties), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Base), 1, 64)
            };
        }

        /// <summary>
        /// <para>Equation Array Properties.</para>
        /// <para>Represents the following element tag in the schema: m:eqArrPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public DocumentFormat.OpenXml.Math.EquationArrayProperties? EquationArrayProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Math.EquationArrayProperties>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<EquationArray>(deep);
    }

    /// <summary>
    /// <para>Fraction Function.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:f.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.FractionProperties" /> <c>&lt;m:fPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.Numerator" /> <c>&lt;m:num></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.Denominator" /> <c>&lt;m:den></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("m:f")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class Fraction : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Fraction class.
        /// </summary>
        public Fraction() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Fraction class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Fraction(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Fraction class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Fraction(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Fraction class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Fraction(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("m:f");
            builder.AddChild<DocumentFormat.OpenXml.Math.FractionProperties>();
            builder.AddChild<DocumentFormat.OpenXml.Math.Numerator>();
            builder.AddChild<DocumentFormat.OpenXml.Math.Denominator>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.FractionProperties), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Numerator), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Denominator), 1, 1)
            };
        }

        /// <summary>
        /// <para>Fraction Properties.</para>
        /// <para>Represents the following element tag in the schema: m:fPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public DocumentFormat.OpenXml.Math.FractionProperties? FractionProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Math.FractionProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Numerator.</para>
        /// <para>Represents the following element tag in the schema: m:num.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public DocumentFormat.OpenXml.Math.Numerator? Numerator
        {
            get => GetElement<DocumentFormat.OpenXml.Math.Numerator>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Denominator.</para>
        /// <para>Represents the following element tag in the schema: m:den.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public DocumentFormat.OpenXml.Math.Denominator? Denominator
        {
            get => GetElement<DocumentFormat.OpenXml.Math.Denominator>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Fraction>(deep);
    }

    /// <summary>
    /// <para>Function Apply Function.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:func.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.FunctionProperties" /> <c>&lt;m:funcPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.FunctionName" /> <c>&lt;m:fName></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.Base" /> <c>&lt;m:e></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("m:func")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class MathFunction : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the MathFunction class.
        /// </summary>
        public MathFunction() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the MathFunction class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public MathFunction(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the MathFunction class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public MathFunction(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the MathFunction class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public MathFunction(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("m:func");
            builder.AddChild<DocumentFormat.OpenXml.Math.FunctionProperties>();
            builder.AddChild<DocumentFormat.OpenXml.Math.FunctionName>();
            builder.AddChild<DocumentFormat.OpenXml.Math.Base>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.FunctionProperties), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.FunctionName), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Base), 1, 1)
            };
        }

        /// <summary>
        /// <para>Function Properties.</para>
        /// <para>Represents the following element tag in the schema: m:funcPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public DocumentFormat.OpenXml.Math.FunctionProperties? FunctionProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Math.FunctionProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Function Name.</para>
        /// <para>Represents the following element tag in the schema: m:fName.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public DocumentFormat.OpenXml.Math.FunctionName? FunctionName
        {
            get => GetElement<DocumentFormat.OpenXml.Math.FunctionName>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Base (Argument).</para>
        /// <para>Represents the following element tag in the schema: m:e.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public DocumentFormat.OpenXml.Math.Base? Base
        {
            get => GetElement<DocumentFormat.OpenXml.Math.Base>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<MathFunction>(deep);
    }

    /// <summary>
    /// <para>Group-Character Function.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:groupChr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.GroupCharProperties" /> <c>&lt;m:groupChrPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.Base" /> <c>&lt;m:e></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("m:groupChr")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class GroupChar : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the GroupChar class.
        /// </summary>
        public GroupChar() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the GroupChar class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public GroupChar(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the GroupChar class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public GroupChar(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the GroupChar class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public GroupChar(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("m:groupChr");
            builder.AddChild<DocumentFormat.OpenXml.Math.GroupCharProperties>();
            builder.AddChild<DocumentFormat.OpenXml.Math.Base>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.GroupCharProperties), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Base), 1, 1)
            };
        }

        /// <summary>
        /// <para>Group-Character Properties.</para>
        /// <para>Represents the following element tag in the schema: m:groupChrPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public DocumentFormat.OpenXml.Math.GroupCharProperties? GroupCharProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Math.GroupCharProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Base.</para>
        /// <para>Represents the following element tag in the schema: m:e.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public DocumentFormat.OpenXml.Math.Base? Base
        {
            get => GetElement<DocumentFormat.OpenXml.Math.Base>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<GroupChar>(deep);
    }

    /// <summary>
    /// <para>Lower-Limit Function.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:limLow.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.LimitLowerProperties" /> <c>&lt;m:limLowPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.Base" /> <c>&lt;m:e></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.Limit" /> <c>&lt;m:lim></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("m:limLow")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class LimitLower : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the LimitLower class.
        /// </summary>
        public LimitLower() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the LimitLower class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public LimitLower(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the LimitLower class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public LimitLower(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the LimitLower class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public LimitLower(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("m:limLow");
            builder.AddChild<DocumentFormat.OpenXml.Math.LimitLowerProperties>();
            builder.AddChild<DocumentFormat.OpenXml.Math.Base>();
            builder.AddChild<DocumentFormat.OpenXml.Math.Limit>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.LimitLowerProperties), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Base), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Limit), 1, 1)
            };
        }

        /// <summary>
        /// <para>Lower Limit Properties.</para>
        /// <para>Represents the following element tag in the schema: m:limLowPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public DocumentFormat.OpenXml.Math.LimitLowerProperties? LimitLowerProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Math.LimitLowerProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Base.</para>
        /// <para>Represents the following element tag in the schema: m:e.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public DocumentFormat.OpenXml.Math.Base? Base
        {
            get => GetElement<DocumentFormat.OpenXml.Math.Base>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Limit (Lower).</para>
        /// <para>Represents the following element tag in the schema: m:lim.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public DocumentFormat.OpenXml.Math.Limit? Limit
        {
            get => GetElement<DocumentFormat.OpenXml.Math.Limit>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<LimitLower>(deep);
    }

    /// <summary>
    /// <para>Upper-Limit Function.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:limUpp.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.LimitUpperProperties" /> <c>&lt;m:limUppPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.Base" /> <c>&lt;m:e></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.Limit" /> <c>&lt;m:lim></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("m:limUpp")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class LimitUpper : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the LimitUpper class.
        /// </summary>
        public LimitUpper() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the LimitUpper class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public LimitUpper(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the LimitUpper class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public LimitUpper(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the LimitUpper class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public LimitUpper(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("m:limUpp");
            builder.AddChild<DocumentFormat.OpenXml.Math.LimitUpperProperties>();
            builder.AddChild<DocumentFormat.OpenXml.Math.Base>();
            builder.AddChild<DocumentFormat.OpenXml.Math.Limit>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.LimitUpperProperties), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Base), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Limit), 1, 1)
            };
        }

        /// <summary>
        /// <para>Upper Limit Properties.</para>
        /// <para>Represents the following element tag in the schema: m:limUppPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public DocumentFormat.OpenXml.Math.LimitUpperProperties? LimitUpperProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Math.LimitUpperProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Base.</para>
        /// <para>Represents the following element tag in the schema: m:e.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public DocumentFormat.OpenXml.Math.Base? Base
        {
            get => GetElement<DocumentFormat.OpenXml.Math.Base>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Limit (Upper).</para>
        /// <para>Represents the following element tag in the schema: m:lim.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public DocumentFormat.OpenXml.Math.Limit? Limit
        {
            get => GetElement<DocumentFormat.OpenXml.Math.Limit>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<LimitUpper>(deep);
    }

    /// <summary>
    /// <para>Matrix Function.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:m.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.MatrixProperties" /> <c>&lt;m:mPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.MatrixRow" /> <c>&lt;m:mr></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("m:m")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class Matrix : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Matrix class.
        /// </summary>
        public Matrix() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Matrix class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Matrix(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Matrix class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Matrix(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Matrix class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Matrix(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("m:m");
            builder.AddChild<DocumentFormat.OpenXml.Math.MatrixProperties>();
            builder.AddChild<DocumentFormat.OpenXml.Math.MatrixRow>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.MatrixProperties), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.MatrixRow), 1, 256)
            };
        }

        /// <summary>
        /// <para>Matrix Properties.</para>
        /// <para>Represents the following element tag in the schema: m:mPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public DocumentFormat.OpenXml.Math.MatrixProperties? MatrixProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Math.MatrixProperties>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Matrix>(deep);
    }

    /// <summary>
    /// <para>n-ary Operator Function.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:nary.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.NaryProperties" /> <c>&lt;m:naryPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.SubArgument" /> <c>&lt;m:sub></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.SuperArgument" /> <c>&lt;m:sup></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.Base" /> <c>&lt;m:e></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("m:nary")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class Nary : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Nary class.
        /// </summary>
        public Nary() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Nary class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Nary(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Nary class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Nary(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Nary class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Nary(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("m:nary");
            builder.AddChild<DocumentFormat.OpenXml.Math.NaryProperties>();
            builder.AddChild<DocumentFormat.OpenXml.Math.SubArgument>();
            builder.AddChild<DocumentFormat.OpenXml.Math.SuperArgument>();
            builder.AddChild<DocumentFormat.OpenXml.Math.Base>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.NaryProperties), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.SubArgument), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.SuperArgument), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Base), 1, 1)
            };
        }

        /// <summary>
        /// <para>n-ary Properties.</para>
        /// <para>Represents the following element tag in the schema: m:naryPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public DocumentFormat.OpenXml.Math.NaryProperties? NaryProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Math.NaryProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Lower limit (n-ary) .</para>
        /// <para>Represents the following element tag in the schema: m:sub.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public DocumentFormat.OpenXml.Math.SubArgument? SubArgument
        {
            get => GetElement<DocumentFormat.OpenXml.Math.SubArgument>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Upper limit (n-ary).</para>
        /// <para>Represents the following element tag in the schema: m:sup.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public DocumentFormat.OpenXml.Math.SuperArgument? SuperArgument
        {
            get => GetElement<DocumentFormat.OpenXml.Math.SuperArgument>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Base (Argument).</para>
        /// <para>Represents the following element tag in the schema: m:e.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public DocumentFormat.OpenXml.Math.Base? Base
        {
            get => GetElement<DocumentFormat.OpenXml.Math.Base>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Nary>(deep);
    }

    /// <summary>
    /// <para>Phantom Function.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:phant.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.Base" /> <c>&lt;m:e></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.PhantomProperties" /> <c>&lt;m:phantPr></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("m:phant")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class Phantom : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Phantom class.
        /// </summary>
        public Phantom() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Phantom class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Phantom(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Phantom class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Phantom(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Phantom class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Phantom(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("m:phant");
            builder.AddChild<DocumentFormat.OpenXml.Math.Base>();
            builder.AddChild<DocumentFormat.OpenXml.Math.PhantomProperties>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.PhantomProperties), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Base), 1, 1)
            };
        }

        /// <summary>
        /// <para>Phantom Properties.</para>
        /// <para>Represents the following element tag in the schema: m:phantPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public DocumentFormat.OpenXml.Math.PhantomProperties? PhantomProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Math.PhantomProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Base.</para>
        /// <para>Represents the following element tag in the schema: m:e.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public DocumentFormat.OpenXml.Math.Base? Base
        {
            get => GetElement<DocumentFormat.OpenXml.Math.Base>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Phantom>(deep);
    }

    /// <summary>
    /// <para>Radical Function.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:rad.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.Degree" /> <c>&lt;m:deg></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.Base" /> <c>&lt;m:e></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.RadicalProperties" /> <c>&lt;m:radPr></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("m:rad")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class Radical : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Radical class.
        /// </summary>
        public Radical() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Radical class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Radical(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Radical class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Radical(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Radical class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Radical(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("m:rad");
            builder.AddChild<DocumentFormat.OpenXml.Math.Degree>();
            builder.AddChild<DocumentFormat.OpenXml.Math.Base>();
            builder.AddChild<DocumentFormat.OpenXml.Math.RadicalProperties>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.RadicalProperties), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Degree), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Base), 1, 1)
            };
        }

        /// <summary>
        /// <para>Radical Properties.</para>
        /// <para>Represents the following element tag in the schema: m:radPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public DocumentFormat.OpenXml.Math.RadicalProperties? RadicalProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Math.RadicalProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Degree.</para>
        /// <para>Represents the following element tag in the schema: m:deg.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public DocumentFormat.OpenXml.Math.Degree? Degree
        {
            get => GetElement<DocumentFormat.OpenXml.Math.Degree>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Base.</para>
        /// <para>Represents the following element tag in the schema: m:e.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public DocumentFormat.OpenXml.Math.Base? Base
        {
            get => GetElement<DocumentFormat.OpenXml.Math.Base>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Radical>(deep);
    }

    /// <summary>
    /// <para>Pre-Sub-Superscript Function.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:sPre.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.SubArgument" /> <c>&lt;m:sub></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.SuperArgument" /> <c>&lt;m:sup></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.Base" /> <c>&lt;m:e></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.PreSubSuperProperties" /> <c>&lt;m:sPrePr></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("m:sPre")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class PreSubSuper : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the PreSubSuper class.
        /// </summary>
        public PreSubSuper() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the PreSubSuper class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public PreSubSuper(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PreSubSuper class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public PreSubSuper(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PreSubSuper class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public PreSubSuper(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("m:sPre");
            builder.AddChild<DocumentFormat.OpenXml.Math.SubArgument>();
            builder.AddChild<DocumentFormat.OpenXml.Math.SuperArgument>();
            builder.AddChild<DocumentFormat.OpenXml.Math.Base>();
            builder.AddChild<DocumentFormat.OpenXml.Math.PreSubSuperProperties>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.PreSubSuperProperties), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.SubArgument), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.SuperArgument), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Base), 1, 1)
            };
        }

        /// <summary>
        /// <para>Pre-Sub-Superscript Properties.</para>
        /// <para>Represents the following element tag in the schema: m:sPrePr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public DocumentFormat.OpenXml.Math.PreSubSuperProperties? PreSubSuperProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Math.PreSubSuperProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Subscript (Pre-Sub-Superscript).</para>
        /// <para>Represents the following element tag in the schema: m:sub.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public DocumentFormat.OpenXml.Math.SubArgument? SubArgument
        {
            get => GetElement<DocumentFormat.OpenXml.Math.SubArgument>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Superscript(Pre-Sub-Superscript function).</para>
        /// <para>Represents the following element tag in the schema: m:sup.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public DocumentFormat.OpenXml.Math.SuperArgument? SuperArgument
        {
            get => GetElement<DocumentFormat.OpenXml.Math.SuperArgument>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Base.</para>
        /// <para>Represents the following element tag in the schema: m:e.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public DocumentFormat.OpenXml.Math.Base? Base
        {
            get => GetElement<DocumentFormat.OpenXml.Math.Base>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<PreSubSuper>(deep);
    }

    /// <summary>
    /// <para>Subscript Function.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:sSub.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.Base" /> <c>&lt;m:e></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.SubArgument" /> <c>&lt;m:sub></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.SubscriptProperties" /> <c>&lt;m:sSubPr></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("m:sSub")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class Subscript : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Subscript class.
        /// </summary>
        public Subscript() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Subscript class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Subscript(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Subscript class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Subscript(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Subscript class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Subscript(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("m:sSub");
            builder.AddChild<DocumentFormat.OpenXml.Math.Base>();
            builder.AddChild<DocumentFormat.OpenXml.Math.SubArgument>();
            builder.AddChild<DocumentFormat.OpenXml.Math.SubscriptProperties>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.SubscriptProperties), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Base), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.SubArgument), 1, 1)
            };
        }

        /// <summary>
        /// <para>Subscript Properties.</para>
        /// <para>Represents the following element tag in the schema: m:sSubPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public DocumentFormat.OpenXml.Math.SubscriptProperties? SubscriptProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Math.SubscriptProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Base.</para>
        /// <para>Represents the following element tag in the schema: m:e.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public DocumentFormat.OpenXml.Math.Base? Base
        {
            get => GetElement<DocumentFormat.OpenXml.Math.Base>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Subscript (Subscript function).</para>
        /// <para>Represents the following element tag in the schema: m:sub.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public DocumentFormat.OpenXml.Math.SubArgument? SubArgument
        {
            get => GetElement<DocumentFormat.OpenXml.Math.SubArgument>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Subscript>(deep);
    }

    /// <summary>
    /// <para>Sub-Superscript Function.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:sSubSup.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.Base" /> <c>&lt;m:e></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.SubArgument" /> <c>&lt;m:sub></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.SuperArgument" /> <c>&lt;m:sup></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.SubSuperscriptProperties" /> <c>&lt;m:sSubSupPr></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("m:sSubSup")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class SubSuperscript : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the SubSuperscript class.
        /// </summary>
        public SubSuperscript() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the SubSuperscript class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SubSuperscript(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SubSuperscript class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SubSuperscript(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SubSuperscript class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public SubSuperscript(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("m:sSubSup");
            builder.AddChild<DocumentFormat.OpenXml.Math.Base>();
            builder.AddChild<DocumentFormat.OpenXml.Math.SubArgument>();
            builder.AddChild<DocumentFormat.OpenXml.Math.SuperArgument>();
            builder.AddChild<DocumentFormat.OpenXml.Math.SubSuperscriptProperties>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.SubSuperscriptProperties), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Base), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.SubArgument), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.SuperArgument), 1, 1)
            };
        }

        /// <summary>
        /// <para>Sub-Superscript Properties.</para>
        /// <para>Represents the following element tag in the schema: m:sSubSupPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public DocumentFormat.OpenXml.Math.SubSuperscriptProperties? SubSuperscriptProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Math.SubSuperscriptProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Base.</para>
        /// <para>Represents the following element tag in the schema: m:e.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public DocumentFormat.OpenXml.Math.Base? Base
        {
            get => GetElement<DocumentFormat.OpenXml.Math.Base>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Subscript (Sub-Superscript).</para>
        /// <para>Represents the following element tag in the schema: m:sub.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public DocumentFormat.OpenXml.Math.SubArgument? SubArgument
        {
            get => GetElement<DocumentFormat.OpenXml.Math.SubArgument>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Superscript (Sub-Superscript function).</para>
        /// <para>Represents the following element tag in the schema: m:sup.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public DocumentFormat.OpenXml.Math.SuperArgument? SuperArgument
        {
            get => GetElement<DocumentFormat.OpenXml.Math.SuperArgument>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SubSuperscript>(deep);
    }

    /// <summary>
    /// <para>Superscript Function.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:sSup.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.Base" /> <c>&lt;m:e></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.SuperArgument" /> <c>&lt;m:sup></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.SuperscriptProperties" /> <c>&lt;m:sSupPr></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("m:sSup")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class Superscript : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Superscript class.
        /// </summary>
        public Superscript() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Superscript class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Superscript(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Superscript class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Superscript(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Superscript class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Superscript(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("m:sSup");
            builder.AddChild<DocumentFormat.OpenXml.Math.Base>();
            builder.AddChild<DocumentFormat.OpenXml.Math.SuperArgument>();
            builder.AddChild<DocumentFormat.OpenXml.Math.SuperscriptProperties>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.SuperscriptProperties), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Base), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.SuperArgument), 1, 1)
            };
        }

        /// <summary>
        /// <para>Superscript Properties.</para>
        /// <para>Represents the following element tag in the schema: m:sSupPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public DocumentFormat.OpenXml.Math.SuperscriptProperties? SuperscriptProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Math.SuperscriptProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Base.</para>
        /// <para>Represents the following element tag in the schema: m:e.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public DocumentFormat.OpenXml.Math.Base? Base
        {
            get => GetElement<DocumentFormat.OpenXml.Math.Base>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Superscript (Superscript function).</para>
        /// <para>Represents the following element tag in the schema: m:sup.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public DocumentFormat.OpenXml.Math.SuperArgument? SuperArgument
        {
            get => GetElement<DocumentFormat.OpenXml.Math.SuperArgument>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Superscript>(deep);
    }

    /// <summary>
    /// <para>Defines the Paragraph Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:oMathPara.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.OfficeMath" /> <c>&lt;m:oMath></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.ParagraphProperties" /> <c>&lt;m:oMathParaPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.Run" /> <c>&lt;m:r></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.BookmarkStart" /> <c>&lt;w:bookmarkStart></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.ContentPart" /> <c>&lt;w:contentPart></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeEnd" /> <c>&lt;w:customXmlInsRangeEnd></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeEnd" /> <c>&lt;w:customXmlDelRangeEnd></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeEnd" /> <c>&lt;w:customXmlMoveFromRangeEnd></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeEnd" /> <c>&lt;w:customXmlMoveToRangeEnd></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictInsertionRangeEnd" /> <c>&lt;w14:customXmlConflictInsRangeEnd></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictDeletionRangeEnd" /> <c>&lt;w14:customXmlConflictDelRangeEnd></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.BookmarkEnd" /> <c>&lt;w:bookmarkEnd></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.CommentRangeStart" /> <c>&lt;w:commentRangeStart></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.CommentRangeEnd" /> <c>&lt;w:commentRangeEnd></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeEnd" /> <c>&lt;w:moveFromRangeEnd></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.MoveToRangeEnd" /> <c>&lt;w:moveToRangeEnd></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeStart" /> <c>&lt;w:moveFromRangeStart></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.MoveToRangeStart" /> <c>&lt;w:moveToRangeStart></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.PermEnd" /> <c>&lt;w:permEnd></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.PermStart" /> <c>&lt;w:permStart></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.ProofError" /> <c>&lt;w:proofErr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.Run" /> <c>&lt;w:r></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.InsertedRun" /> <c>&lt;w:ins></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.DeletedRun" /> <c>&lt;w:del></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.MoveFromRun" /> <c>&lt;w:moveFrom></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.MoveToRun" /> <c>&lt;w:moveTo></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.Word.RunConflictInsertion" /> <c>&lt;w14:conflictIns></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.Word.RunConflictDeletion" /> <c>&lt;w14:conflictDel></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeStart" /> <c>&lt;w:customXmlInsRangeStart></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeStart" /> <c>&lt;w:customXmlDelRangeStart></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeStart" /> <c>&lt;w:customXmlMoveFromRangeStart></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeStart" /> <c>&lt;w:customXmlMoveToRangeStart></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictInsertionRangeStart" /> <c>&lt;w14:customXmlConflictInsRangeStart></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictDeletionRangeStart" /> <c>&lt;w14:customXmlConflictDelRangeStart></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("m:oMathPara")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class Paragraph : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Paragraph class.
        /// </summary>
        public Paragraph() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Paragraph class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Paragraph(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Paragraph class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Paragraph(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Paragraph class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Paragraph(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("m:oMathPara");
            builder.AddChild<DocumentFormat.OpenXml.Math.OfficeMath>();
            builder.AddChild<DocumentFormat.OpenXml.Math.ParagraphProperties>();
            builder.AddChild<DocumentFormat.OpenXml.Math.Run>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.BookmarkStart>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.ContentPart>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeEnd>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeEnd>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeEnd>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeEnd>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictInsertionRangeEnd>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictDeletionRangeEnd>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.BookmarkEnd>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.CommentRangeStart>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.CommentRangeEnd>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeEnd>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.MoveToRangeEnd>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeStart>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.MoveToRangeStart>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.PermEnd>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.PermStart>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.ProofError>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.Run>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.InsertedRun>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.DeletedRun>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.MoveFromRun>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.MoveToRun>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.Word.RunConflictInsertion>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.Word.RunConflictDeletion>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeStart>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeStart>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeStart>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeStart>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictInsertionRangeStart>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictDeletionRangeStart>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.ParagraphProperties), 0, 1),
                new CompositeParticle.Builder(ParticleType.Choice, 1, 0)
                {
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Math.OfficeMath), 1, 0),
                    new CompositeParticle.Builder(ParticleType.Group, 1, 1)
                    {
                        new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                        {
                            new CompositeParticle.Builder(ParticleType.Group, 1, 1)
                            {
                                new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                                {
                                    new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Run), 1, 1)
                                }
                            },
                            new CompositeParticle.Builder(ParticleType.Group, 1, 1)
                            {
                                new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                                {
                                    new CompositeParticle.Builder(ParticleType.Group, 0, 0)
                                    {
                                        new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                                        {
                                            new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.ProofError), 0, 1),
                                            new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.PermStart), 0, 1),
                                            new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.PermEnd), 0, 1)
                                        }
                                    },
                                    new CompositeParticle.Builder(ParticleType.Group, 0, 0)
                                    {
                                        new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                                        {
                                            new CompositeParticle.Builder(ParticleType.Group, 0, 0)
                                            {
                                                new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                                                {
                                                    new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.BookmarkStart), 1, 1),
                                                    new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.BookmarkEnd), 1, 1),
                                                    new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CommentRangeStart), 1, 1),
                                                    new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CommentRangeEnd), 1, 1)
                                                }
                                            },
                                            new CompositeParticle.Builder(ParticleType.Group, 0, 0)
                                            {
                                                new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                                                {
                                                    new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeStart), 1, 1),
                                                    new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeEnd), 1, 1),
                                                    new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.MoveToRangeStart), 1, 1),
                                                    new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.MoveToRangeEnd), 1, 1),
                                                    new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeStart), 1, 1),
                                                    new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeEnd), 1, 1),
                                                    new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeStart), 1, 1),
                                                    new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeEnd), 1, 1),
                                                    new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeStart), 1, 1),
                                                    new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeEnd), 1, 1),
                                                    new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeStart), 1, 1),
                                                    new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeEnd), 1, 1)
                                                }
                                            },
                                            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictInsertionRangeStart), 0, 1, version: FileFormatVersions.Office2010),
                                            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictInsertionRangeEnd), 0, 1, version: FileFormatVersions.Office2010),
                                            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictDeletionRangeStart), 0, 1, version: FileFormatVersions.Office2010),
                                            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictDeletionRangeEnd), 0, 1, version: FileFormatVersions.Office2010)
                                        }
                                    },
                                    new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.InsertedRun), 0, 1),
                                    new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.DeletedRun), 0, 1),
                                    new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.MoveFromRun), 1, 1),
                                    new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.MoveToRun), 1, 1),
                                    new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.ContentPart), 0, 0, version: FileFormatVersions.Office2010),
                                    new CompositeParticle.Builder(ParticleType.Group, 0, 1, version: FileFormatVersions.Office2010)
                                    {
                                        new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
                                        {
                                            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.RunConflictInsertion), 0, 1, version: FileFormatVersions.Office2010),
                                            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.RunConflictDeletion), 0, 1, version: FileFormatVersions.Office2010)
                                        }
                                    }
                                }
                            },
                            new CompositeParticle.Builder(ParticleType.Group, 1, 1)
                            {
                                new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                                {
                                    new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.Run), 1, 1)
                                }
                            }
                        }
                    }
                }
            };
        }

        /// <summary>
        /// <para>Office Math Paragraph Properties.</para>
        /// <para>Represents the following element tag in the schema: m:oMathParaPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public DocumentFormat.OpenXml.Math.ParagraphProperties? ParagraphProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Math.ParagraphProperties>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Paragraph>(deep);
    }

    /// <summary>
    /// <para>Defines the OfficeMath Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:oMath.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.Accent" /> <c>&lt;m:acc></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.Bar" /> <c>&lt;m:bar></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.BorderBox" /> <c>&lt;m:borderBox></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.Box" /> <c>&lt;m:box></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.Delimiter" /> <c>&lt;m:d></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.EquationArray" /> <c>&lt;m:eqArr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.Fraction" /> <c>&lt;m:f></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.MathFunction" /> <c>&lt;m:func></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.GroupChar" /> <c>&lt;m:groupChr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.LimitLower" /> <c>&lt;m:limLow></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.LimitUpper" /> <c>&lt;m:limUpp></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.Matrix" /> <c>&lt;m:m></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.Nary" /> <c>&lt;m:nary></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.OfficeMath" /> <c>&lt;m:oMath></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.Paragraph" /> <c>&lt;m:oMathPara></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.Phantom" /> <c>&lt;m:phant></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.Run" /> <c>&lt;m:r></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.Radical" /> <c>&lt;m:rad></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.PreSubSuper" /> <c>&lt;m:sPre></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.Subscript" /> <c>&lt;m:sSub></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.SubSuperscript" /> <c>&lt;m:sSubSup></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.Superscript" /> <c>&lt;m:sSup></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.BookmarkStart" /> <c>&lt;w:bookmarkStart></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.ContentPart" /> <c>&lt;w:contentPart></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.CustomXmlRun" /> <c>&lt;w:customXml></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.Hyperlink" /> <c>&lt;w:hyperlink></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeEnd" /> <c>&lt;w:customXmlInsRangeEnd></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeEnd" /> <c>&lt;w:customXmlDelRangeEnd></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeEnd" /> <c>&lt;w:customXmlMoveFromRangeEnd></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeEnd" /> <c>&lt;w:customXmlMoveToRangeEnd></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictInsertionRangeEnd" /> <c>&lt;w14:customXmlConflictInsRangeEnd></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictDeletionRangeEnd" /> <c>&lt;w14:customXmlConflictDelRangeEnd></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.BookmarkEnd" /> <c>&lt;w:bookmarkEnd></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.CommentRangeStart" /> <c>&lt;w:commentRangeStart></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.CommentRangeEnd" /> <c>&lt;w:commentRangeEnd></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeEnd" /> <c>&lt;w:moveFromRangeEnd></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.MoveToRangeEnd" /> <c>&lt;w:moveToRangeEnd></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeStart" /> <c>&lt;w:moveFromRangeStart></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.MoveToRangeStart" /> <c>&lt;w:moveToRangeStart></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.PermEnd" /> <c>&lt;w:permEnd></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.PermStart" /> <c>&lt;w:permStart></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.ProofError" /> <c>&lt;w:proofErr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.InsertedRun" /> <c>&lt;w:ins></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.DeletedRun" /> <c>&lt;w:del></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.MoveFromRun" /> <c>&lt;w:moveFrom></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.MoveToRun" /> <c>&lt;w:moveTo></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.Word.RunConflictInsertion" /> <c>&lt;w14:conflictIns></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.Word.RunConflictDeletion" /> <c>&lt;w14:conflictDel></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.SdtRun" /> <c>&lt;w:sdt></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.SimpleField" /> <c>&lt;w:fldSimple></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeStart" /> <c>&lt;w:customXmlInsRangeStart></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeStart" /> <c>&lt;w:customXmlDelRangeStart></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeStart" /> <c>&lt;w:customXmlMoveFromRangeStart></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeStart" /> <c>&lt;w:customXmlMoveToRangeStart></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictInsertionRangeStart" /> <c>&lt;w14:customXmlConflictInsRangeStart></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictDeletionRangeStart" /> <c>&lt;w14:customXmlConflictDelRangeStart></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("m:oMath")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class OfficeMath : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the OfficeMath class.
        /// </summary>
        public OfficeMath() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the OfficeMath class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public OfficeMath(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the OfficeMath class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public OfficeMath(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the OfficeMath class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public OfficeMath(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("m:oMath");
            builder.AddChild<DocumentFormat.OpenXml.Math.Accent>();
            builder.AddChild<DocumentFormat.OpenXml.Math.Bar>();
            builder.AddChild<DocumentFormat.OpenXml.Math.BorderBox>();
            builder.AddChild<DocumentFormat.OpenXml.Math.Box>();
            builder.AddChild<DocumentFormat.OpenXml.Math.Delimiter>();
            builder.AddChild<DocumentFormat.OpenXml.Math.EquationArray>();
            builder.AddChild<DocumentFormat.OpenXml.Math.Fraction>();
            builder.AddChild<DocumentFormat.OpenXml.Math.MathFunction>();
            builder.AddChild<DocumentFormat.OpenXml.Math.GroupChar>();
            builder.AddChild<DocumentFormat.OpenXml.Math.LimitLower>();
            builder.AddChild<DocumentFormat.OpenXml.Math.LimitUpper>();
            builder.AddChild<DocumentFormat.OpenXml.Math.Matrix>();
            builder.AddChild<DocumentFormat.OpenXml.Math.Nary>();
            builder.AddChild<DocumentFormat.OpenXml.Math.OfficeMath>();
            builder.AddChild<DocumentFormat.OpenXml.Math.Paragraph>();
            builder.AddChild<DocumentFormat.OpenXml.Math.Phantom>();
            builder.AddChild<DocumentFormat.OpenXml.Math.Run>();
            builder.AddChild<DocumentFormat.OpenXml.Math.Radical>();
            builder.AddChild<DocumentFormat.OpenXml.Math.PreSubSuper>();
            builder.AddChild<DocumentFormat.OpenXml.Math.Subscript>();
            builder.AddChild<DocumentFormat.OpenXml.Math.SubSuperscript>();
            builder.AddChild<DocumentFormat.OpenXml.Math.Superscript>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.BookmarkStart>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.ContentPart>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.CustomXmlRun>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.Hyperlink>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeEnd>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeEnd>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeEnd>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeEnd>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictInsertionRangeEnd>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictDeletionRangeEnd>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.BookmarkEnd>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.CommentRangeStart>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.CommentRangeEnd>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeEnd>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.MoveToRangeEnd>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeStart>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.MoveToRangeStart>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.PermEnd>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.PermStart>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.ProofError>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.InsertedRun>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.DeletedRun>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.MoveFromRun>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.MoveToRun>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.Word.RunConflictInsertion>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.Word.RunConflictDeletion>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.SdtRun>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.SimpleField>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeStart>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeStart>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeStart>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeStart>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictInsertionRangeStart>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictDeletionRangeStart>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle.Builder(ParticleType.Group, 0, 0)
                {
                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                    {
                        new CompositeParticle.Builder(ParticleType.Group, 1, 1)
                        {
                            new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                            {
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Accent), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Bar), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Box), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.BorderBox), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Delimiter), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.EquationArray), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Fraction), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.MathFunction), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.GroupChar), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.LimitLower), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.LimitUpper), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Matrix), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Nary), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Phantom), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Radical), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.PreSubSuper), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Subscript), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.SubSuperscript), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Superscript), 1, 1),
                                new CompositeParticle.Builder(ParticleType.Group, 1, 1)
                                {
                                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                                    {
                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Run), 1, 1)
                                    }
                                }
                            }
                        },
                        new CompositeParticle.Builder(ParticleType.Group, 1, 1)
                        {
                            new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                            {
                                new CompositeParticle.Builder(ParticleType.Group, 0, 0)
                                {
                                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                                    {
                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlRun), 1, 1),
                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.SimpleField), 0, 0),
                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.Hyperlink), 1, 1)
                                    }
                                },
                                new CompositeParticle.Builder(ParticleType.Group, 0, 0)
                                {
                                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                                    {
                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.SdtRun), 1, 1),
                                        new CompositeParticle.Builder(ParticleType.Group, 0, 0)
                                        {
                                            new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                                            {
                                                new CompositeParticle.Builder(ParticleType.Group, 0, 0)
                                                {
                                                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                                                    {
                                                        new CompositeParticle.Builder(ParticleType.Group, 0, 0)
                                                        {
                                                            new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                                                            {
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.ProofError), 0, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.PermStart), 0, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.PermEnd), 0, 1)
                                                            }
                                                        },
                                                        new CompositeParticle.Builder(ParticleType.Group, 0, 0)
                                                        {
                                                            new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                                                            {
                                                                new CompositeParticle.Builder(ParticleType.Group, 0, 0)
                                                                {
                                                                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                                                                    {
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.BookmarkStart), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.BookmarkEnd), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CommentRangeStart), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CommentRangeEnd), 1, 1)
                                                                    }
                                                                },
                                                                new CompositeParticle.Builder(ParticleType.Group, 0, 0)
                                                                {
                                                                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                                                                    {
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeStart), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeEnd), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.MoveToRangeStart), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.MoveToRangeEnd), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeStart), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeEnd), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeStart), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeEnd), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeStart), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeEnd), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeStart), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeEnd), 1, 1)
                                                                    }
                                                                },
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictInsertionRangeStart), 0, 1, version: FileFormatVersions.Office2010),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictInsertionRangeEnd), 0, 1, version: FileFormatVersions.Office2010),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictDeletionRangeStart), 0, 1, version: FileFormatVersions.Office2010),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictDeletionRangeEnd), 0, 1, version: FileFormatVersions.Office2010)
                                                            }
                                                        },
                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.InsertedRun), 0, 1),
                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.DeletedRun), 0, 1),
                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.MoveFromRun), 1, 1),
                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.MoveToRun), 1, 1),
                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.ContentPart), 0, 0, version: FileFormatVersions.Office2010),
                                                        new CompositeParticle.Builder(ParticleType.Group, 0, 1, version: FileFormatVersions.Office2010)
                                                        {
                                                            new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
                                                            {
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.RunConflictInsertion), 0, 1, version: FileFormatVersions.Office2010),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.RunConflictDeletion), 0, 1, version: FileFormatVersions.Office2010)
                                                            }
                                                        }
                                                    }
                                                },
                                                new CompositeParticle.Builder(ParticleType.Group, 0, 0)
                                                {
                                                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                                                    {
                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Paragraph), 1, 1),
                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Math.OfficeMath), 1, 1),
                                                        new CompositeParticle.Builder(ParticleType.Group, 1, 1)
                                                        {
                                                            new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                                                            {
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Accent), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Bar), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Box), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.BorderBox), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Delimiter), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.EquationArray), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Fraction), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.MathFunction), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.GroupChar), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.LimitLower), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.LimitUpper), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Matrix), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Nary), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Phantom), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Radical), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.PreSubSuper), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Subscript), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.SubSuperscript), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Superscript), 1, 1),
                                                                new CompositeParticle.Builder(ParticleType.Group, 1, 1)
                                                                {
                                                                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                                                                    {
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Run), 1, 1)
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<OfficeMath>(deep);
    }

    /// <summary>
    /// <para>Math Properties.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:mathPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.BreakBinary" /> <c>&lt;m:brkBin></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.BreakBinarySubtraction" /> <c>&lt;m:brkBinSub></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.MathFont" /> <c>&lt;m:mathFont></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.IntegralLimitLocation" /> <c>&lt;m:intLim></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.NaryLimitLocation" /> <c>&lt;m:naryLim></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.DefaultJustification" /> <c>&lt;m:defJc></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.SmallFraction" /> <c>&lt;m:smallFrac></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.DisplayDefaults" /> <c>&lt;m:dispDef></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.WrapRight" /> <c>&lt;m:wrapRight></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.LeftMargin" /> <c>&lt;m:lMargin></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.RightMargin" /> <c>&lt;m:rMargin></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.PreSpacing" /> <c>&lt;m:preSp></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.PostSpacing" /> <c>&lt;m:postSp></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.InterSpacing" /> <c>&lt;m:interSp></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.IntraSpacing" /> <c>&lt;m:intraSp></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.WrapIndent" /> <c>&lt;m:wrapIndent></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("m:mathPr")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class MathProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the MathProperties class.
        /// </summary>
        public MathProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the MathProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public MathProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the MathProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public MathProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the MathProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public MathProperties(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("m:mathPr");
            builder.AddChild<DocumentFormat.OpenXml.Math.BreakBinary>();
            builder.AddChild<DocumentFormat.OpenXml.Math.BreakBinarySubtraction>();
            builder.AddChild<DocumentFormat.OpenXml.Math.MathFont>();
            builder.AddChild<DocumentFormat.OpenXml.Math.IntegralLimitLocation>();
            builder.AddChild<DocumentFormat.OpenXml.Math.NaryLimitLocation>();
            builder.AddChild<DocumentFormat.OpenXml.Math.DefaultJustification>();
            builder.AddChild<DocumentFormat.OpenXml.Math.SmallFraction>();
            builder.AddChild<DocumentFormat.OpenXml.Math.DisplayDefaults>();
            builder.AddChild<DocumentFormat.OpenXml.Math.WrapRight>();
            builder.AddChild<DocumentFormat.OpenXml.Math.LeftMargin>();
            builder.AddChild<DocumentFormat.OpenXml.Math.RightMargin>();
            builder.AddChild<DocumentFormat.OpenXml.Math.PreSpacing>();
            builder.AddChild<DocumentFormat.OpenXml.Math.PostSpacing>();
            builder.AddChild<DocumentFormat.OpenXml.Math.InterSpacing>();
            builder.AddChild<DocumentFormat.OpenXml.Math.IntraSpacing>();
            builder.AddChild<DocumentFormat.OpenXml.Math.WrapIndent>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.MathFont), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.BreakBinary), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.BreakBinarySubtraction), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.SmallFraction), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.DisplayDefaults), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.LeftMargin), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.RightMargin), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.DefaultJustification), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.PreSpacing), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.PostSpacing), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.InterSpacing), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.IntraSpacing), 0, 1),
                new CompositeParticle.Builder(ParticleType.Choice, 0, 1)
                {
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Math.WrapIndent), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Math.WrapRight), 1, 1)
                },
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.IntegralLimitLocation), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.NaryLimitLocation), 0, 1)
            };
        }

        /// <summary>
        /// <para>Math Font.</para>
        /// <para>Represents the following element tag in the schema: m:mathFont.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public DocumentFormat.OpenXml.Math.MathFont? MathFont
        {
            get => GetElement<DocumentFormat.OpenXml.Math.MathFont>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Break on Binary Operators.</para>
        /// <para>Represents the following element tag in the schema: m:brkBin.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public DocumentFormat.OpenXml.Math.BreakBinary? BreakBinary
        {
            get => GetElement<DocumentFormat.OpenXml.Math.BreakBinary>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Break on Binary Subtraction.</para>
        /// <para>Represents the following element tag in the schema: m:brkBinSub.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public DocumentFormat.OpenXml.Math.BreakBinarySubtraction? BreakBinarySubtraction
        {
            get => GetElement<DocumentFormat.OpenXml.Math.BreakBinarySubtraction>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Small Fraction.</para>
        /// <para>Represents the following element tag in the schema: m:smallFrac.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public DocumentFormat.OpenXml.Math.SmallFraction? SmallFraction
        {
            get => GetElement<DocumentFormat.OpenXml.Math.SmallFraction>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Use Display Math Defaults.</para>
        /// <para>Represents the following element tag in the schema: m:dispDef.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public DocumentFormat.OpenXml.Math.DisplayDefaults? DisplayDefaults
        {
            get => GetElement<DocumentFormat.OpenXml.Math.DisplayDefaults>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Left Margin.</para>
        /// <para>Represents the following element tag in the schema: m:lMargin.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public DocumentFormat.OpenXml.Math.LeftMargin? LeftMargin
        {
            get => GetElement<DocumentFormat.OpenXml.Math.LeftMargin>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Right Margin.</para>
        /// <para>Represents the following element tag in the schema: m:rMargin.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public DocumentFormat.OpenXml.Math.RightMargin? RightMargin
        {
            get => GetElement<DocumentFormat.OpenXml.Math.RightMargin>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Default Justification.</para>
        /// <para>Represents the following element tag in the schema: m:defJc.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public DocumentFormat.OpenXml.Math.DefaultJustification? DefaultJustification
        {
            get => GetElement<DocumentFormat.OpenXml.Math.DefaultJustification>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Pre-Equation Spacing.</para>
        /// <para>Represents the following element tag in the schema: m:preSp.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public DocumentFormat.OpenXml.Math.PreSpacing? PreSpacing
        {
            get => GetElement<DocumentFormat.OpenXml.Math.PreSpacing>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Post-Equation Spacing.</para>
        /// <para>Represents the following element tag in the schema: m:postSp.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public DocumentFormat.OpenXml.Math.PostSpacing? PostSpacing
        {
            get => GetElement<DocumentFormat.OpenXml.Math.PostSpacing>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Inter-Equation Spacing.</para>
        /// <para>Represents the following element tag in the schema: m:interSp.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public DocumentFormat.OpenXml.Math.InterSpacing? InterSpacing
        {
            get => GetElement<DocumentFormat.OpenXml.Math.InterSpacing>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Intra-Equation Spacing.</para>
        /// <para>Represents the following element tag in the schema: m:intraSp.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public DocumentFormat.OpenXml.Math.IntraSpacing? IntraSpacing
        {
            get => GetElement<DocumentFormat.OpenXml.Math.IntraSpacing>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<MathProperties>(deep);
    }

    /// <summary>
    /// <para>Literal.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:lit.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("m:lit")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class Literal : OnOffType
    {
        /// <summary>
        /// Initializes a new instance of the Literal class.
        /// </summary>
        public Literal() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("m:lit");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Literal>(deep);
    }

    /// <summary>
    /// <para>Normal Text.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:nor.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("m:nor")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class NormalText : OnOffType
    {
        /// <summary>
        /// Initializes a new instance of the NormalText class.
        /// </summary>
        public NormalText() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("m:nor");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<NormalText>(deep);
    }

    /// <summary>
    /// <para>Align.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:aln.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("m:aln")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class Alignment : OnOffType
    {
        /// <summary>
        /// Initializes a new instance of the Alignment class.
        /// </summary>
        public Alignment() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("m:aln");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Alignment>(deep);
    }

    /// <summary>
    /// <para>Operator Emulator.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:opEmu.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("m:opEmu")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class OperatorEmulator : OnOffType
    {
        /// <summary>
        /// Initializes a new instance of the OperatorEmulator class.
        /// </summary>
        public OperatorEmulator() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("m:opEmu");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<OperatorEmulator>(deep);
    }

    /// <summary>
    /// <para>No Break.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:noBreak.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("m:noBreak")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class NoBreak : OnOffType
    {
        /// <summary>
        /// Initializes a new instance of the NoBreak class.
        /// </summary>
        public NoBreak() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("m:noBreak");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<NoBreak>(deep);
    }

    /// <summary>
    /// <para>Differential.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:diff.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("m:diff")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class Differential : OnOffType
    {
        /// <summary>
        /// Initializes a new instance of the Differential class.
        /// </summary>
        public Differential() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("m:diff");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Differential>(deep);
    }

    /// <summary>
    /// <para>Hide Top Edge.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:hideTop.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("m:hideTop")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class HideTop : OnOffType
    {
        /// <summary>
        /// Initializes a new instance of the HideTop class.
        /// </summary>
        public HideTop() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("m:hideTop");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<HideTop>(deep);
    }

    /// <summary>
    /// <para>Hide Bottom Edge.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:hideBot.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("m:hideBot")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class HideBottom : OnOffType
    {
        /// <summary>
        /// Initializes a new instance of the HideBottom class.
        /// </summary>
        public HideBottom() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("m:hideBot");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<HideBottom>(deep);
    }

    /// <summary>
    /// <para>Hide Left Edge.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:hideLeft.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("m:hideLeft")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class HideLeft : OnOffType
    {
        /// <summary>
        /// Initializes a new instance of the HideLeft class.
        /// </summary>
        public HideLeft() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("m:hideLeft");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<HideLeft>(deep);
    }

    /// <summary>
    /// <para>Hide Right Edge.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:hideRight.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("m:hideRight")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class HideRight : OnOffType
    {
        /// <summary>
        /// Initializes a new instance of the HideRight class.
        /// </summary>
        public HideRight() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("m:hideRight");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<HideRight>(deep);
    }

    /// <summary>
    /// <para>Border Box Strikethrough Horizontal.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:strikeH.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("m:strikeH")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class StrikeHorizontal : OnOffType
    {
        /// <summary>
        /// Initializes a new instance of the StrikeHorizontal class.
        /// </summary>
        public StrikeHorizontal() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("m:strikeH");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<StrikeHorizontal>(deep);
    }

    /// <summary>
    /// <para>Border Box Strikethrough Vertical.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:strikeV.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("m:strikeV")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class StrikeVertical : OnOffType
    {
        /// <summary>
        /// Initializes a new instance of the StrikeVertical class.
        /// </summary>
        public StrikeVertical() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("m:strikeV");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<StrikeVertical>(deep);
    }

    /// <summary>
    /// <para>Border Box Strikethrough Bottom-Left to Top-Right.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:strikeBLTR.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("m:strikeBLTR")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class StrikeBottomLeftToTopRight : OnOffType
    {
        /// <summary>
        /// Initializes a new instance of the StrikeBottomLeftToTopRight class.
        /// </summary>
        public StrikeBottomLeftToTopRight() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("m:strikeBLTR");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<StrikeBottomLeftToTopRight>(deep);
    }

    /// <summary>
    /// <para>Border Box Strikethrough Top-Left to Bottom-Right.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:strikeTLBR.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("m:strikeTLBR")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class StrikeTopLeftToBottomRight : OnOffType
    {
        /// <summary>
        /// Initializes a new instance of the StrikeTopLeftToBottomRight class.
        /// </summary>
        public StrikeTopLeftToBottomRight() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("m:strikeTLBR");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<StrikeTopLeftToBottomRight>(deep);
    }

    /// <summary>
    /// <para>Delimiter Grow.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:grow.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("m:grow")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class GrowOperators : OnOffType
    {
        /// <summary>
        /// Initializes a new instance of the GrowOperators class.
        /// </summary>
        public GrowOperators() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("m:grow");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<GrowOperators>(deep);
    }

    /// <summary>
    /// <para>Maximum Distribution.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:maxDist.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("m:maxDist")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class MaxDistribution : OnOffType
    {
        /// <summary>
        /// Initializes a new instance of the MaxDistribution class.
        /// </summary>
        public MaxDistribution() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("m:maxDist");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<MaxDistribution>(deep);
    }

    /// <summary>
    /// <para>Object Distribution.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:objDist.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("m:objDist")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class ObjectDistribution : OnOffType
    {
        /// <summary>
        /// Initializes a new instance of the ObjectDistribution class.
        /// </summary>
        public ObjectDistribution() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("m:objDist");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ObjectDistribution>(deep);
    }

    /// <summary>
    /// <para>Hide Placeholders (Matrix).</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:plcHide.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("m:plcHide")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class HidePlaceholder : OnOffType
    {
        /// <summary>
        /// Initializes a new instance of the HidePlaceholder class.
        /// </summary>
        public HidePlaceholder() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("m:plcHide");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<HidePlaceholder>(deep);
    }

    /// <summary>
    /// <para>Hide Subscript (n-ary).</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:subHide.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("m:subHide")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class HideSubArgument : OnOffType
    {
        /// <summary>
        /// Initializes a new instance of the HideSubArgument class.
        /// </summary>
        public HideSubArgument() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("m:subHide");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<HideSubArgument>(deep);
    }

    /// <summary>
    /// <para>Hide Superscript (n-ary).</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:supHide.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("m:supHide")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class HideSuperArgument : OnOffType
    {
        /// <summary>
        /// Initializes a new instance of the HideSuperArgument class.
        /// </summary>
        public HideSuperArgument() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("m:supHide");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<HideSuperArgument>(deep);
    }

    /// <summary>
    /// <para>Phantom Show.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:show.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("m:show")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class ShowPhantom : OnOffType
    {
        /// <summary>
        /// Initializes a new instance of the ShowPhantom class.
        /// </summary>
        public ShowPhantom() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("m:show");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ShowPhantom>(deep);
    }

    /// <summary>
    /// <para>Phantom Zero Width.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:zeroWid.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("m:zeroWid")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class ZeroWidth : OnOffType
    {
        /// <summary>
        /// Initializes a new instance of the ZeroWidth class.
        /// </summary>
        public ZeroWidth() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("m:zeroWid");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ZeroWidth>(deep);
    }

    /// <summary>
    /// <para>Phantom Zero Ascent.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:zeroAsc.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("m:zeroAsc")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class ZeroAscent : OnOffType
    {
        /// <summary>
        /// Initializes a new instance of the ZeroAscent class.
        /// </summary>
        public ZeroAscent() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("m:zeroAsc");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ZeroAscent>(deep);
    }

    /// <summary>
    /// <para>Phantom Zero Descent.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:zeroDesc.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("m:zeroDesc")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class ZeroDescent : OnOffType
    {
        /// <summary>
        /// Initializes a new instance of the ZeroDescent class.
        /// </summary>
        public ZeroDescent() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("m:zeroDesc");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ZeroDescent>(deep);
    }

    /// <summary>
    /// <para>Transparent (Phantom).</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:transp.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("m:transp")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class Transparent : OnOffType
    {
        /// <summary>
        /// Initializes a new instance of the Transparent class.
        /// </summary>
        public Transparent() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("m:transp");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Transparent>(deep);
    }

    /// <summary>
    /// <para>Hide Degree.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:degHide.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("m:degHide")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class HideDegree : OnOffType
    {
        /// <summary>
        /// Initializes a new instance of the HideDegree class.
        /// </summary>
        public HideDegree() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("m:degHide");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<HideDegree>(deep);
    }

    /// <summary>
    /// <para>Align Scripts.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:alnScr.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("m:alnScr")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class AlignScripts : OnOffType
    {
        /// <summary>
        /// Initializes a new instance of the AlignScripts class.
        /// </summary>
        public AlignScripts() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("m:alnScr");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<AlignScripts>(deep);
    }

    /// <summary>
    /// <para>Small Fraction.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:smallFrac.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("m:smallFrac")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class SmallFraction : OnOffType
    {
        /// <summary>
        /// Initializes a new instance of the SmallFraction class.
        /// </summary>
        public SmallFraction() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("m:smallFrac");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SmallFraction>(deep);
    }

    /// <summary>
    /// <para>Use Display Math Defaults.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:dispDef.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("m:dispDef")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class DisplayDefaults : OnOffType
    {
        /// <summary>
        /// Initializes a new instance of the DisplayDefaults class.
        /// </summary>
        public DisplayDefaults() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("m:dispDef");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DisplayDefaults>(deep);
    }

    /// <summary>
    /// <para>Wrap Right.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:wrapRight.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("m:wrapRight")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class WrapRight : OnOffType
    {
        /// <summary>
        /// Initializes a new instance of the WrapRight class.
        /// </summary>
        public WrapRight() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("m:wrapRight");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<WrapRight>(deep);
    }

    /// <summary>
    /// <para>Defines the OnOffType Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is :.</para>
    /// </summary>
    public abstract partial class OnOffType : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the OnOffType class.
        /// </summary>
        protected OnOffType() : base()
        {
        }

        /// <summary>
        /// <para>value</para>
        /// <para>Represents the following attribute in the schema: m:val</para>
        /// </summary>
        /// <remark>
        /// xmlns:m=http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("m:val")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Math.BooleanValues>? Val
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Math.BooleanValues>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddElement<OnOffType>()
                           .AddAttribute("m:val", a => a.Val);
        }
    }

    /// <summary>
    /// <para>Break.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:brk.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("m:brk")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class Break : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the Break class.
        /// </summary>
        public Break() : base()
        {
        }

        /// <summary>
        /// <para>Index of Operator to Align To</para>
        /// <para>Represents the following attribute in the schema: m:alnAt</para>
        /// </summary>
        /// <remark>
        /// xmlns:m=http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("m:alnAt")]
#pragma warning restore CS0618 // Type or member is obsolete

        public IntegerValue? AlignAt
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Index of Operator to Align To</para>
        /// <para>Represents the following attribute in the schema: m:val</para>
        /// </summary>
        /// <remark>
        /// xmlns:m=http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("m:val")]
#pragma warning restore CS0618 // Type or member is obsolete

        public IntegerValue? Val
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("m:brk");
            builder.AddElement<Break>()
.AddAttribute("m:alnAt", a => a.AlignAt, aBuilder =>
{
    aBuilder.AddValidator(new NumberValidator() { MinInclusive = (1L), MaxInclusive = (255L) });
})
.AddAttribute("m:val", a => a.Val, aBuilder =>
{
    aBuilder.AddValidator(new NumberValidator() { MinInclusive = (1L), MaxInclusive = (255L) });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Break>(deep);
    }

    /// <summary>
    /// <para>Run Properties.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:rPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.Break" /> <c>&lt;m:brk></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.Literal" /> <c>&lt;m:lit></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.NormalText" /> <c>&lt;m:nor></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.Alignment" /> <c>&lt;m:aln></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.Script" /> <c>&lt;m:scr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.Style" /> <c>&lt;m:sty></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("m:rPr")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class RunProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the RunProperties class.
        /// </summary>
        public RunProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the RunProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public RunProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the RunProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public RunProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the RunProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public RunProperties(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("m:rPr");
            builder.AddChild<DocumentFormat.OpenXml.Math.Break>();
            builder.AddChild<DocumentFormat.OpenXml.Math.Literal>();
            builder.AddChild<DocumentFormat.OpenXml.Math.NormalText>();
            builder.AddChild<DocumentFormat.OpenXml.Math.Alignment>();
            builder.AddChild<DocumentFormat.OpenXml.Math.Script>();
            builder.AddChild<DocumentFormat.OpenXml.Math.Style>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Literal), 0, 1),
                new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                {
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Math.NormalText), 0, 1),
                    new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
                    {
                        new CompositeParticle.Builder(ParticleType.Group, 1, 1)
                        {
                            new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
                            {
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Script), 0, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Style), 0, 1)
                            }
                        }
                    }
                },
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Break), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Alignment), 0, 1)
            };
        }

        /// <summary>
        /// <para>Literal.</para>
        /// <para>Represents the following element tag in the schema: m:lit.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public DocumentFormat.OpenXml.Math.Literal? Literal
        {
            get => GetElement<DocumentFormat.OpenXml.Math.Literal>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RunProperties>(deep);
    }

    /// <summary>
    /// <para>Text.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:t.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("m:t")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class Text : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the Text class.
        /// </summary>
        public Text() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Text class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public Text(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        /// <summary>
        /// <para>space</para>
        /// <para>Represents the following attribute in the schema: xml:space</para>
        /// </summary>
        /// <remark>
        /// xmlns:xml=http://www.w3.org/XML/1998/namespace
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("xml:space")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.SpaceProcessingModeValues>? Space
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.SpaceProcessingModeValues>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("m:t");
            builder.AddElement<Text>()
  .AddAttribute("xml:space", a => a.Space);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Text>(deep);
    }

    /// <summary>
    /// <para>Accent Character.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:chr.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("m:chr")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class AccentChar : CharType
    {
        /// <summary>
        /// Initializes a new instance of the AccentChar class.
        /// </summary>
        public AccentChar() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("m:chr");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<AccentChar>(deep);
    }

    /// <summary>
    /// <para>Delimiter Beginning Character.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:begChr.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("m:begChr")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class BeginChar : CharType
    {
        /// <summary>
        /// Initializes a new instance of the BeginChar class.
        /// </summary>
        public BeginChar() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("m:begChr");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<BeginChar>(deep);
    }

    /// <summary>
    /// <para>Delimiter Separator Character.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:sepChr.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("m:sepChr")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class SeparatorChar : CharType
    {
        /// <summary>
        /// Initializes a new instance of the SeparatorChar class.
        /// </summary>
        public SeparatorChar() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("m:sepChr");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SeparatorChar>(deep);
    }

    /// <summary>
    /// <para>Delimiter Ending Character.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:endChr.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("m:endChr")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class EndChar : CharType
    {
        /// <summary>
        /// Initializes a new instance of the EndChar class.
        /// </summary>
        public EndChar() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("m:endChr");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<EndChar>(deep);
    }

    /// <summary>
    /// <para>Defines the CharType Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is :.</para>
    /// </summary>
    public abstract partial class CharType : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the CharType class.
        /// </summary>
        protected CharType() : base()
        {
        }

        /// <summary>
        /// <para>value</para>
        /// <para>Represents the following attribute in the schema: m:val</para>
        /// </summary>
        /// <remark>
        /// xmlns:m=http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("m:val")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Val
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddElement<CharType>()
                           .AddAttribute("m:val", a => a.Val, aBuilder =>
                           {
                               aBuilder.AddValidator(RequiredValidator.Instance);
                               aBuilder.AddValidator(new StringValidator() { MaxLength = (1L) });
                           });
        }
    }

    /// <summary>
    /// <para>Control Properties.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:ctrlPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.DeletedMathControl" /> <c>&lt;w:del></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.InsertedMathControl" /> <c>&lt;w:ins></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.MoveFromMathControl" /> <c>&lt;w:moveFrom></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.MoveToMathControl" /> <c>&lt;w:moveTo></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.RunProperties" /> <c>&lt;w:rPr></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("m:ctrlPr")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class ControlProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ControlProperties class.
        /// </summary>
        public ControlProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ControlProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ControlProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ControlProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ControlProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ControlProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ControlProperties(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("m:ctrlPr");
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.DeletedMathControl>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.InsertedMathControl>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.MoveFromMathControl>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.MoveToMathControl>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.RunProperties>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle.Builder(ParticleType.Group, 0, 1)
                {
                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                    {
                        new CompositeParticle.Builder(ParticleType.Group, 1, 1)
                        {
                            new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
                            {
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.RunProperties), 0, 1)
                            }
                        },
                        new CompositeParticle.Builder(ParticleType.Group, 1, 1)
                        {
                            new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                            {
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.InsertedMathControl), 1, 1)
                            }
                        },
                        new CompositeParticle.Builder(ParticleType.Group, 1, 1)
                        {
                            new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                            {
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.DeletedMathControl), 1, 1)
                            }
                        },
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.MoveFromMathControl), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.MoveToMathControl), 1, 1)
                    }
                }
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ControlProperties>(deep);
    }

    /// <summary>
    /// <para>Accent Properties.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:accPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.AccentChar" /> <c>&lt;m:chr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.ControlProperties" /> <c>&lt;m:ctrlPr></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("m:accPr")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class AccentProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the AccentProperties class.
        /// </summary>
        public AccentProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the AccentProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public AccentProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the AccentProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public AccentProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the AccentProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public AccentProperties(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("m:accPr");
            builder.AddChild<DocumentFormat.OpenXml.Math.AccentChar>();
            builder.AddChild<DocumentFormat.OpenXml.Math.ControlProperties>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.AccentChar), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.ControlProperties), 0, 1)
            };
        }

        /// <summary>
        /// <para>Accent Character.</para>
        /// <para>Represents the following element tag in the schema: m:chr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public DocumentFormat.OpenXml.Math.AccentChar? AccentChar
        {
            get => GetElement<DocumentFormat.OpenXml.Math.AccentChar>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Control Properties.</para>
        /// <para>Represents the following element tag in the schema: m:ctrlPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public DocumentFormat.OpenXml.Math.ControlProperties? ControlProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Math.ControlProperties>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<AccentProperties>(deep);
    }

    /// <summary>
    /// <para>Base.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:e.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.Accent" /> <c>&lt;m:acc></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.Bar" /> <c>&lt;m:bar></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.BorderBox" /> <c>&lt;m:borderBox></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.Box" /> <c>&lt;m:box></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.ControlProperties" /> <c>&lt;m:ctrlPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.Delimiter" /> <c>&lt;m:d></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.EquationArray" /> <c>&lt;m:eqArr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.Fraction" /> <c>&lt;m:f></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.MathFunction" /> <c>&lt;m:func></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.GroupChar" /> <c>&lt;m:groupChr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.LimitLower" /> <c>&lt;m:limLow></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.LimitUpper" /> <c>&lt;m:limUpp></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.Matrix" /> <c>&lt;m:m></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.Nary" /> <c>&lt;m:nary></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.OfficeMath" /> <c>&lt;m:oMath></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.ArgumentProperties" /> <c>&lt;m:argPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.Paragraph" /> <c>&lt;m:oMathPara></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.Phantom" /> <c>&lt;m:phant></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.Run" /> <c>&lt;m:r></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.Radical" /> <c>&lt;m:rad></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.PreSubSuper" /> <c>&lt;m:sPre></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.Subscript" /> <c>&lt;m:sSub></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.SubSuperscript" /> <c>&lt;m:sSubSup></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.Superscript" /> <c>&lt;m:sSup></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.BookmarkStart" /> <c>&lt;w:bookmarkStart></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.ContentPart" /> <c>&lt;w:contentPart></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.CustomXmlRun" /> <c>&lt;w:customXml></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.Hyperlink" /> <c>&lt;w:hyperlink></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeEnd" /> <c>&lt;w:customXmlInsRangeEnd></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeEnd" /> <c>&lt;w:customXmlDelRangeEnd></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeEnd" /> <c>&lt;w:customXmlMoveFromRangeEnd></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeEnd" /> <c>&lt;w:customXmlMoveToRangeEnd></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictInsertionRangeEnd" /> <c>&lt;w14:customXmlConflictInsRangeEnd></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictDeletionRangeEnd" /> <c>&lt;w14:customXmlConflictDelRangeEnd></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.BookmarkEnd" /> <c>&lt;w:bookmarkEnd></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.CommentRangeStart" /> <c>&lt;w:commentRangeStart></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.CommentRangeEnd" /> <c>&lt;w:commentRangeEnd></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeEnd" /> <c>&lt;w:moveFromRangeEnd></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.MoveToRangeEnd" /> <c>&lt;w:moveToRangeEnd></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeStart" /> <c>&lt;w:moveFromRangeStart></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.MoveToRangeStart" /> <c>&lt;w:moveToRangeStart></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.PermEnd" /> <c>&lt;w:permEnd></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.PermStart" /> <c>&lt;w:permStart></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.ProofError" /> <c>&lt;w:proofErr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.InsertedRun" /> <c>&lt;w:ins></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.DeletedRun" /> <c>&lt;w:del></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.MoveFromRun" /> <c>&lt;w:moveFrom></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.MoveToRun" /> <c>&lt;w:moveTo></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.Word.RunConflictInsertion" /> <c>&lt;w14:conflictIns></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.Word.RunConflictDeletion" /> <c>&lt;w14:conflictDel></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.SdtRun" /> <c>&lt;w:sdt></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.SimpleField" /> <c>&lt;w:fldSimple></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeStart" /> <c>&lt;w:customXmlInsRangeStart></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeStart" /> <c>&lt;w:customXmlDelRangeStart></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeStart" /> <c>&lt;w:customXmlMoveFromRangeStart></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeStart" /> <c>&lt;w:customXmlMoveToRangeStart></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictInsertionRangeStart" /> <c>&lt;w14:customXmlConflictInsRangeStart></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictDeletionRangeStart" /> <c>&lt;w14:customXmlConflictDelRangeStart></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("m:e")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class Base : OfficeMathArgumentType
    {
        /// <summary>
        /// Initializes a new instance of the Base class.
        /// </summary>
        public Base() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Base class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Base(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Base class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Base(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Base class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Base(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("m:e");
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.ArgumentProperties), 0, 1),
                new CompositeParticle.Builder(ParticleType.Group, 0, 0)
                {
                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                    {
                        new CompositeParticle.Builder(ParticleType.Group, 1, 1)
                        {
                            new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                            {
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Accent), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Bar), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Box), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.BorderBox), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Delimiter), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.EquationArray), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Fraction), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.MathFunction), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.GroupChar), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.LimitLower), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.LimitUpper), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Matrix), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Nary), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Phantom), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Radical), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.PreSubSuper), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Subscript), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.SubSuperscript), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Superscript), 1, 1),
                                new CompositeParticle.Builder(ParticleType.Group, 1, 1)
                                {
                                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                                    {
                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Run), 1, 1)
                                    }
                                }
                            }
                        },
                        new CompositeParticle.Builder(ParticleType.Group, 1, 1)
                        {
                            new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                            {
                                new CompositeParticle.Builder(ParticleType.Group, 0, 0)
                                {
                                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                                    {
                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlRun), 1, 1),
                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.SimpleField), 0, 0),
                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.Hyperlink), 1, 1)
                                    }
                                },
                                new CompositeParticle.Builder(ParticleType.Group, 0, 0)
                                {
                                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                                    {
                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.SdtRun), 1, 1),
                                        new CompositeParticle.Builder(ParticleType.Group, 0, 0)
                                        {
                                            new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                                            {
                                                new CompositeParticle.Builder(ParticleType.Group, 0, 0)
                                                {
                                                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                                                    {
                                                        new CompositeParticle.Builder(ParticleType.Group, 0, 0)
                                                        {
                                                            new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                                                            {
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.ProofError), 0, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.PermStart), 0, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.PermEnd), 0, 1)
                                                            }
                                                        },
                                                        new CompositeParticle.Builder(ParticleType.Group, 0, 0)
                                                        {
                                                            new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                                                            {
                                                                new CompositeParticle.Builder(ParticleType.Group, 0, 0)
                                                                {
                                                                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                                                                    {
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.BookmarkStart), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.BookmarkEnd), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CommentRangeStart), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CommentRangeEnd), 1, 1)
                                                                    }
                                                                },
                                                                new CompositeParticle.Builder(ParticleType.Group, 0, 0)
                                                                {
                                                                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                                                                    {
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeStart), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeEnd), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.MoveToRangeStart), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.MoveToRangeEnd), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeStart), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeEnd), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeStart), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeEnd), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeStart), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeEnd), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeStart), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeEnd), 1, 1)
                                                                    }
                                                                },
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictInsertionRangeStart), 0, 1, version: FileFormatVersions.Office2010),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictInsertionRangeEnd), 0, 1, version: FileFormatVersions.Office2010),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictDeletionRangeStart), 0, 1, version: FileFormatVersions.Office2010),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictDeletionRangeEnd), 0, 1, version: FileFormatVersions.Office2010)
                                                            }
                                                        },
                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.InsertedRun), 0, 1),
                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.DeletedRun), 0, 1),
                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.MoveFromRun), 1, 1),
                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.MoveToRun), 1, 1),
                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.ContentPart), 0, 0, version: FileFormatVersions.Office2010),
                                                        new CompositeParticle.Builder(ParticleType.Group, 0, 1, version: FileFormatVersions.Office2010)
                                                        {
                                                            new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
                                                            {
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.RunConflictInsertion), 0, 1, version: FileFormatVersions.Office2010),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.RunConflictDeletion), 0, 1, version: FileFormatVersions.Office2010)
                                                            }
                                                        }
                                                    }
                                                },
                                                new CompositeParticle.Builder(ParticleType.Group, 0, 0)
                                                {
                                                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                                                    {
                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Paragraph), 1, 1),
                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Math.OfficeMath), 1, 1),
                                                        new CompositeParticle.Builder(ParticleType.Group, 1, 1)
                                                        {
                                                            new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                                                            {
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Accent), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Bar), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Box), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.BorderBox), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Delimiter), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.EquationArray), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Fraction), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.MathFunction), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.GroupChar), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.LimitLower), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.LimitUpper), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Matrix), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Nary), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Phantom), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Radical), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.PreSubSuper), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Subscript), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.SubSuperscript), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Superscript), 1, 1),
                                                                new CompositeParticle.Builder(ParticleType.Group, 1, 1)
                                                                {
                                                                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                                                                    {
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Run), 1, 1)
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                },
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.ControlProperties), 0, 1)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Base>(deep);
    }

    /// <summary>
    /// <para>Numerator.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:num.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.Accent" /> <c>&lt;m:acc></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.Bar" /> <c>&lt;m:bar></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.BorderBox" /> <c>&lt;m:borderBox></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.Box" /> <c>&lt;m:box></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.ControlProperties" /> <c>&lt;m:ctrlPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.Delimiter" /> <c>&lt;m:d></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.EquationArray" /> <c>&lt;m:eqArr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.Fraction" /> <c>&lt;m:f></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.MathFunction" /> <c>&lt;m:func></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.GroupChar" /> <c>&lt;m:groupChr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.LimitLower" /> <c>&lt;m:limLow></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.LimitUpper" /> <c>&lt;m:limUpp></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.Matrix" /> <c>&lt;m:m></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.Nary" /> <c>&lt;m:nary></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.OfficeMath" /> <c>&lt;m:oMath></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.ArgumentProperties" /> <c>&lt;m:argPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.Paragraph" /> <c>&lt;m:oMathPara></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.Phantom" /> <c>&lt;m:phant></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.Run" /> <c>&lt;m:r></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.Radical" /> <c>&lt;m:rad></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.PreSubSuper" /> <c>&lt;m:sPre></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.Subscript" /> <c>&lt;m:sSub></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.SubSuperscript" /> <c>&lt;m:sSubSup></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.Superscript" /> <c>&lt;m:sSup></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.BookmarkStart" /> <c>&lt;w:bookmarkStart></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.ContentPart" /> <c>&lt;w:contentPart></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.CustomXmlRun" /> <c>&lt;w:customXml></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.Hyperlink" /> <c>&lt;w:hyperlink></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeEnd" /> <c>&lt;w:customXmlInsRangeEnd></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeEnd" /> <c>&lt;w:customXmlDelRangeEnd></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeEnd" /> <c>&lt;w:customXmlMoveFromRangeEnd></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeEnd" /> <c>&lt;w:customXmlMoveToRangeEnd></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictInsertionRangeEnd" /> <c>&lt;w14:customXmlConflictInsRangeEnd></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictDeletionRangeEnd" /> <c>&lt;w14:customXmlConflictDelRangeEnd></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.BookmarkEnd" /> <c>&lt;w:bookmarkEnd></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.CommentRangeStart" /> <c>&lt;w:commentRangeStart></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.CommentRangeEnd" /> <c>&lt;w:commentRangeEnd></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeEnd" /> <c>&lt;w:moveFromRangeEnd></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.MoveToRangeEnd" /> <c>&lt;w:moveToRangeEnd></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeStart" /> <c>&lt;w:moveFromRangeStart></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.MoveToRangeStart" /> <c>&lt;w:moveToRangeStart></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.PermEnd" /> <c>&lt;w:permEnd></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.PermStart" /> <c>&lt;w:permStart></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.ProofError" /> <c>&lt;w:proofErr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.InsertedRun" /> <c>&lt;w:ins></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.DeletedRun" /> <c>&lt;w:del></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.MoveFromRun" /> <c>&lt;w:moveFrom></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.MoveToRun" /> <c>&lt;w:moveTo></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.Word.RunConflictInsertion" /> <c>&lt;w14:conflictIns></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.Word.RunConflictDeletion" /> <c>&lt;w14:conflictDel></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.SdtRun" /> <c>&lt;w:sdt></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.SimpleField" /> <c>&lt;w:fldSimple></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeStart" /> <c>&lt;w:customXmlInsRangeStart></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeStart" /> <c>&lt;w:customXmlDelRangeStart></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeStart" /> <c>&lt;w:customXmlMoveFromRangeStart></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeStart" /> <c>&lt;w:customXmlMoveToRangeStart></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictInsertionRangeStart" /> <c>&lt;w14:customXmlConflictInsRangeStart></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictDeletionRangeStart" /> <c>&lt;w14:customXmlConflictDelRangeStart></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("m:num")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class Numerator : OfficeMathArgumentType
    {
        /// <summary>
        /// Initializes a new instance of the Numerator class.
        /// </summary>
        public Numerator() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Numerator class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Numerator(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Numerator class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Numerator(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Numerator class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Numerator(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("m:num");
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.ArgumentProperties), 0, 1),
                new CompositeParticle.Builder(ParticleType.Group, 0, 0)
                {
                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                    {
                        new CompositeParticle.Builder(ParticleType.Group, 1, 1)
                        {
                            new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                            {
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Accent), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Bar), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Box), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.BorderBox), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Delimiter), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.EquationArray), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Fraction), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.MathFunction), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.GroupChar), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.LimitLower), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.LimitUpper), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Matrix), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Nary), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Phantom), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Radical), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.PreSubSuper), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Subscript), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.SubSuperscript), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Superscript), 1, 1),
                                new CompositeParticle.Builder(ParticleType.Group, 1, 1)
                                {
                                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                                    {
                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Run), 1, 1)
                                    }
                                }
                            }
                        },
                        new CompositeParticle.Builder(ParticleType.Group, 1, 1)
                        {
                            new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                            {
                                new CompositeParticle.Builder(ParticleType.Group, 0, 0)
                                {
                                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                                    {
                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlRun), 1, 1),
                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.SimpleField), 0, 0),
                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.Hyperlink), 1, 1)
                                    }
                                },
                                new CompositeParticle.Builder(ParticleType.Group, 0, 0)
                                {
                                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                                    {
                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.SdtRun), 1, 1),
                                        new CompositeParticle.Builder(ParticleType.Group, 0, 0)
                                        {
                                            new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                                            {
                                                new CompositeParticle.Builder(ParticleType.Group, 0, 0)
                                                {
                                                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                                                    {
                                                        new CompositeParticle.Builder(ParticleType.Group, 0, 0)
                                                        {
                                                            new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                                                            {
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.ProofError), 0, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.PermStart), 0, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.PermEnd), 0, 1)
                                                            }
                                                        },
                                                        new CompositeParticle.Builder(ParticleType.Group, 0, 0)
                                                        {
                                                            new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                                                            {
                                                                new CompositeParticle.Builder(ParticleType.Group, 0, 0)
                                                                {
                                                                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                                                                    {
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.BookmarkStart), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.BookmarkEnd), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CommentRangeStart), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CommentRangeEnd), 1, 1)
                                                                    }
                                                                },
                                                                new CompositeParticle.Builder(ParticleType.Group, 0, 0)
                                                                {
                                                                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                                                                    {
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeStart), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeEnd), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.MoveToRangeStart), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.MoveToRangeEnd), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeStart), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeEnd), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeStart), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeEnd), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeStart), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeEnd), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeStart), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeEnd), 1, 1)
                                                                    }
                                                                },
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictInsertionRangeStart), 0, 1, version: FileFormatVersions.Office2010),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictInsertionRangeEnd), 0, 1, version: FileFormatVersions.Office2010),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictDeletionRangeStart), 0, 1, version: FileFormatVersions.Office2010),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictDeletionRangeEnd), 0, 1, version: FileFormatVersions.Office2010)
                                                            }
                                                        },
                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.InsertedRun), 0, 1),
                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.DeletedRun), 0, 1),
                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.MoveFromRun), 1, 1),
                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.MoveToRun), 1, 1),
                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.ContentPart), 0, 0, version: FileFormatVersions.Office2010),
                                                        new CompositeParticle.Builder(ParticleType.Group, 0, 1, version: FileFormatVersions.Office2010)
                                                        {
                                                            new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
                                                            {
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.RunConflictInsertion), 0, 1, version: FileFormatVersions.Office2010),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.RunConflictDeletion), 0, 1, version: FileFormatVersions.Office2010)
                                                            }
                                                        }
                                                    }
                                                },
                                                new CompositeParticle.Builder(ParticleType.Group, 0, 0)
                                                {
                                                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                                                    {
                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Paragraph), 1, 1),
                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Math.OfficeMath), 1, 1),
                                                        new CompositeParticle.Builder(ParticleType.Group, 1, 1)
                                                        {
                                                            new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                                                            {
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Accent), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Bar), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Box), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.BorderBox), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Delimiter), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.EquationArray), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Fraction), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.MathFunction), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.GroupChar), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.LimitLower), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.LimitUpper), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Matrix), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Nary), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Phantom), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Radical), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.PreSubSuper), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Subscript), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.SubSuperscript), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Superscript), 1, 1),
                                                                new CompositeParticle.Builder(ParticleType.Group, 1, 1)
                                                                {
                                                                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                                                                    {
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Run), 1, 1)
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                },
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.ControlProperties), 0, 1)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Numerator>(deep);
    }

    /// <summary>
    /// <para>Denominator.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:den.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.Accent" /> <c>&lt;m:acc></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.Bar" /> <c>&lt;m:bar></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.BorderBox" /> <c>&lt;m:borderBox></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.Box" /> <c>&lt;m:box></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.ControlProperties" /> <c>&lt;m:ctrlPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.Delimiter" /> <c>&lt;m:d></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.EquationArray" /> <c>&lt;m:eqArr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.Fraction" /> <c>&lt;m:f></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.MathFunction" /> <c>&lt;m:func></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.GroupChar" /> <c>&lt;m:groupChr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.LimitLower" /> <c>&lt;m:limLow></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.LimitUpper" /> <c>&lt;m:limUpp></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.Matrix" /> <c>&lt;m:m></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.Nary" /> <c>&lt;m:nary></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.OfficeMath" /> <c>&lt;m:oMath></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.ArgumentProperties" /> <c>&lt;m:argPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.Paragraph" /> <c>&lt;m:oMathPara></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.Phantom" /> <c>&lt;m:phant></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.Run" /> <c>&lt;m:r></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.Radical" /> <c>&lt;m:rad></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.PreSubSuper" /> <c>&lt;m:sPre></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.Subscript" /> <c>&lt;m:sSub></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.SubSuperscript" /> <c>&lt;m:sSubSup></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.Superscript" /> <c>&lt;m:sSup></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.BookmarkStart" /> <c>&lt;w:bookmarkStart></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.ContentPart" /> <c>&lt;w:contentPart></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.CustomXmlRun" /> <c>&lt;w:customXml></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.Hyperlink" /> <c>&lt;w:hyperlink></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeEnd" /> <c>&lt;w:customXmlInsRangeEnd></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeEnd" /> <c>&lt;w:customXmlDelRangeEnd></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeEnd" /> <c>&lt;w:customXmlMoveFromRangeEnd></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeEnd" /> <c>&lt;w:customXmlMoveToRangeEnd></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictInsertionRangeEnd" /> <c>&lt;w14:customXmlConflictInsRangeEnd></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictDeletionRangeEnd" /> <c>&lt;w14:customXmlConflictDelRangeEnd></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.BookmarkEnd" /> <c>&lt;w:bookmarkEnd></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.CommentRangeStart" /> <c>&lt;w:commentRangeStart></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.CommentRangeEnd" /> <c>&lt;w:commentRangeEnd></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeEnd" /> <c>&lt;w:moveFromRangeEnd></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.MoveToRangeEnd" /> <c>&lt;w:moveToRangeEnd></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeStart" /> <c>&lt;w:moveFromRangeStart></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.MoveToRangeStart" /> <c>&lt;w:moveToRangeStart></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.PermEnd" /> <c>&lt;w:permEnd></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.PermStart" /> <c>&lt;w:permStart></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.ProofError" /> <c>&lt;w:proofErr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.InsertedRun" /> <c>&lt;w:ins></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.DeletedRun" /> <c>&lt;w:del></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.MoveFromRun" /> <c>&lt;w:moveFrom></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.MoveToRun" /> <c>&lt;w:moveTo></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.Word.RunConflictInsertion" /> <c>&lt;w14:conflictIns></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.Word.RunConflictDeletion" /> <c>&lt;w14:conflictDel></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.SdtRun" /> <c>&lt;w:sdt></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.SimpleField" /> <c>&lt;w:fldSimple></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeStart" /> <c>&lt;w:customXmlInsRangeStart></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeStart" /> <c>&lt;w:customXmlDelRangeStart></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeStart" /> <c>&lt;w:customXmlMoveFromRangeStart></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeStart" /> <c>&lt;w:customXmlMoveToRangeStart></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictInsertionRangeStart" /> <c>&lt;w14:customXmlConflictInsRangeStart></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictDeletionRangeStart" /> <c>&lt;w14:customXmlConflictDelRangeStart></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("m:den")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class Denominator : OfficeMathArgumentType
    {
        /// <summary>
        /// Initializes a new instance of the Denominator class.
        /// </summary>
        public Denominator() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Denominator class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Denominator(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Denominator class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Denominator(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Denominator class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Denominator(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("m:den");
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.ArgumentProperties), 0, 1),
                new CompositeParticle.Builder(ParticleType.Group, 0, 0)
                {
                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                    {
                        new CompositeParticle.Builder(ParticleType.Group, 1, 1)
                        {
                            new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                            {
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Accent), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Bar), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Box), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.BorderBox), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Delimiter), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.EquationArray), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Fraction), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.MathFunction), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.GroupChar), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.LimitLower), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.LimitUpper), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Matrix), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Nary), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Phantom), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Radical), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.PreSubSuper), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Subscript), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.SubSuperscript), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Superscript), 1, 1),
                                new CompositeParticle.Builder(ParticleType.Group, 1, 1)
                                {
                                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                                    {
                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Run), 1, 1)
                                    }
                                }
                            }
                        },
                        new CompositeParticle.Builder(ParticleType.Group, 1, 1)
                        {
                            new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                            {
                                new CompositeParticle.Builder(ParticleType.Group, 0, 0)
                                {
                                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                                    {
                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlRun), 1, 1),
                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.SimpleField), 0, 0),
                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.Hyperlink), 1, 1)
                                    }
                                },
                                new CompositeParticle.Builder(ParticleType.Group, 0, 0)
                                {
                                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                                    {
                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.SdtRun), 1, 1),
                                        new CompositeParticle.Builder(ParticleType.Group, 0, 0)
                                        {
                                            new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                                            {
                                                new CompositeParticle.Builder(ParticleType.Group, 0, 0)
                                                {
                                                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                                                    {
                                                        new CompositeParticle.Builder(ParticleType.Group, 0, 0)
                                                        {
                                                            new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                                                            {
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.ProofError), 0, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.PermStart), 0, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.PermEnd), 0, 1)
                                                            }
                                                        },
                                                        new CompositeParticle.Builder(ParticleType.Group, 0, 0)
                                                        {
                                                            new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                                                            {
                                                                new CompositeParticle.Builder(ParticleType.Group, 0, 0)
                                                                {
                                                                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                                                                    {
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.BookmarkStart), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.BookmarkEnd), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CommentRangeStart), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CommentRangeEnd), 1, 1)
                                                                    }
                                                                },
                                                                new CompositeParticle.Builder(ParticleType.Group, 0, 0)
                                                                {
                                                                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                                                                    {
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeStart), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeEnd), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.MoveToRangeStart), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.MoveToRangeEnd), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeStart), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeEnd), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeStart), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeEnd), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeStart), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeEnd), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeStart), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeEnd), 1, 1)
                                                                    }
                                                                },
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictInsertionRangeStart), 0, 1, version: FileFormatVersions.Office2010),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictInsertionRangeEnd), 0, 1, version: FileFormatVersions.Office2010),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictDeletionRangeStart), 0, 1, version: FileFormatVersions.Office2010),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictDeletionRangeEnd), 0, 1, version: FileFormatVersions.Office2010)
                                                            }
                                                        },
                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.InsertedRun), 0, 1),
                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.DeletedRun), 0, 1),
                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.MoveFromRun), 1, 1),
                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.MoveToRun), 1, 1),
                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.ContentPart), 0, 0, version: FileFormatVersions.Office2010),
                                                        new CompositeParticle.Builder(ParticleType.Group, 0, 1, version: FileFormatVersions.Office2010)
                                                        {
                                                            new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
                                                            {
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.RunConflictInsertion), 0, 1, version: FileFormatVersions.Office2010),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.RunConflictDeletion), 0, 1, version: FileFormatVersions.Office2010)
                                                            }
                                                        }
                                                    }
                                                },
                                                new CompositeParticle.Builder(ParticleType.Group, 0, 0)
                                                {
                                                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                                                    {
                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Paragraph), 1, 1),
                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Math.OfficeMath), 1, 1),
                                                        new CompositeParticle.Builder(ParticleType.Group, 1, 1)
                                                        {
                                                            new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                                                            {
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Accent), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Bar), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Box), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.BorderBox), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Delimiter), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.EquationArray), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Fraction), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.MathFunction), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.GroupChar), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.LimitLower), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.LimitUpper), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Matrix), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Nary), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Phantom), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Radical), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.PreSubSuper), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Subscript), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.SubSuperscript), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Superscript), 1, 1),
                                                                new CompositeParticle.Builder(ParticleType.Group, 1, 1)
                                                                {
                                                                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                                                                    {
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Run), 1, 1)
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                },
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.ControlProperties), 0, 1)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Denominator>(deep);
    }

    /// <summary>
    /// <para>Function Name.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:fName.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.Accent" /> <c>&lt;m:acc></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.Bar" /> <c>&lt;m:bar></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.BorderBox" /> <c>&lt;m:borderBox></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.Box" /> <c>&lt;m:box></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.ControlProperties" /> <c>&lt;m:ctrlPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.Delimiter" /> <c>&lt;m:d></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.EquationArray" /> <c>&lt;m:eqArr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.Fraction" /> <c>&lt;m:f></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.MathFunction" /> <c>&lt;m:func></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.GroupChar" /> <c>&lt;m:groupChr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.LimitLower" /> <c>&lt;m:limLow></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.LimitUpper" /> <c>&lt;m:limUpp></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.Matrix" /> <c>&lt;m:m></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.Nary" /> <c>&lt;m:nary></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.OfficeMath" /> <c>&lt;m:oMath></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.ArgumentProperties" /> <c>&lt;m:argPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.Paragraph" /> <c>&lt;m:oMathPara></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.Phantom" /> <c>&lt;m:phant></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.Run" /> <c>&lt;m:r></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.Radical" /> <c>&lt;m:rad></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.PreSubSuper" /> <c>&lt;m:sPre></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.Subscript" /> <c>&lt;m:sSub></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.SubSuperscript" /> <c>&lt;m:sSubSup></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.Superscript" /> <c>&lt;m:sSup></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.BookmarkStart" /> <c>&lt;w:bookmarkStart></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.ContentPart" /> <c>&lt;w:contentPart></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.CustomXmlRun" /> <c>&lt;w:customXml></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.Hyperlink" /> <c>&lt;w:hyperlink></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeEnd" /> <c>&lt;w:customXmlInsRangeEnd></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeEnd" /> <c>&lt;w:customXmlDelRangeEnd></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeEnd" /> <c>&lt;w:customXmlMoveFromRangeEnd></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeEnd" /> <c>&lt;w:customXmlMoveToRangeEnd></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictInsertionRangeEnd" /> <c>&lt;w14:customXmlConflictInsRangeEnd></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictDeletionRangeEnd" /> <c>&lt;w14:customXmlConflictDelRangeEnd></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.BookmarkEnd" /> <c>&lt;w:bookmarkEnd></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.CommentRangeStart" /> <c>&lt;w:commentRangeStart></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.CommentRangeEnd" /> <c>&lt;w:commentRangeEnd></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeEnd" /> <c>&lt;w:moveFromRangeEnd></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.MoveToRangeEnd" /> <c>&lt;w:moveToRangeEnd></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeStart" /> <c>&lt;w:moveFromRangeStart></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.MoveToRangeStart" /> <c>&lt;w:moveToRangeStart></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.PermEnd" /> <c>&lt;w:permEnd></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.PermStart" /> <c>&lt;w:permStart></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.ProofError" /> <c>&lt;w:proofErr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.InsertedRun" /> <c>&lt;w:ins></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.DeletedRun" /> <c>&lt;w:del></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.MoveFromRun" /> <c>&lt;w:moveFrom></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.MoveToRun" /> <c>&lt;w:moveTo></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.Word.RunConflictInsertion" /> <c>&lt;w14:conflictIns></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.Word.RunConflictDeletion" /> <c>&lt;w14:conflictDel></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.SdtRun" /> <c>&lt;w:sdt></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.SimpleField" /> <c>&lt;w:fldSimple></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeStart" /> <c>&lt;w:customXmlInsRangeStart></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeStart" /> <c>&lt;w:customXmlDelRangeStart></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeStart" /> <c>&lt;w:customXmlMoveFromRangeStart></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeStart" /> <c>&lt;w:customXmlMoveToRangeStart></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictInsertionRangeStart" /> <c>&lt;w14:customXmlConflictInsRangeStart></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictDeletionRangeStart" /> <c>&lt;w14:customXmlConflictDelRangeStart></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("m:fName")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class FunctionName : OfficeMathArgumentType
    {
        /// <summary>
        /// Initializes a new instance of the FunctionName class.
        /// </summary>
        public FunctionName() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the FunctionName class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public FunctionName(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the FunctionName class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public FunctionName(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the FunctionName class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public FunctionName(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("m:fName");
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.ArgumentProperties), 0, 1),
                new CompositeParticle.Builder(ParticleType.Group, 0, 0)
                {
                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                    {
                        new CompositeParticle.Builder(ParticleType.Group, 1, 1)
                        {
                            new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                            {
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Accent), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Bar), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Box), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.BorderBox), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Delimiter), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.EquationArray), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Fraction), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.MathFunction), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.GroupChar), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.LimitLower), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.LimitUpper), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Matrix), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Nary), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Phantom), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Radical), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.PreSubSuper), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Subscript), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.SubSuperscript), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Superscript), 1, 1),
                                new CompositeParticle.Builder(ParticleType.Group, 1, 1)
                                {
                                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                                    {
                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Run), 1, 1)
                                    }
                                }
                            }
                        },
                        new CompositeParticle.Builder(ParticleType.Group, 1, 1)
                        {
                            new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                            {
                                new CompositeParticle.Builder(ParticleType.Group, 0, 0)
                                {
                                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                                    {
                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlRun), 1, 1),
                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.SimpleField), 0, 0),
                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.Hyperlink), 1, 1)
                                    }
                                },
                                new CompositeParticle.Builder(ParticleType.Group, 0, 0)
                                {
                                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                                    {
                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.SdtRun), 1, 1),
                                        new CompositeParticle.Builder(ParticleType.Group, 0, 0)
                                        {
                                            new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                                            {
                                                new CompositeParticle.Builder(ParticleType.Group, 0, 0)
                                                {
                                                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                                                    {
                                                        new CompositeParticle.Builder(ParticleType.Group, 0, 0)
                                                        {
                                                            new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                                                            {
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.ProofError), 0, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.PermStart), 0, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.PermEnd), 0, 1)
                                                            }
                                                        },
                                                        new CompositeParticle.Builder(ParticleType.Group, 0, 0)
                                                        {
                                                            new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                                                            {
                                                                new CompositeParticle.Builder(ParticleType.Group, 0, 0)
                                                                {
                                                                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                                                                    {
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.BookmarkStart), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.BookmarkEnd), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CommentRangeStart), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CommentRangeEnd), 1, 1)
                                                                    }
                                                                },
                                                                new CompositeParticle.Builder(ParticleType.Group, 0, 0)
                                                                {
                                                                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                                                                    {
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeStart), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeEnd), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.MoveToRangeStart), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.MoveToRangeEnd), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeStart), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeEnd), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeStart), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeEnd), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeStart), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeEnd), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeStart), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeEnd), 1, 1)
                                                                    }
                                                                },
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictInsertionRangeStart), 0, 1, version: FileFormatVersions.Office2010),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictInsertionRangeEnd), 0, 1, version: FileFormatVersions.Office2010),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictDeletionRangeStart), 0, 1, version: FileFormatVersions.Office2010),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictDeletionRangeEnd), 0, 1, version: FileFormatVersions.Office2010)
                                                            }
                                                        },
                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.InsertedRun), 0, 1),
                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.DeletedRun), 0, 1),
                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.MoveFromRun), 1, 1),
                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.MoveToRun), 1, 1),
                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.ContentPart), 0, 0, version: FileFormatVersions.Office2010),
                                                        new CompositeParticle.Builder(ParticleType.Group, 0, 1, version: FileFormatVersions.Office2010)
                                                        {
                                                            new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
                                                            {
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.RunConflictInsertion), 0, 1, version: FileFormatVersions.Office2010),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.RunConflictDeletion), 0, 1, version: FileFormatVersions.Office2010)
                                                            }
                                                        }
                                                    }
                                                },
                                                new CompositeParticle.Builder(ParticleType.Group, 0, 0)
                                                {
                                                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                                                    {
                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Paragraph), 1, 1),
                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Math.OfficeMath), 1, 1),
                                                        new CompositeParticle.Builder(ParticleType.Group, 1, 1)
                                                        {
                                                            new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                                                            {
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Accent), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Bar), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Box), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.BorderBox), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Delimiter), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.EquationArray), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Fraction), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.MathFunction), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.GroupChar), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.LimitLower), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.LimitUpper), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Matrix), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Nary), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Phantom), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Radical), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.PreSubSuper), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Subscript), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.SubSuperscript), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Superscript), 1, 1),
                                                                new CompositeParticle.Builder(ParticleType.Group, 1, 1)
                                                                {
                                                                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                                                                    {
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Run), 1, 1)
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                },
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.ControlProperties), 0, 1)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<FunctionName>(deep);
    }

    /// <summary>
    /// <para>Limit (Lower).</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:lim.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.Accent" /> <c>&lt;m:acc></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.Bar" /> <c>&lt;m:bar></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.BorderBox" /> <c>&lt;m:borderBox></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.Box" /> <c>&lt;m:box></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.ControlProperties" /> <c>&lt;m:ctrlPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.Delimiter" /> <c>&lt;m:d></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.EquationArray" /> <c>&lt;m:eqArr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.Fraction" /> <c>&lt;m:f></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.MathFunction" /> <c>&lt;m:func></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.GroupChar" /> <c>&lt;m:groupChr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.LimitLower" /> <c>&lt;m:limLow></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.LimitUpper" /> <c>&lt;m:limUpp></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.Matrix" /> <c>&lt;m:m></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.Nary" /> <c>&lt;m:nary></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.OfficeMath" /> <c>&lt;m:oMath></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.ArgumentProperties" /> <c>&lt;m:argPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.Paragraph" /> <c>&lt;m:oMathPara></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.Phantom" /> <c>&lt;m:phant></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.Run" /> <c>&lt;m:r></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.Radical" /> <c>&lt;m:rad></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.PreSubSuper" /> <c>&lt;m:sPre></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.Subscript" /> <c>&lt;m:sSub></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.SubSuperscript" /> <c>&lt;m:sSubSup></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.Superscript" /> <c>&lt;m:sSup></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.BookmarkStart" /> <c>&lt;w:bookmarkStart></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.ContentPart" /> <c>&lt;w:contentPart></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.CustomXmlRun" /> <c>&lt;w:customXml></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.Hyperlink" /> <c>&lt;w:hyperlink></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeEnd" /> <c>&lt;w:customXmlInsRangeEnd></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeEnd" /> <c>&lt;w:customXmlDelRangeEnd></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeEnd" /> <c>&lt;w:customXmlMoveFromRangeEnd></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeEnd" /> <c>&lt;w:customXmlMoveToRangeEnd></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictInsertionRangeEnd" /> <c>&lt;w14:customXmlConflictInsRangeEnd></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictDeletionRangeEnd" /> <c>&lt;w14:customXmlConflictDelRangeEnd></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.BookmarkEnd" /> <c>&lt;w:bookmarkEnd></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.CommentRangeStart" /> <c>&lt;w:commentRangeStart></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.CommentRangeEnd" /> <c>&lt;w:commentRangeEnd></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeEnd" /> <c>&lt;w:moveFromRangeEnd></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.MoveToRangeEnd" /> <c>&lt;w:moveToRangeEnd></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeStart" /> <c>&lt;w:moveFromRangeStart></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.MoveToRangeStart" /> <c>&lt;w:moveToRangeStart></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.PermEnd" /> <c>&lt;w:permEnd></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.PermStart" /> <c>&lt;w:permStart></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.ProofError" /> <c>&lt;w:proofErr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.InsertedRun" /> <c>&lt;w:ins></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.DeletedRun" /> <c>&lt;w:del></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.MoveFromRun" /> <c>&lt;w:moveFrom></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.MoveToRun" /> <c>&lt;w:moveTo></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.Word.RunConflictInsertion" /> <c>&lt;w14:conflictIns></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.Word.RunConflictDeletion" /> <c>&lt;w14:conflictDel></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.SdtRun" /> <c>&lt;w:sdt></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.SimpleField" /> <c>&lt;w:fldSimple></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeStart" /> <c>&lt;w:customXmlInsRangeStart></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeStart" /> <c>&lt;w:customXmlDelRangeStart></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeStart" /> <c>&lt;w:customXmlMoveFromRangeStart></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeStart" /> <c>&lt;w:customXmlMoveToRangeStart></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictInsertionRangeStart" /> <c>&lt;w14:customXmlConflictInsRangeStart></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictDeletionRangeStart" /> <c>&lt;w14:customXmlConflictDelRangeStart></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("m:lim")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class Limit : OfficeMathArgumentType
    {
        /// <summary>
        /// Initializes a new instance of the Limit class.
        /// </summary>
        public Limit() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Limit class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Limit(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Limit class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Limit(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Limit class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Limit(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("m:lim");
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.ArgumentProperties), 0, 1),
                new CompositeParticle.Builder(ParticleType.Group, 0, 0)
                {
                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                    {
                        new CompositeParticle.Builder(ParticleType.Group, 1, 1)
                        {
                            new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                            {
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Accent), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Bar), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Box), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.BorderBox), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Delimiter), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.EquationArray), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Fraction), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.MathFunction), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.GroupChar), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.LimitLower), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.LimitUpper), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Matrix), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Nary), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Phantom), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Radical), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.PreSubSuper), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Subscript), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.SubSuperscript), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Superscript), 1, 1),
                                new CompositeParticle.Builder(ParticleType.Group, 1, 1)
                                {
                                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                                    {
                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Run), 1, 1)
                                    }
                                }
                            }
                        },
                        new CompositeParticle.Builder(ParticleType.Group, 1, 1)
                        {
                            new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                            {
                                new CompositeParticle.Builder(ParticleType.Group, 0, 0)
                                {
                                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                                    {
                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlRun), 1, 1),
                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.SimpleField), 0, 0),
                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.Hyperlink), 1, 1)
                                    }
                                },
                                new CompositeParticle.Builder(ParticleType.Group, 0, 0)
                                {
                                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                                    {
                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.SdtRun), 1, 1),
                                        new CompositeParticle.Builder(ParticleType.Group, 0, 0)
                                        {
                                            new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                                            {
                                                new CompositeParticle.Builder(ParticleType.Group, 0, 0)
                                                {
                                                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                                                    {
                                                        new CompositeParticle.Builder(ParticleType.Group, 0, 0)
                                                        {
                                                            new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                                                            {
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.ProofError), 0, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.PermStart), 0, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.PermEnd), 0, 1)
                                                            }
                                                        },
                                                        new CompositeParticle.Builder(ParticleType.Group, 0, 0)
                                                        {
                                                            new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                                                            {
                                                                new CompositeParticle.Builder(ParticleType.Group, 0, 0)
                                                                {
                                                                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                                                                    {
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.BookmarkStart), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.BookmarkEnd), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CommentRangeStart), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CommentRangeEnd), 1, 1)
                                                                    }
                                                                },
                                                                new CompositeParticle.Builder(ParticleType.Group, 0, 0)
                                                                {
                                                                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                                                                    {
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeStart), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeEnd), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.MoveToRangeStart), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.MoveToRangeEnd), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeStart), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeEnd), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeStart), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeEnd), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeStart), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeEnd), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeStart), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeEnd), 1, 1)
                                                                    }
                                                                },
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictInsertionRangeStart), 0, 1, version: FileFormatVersions.Office2010),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictInsertionRangeEnd), 0, 1, version: FileFormatVersions.Office2010),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictDeletionRangeStart), 0, 1, version: FileFormatVersions.Office2010),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictDeletionRangeEnd), 0, 1, version: FileFormatVersions.Office2010)
                                                            }
                                                        },
                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.InsertedRun), 0, 1),
                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.DeletedRun), 0, 1),
                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.MoveFromRun), 1, 1),
                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.MoveToRun), 1, 1),
                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.ContentPart), 0, 0, version: FileFormatVersions.Office2010),
                                                        new CompositeParticle.Builder(ParticleType.Group, 0, 1, version: FileFormatVersions.Office2010)
                                                        {
                                                            new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
                                                            {
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.RunConflictInsertion), 0, 1, version: FileFormatVersions.Office2010),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.RunConflictDeletion), 0, 1, version: FileFormatVersions.Office2010)
                                                            }
                                                        }
                                                    }
                                                },
                                                new CompositeParticle.Builder(ParticleType.Group, 0, 0)
                                                {
                                                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                                                    {
                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Paragraph), 1, 1),
                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Math.OfficeMath), 1, 1),
                                                        new CompositeParticle.Builder(ParticleType.Group, 1, 1)
                                                        {
                                                            new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                                                            {
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Accent), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Bar), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Box), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.BorderBox), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Delimiter), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.EquationArray), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Fraction), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.MathFunction), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.GroupChar), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.LimitLower), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.LimitUpper), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Matrix), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Nary), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Phantom), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Radical), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.PreSubSuper), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Subscript), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.SubSuperscript), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Superscript), 1, 1),
                                                                new CompositeParticle.Builder(ParticleType.Group, 1, 1)
                                                                {
                                                                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                                                                    {
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Run), 1, 1)
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                },
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.ControlProperties), 0, 1)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Limit>(deep);
    }

    /// <summary>
    /// <para>Lower limit (n-ary) .</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:sub.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.Accent" /> <c>&lt;m:acc></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.Bar" /> <c>&lt;m:bar></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.BorderBox" /> <c>&lt;m:borderBox></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.Box" /> <c>&lt;m:box></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.ControlProperties" /> <c>&lt;m:ctrlPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.Delimiter" /> <c>&lt;m:d></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.EquationArray" /> <c>&lt;m:eqArr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.Fraction" /> <c>&lt;m:f></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.MathFunction" /> <c>&lt;m:func></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.GroupChar" /> <c>&lt;m:groupChr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.LimitLower" /> <c>&lt;m:limLow></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.LimitUpper" /> <c>&lt;m:limUpp></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.Matrix" /> <c>&lt;m:m></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.Nary" /> <c>&lt;m:nary></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.OfficeMath" /> <c>&lt;m:oMath></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.ArgumentProperties" /> <c>&lt;m:argPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.Paragraph" /> <c>&lt;m:oMathPara></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.Phantom" /> <c>&lt;m:phant></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.Run" /> <c>&lt;m:r></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.Radical" /> <c>&lt;m:rad></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.PreSubSuper" /> <c>&lt;m:sPre></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.Subscript" /> <c>&lt;m:sSub></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.SubSuperscript" /> <c>&lt;m:sSubSup></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.Superscript" /> <c>&lt;m:sSup></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.BookmarkStart" /> <c>&lt;w:bookmarkStart></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.ContentPart" /> <c>&lt;w:contentPart></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.CustomXmlRun" /> <c>&lt;w:customXml></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.Hyperlink" /> <c>&lt;w:hyperlink></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeEnd" /> <c>&lt;w:customXmlInsRangeEnd></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeEnd" /> <c>&lt;w:customXmlDelRangeEnd></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeEnd" /> <c>&lt;w:customXmlMoveFromRangeEnd></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeEnd" /> <c>&lt;w:customXmlMoveToRangeEnd></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictInsertionRangeEnd" /> <c>&lt;w14:customXmlConflictInsRangeEnd></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictDeletionRangeEnd" /> <c>&lt;w14:customXmlConflictDelRangeEnd></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.BookmarkEnd" /> <c>&lt;w:bookmarkEnd></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.CommentRangeStart" /> <c>&lt;w:commentRangeStart></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.CommentRangeEnd" /> <c>&lt;w:commentRangeEnd></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeEnd" /> <c>&lt;w:moveFromRangeEnd></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.MoveToRangeEnd" /> <c>&lt;w:moveToRangeEnd></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeStart" /> <c>&lt;w:moveFromRangeStart></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.MoveToRangeStart" /> <c>&lt;w:moveToRangeStart></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.PermEnd" /> <c>&lt;w:permEnd></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.PermStart" /> <c>&lt;w:permStart></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.ProofError" /> <c>&lt;w:proofErr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.InsertedRun" /> <c>&lt;w:ins></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.DeletedRun" /> <c>&lt;w:del></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.MoveFromRun" /> <c>&lt;w:moveFrom></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.MoveToRun" /> <c>&lt;w:moveTo></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.Word.RunConflictInsertion" /> <c>&lt;w14:conflictIns></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.Word.RunConflictDeletion" /> <c>&lt;w14:conflictDel></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.SdtRun" /> <c>&lt;w:sdt></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.SimpleField" /> <c>&lt;w:fldSimple></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeStart" /> <c>&lt;w:customXmlInsRangeStart></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeStart" /> <c>&lt;w:customXmlDelRangeStart></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeStart" /> <c>&lt;w:customXmlMoveFromRangeStart></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeStart" /> <c>&lt;w:customXmlMoveToRangeStart></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictInsertionRangeStart" /> <c>&lt;w14:customXmlConflictInsRangeStart></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictDeletionRangeStart" /> <c>&lt;w14:customXmlConflictDelRangeStart></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("m:sub")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class SubArgument : OfficeMathArgumentType
    {
        /// <summary>
        /// Initializes a new instance of the SubArgument class.
        /// </summary>
        public SubArgument() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the SubArgument class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SubArgument(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SubArgument class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SubArgument(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SubArgument class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public SubArgument(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("m:sub");
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.ArgumentProperties), 0, 1),
                new CompositeParticle.Builder(ParticleType.Group, 0, 0)
                {
                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                    {
                        new CompositeParticle.Builder(ParticleType.Group, 1, 1)
                        {
                            new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                            {
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Accent), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Bar), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Box), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.BorderBox), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Delimiter), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.EquationArray), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Fraction), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.MathFunction), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.GroupChar), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.LimitLower), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.LimitUpper), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Matrix), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Nary), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Phantom), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Radical), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.PreSubSuper), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Subscript), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.SubSuperscript), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Superscript), 1, 1),
                                new CompositeParticle.Builder(ParticleType.Group, 1, 1)
                                {
                                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                                    {
                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Run), 1, 1)
                                    }
                                }
                            }
                        },
                        new CompositeParticle.Builder(ParticleType.Group, 1, 1)
                        {
                            new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                            {
                                new CompositeParticle.Builder(ParticleType.Group, 0, 0)
                                {
                                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                                    {
                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlRun), 1, 1),
                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.SimpleField), 0, 0),
                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.Hyperlink), 1, 1)
                                    }
                                },
                                new CompositeParticle.Builder(ParticleType.Group, 0, 0)
                                {
                                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                                    {
                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.SdtRun), 1, 1),
                                        new CompositeParticle.Builder(ParticleType.Group, 0, 0)
                                        {
                                            new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                                            {
                                                new CompositeParticle.Builder(ParticleType.Group, 0, 0)
                                                {
                                                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                                                    {
                                                        new CompositeParticle.Builder(ParticleType.Group, 0, 0)
                                                        {
                                                            new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                                                            {
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.ProofError), 0, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.PermStart), 0, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.PermEnd), 0, 1)
                                                            }
                                                        },
                                                        new CompositeParticle.Builder(ParticleType.Group, 0, 0)
                                                        {
                                                            new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                                                            {
                                                                new CompositeParticle.Builder(ParticleType.Group, 0, 0)
                                                                {
                                                                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                                                                    {
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.BookmarkStart), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.BookmarkEnd), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CommentRangeStart), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CommentRangeEnd), 1, 1)
                                                                    }
                                                                },
                                                                new CompositeParticle.Builder(ParticleType.Group, 0, 0)
                                                                {
                                                                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                                                                    {
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeStart), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeEnd), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.MoveToRangeStart), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.MoveToRangeEnd), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeStart), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeEnd), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeStart), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeEnd), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeStart), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeEnd), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeStart), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeEnd), 1, 1)
                                                                    }
                                                                },
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictInsertionRangeStart), 0, 1, version: FileFormatVersions.Office2010),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictInsertionRangeEnd), 0, 1, version: FileFormatVersions.Office2010),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictDeletionRangeStart), 0, 1, version: FileFormatVersions.Office2010),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictDeletionRangeEnd), 0, 1, version: FileFormatVersions.Office2010)
                                                            }
                                                        },
                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.InsertedRun), 0, 1),
                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.DeletedRun), 0, 1),
                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.MoveFromRun), 1, 1),
                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.MoveToRun), 1, 1),
                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.ContentPart), 0, 0, version: FileFormatVersions.Office2010),
                                                        new CompositeParticle.Builder(ParticleType.Group, 0, 1, version: FileFormatVersions.Office2010)
                                                        {
                                                            new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
                                                            {
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.RunConflictInsertion), 0, 1, version: FileFormatVersions.Office2010),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.RunConflictDeletion), 0, 1, version: FileFormatVersions.Office2010)
                                                            }
                                                        }
                                                    }
                                                },
                                                new CompositeParticle.Builder(ParticleType.Group, 0, 0)
                                                {
                                                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                                                    {
                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Paragraph), 1, 1),
                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Math.OfficeMath), 1, 1),
                                                        new CompositeParticle.Builder(ParticleType.Group, 1, 1)
                                                        {
                                                            new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                                                            {
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Accent), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Bar), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Box), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.BorderBox), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Delimiter), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.EquationArray), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Fraction), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.MathFunction), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.GroupChar), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.LimitLower), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.LimitUpper), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Matrix), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Nary), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Phantom), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Radical), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.PreSubSuper), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Subscript), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.SubSuperscript), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Superscript), 1, 1),
                                                                new CompositeParticle.Builder(ParticleType.Group, 1, 1)
                                                                {
                                                                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                                                                    {
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Run), 1, 1)
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                },
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.ControlProperties), 0, 1)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SubArgument>(deep);
    }

    /// <summary>
    /// <para>Upper limit (n-ary).</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:sup.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.Accent" /> <c>&lt;m:acc></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.Bar" /> <c>&lt;m:bar></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.BorderBox" /> <c>&lt;m:borderBox></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.Box" /> <c>&lt;m:box></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.ControlProperties" /> <c>&lt;m:ctrlPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.Delimiter" /> <c>&lt;m:d></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.EquationArray" /> <c>&lt;m:eqArr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.Fraction" /> <c>&lt;m:f></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.MathFunction" /> <c>&lt;m:func></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.GroupChar" /> <c>&lt;m:groupChr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.LimitLower" /> <c>&lt;m:limLow></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.LimitUpper" /> <c>&lt;m:limUpp></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.Matrix" /> <c>&lt;m:m></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.Nary" /> <c>&lt;m:nary></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.OfficeMath" /> <c>&lt;m:oMath></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.ArgumentProperties" /> <c>&lt;m:argPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.Paragraph" /> <c>&lt;m:oMathPara></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.Phantom" /> <c>&lt;m:phant></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.Run" /> <c>&lt;m:r></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.Radical" /> <c>&lt;m:rad></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.PreSubSuper" /> <c>&lt;m:sPre></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.Subscript" /> <c>&lt;m:sSub></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.SubSuperscript" /> <c>&lt;m:sSubSup></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.Superscript" /> <c>&lt;m:sSup></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.BookmarkStart" /> <c>&lt;w:bookmarkStart></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.ContentPart" /> <c>&lt;w:contentPart></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.CustomXmlRun" /> <c>&lt;w:customXml></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.Hyperlink" /> <c>&lt;w:hyperlink></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeEnd" /> <c>&lt;w:customXmlInsRangeEnd></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeEnd" /> <c>&lt;w:customXmlDelRangeEnd></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeEnd" /> <c>&lt;w:customXmlMoveFromRangeEnd></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeEnd" /> <c>&lt;w:customXmlMoveToRangeEnd></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictInsertionRangeEnd" /> <c>&lt;w14:customXmlConflictInsRangeEnd></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictDeletionRangeEnd" /> <c>&lt;w14:customXmlConflictDelRangeEnd></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.BookmarkEnd" /> <c>&lt;w:bookmarkEnd></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.CommentRangeStart" /> <c>&lt;w:commentRangeStart></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.CommentRangeEnd" /> <c>&lt;w:commentRangeEnd></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeEnd" /> <c>&lt;w:moveFromRangeEnd></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.MoveToRangeEnd" /> <c>&lt;w:moveToRangeEnd></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeStart" /> <c>&lt;w:moveFromRangeStart></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.MoveToRangeStart" /> <c>&lt;w:moveToRangeStart></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.PermEnd" /> <c>&lt;w:permEnd></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.PermStart" /> <c>&lt;w:permStart></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.ProofError" /> <c>&lt;w:proofErr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.InsertedRun" /> <c>&lt;w:ins></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.DeletedRun" /> <c>&lt;w:del></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.MoveFromRun" /> <c>&lt;w:moveFrom></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.MoveToRun" /> <c>&lt;w:moveTo></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.Word.RunConflictInsertion" /> <c>&lt;w14:conflictIns></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.Word.RunConflictDeletion" /> <c>&lt;w14:conflictDel></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.SdtRun" /> <c>&lt;w:sdt></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.SimpleField" /> <c>&lt;w:fldSimple></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeStart" /> <c>&lt;w:customXmlInsRangeStart></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeStart" /> <c>&lt;w:customXmlDelRangeStart></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeStart" /> <c>&lt;w:customXmlMoveFromRangeStart></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeStart" /> <c>&lt;w:customXmlMoveToRangeStart></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictInsertionRangeStart" /> <c>&lt;w14:customXmlConflictInsRangeStart></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictDeletionRangeStart" /> <c>&lt;w14:customXmlConflictDelRangeStart></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("m:sup")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class SuperArgument : OfficeMathArgumentType
    {
        /// <summary>
        /// Initializes a new instance of the SuperArgument class.
        /// </summary>
        public SuperArgument() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the SuperArgument class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SuperArgument(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SuperArgument class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SuperArgument(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SuperArgument class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public SuperArgument(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("m:sup");
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.ArgumentProperties), 0, 1),
                new CompositeParticle.Builder(ParticleType.Group, 0, 0)
                {
                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                    {
                        new CompositeParticle.Builder(ParticleType.Group, 1, 1)
                        {
                            new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                            {
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Accent), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Bar), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Box), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.BorderBox), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Delimiter), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.EquationArray), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Fraction), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.MathFunction), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.GroupChar), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.LimitLower), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.LimitUpper), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Matrix), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Nary), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Phantom), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Radical), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.PreSubSuper), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Subscript), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.SubSuperscript), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Superscript), 1, 1),
                                new CompositeParticle.Builder(ParticleType.Group, 1, 1)
                                {
                                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                                    {
                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Run), 1, 1)
                                    }
                                }
                            }
                        },
                        new CompositeParticle.Builder(ParticleType.Group, 1, 1)
                        {
                            new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                            {
                                new CompositeParticle.Builder(ParticleType.Group, 0, 0)
                                {
                                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                                    {
                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlRun), 1, 1),
                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.SimpleField), 0, 0),
                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.Hyperlink), 1, 1)
                                    }
                                },
                                new CompositeParticle.Builder(ParticleType.Group, 0, 0)
                                {
                                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                                    {
                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.SdtRun), 1, 1),
                                        new CompositeParticle.Builder(ParticleType.Group, 0, 0)
                                        {
                                            new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                                            {
                                                new CompositeParticle.Builder(ParticleType.Group, 0, 0)
                                                {
                                                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                                                    {
                                                        new CompositeParticle.Builder(ParticleType.Group, 0, 0)
                                                        {
                                                            new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                                                            {
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.ProofError), 0, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.PermStart), 0, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.PermEnd), 0, 1)
                                                            }
                                                        },
                                                        new CompositeParticle.Builder(ParticleType.Group, 0, 0)
                                                        {
                                                            new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                                                            {
                                                                new CompositeParticle.Builder(ParticleType.Group, 0, 0)
                                                                {
                                                                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                                                                    {
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.BookmarkStart), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.BookmarkEnd), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CommentRangeStart), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CommentRangeEnd), 1, 1)
                                                                    }
                                                                },
                                                                new CompositeParticle.Builder(ParticleType.Group, 0, 0)
                                                                {
                                                                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                                                                    {
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeStart), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeEnd), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.MoveToRangeStart), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.MoveToRangeEnd), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeStart), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeEnd), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeStart), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeEnd), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeStart), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeEnd), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeStart), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeEnd), 1, 1)
                                                                    }
                                                                },
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictInsertionRangeStart), 0, 1, version: FileFormatVersions.Office2010),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictInsertionRangeEnd), 0, 1, version: FileFormatVersions.Office2010),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictDeletionRangeStart), 0, 1, version: FileFormatVersions.Office2010),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictDeletionRangeEnd), 0, 1, version: FileFormatVersions.Office2010)
                                                            }
                                                        },
                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.InsertedRun), 0, 1),
                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.DeletedRun), 0, 1),
                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.MoveFromRun), 1, 1),
                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.MoveToRun), 1, 1),
                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.ContentPart), 0, 0, version: FileFormatVersions.Office2010),
                                                        new CompositeParticle.Builder(ParticleType.Group, 0, 1, version: FileFormatVersions.Office2010)
                                                        {
                                                            new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
                                                            {
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.RunConflictInsertion), 0, 1, version: FileFormatVersions.Office2010),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.RunConflictDeletion), 0, 1, version: FileFormatVersions.Office2010)
                                                            }
                                                        }
                                                    }
                                                },
                                                new CompositeParticle.Builder(ParticleType.Group, 0, 0)
                                                {
                                                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                                                    {
                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Paragraph), 1, 1),
                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Math.OfficeMath), 1, 1),
                                                        new CompositeParticle.Builder(ParticleType.Group, 1, 1)
                                                        {
                                                            new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                                                            {
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Accent), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Bar), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Box), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.BorderBox), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Delimiter), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.EquationArray), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Fraction), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.MathFunction), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.GroupChar), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.LimitLower), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.LimitUpper), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Matrix), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Nary), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Phantom), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Radical), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.PreSubSuper), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Subscript), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.SubSuperscript), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Superscript), 1, 1),
                                                                new CompositeParticle.Builder(ParticleType.Group, 1, 1)
                                                                {
                                                                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                                                                    {
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Run), 1, 1)
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                },
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.ControlProperties), 0, 1)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SuperArgument>(deep);
    }

    /// <summary>
    /// <para>Degree.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:deg.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.Accent" /> <c>&lt;m:acc></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.Bar" /> <c>&lt;m:bar></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.BorderBox" /> <c>&lt;m:borderBox></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.Box" /> <c>&lt;m:box></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.ControlProperties" /> <c>&lt;m:ctrlPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.Delimiter" /> <c>&lt;m:d></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.EquationArray" /> <c>&lt;m:eqArr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.Fraction" /> <c>&lt;m:f></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.MathFunction" /> <c>&lt;m:func></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.GroupChar" /> <c>&lt;m:groupChr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.LimitLower" /> <c>&lt;m:limLow></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.LimitUpper" /> <c>&lt;m:limUpp></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.Matrix" /> <c>&lt;m:m></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.Nary" /> <c>&lt;m:nary></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.OfficeMath" /> <c>&lt;m:oMath></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.ArgumentProperties" /> <c>&lt;m:argPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.Paragraph" /> <c>&lt;m:oMathPara></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.Phantom" /> <c>&lt;m:phant></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.Run" /> <c>&lt;m:r></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.Radical" /> <c>&lt;m:rad></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.PreSubSuper" /> <c>&lt;m:sPre></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.Subscript" /> <c>&lt;m:sSub></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.SubSuperscript" /> <c>&lt;m:sSubSup></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.Superscript" /> <c>&lt;m:sSup></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.BookmarkStart" /> <c>&lt;w:bookmarkStart></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.ContentPart" /> <c>&lt;w:contentPart></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.CustomXmlRun" /> <c>&lt;w:customXml></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.Hyperlink" /> <c>&lt;w:hyperlink></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeEnd" /> <c>&lt;w:customXmlInsRangeEnd></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeEnd" /> <c>&lt;w:customXmlDelRangeEnd></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeEnd" /> <c>&lt;w:customXmlMoveFromRangeEnd></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeEnd" /> <c>&lt;w:customXmlMoveToRangeEnd></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictInsertionRangeEnd" /> <c>&lt;w14:customXmlConflictInsRangeEnd></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictDeletionRangeEnd" /> <c>&lt;w14:customXmlConflictDelRangeEnd></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.BookmarkEnd" /> <c>&lt;w:bookmarkEnd></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.CommentRangeStart" /> <c>&lt;w:commentRangeStart></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.CommentRangeEnd" /> <c>&lt;w:commentRangeEnd></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeEnd" /> <c>&lt;w:moveFromRangeEnd></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.MoveToRangeEnd" /> <c>&lt;w:moveToRangeEnd></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeStart" /> <c>&lt;w:moveFromRangeStart></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.MoveToRangeStart" /> <c>&lt;w:moveToRangeStart></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.PermEnd" /> <c>&lt;w:permEnd></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.PermStart" /> <c>&lt;w:permStart></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.ProofError" /> <c>&lt;w:proofErr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.InsertedRun" /> <c>&lt;w:ins></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.DeletedRun" /> <c>&lt;w:del></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.MoveFromRun" /> <c>&lt;w:moveFrom></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.MoveToRun" /> <c>&lt;w:moveTo></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.Word.RunConflictInsertion" /> <c>&lt;w14:conflictIns></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.Word.RunConflictDeletion" /> <c>&lt;w14:conflictDel></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.SdtRun" /> <c>&lt;w:sdt></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.SimpleField" /> <c>&lt;w:fldSimple></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeStart" /> <c>&lt;w:customXmlInsRangeStart></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeStart" /> <c>&lt;w:customXmlDelRangeStart></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeStart" /> <c>&lt;w:customXmlMoveFromRangeStart></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeStart" /> <c>&lt;w:customXmlMoveToRangeStart></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictInsertionRangeStart" /> <c>&lt;w14:customXmlConflictInsRangeStart></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictDeletionRangeStart" /> <c>&lt;w14:customXmlConflictDelRangeStart></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("m:deg")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class Degree : OfficeMathArgumentType
    {
        /// <summary>
        /// Initializes a new instance of the Degree class.
        /// </summary>
        public Degree() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Degree class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Degree(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Degree class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Degree(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Degree class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Degree(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("m:deg");
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.ArgumentProperties), 0, 1),
                new CompositeParticle.Builder(ParticleType.Group, 0, 0)
                {
                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                    {
                        new CompositeParticle.Builder(ParticleType.Group, 1, 1)
                        {
                            new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                            {
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Accent), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Bar), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Box), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.BorderBox), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Delimiter), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.EquationArray), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Fraction), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.MathFunction), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.GroupChar), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.LimitLower), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.LimitUpper), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Matrix), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Nary), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Phantom), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Radical), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.PreSubSuper), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Subscript), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.SubSuperscript), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Superscript), 1, 1),
                                new CompositeParticle.Builder(ParticleType.Group, 1, 1)
                                {
                                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                                    {
                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Run), 1, 1)
                                    }
                                }
                            }
                        },
                        new CompositeParticle.Builder(ParticleType.Group, 1, 1)
                        {
                            new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                            {
                                new CompositeParticle.Builder(ParticleType.Group, 0, 0)
                                {
                                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                                    {
                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlRun), 1, 1),
                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.SimpleField), 0, 0),
                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.Hyperlink), 1, 1)
                                    }
                                },
                                new CompositeParticle.Builder(ParticleType.Group, 0, 0)
                                {
                                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                                    {
                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.SdtRun), 1, 1),
                                        new CompositeParticle.Builder(ParticleType.Group, 0, 0)
                                        {
                                            new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                                            {
                                                new CompositeParticle.Builder(ParticleType.Group, 0, 0)
                                                {
                                                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                                                    {
                                                        new CompositeParticle.Builder(ParticleType.Group, 0, 0)
                                                        {
                                                            new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                                                            {
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.ProofError), 0, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.PermStart), 0, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.PermEnd), 0, 1)
                                                            }
                                                        },
                                                        new CompositeParticle.Builder(ParticleType.Group, 0, 0)
                                                        {
                                                            new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                                                            {
                                                                new CompositeParticle.Builder(ParticleType.Group, 0, 0)
                                                                {
                                                                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                                                                    {
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.BookmarkStart), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.BookmarkEnd), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CommentRangeStart), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CommentRangeEnd), 1, 1)
                                                                    }
                                                                },
                                                                new CompositeParticle.Builder(ParticleType.Group, 0, 0)
                                                                {
                                                                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                                                                    {
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeStart), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeEnd), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.MoveToRangeStart), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.MoveToRangeEnd), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeStart), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeEnd), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeStart), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeEnd), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeStart), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeEnd), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeStart), 1, 1),
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeEnd), 1, 1)
                                                                    }
                                                                },
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictInsertionRangeStart), 0, 1, version: FileFormatVersions.Office2010),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictInsertionRangeEnd), 0, 1, version: FileFormatVersions.Office2010),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictDeletionRangeStart), 0, 1, version: FileFormatVersions.Office2010),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictDeletionRangeEnd), 0, 1, version: FileFormatVersions.Office2010)
                                                            }
                                                        },
                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.InsertedRun), 0, 1),
                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.DeletedRun), 0, 1),
                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.MoveFromRun), 1, 1),
                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.MoveToRun), 1, 1),
                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.ContentPart), 0, 0, version: FileFormatVersions.Office2010),
                                                        new CompositeParticle.Builder(ParticleType.Group, 0, 1, version: FileFormatVersions.Office2010)
                                                        {
                                                            new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
                                                            {
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.RunConflictInsertion), 0, 1, version: FileFormatVersions.Office2010),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.RunConflictDeletion), 0, 1, version: FileFormatVersions.Office2010)
                                                            }
                                                        }
                                                    }
                                                },
                                                new CompositeParticle.Builder(ParticleType.Group, 0, 0)
                                                {
                                                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                                                    {
                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Paragraph), 1, 1),
                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Math.OfficeMath), 1, 1),
                                                        new CompositeParticle.Builder(ParticleType.Group, 1, 1)
                                                        {
                                                            new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                                                            {
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Accent), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Bar), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Box), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.BorderBox), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Delimiter), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.EquationArray), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Fraction), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.MathFunction), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.GroupChar), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.LimitLower), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.LimitUpper), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Matrix), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Nary), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Phantom), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Radical), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.PreSubSuper), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Subscript), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.SubSuperscript), 1, 1),
                                                                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Superscript), 1, 1),
                                                                new CompositeParticle.Builder(ParticleType.Group, 1, 1)
                                                                {
                                                                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                                                                    {
                                                                        new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Run), 1, 1)
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                },
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.ControlProperties), 0, 1)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Degree>(deep);
    }

    /// <summary>
    /// <para>Defines the OfficeMathArgumentType Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is :.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.Accent" /> <c>&lt;m:acc></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.Bar" /> <c>&lt;m:bar></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.BorderBox" /> <c>&lt;m:borderBox></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.Box" /> <c>&lt;m:box></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.ControlProperties" /> <c>&lt;m:ctrlPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.Delimiter" /> <c>&lt;m:d></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.EquationArray" /> <c>&lt;m:eqArr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.Fraction" /> <c>&lt;m:f></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.MathFunction" /> <c>&lt;m:func></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.GroupChar" /> <c>&lt;m:groupChr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.LimitLower" /> <c>&lt;m:limLow></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.LimitUpper" /> <c>&lt;m:limUpp></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.Matrix" /> <c>&lt;m:m></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.Nary" /> <c>&lt;m:nary></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.OfficeMath" /> <c>&lt;m:oMath></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.ArgumentProperties" /> <c>&lt;m:argPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.Paragraph" /> <c>&lt;m:oMathPara></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.Phantom" /> <c>&lt;m:phant></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.Run" /> <c>&lt;m:r></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.Radical" /> <c>&lt;m:rad></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.PreSubSuper" /> <c>&lt;m:sPre></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.Subscript" /> <c>&lt;m:sSub></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.SubSuperscript" /> <c>&lt;m:sSubSup></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.Superscript" /> <c>&lt;m:sSup></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.BookmarkStart" /> <c>&lt;w:bookmarkStart></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.ContentPart" /> <c>&lt;w:contentPart></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.CustomXmlRun" /> <c>&lt;w:customXml></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.Hyperlink" /> <c>&lt;w:hyperlink></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeEnd" /> <c>&lt;w:customXmlInsRangeEnd></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeEnd" /> <c>&lt;w:customXmlDelRangeEnd></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeEnd" /> <c>&lt;w:customXmlMoveFromRangeEnd></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeEnd" /> <c>&lt;w:customXmlMoveToRangeEnd></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictInsertionRangeEnd" /> <c>&lt;w14:customXmlConflictInsRangeEnd></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictDeletionRangeEnd" /> <c>&lt;w14:customXmlConflictDelRangeEnd></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.BookmarkEnd" /> <c>&lt;w:bookmarkEnd></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.CommentRangeStart" /> <c>&lt;w:commentRangeStart></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.CommentRangeEnd" /> <c>&lt;w:commentRangeEnd></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeEnd" /> <c>&lt;w:moveFromRangeEnd></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.MoveToRangeEnd" /> <c>&lt;w:moveToRangeEnd></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeStart" /> <c>&lt;w:moveFromRangeStart></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.MoveToRangeStart" /> <c>&lt;w:moveToRangeStart></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.PermEnd" /> <c>&lt;w:permEnd></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.PermStart" /> <c>&lt;w:permStart></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.ProofError" /> <c>&lt;w:proofErr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.InsertedRun" /> <c>&lt;w:ins></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.DeletedRun" /> <c>&lt;w:del></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.MoveFromRun" /> <c>&lt;w:moveFrom></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.MoveToRun" /> <c>&lt;w:moveTo></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.Word.RunConflictInsertion" /> <c>&lt;w14:conflictIns></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.Word.RunConflictDeletion" /> <c>&lt;w14:conflictDel></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.SdtRun" /> <c>&lt;w:sdt></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.SimpleField" /> <c>&lt;w:fldSimple></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeStart" /> <c>&lt;w:customXmlInsRangeStart></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeStart" /> <c>&lt;w:customXmlDelRangeStart></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeStart" /> <c>&lt;w:customXmlMoveFromRangeStart></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeStart" /> <c>&lt;w:customXmlMoveToRangeStart></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictInsertionRangeStart" /> <c>&lt;w14:customXmlConflictInsRangeStart></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictDeletionRangeStart" /> <c>&lt;w14:customXmlConflictDelRangeStart></c></description></item>
    /// </list>
    /// </remark>
    public abstract partial class OfficeMathArgumentType : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the OfficeMathArgumentType class.
        /// </summary>
        protected OfficeMathArgumentType() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the OfficeMathArgumentType class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        protected OfficeMathArgumentType(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the OfficeMathArgumentType class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        protected OfficeMathArgumentType(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the OfficeMathArgumentType class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        protected OfficeMathArgumentType(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddChild<DocumentFormat.OpenXml.Math.Accent>();
            builder.AddChild<DocumentFormat.OpenXml.Math.Bar>();
            builder.AddChild<DocumentFormat.OpenXml.Math.BorderBox>();
            builder.AddChild<DocumentFormat.OpenXml.Math.Box>();
            builder.AddChild<DocumentFormat.OpenXml.Math.ControlProperties>();
            builder.AddChild<DocumentFormat.OpenXml.Math.Delimiter>();
            builder.AddChild<DocumentFormat.OpenXml.Math.EquationArray>();
            builder.AddChild<DocumentFormat.OpenXml.Math.Fraction>();
            builder.AddChild<DocumentFormat.OpenXml.Math.MathFunction>();
            builder.AddChild<DocumentFormat.OpenXml.Math.GroupChar>();
            builder.AddChild<DocumentFormat.OpenXml.Math.LimitLower>();
            builder.AddChild<DocumentFormat.OpenXml.Math.LimitUpper>();
            builder.AddChild<DocumentFormat.OpenXml.Math.Matrix>();
            builder.AddChild<DocumentFormat.OpenXml.Math.Nary>();
            builder.AddChild<DocumentFormat.OpenXml.Math.OfficeMath>();
            builder.AddChild<DocumentFormat.OpenXml.Math.ArgumentProperties>();
            builder.AddChild<DocumentFormat.OpenXml.Math.Paragraph>();
            builder.AddChild<DocumentFormat.OpenXml.Math.Phantom>();
            builder.AddChild<DocumentFormat.OpenXml.Math.Run>();
            builder.AddChild<DocumentFormat.OpenXml.Math.Radical>();
            builder.AddChild<DocumentFormat.OpenXml.Math.PreSubSuper>();
            builder.AddChild<DocumentFormat.OpenXml.Math.Subscript>();
            builder.AddChild<DocumentFormat.OpenXml.Math.SubSuperscript>();
            builder.AddChild<DocumentFormat.OpenXml.Math.Superscript>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.BookmarkStart>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.ContentPart>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.CustomXmlRun>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.Hyperlink>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeEnd>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeEnd>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeEnd>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeEnd>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictInsertionRangeEnd>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictDeletionRangeEnd>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.BookmarkEnd>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.CommentRangeStart>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.CommentRangeEnd>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeEnd>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.MoveToRangeEnd>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeStart>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.MoveToRangeStart>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.PermEnd>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.PermStart>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.ProofError>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.InsertedRun>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.DeletedRun>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.MoveFromRun>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.MoveToRun>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.Word.RunConflictInsertion>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.Word.RunConflictDeletion>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.SdtRun>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.SimpleField>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeStart>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeStart>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeStart>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeStart>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictInsertionRangeStart>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictDeletionRangeStart>();
        }

        /// <summary>
        /// <para>Argument Properties.</para>
        /// <para>Represents the following element tag in the schema: m:argPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public DocumentFormat.OpenXml.Math.ArgumentProperties? ArgumentProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Math.ArgumentProperties>();
            set => SetElement(value);
        }
    }

    /// <summary>
    /// <para>Position (Bar).</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:pos.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("m:pos")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class Position : TopBottomType
    {
        /// <summary>
        /// Initializes a new instance of the Position class.
        /// </summary>
        public Position() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("m:pos");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Position>(deep);
    }

    /// <summary>
    /// <para>Vertical Justification.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:vertJc.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("m:vertJc")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class VerticalJustification : TopBottomType
    {
        /// <summary>
        /// Initializes a new instance of the VerticalJustification class.
        /// </summary>
        public VerticalJustification() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("m:vertJc");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<VerticalJustification>(deep);
    }

    /// <summary>
    /// <para>Defines the TopBottomType Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is :.</para>
    /// </summary>
    public abstract partial class TopBottomType : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the TopBottomType class.
        /// </summary>
        protected TopBottomType() : base()
        {
        }

        /// <summary>
        /// <para>Value</para>
        /// <para>Represents the following attribute in the schema: m:val</para>
        /// </summary>
        /// <remark>
        /// xmlns:m=http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("m:val")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Math.VerticalJustificationValues>? Val
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Math.VerticalJustificationValues>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddElement<TopBottomType>()
                           .AddAttribute("m:val", a => a.Val, aBuilder =>
                           {
                               aBuilder.AddValidator(RequiredValidator.Instance);
                           });
        }
    }

    /// <summary>
    /// <para>Bar Properties.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:barPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.ControlProperties" /> <c>&lt;m:ctrlPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.Position" /> <c>&lt;m:pos></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("m:barPr")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class BarProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the BarProperties class.
        /// </summary>
        public BarProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the BarProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public BarProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the BarProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public BarProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the BarProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public BarProperties(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("m:barPr");
            builder.AddChild<DocumentFormat.OpenXml.Math.ControlProperties>();
            builder.AddChild<DocumentFormat.OpenXml.Math.Position>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Position), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.ControlProperties), 0, 1)
            };
        }

        /// <summary>
        /// <para>Position (Bar).</para>
        /// <para>Represents the following element tag in the schema: m:pos.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public DocumentFormat.OpenXml.Math.Position? Position
        {
            get => GetElement<DocumentFormat.OpenXml.Math.Position>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ControlProperties.</para>
        /// <para>Represents the following element tag in the schema: m:ctrlPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public DocumentFormat.OpenXml.Math.ControlProperties? ControlProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Math.ControlProperties>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<BarProperties>(deep);
    }

    /// <summary>
    /// <para>Box Properties.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:boxPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.ControlProperties" /> <c>&lt;m:ctrlPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.Break" /> <c>&lt;m:brk></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.OperatorEmulator" /> <c>&lt;m:opEmu></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.NoBreak" /> <c>&lt;m:noBreak></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.Differential" /> <c>&lt;m:diff></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.Alignment" /> <c>&lt;m:aln></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("m:boxPr")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class BoxProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the BoxProperties class.
        /// </summary>
        public BoxProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the BoxProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public BoxProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the BoxProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public BoxProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the BoxProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public BoxProperties(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("m:boxPr");
            builder.AddChild<DocumentFormat.OpenXml.Math.ControlProperties>();
            builder.AddChild<DocumentFormat.OpenXml.Math.Break>();
            builder.AddChild<DocumentFormat.OpenXml.Math.OperatorEmulator>();
            builder.AddChild<DocumentFormat.OpenXml.Math.NoBreak>();
            builder.AddChild<DocumentFormat.OpenXml.Math.Differential>();
            builder.AddChild<DocumentFormat.OpenXml.Math.Alignment>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.OperatorEmulator), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.NoBreak), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Differential), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Break), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Alignment), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.ControlProperties), 0, 1)
            };
        }

        /// <summary>
        /// <para>Operator Emulator.</para>
        /// <para>Represents the following element tag in the schema: m:opEmu.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public DocumentFormat.OpenXml.Math.OperatorEmulator? OperatorEmulator
        {
            get => GetElement<DocumentFormat.OpenXml.Math.OperatorEmulator>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>No Break.</para>
        /// <para>Represents the following element tag in the schema: m:noBreak.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public DocumentFormat.OpenXml.Math.NoBreak? NoBreak
        {
            get => GetElement<DocumentFormat.OpenXml.Math.NoBreak>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Differential.</para>
        /// <para>Represents the following element tag in the schema: m:diff.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public DocumentFormat.OpenXml.Math.Differential? Differential
        {
            get => GetElement<DocumentFormat.OpenXml.Math.Differential>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Break.</para>
        /// <para>Represents the following element tag in the schema: m:brk.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public DocumentFormat.OpenXml.Math.Break? Break
        {
            get => GetElement<DocumentFormat.OpenXml.Math.Break>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Alignment.</para>
        /// <para>Represents the following element tag in the schema: m:aln.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public DocumentFormat.OpenXml.Math.Alignment? Alignment
        {
            get => GetElement<DocumentFormat.OpenXml.Math.Alignment>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ControlProperties.</para>
        /// <para>Represents the following element tag in the schema: m:ctrlPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public DocumentFormat.OpenXml.Math.ControlProperties? ControlProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Math.ControlProperties>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<BoxProperties>(deep);
    }

    /// <summary>
    /// <para>Border Box Properties.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:borderBoxPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.ControlProperties" /> <c>&lt;m:ctrlPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.HideTop" /> <c>&lt;m:hideTop></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.HideBottom" /> <c>&lt;m:hideBot></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.HideLeft" /> <c>&lt;m:hideLeft></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.HideRight" /> <c>&lt;m:hideRight></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.StrikeHorizontal" /> <c>&lt;m:strikeH></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.StrikeVertical" /> <c>&lt;m:strikeV></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.StrikeBottomLeftToTopRight" /> <c>&lt;m:strikeBLTR></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.StrikeTopLeftToBottomRight" /> <c>&lt;m:strikeTLBR></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("m:borderBoxPr")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class BorderBoxProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the BorderBoxProperties class.
        /// </summary>
        public BorderBoxProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the BorderBoxProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public BorderBoxProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the BorderBoxProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public BorderBoxProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the BorderBoxProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public BorderBoxProperties(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("m:borderBoxPr");
            builder.AddChild<DocumentFormat.OpenXml.Math.ControlProperties>();
            builder.AddChild<DocumentFormat.OpenXml.Math.HideTop>();
            builder.AddChild<DocumentFormat.OpenXml.Math.HideBottom>();
            builder.AddChild<DocumentFormat.OpenXml.Math.HideLeft>();
            builder.AddChild<DocumentFormat.OpenXml.Math.HideRight>();
            builder.AddChild<DocumentFormat.OpenXml.Math.StrikeHorizontal>();
            builder.AddChild<DocumentFormat.OpenXml.Math.StrikeVertical>();
            builder.AddChild<DocumentFormat.OpenXml.Math.StrikeBottomLeftToTopRight>();
            builder.AddChild<DocumentFormat.OpenXml.Math.StrikeTopLeftToBottomRight>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.HideTop), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.HideBottom), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.HideLeft), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.HideRight), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.StrikeHorizontal), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.StrikeVertical), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.StrikeBottomLeftToTopRight), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.StrikeTopLeftToBottomRight), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.ControlProperties), 0, 1)
            };
        }

        /// <summary>
        /// <para>Hide Top Edge.</para>
        /// <para>Represents the following element tag in the schema: m:hideTop.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public DocumentFormat.OpenXml.Math.HideTop? HideTop
        {
            get => GetElement<DocumentFormat.OpenXml.Math.HideTop>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Hide Bottom Edge.</para>
        /// <para>Represents the following element tag in the schema: m:hideBot.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public DocumentFormat.OpenXml.Math.HideBottom? HideBottom
        {
            get => GetElement<DocumentFormat.OpenXml.Math.HideBottom>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Hide Left Edge.</para>
        /// <para>Represents the following element tag in the schema: m:hideLeft.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public DocumentFormat.OpenXml.Math.HideLeft? HideLeft
        {
            get => GetElement<DocumentFormat.OpenXml.Math.HideLeft>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Hide Right Edge.</para>
        /// <para>Represents the following element tag in the schema: m:hideRight.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public DocumentFormat.OpenXml.Math.HideRight? HideRight
        {
            get => GetElement<DocumentFormat.OpenXml.Math.HideRight>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Border Box Strikethrough Horizontal.</para>
        /// <para>Represents the following element tag in the schema: m:strikeH.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public DocumentFormat.OpenXml.Math.StrikeHorizontal? StrikeHorizontal
        {
            get => GetElement<DocumentFormat.OpenXml.Math.StrikeHorizontal>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Border Box Strikethrough Vertical.</para>
        /// <para>Represents the following element tag in the schema: m:strikeV.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public DocumentFormat.OpenXml.Math.StrikeVertical? StrikeVertical
        {
            get => GetElement<DocumentFormat.OpenXml.Math.StrikeVertical>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Border Box Strikethrough Bottom-Left to Top-Right.</para>
        /// <para>Represents the following element tag in the schema: m:strikeBLTR.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public DocumentFormat.OpenXml.Math.StrikeBottomLeftToTopRight? StrikeBottomLeftToTopRight
        {
            get => GetElement<DocumentFormat.OpenXml.Math.StrikeBottomLeftToTopRight>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Border Box Strikethrough Top-Left to Bottom-Right.</para>
        /// <para>Represents the following element tag in the schema: m:strikeTLBR.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public DocumentFormat.OpenXml.Math.StrikeTopLeftToBottomRight? StrikeTopLeftToBottomRight
        {
            get => GetElement<DocumentFormat.OpenXml.Math.StrikeTopLeftToBottomRight>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ControlProperties.</para>
        /// <para>Represents the following element tag in the schema: m:ctrlPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public DocumentFormat.OpenXml.Math.ControlProperties? ControlProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Math.ControlProperties>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<BorderBoxProperties>(deep);
    }

    /// <summary>
    /// <para>Shape (Delimiters).</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:shp.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("m:shp")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class Shape : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the Shape class.
        /// </summary>
        public Shape() : base()
        {
        }

        /// <summary>
        /// <para>Value</para>
        /// <para>Represents the following attribute in the schema: m:val</para>
        /// </summary>
        /// <remark>
        /// xmlns:m=http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("m:val")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Math.ShapeDelimiterValues>? Val
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Math.ShapeDelimiterValues>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("m:shp");
            builder.AddElement<Shape>()
.AddAttribute("m:val", a => a.Val, aBuilder =>
{
    aBuilder.AddValidator(RequiredValidator.Instance);
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Shape>(deep);
    }

    /// <summary>
    /// <para>Delimiter Properties.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:dPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.BeginChar" /> <c>&lt;m:begChr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.SeparatorChar" /> <c>&lt;m:sepChr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.EndChar" /> <c>&lt;m:endChr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.ControlProperties" /> <c>&lt;m:ctrlPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.GrowOperators" /> <c>&lt;m:grow></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.Shape" /> <c>&lt;m:shp></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("m:dPr")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class DelimiterProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the DelimiterProperties class.
        /// </summary>
        public DelimiterProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the DelimiterProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DelimiterProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DelimiterProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DelimiterProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DelimiterProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public DelimiterProperties(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("m:dPr");
            builder.AddChild<DocumentFormat.OpenXml.Math.BeginChar>();
            builder.AddChild<DocumentFormat.OpenXml.Math.SeparatorChar>();
            builder.AddChild<DocumentFormat.OpenXml.Math.EndChar>();
            builder.AddChild<DocumentFormat.OpenXml.Math.ControlProperties>();
            builder.AddChild<DocumentFormat.OpenXml.Math.GrowOperators>();
            builder.AddChild<DocumentFormat.OpenXml.Math.Shape>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.BeginChar), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.SeparatorChar), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.EndChar), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.GrowOperators), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Shape), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.ControlProperties), 0, 1)
            };
        }

        /// <summary>
        /// <para>Delimiter Beginning Character.</para>
        /// <para>Represents the following element tag in the schema: m:begChr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public DocumentFormat.OpenXml.Math.BeginChar? BeginChar
        {
            get => GetElement<DocumentFormat.OpenXml.Math.BeginChar>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Delimiter Separator Character.</para>
        /// <para>Represents the following element tag in the schema: m:sepChr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public DocumentFormat.OpenXml.Math.SeparatorChar? SeparatorChar
        {
            get => GetElement<DocumentFormat.OpenXml.Math.SeparatorChar>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Delimiter Ending Character.</para>
        /// <para>Represents the following element tag in the schema: m:endChr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public DocumentFormat.OpenXml.Math.EndChar? EndChar
        {
            get => GetElement<DocumentFormat.OpenXml.Math.EndChar>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Delimiter Grow.</para>
        /// <para>Represents the following element tag in the schema: m:grow.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public DocumentFormat.OpenXml.Math.GrowOperators? GrowOperators
        {
            get => GetElement<DocumentFormat.OpenXml.Math.GrowOperators>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Shape (Delimiters).</para>
        /// <para>Represents the following element tag in the schema: m:shp.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public DocumentFormat.OpenXml.Math.Shape? Shape
        {
            get => GetElement<DocumentFormat.OpenXml.Math.Shape>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ControlProperties.</para>
        /// <para>Represents the following element tag in the schema: m:ctrlPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public DocumentFormat.OpenXml.Math.ControlProperties? ControlProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Math.ControlProperties>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DelimiterProperties>(deep);
    }

    /// <summary>
    /// <para>Equation Array Base Justification.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:baseJc.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("m:baseJc")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class BaseJustification : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the BaseJustification class.
        /// </summary>
        public BaseJustification() : base()
        {
        }

        /// <summary>
        /// <para>Value</para>
        /// <para>Represents the following attribute in the schema: m:val</para>
        /// </summary>
        /// <remark>
        /// xmlns:m=http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("m:val")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Math.VerticalAlignmentValues>? Val
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Math.VerticalAlignmentValues>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("m:baseJc");
            builder.AddElement<BaseJustification>()
.AddAttribute("m:val", a => a.Val, aBuilder =>
{
 aBuilder.AddValidator(RequiredValidator.Instance);
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<BaseJustification>(deep);
    }

    /// <summary>
    /// <para>Row Spacing Rule.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:rSpRule.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("m:rSpRule")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class RowSpacingRule : SpacingRuleType
    {
        /// <summary>
        /// Initializes a new instance of the RowSpacingRule class.
        /// </summary>
        public RowSpacingRule() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("m:rSpRule");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RowSpacingRule>(deep);
    }

    /// <summary>
    /// <para>Matrix Column Gap Rule.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:cGpRule.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("m:cGpRule")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class ColumnGapRule : SpacingRuleType
    {
        /// <summary>
        /// Initializes a new instance of the ColumnGapRule class.
        /// </summary>
        public ColumnGapRule() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("m:cGpRule");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ColumnGapRule>(deep);
    }

    /// <summary>
    /// <para>Defines the SpacingRuleType Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is :.</para>
    /// </summary>
    public abstract partial class SpacingRuleType : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the SpacingRuleType class.
        /// </summary>
        protected SpacingRuleType() : base()
        {
        }

        /// <summary>
        /// <para>Value</para>
        /// <para>Represents the following attribute in the schema: m:val</para>
        /// </summary>
        /// <remark>
        /// xmlns:m=http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("m:val")]
#pragma warning restore CS0618 // Type or member is obsolete

        public IntegerValue? Val
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddElement<SpacingRuleType>()
                           .AddAttribute("m:val", a => a.Val, aBuilder =>
                           {
                               aBuilder.AddValidator(RequiredValidator.Instance);
                               aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (4L) });
                           });
        }
    }

    /// <summary>
    /// <para>Row Spacing (Equation Array).</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:rSp.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("m:rSp")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class RowSpacing : UnsignedShortType
    {
        /// <summary>
        /// Initializes a new instance of the RowSpacing class.
        /// </summary>
        public RowSpacing() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("m:rSp");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RowSpacing>(deep);
    }

    /// <summary>
    /// <para>Matrix Column Gap.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:cGp.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("m:cGp")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class ColumnGap : UnsignedShortType
    {
        /// <summary>
        /// Initializes a new instance of the ColumnGap class.
        /// </summary>
        public ColumnGap() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("m:cGp");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ColumnGap>(deep);
    }

    /// <summary>
    /// <para>Defines the UnsignedShortType Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is :.</para>
    /// </summary>
    public abstract partial class UnsignedShortType : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the UnsignedShortType class.
        /// </summary>
        protected UnsignedShortType() : base()
        {
        }

        /// <summary>
        /// <para>val</para>
        /// <para>Represents the following attribute in the schema: m:val</para>
        /// </summary>
        /// <remark>
        /// xmlns:m=http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("m:val")]
#pragma warning restore CS0618 // Type or member is obsolete

        public UInt16Value? Val
        {
            get => GetAttribute<UInt16Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddElement<UnsignedShortType>()
                           .AddAttribute("m:val", a => a.Val, aBuilder =>
                           {
                               aBuilder.AddValidator(RequiredValidator.Instance);
                           });
        }
    }

    /// <summary>
    /// <para>Equation Array Properties.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:eqArrPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.ControlProperties" /> <c>&lt;m:ctrlPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.MaxDistribution" /> <c>&lt;m:maxDist></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.ObjectDistribution" /> <c>&lt;m:objDist></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.RowSpacingRule" /> <c>&lt;m:rSpRule></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.RowSpacing" /> <c>&lt;m:rSp></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.BaseJustification" /> <c>&lt;m:baseJc></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("m:eqArrPr")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class EquationArrayProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the EquationArrayProperties class.
        /// </summary>
        public EquationArrayProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the EquationArrayProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public EquationArrayProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the EquationArrayProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public EquationArrayProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the EquationArrayProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public EquationArrayProperties(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("m:eqArrPr");
            builder.AddChild<DocumentFormat.OpenXml.Math.ControlProperties>();
            builder.AddChild<DocumentFormat.OpenXml.Math.MaxDistribution>();
            builder.AddChild<DocumentFormat.OpenXml.Math.ObjectDistribution>();
            builder.AddChild<DocumentFormat.OpenXml.Math.RowSpacingRule>();
            builder.AddChild<DocumentFormat.OpenXml.Math.RowSpacing>();
            builder.AddChild<DocumentFormat.OpenXml.Math.BaseJustification>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.BaseJustification), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.MaxDistribution), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.ObjectDistribution), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.RowSpacingRule), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.RowSpacing), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.ControlProperties), 0, 1)
            };
        }

        /// <summary>
        /// <para>Equation Array Base Justification.</para>
        /// <para>Represents the following element tag in the schema: m:baseJc.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public DocumentFormat.OpenXml.Math.BaseJustification? BaseJustification
        {
            get => GetElement<DocumentFormat.OpenXml.Math.BaseJustification>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Maximum Distribution.</para>
        /// <para>Represents the following element tag in the schema: m:maxDist.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public DocumentFormat.OpenXml.Math.MaxDistribution? MaxDistribution
        {
            get => GetElement<DocumentFormat.OpenXml.Math.MaxDistribution>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Object Distribution.</para>
        /// <para>Represents the following element tag in the schema: m:objDist.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public DocumentFormat.OpenXml.Math.ObjectDistribution? ObjectDistribution
        {
            get => GetElement<DocumentFormat.OpenXml.Math.ObjectDistribution>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Row Spacing Rule.</para>
        /// <para>Represents the following element tag in the schema: m:rSpRule.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public DocumentFormat.OpenXml.Math.RowSpacingRule? RowSpacingRule
        {
            get => GetElement<DocumentFormat.OpenXml.Math.RowSpacingRule>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Row Spacing (Equation Array).</para>
        /// <para>Represents the following element tag in the schema: m:rSp.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public DocumentFormat.OpenXml.Math.RowSpacing? RowSpacing
        {
            get => GetElement<DocumentFormat.OpenXml.Math.RowSpacing>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ControlProperties.</para>
        /// <para>Represents the following element tag in the schema: m:ctrlPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public DocumentFormat.OpenXml.Math.ControlProperties? ControlProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Math.ControlProperties>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<EquationArrayProperties>(deep);
    }

    /// <summary>
    /// <para>Fraction type.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:type.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("m:type")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class FractionType : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the FractionType class.
        /// </summary>
        public FractionType() : base()
        {
        }

        /// <summary>
        /// <para>Value</para>
        /// <para>Represents the following attribute in the schema: m:val</para>
        /// </summary>
        /// <remark>
        /// xmlns:m=http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("m:val")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Math.FractionTypeValues>? Val
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Math.FractionTypeValues>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("m:type");
            builder.AddElement<FractionType>()
.AddAttribute("m:val", a => a.Val, aBuilder =>
{
   aBuilder.AddValidator(RequiredValidator.Instance);
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<FractionType>(deep);
    }

    /// <summary>
    /// <para>Fraction Properties.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:fPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.ControlProperties" /> <c>&lt;m:ctrlPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.FractionType" /> <c>&lt;m:type></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("m:fPr")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class FractionProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the FractionProperties class.
        /// </summary>
        public FractionProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the FractionProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public FractionProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the FractionProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public FractionProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the FractionProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public FractionProperties(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("m:fPr");
            builder.AddChild<DocumentFormat.OpenXml.Math.ControlProperties>();
            builder.AddChild<DocumentFormat.OpenXml.Math.FractionType>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.FractionType), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.ControlProperties), 0, 1)
            };
        }

        /// <summary>
        /// <para>Fraction type.</para>
        /// <para>Represents the following element tag in the schema: m:type.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public DocumentFormat.OpenXml.Math.FractionType? FractionType
        {
            get => GetElement<DocumentFormat.OpenXml.Math.FractionType>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ControlProperties.</para>
        /// <para>Represents the following element tag in the schema: m:ctrlPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public DocumentFormat.OpenXml.Math.ControlProperties? ControlProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Math.ControlProperties>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<FractionProperties>(deep);
    }

    /// <summary>
    /// <para>Function Properties.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:funcPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.ControlProperties" /> <c>&lt;m:ctrlPr></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("m:funcPr")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class FunctionProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the FunctionProperties class.
        /// </summary>
        public FunctionProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the FunctionProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public FunctionProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the FunctionProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public FunctionProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the FunctionProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public FunctionProperties(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("m:funcPr");
            builder.AddChild<DocumentFormat.OpenXml.Math.ControlProperties>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.ControlProperties), 0, 1)
            };
        }

        /// <summary>
        /// <para>ControlProperties.</para>
        /// <para>Represents the following element tag in the schema: m:ctrlPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public DocumentFormat.OpenXml.Math.ControlProperties? ControlProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Math.ControlProperties>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<FunctionProperties>(deep);
    }

    /// <summary>
    /// <para>Group-Character Properties.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:groupChrPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.AccentChar" /> <c>&lt;m:chr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.ControlProperties" /> <c>&lt;m:ctrlPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.Position" /> <c>&lt;m:pos></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.VerticalJustification" /> <c>&lt;m:vertJc></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("m:groupChrPr")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class GroupCharProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the GroupCharProperties class.
        /// </summary>
        public GroupCharProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the GroupCharProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public GroupCharProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the GroupCharProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public GroupCharProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the GroupCharProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public GroupCharProperties(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("m:groupChrPr");
            builder.AddChild<DocumentFormat.OpenXml.Math.AccentChar>();
            builder.AddChild<DocumentFormat.OpenXml.Math.ControlProperties>();
            builder.AddChild<DocumentFormat.OpenXml.Math.Position>();
            builder.AddChild<DocumentFormat.OpenXml.Math.VerticalJustification>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.AccentChar), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Position), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.VerticalJustification), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.ControlProperties), 0, 1)
            };
        }

        /// <summary>
        /// <para>Group Character (Grouping Character).</para>
        /// <para>Represents the following element tag in the schema: m:chr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public DocumentFormat.OpenXml.Math.AccentChar? AccentChar
        {
            get => GetElement<DocumentFormat.OpenXml.Math.AccentChar>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Position (Group Character).</para>
        /// <para>Represents the following element tag in the schema: m:pos.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public DocumentFormat.OpenXml.Math.Position? Position
        {
            get => GetElement<DocumentFormat.OpenXml.Math.Position>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Vertical Justification.</para>
        /// <para>Represents the following element tag in the schema: m:vertJc.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public DocumentFormat.OpenXml.Math.VerticalJustification? VerticalJustification
        {
            get => GetElement<DocumentFormat.OpenXml.Math.VerticalJustification>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ControlProperties.</para>
        /// <para>Represents the following element tag in the schema: m:ctrlPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public DocumentFormat.OpenXml.Math.ControlProperties? ControlProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Math.ControlProperties>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<GroupCharProperties>(deep);
    }

    /// <summary>
    /// <para>Lower Limit Properties.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:limLowPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.ControlProperties" /> <c>&lt;m:ctrlPr></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("m:limLowPr")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class LimitLowerProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the LimitLowerProperties class.
        /// </summary>
        public LimitLowerProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the LimitLowerProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public LimitLowerProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the LimitLowerProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public LimitLowerProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the LimitLowerProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public LimitLowerProperties(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("m:limLowPr");
            builder.AddChild<DocumentFormat.OpenXml.Math.ControlProperties>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.ControlProperties), 0, 1)
            };
        }

        /// <summary>
        /// <para>ControlProperties.</para>
        /// <para>Represents the following element tag in the schema: m:ctrlPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public DocumentFormat.OpenXml.Math.ControlProperties? ControlProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Math.ControlProperties>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<LimitLowerProperties>(deep);
    }

    /// <summary>
    /// <para>Upper Limit Properties.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:limUppPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.ControlProperties" /> <c>&lt;m:ctrlPr></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("m:limUppPr")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class LimitUpperProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the LimitUpperProperties class.
        /// </summary>
        public LimitUpperProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the LimitUpperProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public LimitUpperProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the LimitUpperProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public LimitUpperProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the LimitUpperProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public LimitUpperProperties(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("m:limUppPr");
            builder.AddChild<DocumentFormat.OpenXml.Math.ControlProperties>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.ControlProperties), 0, 1)
            };
        }

        /// <summary>
        /// <para>ControlProperties.</para>
        /// <para>Represents the following element tag in the schema: m:ctrlPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public DocumentFormat.OpenXml.Math.ControlProperties? ControlProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Math.ControlProperties>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<LimitUpperProperties>(deep);
    }

    /// <summary>
    /// <para>Matrix Column Count.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:count.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("m:count")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class MatrixColumnCount : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the MatrixColumnCount class.
        /// </summary>
        public MatrixColumnCount() : base()
        {
        }

        /// <summary>
        /// <para>val</para>
        /// <para>Represents the following attribute in the schema: m:val</para>
        /// </summary>
        /// <remark>
        /// xmlns:m=http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("m:val")]
#pragma warning restore CS0618 // Type or member is obsolete

        public IntegerValue? Val
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("m:count");
            builder.AddElement<MatrixColumnCount>()
.AddAttribute("m:val", a => a.Val, aBuilder =>
{
  aBuilder.AddValidator(RequiredValidator.Instance);
  aBuilder.AddValidator(new NumberValidator() { MinInclusive = (1L), MaxInclusive = (64L) });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<MatrixColumnCount>(deep);
    }

    /// <summary>
    /// <para>Matrix Column Justification.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:mcJc.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("m:mcJc")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class MatrixColumnJustification : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the MatrixColumnJustification class.
        /// </summary>
        public MatrixColumnJustification() : base()
        {
        }

        /// <summary>
        /// <para>Value</para>
        /// <para>Represents the following attribute in the schema: m:val</para>
        /// </summary>
        /// <remark>
        /// xmlns:m=http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("m:val")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Math.HorizontalAlignmentValues>? Val
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Math.HorizontalAlignmentValues>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("m:mcJc");
            builder.AddElement<MatrixColumnJustification>()
.AddAttribute("m:val", a => a.Val, aBuilder =>
{
   aBuilder.AddValidator(RequiredValidator.Instance);
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<MatrixColumnJustification>(deep);
    }

    /// <summary>
    /// <para>Matrix Column Properties.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:mcPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.MatrixColumnCount" /> <c>&lt;m:count></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.MatrixColumnJustification" /> <c>&lt;m:mcJc></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("m:mcPr")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class MatrixColumnProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the MatrixColumnProperties class.
        /// </summary>
        public MatrixColumnProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the MatrixColumnProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public MatrixColumnProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the MatrixColumnProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public MatrixColumnProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the MatrixColumnProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public MatrixColumnProperties(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("m:mcPr");
            builder.AddChild<DocumentFormat.OpenXml.Math.MatrixColumnCount>();
            builder.AddChild<DocumentFormat.OpenXml.Math.MatrixColumnJustification>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.MatrixColumnCount), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.MatrixColumnJustification), 0, 1)
            };
        }

        /// <summary>
        /// <para>Matrix Column Count.</para>
        /// <para>Represents the following element tag in the schema: m:count.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public DocumentFormat.OpenXml.Math.MatrixColumnCount? MatrixColumnCount
        {
            get => GetElement<DocumentFormat.OpenXml.Math.MatrixColumnCount>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Matrix Column Justification.</para>
        /// <para>Represents the following element tag in the schema: m:mcJc.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public DocumentFormat.OpenXml.Math.MatrixColumnJustification? MatrixColumnJustification
        {
            get => GetElement<DocumentFormat.OpenXml.Math.MatrixColumnJustification>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<MatrixColumnProperties>(deep);
    }

    /// <summary>
    /// <para>Matrix Column.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:mc.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.MatrixColumnProperties" /> <c>&lt;m:mcPr></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("m:mc")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class MatrixColumn : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the MatrixColumn class.
        /// </summary>
        public MatrixColumn() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the MatrixColumn class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public MatrixColumn(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the MatrixColumn class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public MatrixColumn(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the MatrixColumn class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public MatrixColumn(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("m:mc");
            builder.AddChild<DocumentFormat.OpenXml.Math.MatrixColumnProperties>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.MatrixColumnProperties), 0, 1)
            };
        }

        /// <summary>
        /// <para>Matrix Column Properties.</para>
        /// <para>Represents the following element tag in the schema: m:mcPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public DocumentFormat.OpenXml.Math.MatrixColumnProperties? MatrixColumnProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Math.MatrixColumnProperties>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<MatrixColumn>(deep);
    }

    /// <summary>
    /// <para>Matrix Column Spacing.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:cSp.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("m:cSp")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class ColumnSpacing : TwipsMeasureType
    {
        /// <summary>
        /// Initializes a new instance of the ColumnSpacing class.
        /// </summary>
        public ColumnSpacing() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("m:cSp");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ColumnSpacing>(deep);
    }

    /// <summary>
    /// <para>Left Margin.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:lMargin.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("m:lMargin")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class LeftMargin : TwipsMeasureType
    {
        /// <summary>
        /// Initializes a new instance of the LeftMargin class.
        /// </summary>
        public LeftMargin() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("m:lMargin");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<LeftMargin>(deep);
    }

    /// <summary>
    /// <para>Right Margin.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:rMargin.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("m:rMargin")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class RightMargin : TwipsMeasureType
    {
        /// <summary>
        /// Initializes a new instance of the RightMargin class.
        /// </summary>
        public RightMargin() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("m:rMargin");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RightMargin>(deep);
    }

    /// <summary>
    /// <para>Pre-Equation Spacing.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:preSp.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("m:preSp")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class PreSpacing : TwipsMeasureType
    {
        /// <summary>
        /// Initializes a new instance of the PreSpacing class.
        /// </summary>
        public PreSpacing() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("m:preSp");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<PreSpacing>(deep);
    }

    /// <summary>
    /// <para>Post-Equation Spacing.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:postSp.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("m:postSp")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class PostSpacing : TwipsMeasureType
    {
        /// <summary>
        /// Initializes a new instance of the PostSpacing class.
        /// </summary>
        public PostSpacing() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("m:postSp");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<PostSpacing>(deep);
    }

    /// <summary>
    /// <para>Inter-Equation Spacing.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:interSp.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("m:interSp")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class InterSpacing : TwipsMeasureType
    {
        /// <summary>
        /// Initializes a new instance of the InterSpacing class.
        /// </summary>
        public InterSpacing() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("m:interSp");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<InterSpacing>(deep);
    }

    /// <summary>
    /// <para>Intra-Equation Spacing.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:intraSp.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("m:intraSp")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class IntraSpacing : TwipsMeasureType
    {
        /// <summary>
        /// Initializes a new instance of the IntraSpacing class.
        /// </summary>
        public IntraSpacing() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("m:intraSp");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<IntraSpacing>(deep);
    }

    /// <summary>
    /// <para>Wrap Indent.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:wrapIndent.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("m:wrapIndent")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class WrapIndent : TwipsMeasureType
    {
        /// <summary>
        /// Initializes a new instance of the WrapIndent class.
        /// </summary>
        public WrapIndent() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("m:wrapIndent");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<WrapIndent>(deep);
    }

    /// <summary>
    /// <para>Defines the TwipsMeasureType Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is :.</para>
    /// </summary>
    public abstract partial class TwipsMeasureType : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the TwipsMeasureType class.
        /// </summary>
        protected TwipsMeasureType() : base()
        {
        }

        /// <summary>
        /// <para>Value</para>
        /// <para>Represents the following attribute in the schema: m:val</para>
        /// </summary>
        /// <remark>
        /// xmlns:m=http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("m:val")]
#pragma warning restore CS0618 // Type or member is obsolete

        public UInt32Value? Val
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddElement<TwipsMeasureType>()
                           .AddAttribute("m:val", a => a.Val, aBuilder =>
                           {
                               aBuilder.AddValidator(RequiredValidator.Instance);
                               aBuilder.AddValidator(new NumberValidator() { MaxInclusive = (31680L) });
                           });
        }
    }

    /// <summary>
    /// <para>Matrix Columns.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:mcs.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.MatrixColumn" /> <c>&lt;m:mc></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("m:mcs")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class MatrixColumns : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the MatrixColumns class.
        /// </summary>
        public MatrixColumns() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the MatrixColumns class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public MatrixColumns(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the MatrixColumns class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public MatrixColumns(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the MatrixColumns class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public MatrixColumns(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("m:mcs");
            builder.AddChild<DocumentFormat.OpenXml.Math.MatrixColumn>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.MatrixColumn), 1, 64)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<MatrixColumns>(deep);
    }

    /// <summary>
    /// <para>Matrix Properties.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:mPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.ControlProperties" /> <c>&lt;m:ctrlPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.MatrixColumns" /> <c>&lt;m:mcs></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.HidePlaceholder" /> <c>&lt;m:plcHide></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.RowSpacingRule" /> <c>&lt;m:rSpRule></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.ColumnGapRule" /> <c>&lt;m:cGpRule></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.ColumnSpacing" /> <c>&lt;m:cSp></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.RowSpacing" /> <c>&lt;m:rSp></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.ColumnGap" /> <c>&lt;m:cGp></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.BaseJustification" /> <c>&lt;m:baseJc></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("m:mPr")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class MatrixProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the MatrixProperties class.
        /// </summary>
        public MatrixProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the MatrixProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public MatrixProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the MatrixProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public MatrixProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the MatrixProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public MatrixProperties(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("m:mPr");
            builder.AddChild<DocumentFormat.OpenXml.Math.ControlProperties>();
            builder.AddChild<DocumentFormat.OpenXml.Math.MatrixColumns>();
            builder.AddChild<DocumentFormat.OpenXml.Math.HidePlaceholder>();
            builder.AddChild<DocumentFormat.OpenXml.Math.RowSpacingRule>();
            builder.AddChild<DocumentFormat.OpenXml.Math.ColumnGapRule>();
            builder.AddChild<DocumentFormat.OpenXml.Math.ColumnSpacing>();
            builder.AddChild<DocumentFormat.OpenXml.Math.RowSpacing>();
            builder.AddChild<DocumentFormat.OpenXml.Math.ColumnGap>();
            builder.AddChild<DocumentFormat.OpenXml.Math.BaseJustification>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.BaseJustification), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.HidePlaceholder), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.RowSpacingRule), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.ColumnGapRule), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.RowSpacing), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.ColumnSpacing), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.ColumnGap), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.MatrixColumns), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.ControlProperties), 0, 1)
            };
        }

        /// <summary>
        /// <para>Matrix Base Justification.</para>
        /// <para>Represents the following element tag in the schema: m:baseJc.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public DocumentFormat.OpenXml.Math.BaseJustification? BaseJustification
        {
            get => GetElement<DocumentFormat.OpenXml.Math.BaseJustification>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Hide Placeholders (Matrix).</para>
        /// <para>Represents the following element tag in the schema: m:plcHide.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public DocumentFormat.OpenXml.Math.HidePlaceholder? HidePlaceholder
        {
            get => GetElement<DocumentFormat.OpenXml.Math.HidePlaceholder>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Row Spacing Rule.</para>
        /// <para>Represents the following element tag in the schema: m:rSpRule.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public DocumentFormat.OpenXml.Math.RowSpacingRule? RowSpacingRule
        {
            get => GetElement<DocumentFormat.OpenXml.Math.RowSpacingRule>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Matrix Column Gap Rule.</para>
        /// <para>Represents the following element tag in the schema: m:cGpRule.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public DocumentFormat.OpenXml.Math.ColumnGapRule? ColumnGapRule
        {
            get => GetElement<DocumentFormat.OpenXml.Math.ColumnGapRule>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Row Spacing (Matrix).</para>
        /// <para>Represents the following element tag in the schema: m:rSp.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public DocumentFormat.OpenXml.Math.RowSpacing? RowSpacing
        {
            get => GetElement<DocumentFormat.OpenXml.Math.RowSpacing>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Matrix Column Spacing.</para>
        /// <para>Represents the following element tag in the schema: m:cSp.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public DocumentFormat.OpenXml.Math.ColumnSpacing? ColumnSpacing
        {
            get => GetElement<DocumentFormat.OpenXml.Math.ColumnSpacing>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Matrix Column Gap.</para>
        /// <para>Represents the following element tag in the schema: m:cGp.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public DocumentFormat.OpenXml.Math.ColumnGap? ColumnGap
        {
            get => GetElement<DocumentFormat.OpenXml.Math.ColumnGap>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Matrix Columns.</para>
        /// <para>Represents the following element tag in the schema: m:mcs.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public DocumentFormat.OpenXml.Math.MatrixColumns? MatrixColumns
        {
            get => GetElement<DocumentFormat.OpenXml.Math.MatrixColumns>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ControlProperties.</para>
        /// <para>Represents the following element tag in the schema: m:ctrlPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public DocumentFormat.OpenXml.Math.ControlProperties? ControlProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Math.ControlProperties>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<MatrixProperties>(deep);
    }

    /// <summary>
    /// <para>Matrix Row.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:mr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.Base" /> <c>&lt;m:e></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("m:mr")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class MatrixRow : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the MatrixRow class.
        /// </summary>
        public MatrixRow() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the MatrixRow class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public MatrixRow(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the MatrixRow class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public MatrixRow(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the MatrixRow class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public MatrixRow(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("m:mr");
            builder.AddChild<DocumentFormat.OpenXml.Math.Base>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Base), 1, 64)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<MatrixRow>(deep);
    }

    /// <summary>
    /// <para>n-ary Limit Location.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:limLoc.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("m:limLoc")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class LimitLocation : LimitLocationType
    {
        /// <summary>
        /// Initializes a new instance of the LimitLocation class.
        /// </summary>
        public LimitLocation() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("m:limLoc");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<LimitLocation>(deep);
    }

    /// <summary>
    /// <para>Integral Limit Locations.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:intLim.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("m:intLim")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class IntegralLimitLocation : LimitLocationType
    {
        /// <summary>
        /// Initializes a new instance of the IntegralLimitLocation class.
        /// </summary>
        public IntegralLimitLocation() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("m:intLim");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<IntegralLimitLocation>(deep);
    }

    /// <summary>
    /// <para>n-ary Limit Location.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:naryLim.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("m:naryLim")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class NaryLimitLocation : LimitLocationType
    {
        /// <summary>
        /// Initializes a new instance of the NaryLimitLocation class.
        /// </summary>
        public NaryLimitLocation() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("m:naryLim");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<NaryLimitLocation>(deep);
    }

    /// <summary>
    /// <para>Defines the LimitLocationType Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is :.</para>
    /// </summary>
    public abstract partial class LimitLocationType : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the LimitLocationType class.
        /// </summary>
        protected LimitLocationType() : base()
        {
        }

        /// <summary>
        /// <para>Value</para>
        /// <para>Represents the following attribute in the schema: m:val</para>
        /// </summary>
        /// <remark>
        /// xmlns:m=http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("m:val")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Math.LimitLocationValues>? Val
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Math.LimitLocationValues>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddElement<LimitLocationType>()
                           .AddAttribute("m:val", a => a.Val, aBuilder =>
                           {
                               aBuilder.AddValidator(RequiredValidator.Instance);
                           });
        }
    }

    /// <summary>
    /// <para>n-ary Properties.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:naryPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.AccentChar" /> <c>&lt;m:chr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.ControlProperties" /> <c>&lt;m:ctrlPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.LimitLocation" /> <c>&lt;m:limLoc></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.GrowOperators" /> <c>&lt;m:grow></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.HideSubArgument" /> <c>&lt;m:subHide></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.HideSuperArgument" /> <c>&lt;m:supHide></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("m:naryPr")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class NaryProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the NaryProperties class.
        /// </summary>
        public NaryProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the NaryProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NaryProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NaryProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NaryProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NaryProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public NaryProperties(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("m:naryPr");
            builder.AddChild<DocumentFormat.OpenXml.Math.AccentChar>();
            builder.AddChild<DocumentFormat.OpenXml.Math.ControlProperties>();
            builder.AddChild<DocumentFormat.OpenXml.Math.LimitLocation>();
            builder.AddChild<DocumentFormat.OpenXml.Math.GrowOperators>();
            builder.AddChild<DocumentFormat.OpenXml.Math.HideSubArgument>();
            builder.AddChild<DocumentFormat.OpenXml.Math.HideSuperArgument>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.AccentChar), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.LimitLocation), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.GrowOperators), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.HideSubArgument), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.HideSuperArgument), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.ControlProperties), 0, 1)
            };
        }

        /// <summary>
        /// <para>n-ary Operator Character.</para>
        /// <para>Represents the following element tag in the schema: m:chr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public DocumentFormat.OpenXml.Math.AccentChar? AccentChar
        {
            get => GetElement<DocumentFormat.OpenXml.Math.AccentChar>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>n-ary Limit Location.</para>
        /// <para>Represents the following element tag in the schema: m:limLoc.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public DocumentFormat.OpenXml.Math.LimitLocation? LimitLocation
        {
            get => GetElement<DocumentFormat.OpenXml.Math.LimitLocation>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>n-ary Grow.</para>
        /// <para>Represents the following element tag in the schema: m:grow.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public DocumentFormat.OpenXml.Math.GrowOperators? GrowOperators
        {
            get => GetElement<DocumentFormat.OpenXml.Math.GrowOperators>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Hide Subscript (n-ary).</para>
        /// <para>Represents the following element tag in the schema: m:subHide.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public DocumentFormat.OpenXml.Math.HideSubArgument? HideSubArgument
        {
            get => GetElement<DocumentFormat.OpenXml.Math.HideSubArgument>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Hide Superscript (n-ary).</para>
        /// <para>Represents the following element tag in the schema: m:supHide.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public DocumentFormat.OpenXml.Math.HideSuperArgument? HideSuperArgument
        {
            get => GetElement<DocumentFormat.OpenXml.Math.HideSuperArgument>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ControlProperties.</para>
        /// <para>Represents the following element tag in the schema: m:ctrlPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public DocumentFormat.OpenXml.Math.ControlProperties? ControlProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Math.ControlProperties>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<NaryProperties>(deep);
    }

    /// <summary>
    /// <para>Phantom Properties.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:phantPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.ControlProperties" /> <c>&lt;m:ctrlPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.ShowPhantom" /> <c>&lt;m:show></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.ZeroWidth" /> <c>&lt;m:zeroWid></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.ZeroAscent" /> <c>&lt;m:zeroAsc></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.ZeroDescent" /> <c>&lt;m:zeroDesc></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.Transparent" /> <c>&lt;m:transp></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("m:phantPr")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class PhantomProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the PhantomProperties class.
        /// </summary>
        public PhantomProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the PhantomProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public PhantomProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PhantomProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public PhantomProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PhantomProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public PhantomProperties(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("m:phantPr");
            builder.AddChild<DocumentFormat.OpenXml.Math.ControlProperties>();
            builder.AddChild<DocumentFormat.OpenXml.Math.ShowPhantom>();
            builder.AddChild<DocumentFormat.OpenXml.Math.ZeroWidth>();
            builder.AddChild<DocumentFormat.OpenXml.Math.ZeroAscent>();
            builder.AddChild<DocumentFormat.OpenXml.Math.ZeroDescent>();
            builder.AddChild<DocumentFormat.OpenXml.Math.Transparent>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.ShowPhantom), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.ZeroWidth), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.ZeroAscent), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.ZeroDescent), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Transparent), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.ControlProperties), 0, 1)
            };
        }

        /// <summary>
        /// <para>Phantom Show.</para>
        /// <para>Represents the following element tag in the schema: m:show.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public DocumentFormat.OpenXml.Math.ShowPhantom? ShowPhantom
        {
            get => GetElement<DocumentFormat.OpenXml.Math.ShowPhantom>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Phantom Zero Width.</para>
        /// <para>Represents the following element tag in the schema: m:zeroWid.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public DocumentFormat.OpenXml.Math.ZeroWidth? ZeroWidth
        {
            get => GetElement<DocumentFormat.OpenXml.Math.ZeroWidth>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Phantom Zero Ascent.</para>
        /// <para>Represents the following element tag in the schema: m:zeroAsc.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public DocumentFormat.OpenXml.Math.ZeroAscent? ZeroAscent
        {
            get => GetElement<DocumentFormat.OpenXml.Math.ZeroAscent>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Phantom Zero Descent.</para>
        /// <para>Represents the following element tag in the schema: m:zeroDesc.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public DocumentFormat.OpenXml.Math.ZeroDescent? ZeroDescent
        {
            get => GetElement<DocumentFormat.OpenXml.Math.ZeroDescent>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Transparent (Phantom).</para>
        /// <para>Represents the following element tag in the schema: m:transp.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public DocumentFormat.OpenXml.Math.Transparent? Transparent
        {
            get => GetElement<DocumentFormat.OpenXml.Math.Transparent>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ControlProperties.</para>
        /// <para>Represents the following element tag in the schema: m:ctrlPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public DocumentFormat.OpenXml.Math.ControlProperties? ControlProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Math.ControlProperties>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<PhantomProperties>(deep);
    }

    /// <summary>
    /// <para>Radical Properties.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:radPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.ControlProperties" /> <c>&lt;m:ctrlPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.HideDegree" /> <c>&lt;m:degHide></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("m:radPr")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class RadicalProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the RadicalProperties class.
        /// </summary>
        public RadicalProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the RadicalProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public RadicalProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the RadicalProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public RadicalProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the RadicalProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public RadicalProperties(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("m:radPr");
            builder.AddChild<DocumentFormat.OpenXml.Math.ControlProperties>();
            builder.AddChild<DocumentFormat.OpenXml.Math.HideDegree>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.HideDegree), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.ControlProperties), 0, 1)
            };
        }

        /// <summary>
        /// <para>Hide Degree.</para>
        /// <para>Represents the following element tag in the schema: m:degHide.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public DocumentFormat.OpenXml.Math.HideDegree? HideDegree
        {
            get => GetElement<DocumentFormat.OpenXml.Math.HideDegree>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ControlProperties.</para>
        /// <para>Represents the following element tag in the schema: m:ctrlPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public DocumentFormat.OpenXml.Math.ControlProperties? ControlProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Math.ControlProperties>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RadicalProperties>(deep);
    }

    /// <summary>
    /// <para>Pre-Sub-Superscript Properties.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:sPrePr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.ControlProperties" /> <c>&lt;m:ctrlPr></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("m:sPrePr")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class PreSubSuperProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the PreSubSuperProperties class.
        /// </summary>
        public PreSubSuperProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the PreSubSuperProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public PreSubSuperProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PreSubSuperProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public PreSubSuperProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PreSubSuperProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public PreSubSuperProperties(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("m:sPrePr");
            builder.AddChild<DocumentFormat.OpenXml.Math.ControlProperties>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.ControlProperties), 0, 1)
            };
        }

        /// <summary>
        /// <para>ControlProperties.</para>
        /// <para>Represents the following element tag in the schema: m:ctrlPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public DocumentFormat.OpenXml.Math.ControlProperties? ControlProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Math.ControlProperties>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<PreSubSuperProperties>(deep);
    }

    /// <summary>
    /// <para>Subscript Properties.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:sSubPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.ControlProperties" /> <c>&lt;m:ctrlPr></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("m:sSubPr")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class SubscriptProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the SubscriptProperties class.
        /// </summary>
        public SubscriptProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the SubscriptProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SubscriptProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SubscriptProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SubscriptProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SubscriptProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public SubscriptProperties(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("m:sSubPr");
            builder.AddChild<DocumentFormat.OpenXml.Math.ControlProperties>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.ControlProperties), 0, 1)
            };
        }

        /// <summary>
        /// <para>ControlProperties.</para>
        /// <para>Represents the following element tag in the schema: m:ctrlPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public DocumentFormat.OpenXml.Math.ControlProperties? ControlProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Math.ControlProperties>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SubscriptProperties>(deep);
    }

    /// <summary>
    /// <para>Sub-Superscript Properties.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:sSubSupPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.ControlProperties" /> <c>&lt;m:ctrlPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.AlignScripts" /> <c>&lt;m:alnScr></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("m:sSubSupPr")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class SubSuperscriptProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the SubSuperscriptProperties class.
        /// </summary>
        public SubSuperscriptProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the SubSuperscriptProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SubSuperscriptProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SubSuperscriptProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SubSuperscriptProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SubSuperscriptProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public SubSuperscriptProperties(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("m:sSubSupPr");
            builder.AddChild<DocumentFormat.OpenXml.Math.ControlProperties>();
            builder.AddChild<DocumentFormat.OpenXml.Math.AlignScripts>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.AlignScripts), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.ControlProperties), 0, 1)
            };
        }

        /// <summary>
        /// <para>Align Scripts.</para>
        /// <para>Represents the following element tag in the schema: m:alnScr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public DocumentFormat.OpenXml.Math.AlignScripts? AlignScripts
        {
            get => GetElement<DocumentFormat.OpenXml.Math.AlignScripts>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ControlProperties.</para>
        /// <para>Represents the following element tag in the schema: m:ctrlPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public DocumentFormat.OpenXml.Math.ControlProperties? ControlProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Math.ControlProperties>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SubSuperscriptProperties>(deep);
    }

    /// <summary>
    /// <para>Superscript Properties.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:sSupPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.ControlProperties" /> <c>&lt;m:ctrlPr></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("m:sSupPr")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class SuperscriptProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the SuperscriptProperties class.
        /// </summary>
        public SuperscriptProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the SuperscriptProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SuperscriptProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SuperscriptProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SuperscriptProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SuperscriptProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public SuperscriptProperties(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("m:sSupPr");
            builder.AddChild<DocumentFormat.OpenXml.Math.ControlProperties>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.ControlProperties), 0, 1)
            };
        }

        /// <summary>
        /// <para>ControlProperties.</para>
        /// <para>Represents the following element tag in the schema: m:ctrlPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public DocumentFormat.OpenXml.Math.ControlProperties? ControlProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Math.ControlProperties>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SuperscriptProperties>(deep);
    }

    /// <summary>
    /// <para>Argument Size.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:argSz.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("m:argSz")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class ArgumentSize : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the ArgumentSize class.
        /// </summary>
        public ArgumentSize() : base()
        {
        }

        /// <summary>
        /// <para>Value</para>
        /// <para>Represents the following attribute in the schema: m:val</para>
        /// </summary>
        /// <remark>
        /// xmlns:m=http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("m:val")]
#pragma warning restore CS0618 // Type or member is obsolete

        public IntegerValue? Val
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("m:argSz");
            builder.AddElement<ArgumentSize>()
.AddAttribute("m:val", a => a.Val, aBuilder =>
{
  aBuilder.AddValidator(RequiredValidator.Instance);
  aBuilder.AddValidator(new NumberValidator() { MinInclusive = (-2L), MaxInclusive = (2L) });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ArgumentSize>(deep);
    }

    /// <summary>
    /// <para>Argument Properties.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:argPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.ArgumentSize" /> <c>&lt;m:argSz></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("m:argPr")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class ArgumentProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ArgumentProperties class.
        /// </summary>
        public ArgumentProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ArgumentProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ArgumentProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ArgumentProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ArgumentProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ArgumentProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ArgumentProperties(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("m:argPr");
            builder.AddChild<DocumentFormat.OpenXml.Math.ArgumentSize>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.ArgumentSize), 0, 1)
            };
        }

        /// <summary>
        /// <para>Argument Size.</para>
        /// <para>Represents the following element tag in the schema: m:argSz.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public DocumentFormat.OpenXml.Math.ArgumentSize? ArgumentSize
        {
            get => GetElement<DocumentFormat.OpenXml.Math.ArgumentSize>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ArgumentProperties>(deep);
    }

    /// <summary>
    /// <para>Justification.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:jc.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("m:jc")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class Justification : OfficeMathJustificationType
    {
        /// <summary>
        /// Initializes a new instance of the Justification class.
        /// </summary>
        public Justification() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("m:jc");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Justification>(deep);
    }

    /// <summary>
    /// <para>Default Justification.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:defJc.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("m:defJc")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class DefaultJustification : OfficeMathJustificationType
    {
        /// <summary>
        /// Initializes a new instance of the DefaultJustification class.
        /// </summary>
        public DefaultJustification() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("m:defJc");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DefaultJustification>(deep);
    }

    /// <summary>
    /// <para>Defines the OfficeMathJustificationType Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is :.</para>
    /// </summary>
    public abstract partial class OfficeMathJustificationType : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the OfficeMathJustificationType class.
        /// </summary>
        protected OfficeMathJustificationType() : base()
        {
        }

        /// <summary>
        /// <para>Value</para>
        /// <para>Represents the following attribute in the schema: m:val</para>
        /// </summary>
        /// <remark>
        /// xmlns:m=http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("m:val")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Math.JustificationValues>? Val
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Math.JustificationValues>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddElement<OfficeMathJustificationType>()
                           .AddAttribute("m:val", a => a.Val, aBuilder =>
                           {
                               aBuilder.AddValidator(RequiredValidator.Instance);
                           });
        }
    }

    /// <summary>
    /// <para>Math Font.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:mathFont.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("m:mathFont")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class MathFont : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the MathFont class.
        /// </summary>
        public MathFont() : base()
        {
        }

        /// <summary>
        /// <para>val</para>
        /// <para>Represents the following attribute in the schema: m:val</para>
        /// </summary>
        /// <remark>
        /// xmlns:m=http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("m:val")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Val
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("m:mathFont");
            builder.AddElement<MathFont>()
.AddAttribute("m:val", a => a.Val, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new StringValidator() { MaxLength = (31L) });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<MathFont>(deep);
    }

    /// <summary>
    /// <para>Break on Binary Operators.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:brkBin.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("m:brkBin")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class BreakBinary : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the BreakBinary class.
        /// </summary>
        public BreakBinary() : base()
        {
        }

        /// <summary>
        /// <para>Value</para>
        /// <para>Represents the following attribute in the schema: m:val</para>
        /// </summary>
        /// <remark>
        /// xmlns:m=http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("m:val")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Math.BreakBinaryOperatorValues>? Val
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Math.BreakBinaryOperatorValues>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("m:brkBin");
            builder.AddElement<BreakBinary>()
.AddAttribute("m:val", a => a.Val);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<BreakBinary>(deep);
    }

    /// <summary>
    /// <para>Break on Binary Subtraction.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:brkBinSub.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("m:brkBinSub")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class BreakBinarySubtraction : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the BreakBinarySubtraction class.
        /// </summary>
        public BreakBinarySubtraction() : base()
        {
        }

        /// <summary>
        /// <para>Value</para>
        /// <para>Represents the following attribute in the schema: m:val</para>
        /// </summary>
        /// <remark>
        /// xmlns:m=http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("m:val")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Math.BreakBinarySubtractionValues>? Val
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Math.BreakBinarySubtractionValues>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("m:brkBinSub");
            builder.AddElement<BreakBinarySubtraction>()
.AddAttribute("m:val", a => a.Val, aBuilder =>
{
aBuilder.AddValidator(new RequiredValidator() { Version = (FileFormatVersions.Office2007) });
aBuilder.AddValidator(new RequiredValidator() { IsRequired = (false), InitialVersion = (FileFormatVersions.Office2010) });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<BreakBinarySubtraction>(deep);
    }

    /// <summary>
    /// <para>Office Math Paragraph Properties.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is m:oMathParaPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Math.Justification" /> <c>&lt;m:jc></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("m:oMathParaPr")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class ParagraphProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ParagraphProperties class.
        /// </summary>
        public ParagraphProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ParagraphProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ParagraphProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ParagraphProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ParagraphProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ParagraphProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ParagraphProperties(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("m:oMathParaPr");
            builder.AddChild<DocumentFormat.OpenXml.Math.Justification>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Math.Justification), 0, 1)
            };
        }

        /// <summary>
        /// <para>Justification.</para>
        /// <para>Represents the following element tag in the schema: m:jc.</para>
        /// </summary>
        /// <remark>
        /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
        /// </remark>
        public DocumentFormat.OpenXml.Math.Justification? Justification
        {
            get => GetElement<DocumentFormat.OpenXml.Math.Justification>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ParagraphProperties>(deep);
    }

    /// <summary>
    /// Defines the HorizontalAlignmentValues enumeration.
    /// </summary>
    public enum HorizontalAlignmentValues
    {
        /// <summary>
        /// Left Justification.
        /// <para>When the item is serialized out as xml, its value is "left".</para>
        /// </summary>
        [EnumString("left")]
        Left,
        /// <summary>
        /// Center.
        /// <para>When the item is serialized out as xml, its value is "center".</para>
        /// </summary>
        [EnumString("center")]
        Center,
        /// <summary>
        /// Right.
        /// <para>When the item is serialized out as xml, its value is "right".</para>
        /// </summary>
        [EnumString("right")]
        Right
    }

    /// <summary>
    /// Defines the ShapeDelimiterValues enumeration.
    /// </summary>
    public enum ShapeDelimiterValues
    {
        /// <summary>
        /// Centered (Delimiters).
        /// <para>When the item is serialized out as xml, its value is "centered".</para>
        /// </summary>
        [EnumString("centered")]
        Centered,
        /// <summary>
        /// Match.
        /// <para>When the item is serialized out as xml, its value is "match".</para>
        /// </summary>
        [EnumString("match")]
        Match
    }

    /// <summary>
    /// Defines the FractionTypeValues enumeration.
    /// </summary>
    public enum FractionTypeValues
    {
        /// <summary>
        /// Bar Fraction.
        /// <para>When the item is serialized out as xml, its value is "bar".</para>
        /// </summary>
        [EnumString("bar")]
        Bar,
        /// <summary>
        /// Skewed.
        /// <para>When the item is serialized out as xml, its value is "skw".</para>
        /// </summary>
        [EnumString("skw")]
        Skewed,
        /// <summary>
        /// Linear Fraction.
        /// <para>When the item is serialized out as xml, its value is "lin".</para>
        /// </summary>
        [EnumString("lin")]
        Linear,
        /// <summary>
        /// No-Bar Fraction (Stack).
        /// <para>When the item is serialized out as xml, its value is "noBar".</para>
        /// </summary>
        [EnumString("noBar")]
        NoBar
    }

    /// <summary>
    /// Defines the LimitLocationValues enumeration.
    /// </summary>
    public enum LimitLocationValues
    {
        /// <summary>
        /// Under-Over location.
        /// <para>When the item is serialized out as xml, its value is "undOvr".</para>
        /// </summary>
        [EnumString("undOvr")]
        UnderOver,
        /// <summary>
        /// Subscript-Superscript location.
        /// <para>When the item is serialized out as xml, its value is "subSup".</para>
        /// </summary>
        [EnumString("subSup")]
        SubscriptSuperscript
    }

    /// <summary>
    /// Defines the VerticalJustificationValues enumeration.
    /// </summary>
    public enum VerticalJustificationValues
    {
        /// <summary>
        /// Top.
        /// <para>When the item is serialized out as xml, its value is "top".</para>
        /// </summary>
        [EnumString("top")]
        Top,
        /// <summary>
        /// Bottom Alignment.
        /// <para>When the item is serialized out as xml, its value is "bot".</para>
        /// </summary>
        [EnumString("bot")]
        Bottom
    }

    /// <summary>
    /// Defines the ScriptValues enumeration.
    /// </summary>
    public enum ScriptValues
    {
        /// <summary>
        /// Roman.
        /// <para>When the item is serialized out as xml, its value is "roman".</para>
        /// </summary>
        [EnumString("roman")]
        Roman,
        /// <summary>
        /// Script.
        /// <para>When the item is serialized out as xml, its value is "script".</para>
        /// </summary>
        [EnumString("script")]
        Script,
        /// <summary>
        /// Fraktur.
        /// <para>When the item is serialized out as xml, its value is "fraktur".</para>
        /// </summary>
        [EnumString("fraktur")]
        Fraktur,
        /// <summary>
        /// double-struck.
        /// <para>When the item is serialized out as xml, its value is "double-struck".</para>
        /// </summary>
        [EnumString("double-struck")]
        DoubleStruck,
        /// <summary>
        /// Sans-Serif.
        /// <para>When the item is serialized out as xml, its value is "sans-serif".</para>
        /// </summary>
        [EnumString("sans-serif")]
        SansSerif,
        /// <summary>
        /// Monospace.
        /// <para>When the item is serialized out as xml, its value is "monospace".</para>
        /// </summary>
        [EnumString("monospace")]
        Monospace
    }

    /// <summary>
    /// Defines the StyleValues enumeration.
    /// </summary>
    public enum StyleValues
    {
        /// <summary>
        /// Plain.
        /// <para>When the item is serialized out as xml, its value is "p".</para>
        /// </summary>
        [EnumString("p")]
        Plain,
        /// <summary>
        /// Bold.
        /// <para>When the item is serialized out as xml, its value is "b".</para>
        /// </summary>
        [EnumString("b")]
        Bold,
        /// <summary>
        /// Italic.
        /// <para>When the item is serialized out as xml, its value is "i".</para>
        /// </summary>
        [EnumString("i")]
        Italic,
        /// <summary>
        /// Bold-Italic.
        /// <para>When the item is serialized out as xml, its value is "bi".</para>
        /// </summary>
        [EnumString("bi")]
        BoldItalic
    }

    /// <summary>
    /// Defines the JustificationValues enumeration.
    /// </summary>
    public enum JustificationValues
    {
        /// <summary>
        /// Left Justification.
        /// <para>When the item is serialized out as xml, its value is "left".</para>
        /// </summary>
        [EnumString("left")]
        Left,
        /// <summary>
        /// Right.
        /// <para>When the item is serialized out as xml, its value is "right".</para>
        /// </summary>
        [EnumString("right")]
        Right,
        /// <summary>
        /// Center (Equation).
        /// <para>When the item is serialized out as xml, its value is "center".</para>
        /// </summary>
        [EnumString("center")]
        Center,
        /// <summary>
        /// Centered as Group (Equations).
        /// <para>When the item is serialized out as xml, its value is "centerGroup".</para>
        /// </summary>
        [EnumString("centerGroup")]
        CenterGroup
    }

    /// <summary>
    /// Defines the BreakBinaryOperatorValues enumeration.
    /// </summary>
    public enum BreakBinaryOperatorValues
    {
        /// <summary>
        /// Before.
        /// <para>When the item is serialized out as xml, its value is "before".</para>
        /// </summary>
        [EnumString("before")]
        Before,
        /// <summary>
        /// After.
        /// <para>When the item is serialized out as xml, its value is "after".</para>
        /// </summary>
        [EnumString("after")]
        After,
        /// <summary>
        /// Repeat.
        /// <para>When the item is serialized out as xml, its value is "repeat".</para>
        /// </summary>
        [EnumString("repeat")]
        Repeat
    }

    /// <summary>
    /// Defines the BreakBinarySubtractionValues enumeration.
    /// </summary>
    public enum BreakBinarySubtractionValues
    {
        /// <summary>
        /// Minus Minus.
        /// <para>When the item is serialized out as xml, its value is "--".</para>
        /// </summary>
        [EnumString("--")]
        MinusMinus,
        /// <summary>
        /// Minus Plus.
        /// <para>When the item is serialized out as xml, its value is "-+".</para>
        /// </summary>
        [EnumString("-+")]
        MinusPlus,
        /// <summary>
        /// Plus Minus.
        /// <para>When the item is serialized out as xml, its value is "+-".</para>
        /// </summary>
        [EnumString("+-")]
        PlusMinus
    }

    /// <summary>
    /// Defines the VerticalAlignmentValues enumeration.
    /// </summary>
    public enum VerticalAlignmentValues
    {
        /// <summary>
        /// Top.
        /// <para>When the item is serialized out as xml, its value is "top".</para>
        /// </summary>
        [EnumString("top")]
        Top,
        /// <summary>
        /// Center (Function).
        /// <para>When the item is serialized out as xml, its value is "center".</para>
        /// </summary>
        [EnumString("center")]
        Center,
        /// <summary>
        /// bottom.
        /// <para>When the item is serialized out as xml, its value is "bottom".</para>
        /// </summary>
        [EnumString("bottom")]
        Bottom,
        /// <summary>
        /// Bottom Alignment.
        /// <para>When the item is serialized out as xml, its value is "bot".</para>
        /// </summary>
        [EnumString("bot")]
        Bot
    }

    /// <summary>
    /// Defines the BooleanValues enumeration.
    /// </summary>
    public enum BooleanValues
    {
        /// <summary>
        /// true.
        /// <para>When the item is serialized out as xml, its value is "true".</para>
        /// </summary>
        [EnumString("true")]
        True,
        /// <summary>
        /// false.
        /// <para>When the item is serialized out as xml, its value is "false".</para>
        /// </summary>
        [EnumString("false")]
        False,
        /// <summary>
        /// On.
        /// <para>When the item is serialized out as xml, its value is "on".</para>
        /// </summary>
        [EnumString("on")]
        On,
        /// <summary>
        /// Off.
        /// <para>When the item is serialized out as xml, its value is "off".</para>
        /// </summary>
        [EnumString("off")]
        Off,
        /// <summary>
        /// 0.
        /// <para>When the item is serialized out as xml, its value is "0".</para>
        /// </summary>
        [EnumString("0")]
        Zero,
        /// <summary>
        /// 1.
        /// <para>When the item is serialized out as xml, its value is "1".</para>
        /// </summary>
        [EnumString("1")]
        One
    }
}