﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

#nullable enable

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Drawing.Charts;
using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Framework.Metadata;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Validation.Schema;
using System;
using System.Collections.Generic;
using System.IO.Packaging;

namespace DocumentFormat.OpenXml.Office2016.Drawing.Charts
{
    /// <summary>
    /// <para>Defines the ShapeProperties Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c16:spPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.BlipFill" /> <c>&lt;a:blipFill></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.CustomGeometry" /> <c>&lt;a:custGeom></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.EffectDag" /> <c>&lt;a:effectDag></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.EffectList" /> <c>&lt;a:effectLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.GradientFill" /> <c>&lt;a:gradFill></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.GroupFill" /> <c>&lt;a:grpFill></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Outline" /> <c>&lt;a:ln></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.NoFill" /> <c>&lt;a:noFill></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.PatternFill" /> <c>&lt;a:pattFill></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.PresetGeometry" /> <c>&lt;a:prstGeom></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Scene3DType" /> <c>&lt;a:scene3d></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Shape3DType" /> <c>&lt;a:sp3d></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.ShapePropertiesExtensionList" /> <c>&lt;a:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.SolidFill" /> <c>&lt;a:solidFill></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Transform2D" /> <c>&lt;a:xfrm></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(82, "spPr")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class ShapeProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ShapeProperties class.
        /// </summary>
        public ShapeProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ShapeProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ShapeProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ShapeProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ShapeProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ShapeProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ShapeProperties(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Black and White Mode</para>
        /// <para>Represents the following attribute in the schema: bwMode</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "bwMode")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues>? BlackWhiteMode
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(82, "spPr");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddChild<DocumentFormat.OpenXml.Drawing.BlipFill>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.CustomGeometry>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.EffectDag>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.EffectList>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.GradientFill>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.GroupFill>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Outline>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.NoFill>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.PatternFill>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.PresetGeometry>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Scene3DType>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Shape3DType>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.ShapePropertiesExtensionList>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.SolidFill>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Transform2D>();
            builder.AddElement<ShapeProperties>()
.AddAttribute(0, "bwMode", a => a.BlackWhiteMode, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
});
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Transform2D), 0, 1),
                new CompositeParticle.Builder(ParticleType.Group, 0, 1)
                {
                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.CustomGeometry), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.PresetGeometry), 1, 1)
                    }
                },
                new CompositeParticle.Builder(ParticleType.Group, 0, 1)
                {
                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.NoFill), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.SolidFill), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.GradientFill), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.BlipFill), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.PatternFill), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.GroupFill), 1, 1)
                    }
                },
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Outline), 0, 1),
                new CompositeParticle.Builder(ParticleType.Group, 0, 1)
                {
                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.EffectList), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.EffectDag), 1, 1)
                    }
                },
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Scene3DType), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Shape3DType), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.ShapePropertiesExtensionList), 0, 1)
            };
        }

        /// <summary>
        /// <para>2D Transform for Individual Objects.</para>
        /// <para>Represents the following element tag in the schema: a:xfrm.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Transform2D? Transform2D
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Transform2D>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ShapeProperties>(deep);
    }

    /// <summary>
    /// <para>Defines the UnsignedIntegerType Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c16:explosion.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(82, "explosion")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class UnsignedIntegerType : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the UnsignedIntegerType class.
        /// </summary>
        public UnsignedIntegerType() : base()
        {
        }

        /// <summary>
        /// <para>Integer Value</para>
        /// <para>Represents the following attribute in the schema: val</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "val")]
#pragma warning restore CS0618 // Type or member is obsolete

        public UInt32Value? Val
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(82, "explosion");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddElement<UnsignedIntegerType>()
.AddAttribute(0, "val", a => a.Val, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<UnsignedIntegerType>(deep);
    }

    /// <summary>
    /// <para>Defines the InvertIfNegativeBoolean Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c16:invertIfNegative.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(82, "invertIfNegative")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class InvertIfNegativeBoolean : BooleanType
    {
        /// <summary>
        /// Initializes a new instance of the InvertIfNegativeBoolean class.
        /// </summary>
        public InvertIfNegativeBoolean() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(82, "invertIfNegative");
            builder.Availability = FileFormatVersions.Office2016;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<InvertIfNegativeBoolean>(deep);
    }

    /// <summary>
    /// <para>Defines the Bubble3DBoolean Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c16:bubble3D.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(82, "bubble3D")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class Bubble3DBoolean : BooleanType
    {
        /// <summary>
        /// Initializes a new instance of the Bubble3DBoolean class.
        /// </summary>
        public Bubble3DBoolean() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(82, "bubble3D");
            builder.Availability = FileFormatVersions.Office2016;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Bubble3DBoolean>(deep);
    }

    /// <summary>
    /// <para>Defines the BooleanType Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is :.</para>
    /// </summary>
    public abstract partial class BooleanType : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the BooleanType class.
        /// </summary>
        protected BooleanType() : base()
        {
        }

        /// <summary>
        /// <para>Boolean Value</para>
        /// <para>Represents the following attribute in the schema: val</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "val")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? Val
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddElement<BooleanType>()
                           .AddAttribute(0, "val", a => a.Val);
        }
    }

    /// <summary>
    /// <para>Defines the Marker Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c16:marker.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties" /> <c>&lt;c:spPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Charts.ExtensionList" /> <c>&lt;c:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Charts.Size" /> <c>&lt;c:size></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Charts.Symbol" /> <c>&lt;c:symbol></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(82, "marker")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class Marker : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Marker class.
        /// </summary>
        public Marker() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Marker class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Marker(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Marker class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Marker(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Marker class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Marker(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(82, "marker");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Charts.ExtensionList>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Charts.Size>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Charts.Symbol>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Symbol), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Size), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ExtensionList), 0, 1)
            };
        }

        /// <summary>
        /// <para>Symbol.</para>
        /// <para>Represents the following element tag in the schema: c:symbol.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Charts.Symbol? Symbol
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.Symbol>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Size.</para>
        /// <para>Represents the following element tag in the schema: c:size.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Charts.Size? Size
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.Size>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ChartShapeProperties.</para>
        /// <para>Represents the following element tag in the schema: c:spPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties? ChartShapeProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Chart Extensibility.</para>
        /// <para>Represents the following element tag in the schema: c:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Charts.ExtensionList? ExtensionList
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.ExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Marker>(deep);
    }

    /// <summary>
    /// <para>Defines the DLbl Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c16:dLbl.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties" /> <c>&lt;c:spPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Charts.TextProperties" /> <c>&lt;c:txPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Charts.Delete" /> <c>&lt;c:delete></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Charts.ShowLegendKey" /> <c>&lt;c:showLegendKey></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Charts.ShowValue" /> <c>&lt;c:showVal></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Charts.ShowCategoryName" /> <c>&lt;c:showCatName></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Charts.ShowSeriesName" /> <c>&lt;c:showSerName></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Charts.ShowPercent" /> <c>&lt;c:showPercent></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Charts.ShowBubbleSize" /> <c>&lt;c:showBubbleSize></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Charts.DLblExtensionList" /> <c>&lt;c:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Charts.DataLabelPosition" /> <c>&lt;c:dLblPos></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Charts.Layout" /> <c>&lt;c:layout></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Charts.NumberingFormat" /> <c>&lt;c:numFmt></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Charts.ChartText" /> <c>&lt;c:tx></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Charts.Index" /> <c>&lt;c:idx></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Charts.Separator" /> <c>&lt;c:separator></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(82, "dLbl")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class DLbl : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the DLbl class.
        /// </summary>
        public DLbl() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the DLbl class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DLbl(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DLbl class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DLbl(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DLbl class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public DLbl(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(82, "dLbl");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Charts.TextProperties>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Charts.Delete>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Charts.ShowLegendKey>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Charts.ShowValue>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Charts.ShowCategoryName>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Charts.ShowSeriesName>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Charts.ShowPercent>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Charts.ShowBubbleSize>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Charts.DLblExtensionList>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Charts.DataLabelPosition>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Charts.Layout>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Charts.NumberingFormat>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Charts.ChartText>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Charts.Index>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Charts.Separator>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Index), 1, 1),
                new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                {
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Delete), 1, 1),
                    new CompositeParticle.Builder(ParticleType.Group, 1, 1)
                    {
                        new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
                        {
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Layout), 0, 1),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ChartText), 0, 1),
                            new CompositeParticle.Builder(ParticleType.Group, 1, 1)
                            {
                                new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
                                {
                                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.NumberingFormat), 0, 1),
                                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties), 0, 1),
                                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.TextProperties), 0, 1),
                                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.DataLabelPosition), 0, 1),
                                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ShowLegendKey), 0, 1),
                                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ShowValue), 0, 1),
                                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ShowCategoryName), 0, 1),
                                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ShowSeriesName), 0, 1),
                                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ShowPercent), 0, 1),
                                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ShowBubbleSize), 0, 1),
                                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Separator), 0, 1)
                                }
                            }
                        }
                    }
                },
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.DLblExtensionList), 0, 1)
            };
        }

        /// <summary>
        /// <para>Index.</para>
        /// <para>Represents the following element tag in the schema: c:idx.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Charts.Index? Index
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.Index>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DLbl>(deep);
    }

    /// <summary>
    /// <para>Defines the CategoryFilterExceptions Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c16:categoryFilterExceptions.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.Charts.CategoryFilterException" /> <c>&lt;c16:categoryFilterException></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(82, "categoryFilterExceptions")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class CategoryFilterExceptions : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the CategoryFilterExceptions class.
        /// </summary>
        public CategoryFilterExceptions() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the CategoryFilterExceptions class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public CategoryFilterExceptions(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the CategoryFilterExceptions class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public CategoryFilterExceptions(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the CategoryFilterExceptions class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public CategoryFilterExceptions(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(82, "categoryFilterExceptions");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.Charts.CategoryFilterException>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.Charts.CategoryFilterException), 1, 0, version: FileFormatVersions.Office2016)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<CategoryFilterExceptions>(deep);
    }

    /// <summary>
    /// <para>Defines the PivotOptions16 Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c16:pivotOptions16.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.Charts.BooleanFalse" /> <c>&lt;c16:showExpandCollapseFieldButtons></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(82, "pivotOptions16")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class PivotOptions16 : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the PivotOptions16 class.
        /// </summary>
        public PivotOptions16() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the PivotOptions16 class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public PivotOptions16(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PivotOptions16 class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public PivotOptions16(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PivotOptions16 class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public PivotOptions16(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(82, "pivotOptions16");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.Charts.BooleanFalse>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.Charts.BooleanFalse), 0, 1, version: FileFormatVersions.Office2016)
            };
        }

        /// <summary>
        /// <para>BooleanFalse.</para>
        /// <para>Represents the following element tag in the schema: c16:showExpandCollapseFieldButtons.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c16 = http://schemas.microsoft.com/office/drawing/2014/chart
        /// </remark>
        public BooleanFalse? BooleanFalse
        {
            get => GetElement<BooleanFalse>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<PivotOptions16>(deep);
    }

    /// <summary>
    /// <para>Defines the ChartDataPointUniqueIDMap Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c16:datapointuniqueidmap.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.Charts.ChartDataPointUniqueIDMapEntry" /> <c>&lt;c16:ptentry></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(82, "datapointuniqueidmap")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class ChartDataPointUniqueIDMap : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ChartDataPointUniqueIDMap class.
        /// </summary>
        public ChartDataPointUniqueIDMap() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ChartDataPointUniqueIDMap class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ChartDataPointUniqueIDMap(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ChartDataPointUniqueIDMap class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ChartDataPointUniqueIDMap(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ChartDataPointUniqueIDMap class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ChartDataPointUniqueIDMap(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(82, "datapointuniqueidmap");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.Charts.ChartDataPointUniqueIDMapEntry>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.Charts.ChartDataPointUniqueIDMapEntry), 0, 0, version: FileFormatVersions.Office2016)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ChartDataPointUniqueIDMap>(deep);
    }

    /// <summary>
    /// <para>Defines the UniqueIdChartUniqueID Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c16:uniqueId.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(82, "uniqueId")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class UniqueIdChartUniqueID : UniqueIDChart
    {
        /// <summary>
        /// Initializes a new instance of the UniqueIdChartUniqueID class.
        /// </summary>
        public UniqueIdChartUniqueID() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(82, "uniqueId");
            builder.Availability = FileFormatVersions.Office2016;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<UniqueIdChartUniqueID>(deep);
    }

    /// <summary>
    /// <para>Defines the UniqueID Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c16:uniqueID.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(82, "uniqueID")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class UniqueID : UniqueIDChart
    {
        /// <summary>
        /// Initializes a new instance of the UniqueID class.
        /// </summary>
        public UniqueID() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(82, "uniqueID");
            builder.Availability = FileFormatVersions.Office2016;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<UniqueID>(deep);
    }

    /// <summary>
    /// <para>Defines the UniqueIDChart Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is :.</para>
    /// </summary>
    public abstract partial class UniqueIDChart : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the UniqueIDChart class.
        /// </summary>
        protected UniqueIDChart() : base()
        {
        }

        /// <summary>
        /// <para>val, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: val</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "val")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Val
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddElement<UniqueIDChart>()
                           .AddAttribute(0, "val", a => a.Val, aBuilder =>
                           {
                               aBuilder.AddValidator(RequiredValidator.Instance);
                           });
        }
    }

    /// <summary>
    /// <para>Defines the CategoryFilterException Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c16:categoryFilterException.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.Charts.ShapeProperties" /> <c>&lt;c16:spPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.Charts.InvertIfNegativeBoolean" /> <c>&lt;c16:invertIfNegative></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.Charts.Bubble3DBoolean" /> <c>&lt;c16:bubble3D></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.Charts.DLbl" /> <c>&lt;c16:dLbl></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.Charts.Marker" /> <c>&lt;c16:marker></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.Charts.UnsignedIntegerType" /> <c>&lt;c16:explosion></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.Charts.UniqueIdChartUniqueID" /> <c>&lt;c16:uniqueId></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(82, "categoryFilterException")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class CategoryFilterException : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the CategoryFilterException class.
        /// </summary>
        public CategoryFilterException() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the CategoryFilterException class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public CategoryFilterException(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the CategoryFilterException class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public CategoryFilterException(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the CategoryFilterException class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public CategoryFilterException(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(82, "categoryFilterException");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.Charts.ShapeProperties>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.Charts.InvertIfNegativeBoolean>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.Charts.Bubble3DBoolean>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.Charts.DLbl>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.Charts.Marker>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.Charts.UnsignedIntegerType>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.Charts.UniqueIdChartUniqueID>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.Charts.UniqueIdChartUniqueID), 1, 1, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.Charts.ShapeProperties), 0, 1, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.Charts.UnsignedIntegerType), 0, 1, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.Charts.InvertIfNegativeBoolean), 0, 1, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.Charts.Bubble3DBoolean), 0, 1, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.Charts.Marker), 0, 1, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.Charts.DLbl), 0, 1, version: FileFormatVersions.Office2016)
            };
        }

        /// <summary>
        /// <para>UniqueIdChartUniqueID.</para>
        /// <para>Represents the following element tag in the schema: c16:uniqueId.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c16 = http://schemas.microsoft.com/office/drawing/2014/chart
        /// </remark>
        public UniqueIdChartUniqueID? UniqueIdChartUniqueID
        {
            get => GetElement<UniqueIdChartUniqueID>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ShapeProperties.</para>
        /// <para>Represents the following element tag in the schema: c16:spPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c16 = http://schemas.microsoft.com/office/drawing/2014/chart
        /// </remark>
        public ShapeProperties? ShapeProperties
        {
            get => GetElement<ShapeProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>UnsignedIntegerType.</para>
        /// <para>Represents the following element tag in the schema: c16:explosion.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c16 = http://schemas.microsoft.com/office/drawing/2014/chart
        /// </remark>
        public UnsignedIntegerType? UnsignedIntegerType
        {
            get => GetElement<UnsignedIntegerType>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>InvertIfNegativeBoolean.</para>
        /// <para>Represents the following element tag in the schema: c16:invertIfNegative.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c16 = http://schemas.microsoft.com/office/drawing/2014/chart
        /// </remark>
        public InvertIfNegativeBoolean? InvertIfNegativeBoolean
        {
            get => GetElement<InvertIfNegativeBoolean>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Bubble3DBoolean.</para>
        /// <para>Represents the following element tag in the schema: c16:bubble3D.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c16 = http://schemas.microsoft.com/office/drawing/2014/chart
        /// </remark>
        public Bubble3DBoolean? Bubble3DBoolean
        {
            get => GetElement<Bubble3DBoolean>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Marker.</para>
        /// <para>Represents the following element tag in the schema: c16:marker.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c16 = http://schemas.microsoft.com/office/drawing/2014/chart
        /// </remark>
        public Marker? Marker
        {
            get => GetElement<Marker>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>DLbl.</para>
        /// <para>Represents the following element tag in the schema: c16:dLbl.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c16 = http://schemas.microsoft.com/office/drawing/2014/chart
        /// </remark>
        public DLbl? DLbl
        {
            get => GetElement<DLbl>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<CategoryFilterException>(deep);
    }

    /// <summary>
    /// <para>Defines the NumberDataType Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c16:numCache.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Charts.ExtensionList" /> <c>&lt;c:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Charts.NumericPoint" /> <c>&lt;c:pt></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Charts.PointCount" /> <c>&lt;c:ptCount></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Charts.FormatCode" /> <c>&lt;c:formatCode></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(82, "numCache")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class NumberDataType : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the NumberDataType class.
        /// </summary>
        public NumberDataType() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the NumberDataType class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NumberDataType(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NumberDataType class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NumberDataType(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NumberDataType class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public NumberDataType(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(82, "numCache");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Charts.ExtensionList>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Charts.NumericPoint>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Charts.PointCount>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Charts.FormatCode>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.FormatCode), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.PointCount), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.NumericPoint), 0, 0),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ExtensionList), 0, 1)
            };
        }

        /// <summary>
        /// <para>Format Code.</para>
        /// <para>Represents the following element tag in the schema: c:formatCode.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Charts.FormatCode? FormatCode
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.FormatCode>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Point Count.</para>
        /// <para>Represents the following element tag in the schema: c:ptCount.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Charts.PointCount? PointCount
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.PointCount>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<NumberDataType>(deep);
    }

    /// <summary>
    /// <para>Defines the NumFilteredLiteralCache Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c16:filteredLitCache.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.Charts.NumberDataType" /> <c>&lt;c16:numCache></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(82, "filteredLitCache")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class NumFilteredLiteralCache : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the NumFilteredLiteralCache class.
        /// </summary>
        public NumFilteredLiteralCache() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the NumFilteredLiteralCache class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NumFilteredLiteralCache(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NumFilteredLiteralCache class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NumFilteredLiteralCache(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NumFilteredLiteralCache class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public NumFilteredLiteralCache(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(82, "filteredLitCache");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.Charts.NumberDataType>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.Charts.NumberDataType), 1, 1, version: FileFormatVersions.Office2016)
            };
        }

        /// <summary>
        /// <para>NumberDataType.</para>
        /// <para>Represents the following element tag in the schema: c16:numCache.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c16 = http://schemas.microsoft.com/office/drawing/2014/chart
        /// </remark>
        public NumberDataType? NumberDataType
        {
            get => GetElement<NumberDataType>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<NumFilteredLiteralCache>(deep);
    }

    /// <summary>
    /// <para>Defines the StringDataType Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c16:strCache.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Charts.StrDataExtensionList" /> <c>&lt;c:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Charts.StringPoint" /> <c>&lt;c:pt></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Charts.PointCount" /> <c>&lt;c:ptCount></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(82, "strCache")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class StringDataType : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the StringDataType class.
        /// </summary>
        public StringDataType() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the StringDataType class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public StringDataType(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the StringDataType class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public StringDataType(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the StringDataType class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public StringDataType(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(82, "strCache");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Charts.StrDataExtensionList>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Charts.StringPoint>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Charts.PointCount>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.PointCount), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.StringPoint), 0, 0),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.StrDataExtensionList), 0, 1)
            };
        }

        /// <summary>
        /// <para>PointCount.</para>
        /// <para>Represents the following element tag in the schema: c:ptCount.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Charts.PointCount? PointCount
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.PointCount>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<StringDataType>(deep);
    }

    /// <summary>
    /// <para>Defines the StrFilteredLiteralCache Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c16:filteredLitCache.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.Charts.StringDataType" /> <c>&lt;c16:strCache></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(82, "filteredLitCache")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class StrFilteredLiteralCache : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the StrFilteredLiteralCache class.
        /// </summary>
        public StrFilteredLiteralCache() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the StrFilteredLiteralCache class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public StrFilteredLiteralCache(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the StrFilteredLiteralCache class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public StrFilteredLiteralCache(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the StrFilteredLiteralCache class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public StrFilteredLiteralCache(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(82, "filteredLitCache");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.Charts.StringDataType>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.Charts.StringDataType), 1, 1, version: FileFormatVersions.Office2016)
            };
        }

        /// <summary>
        /// <para>StringDataType.</para>
        /// <para>Represents the following element tag in the schema: c16:strCache.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c16 = http://schemas.microsoft.com/office/drawing/2014/chart
        /// </remark>
        public StringDataType? StringDataType
        {
            get => GetElement<StringDataType>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<StrFilteredLiteralCache>(deep);
    }

    /// <summary>
    /// <para>Defines the MultiLvlStrData Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c16:multiLvlStrCache.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Charts.ExtensionList" /> <c>&lt;c:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Charts.Level" /> <c>&lt;c:lvl></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Charts.PointCount" /> <c>&lt;c:ptCount></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(82, "multiLvlStrCache")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class MultiLvlStrData : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the MultiLvlStrData class.
        /// </summary>
        public MultiLvlStrData() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the MultiLvlStrData class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public MultiLvlStrData(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the MultiLvlStrData class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public MultiLvlStrData(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the MultiLvlStrData class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public MultiLvlStrData(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(82, "multiLvlStrCache");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Charts.ExtensionList>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Charts.Level>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Charts.PointCount>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.PointCount), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.Level), 0, 0),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Charts.ExtensionList), 0, 1)
            };
        }

        /// <summary>
        /// <para>PointCount.</para>
        /// <para>Represents the following element tag in the schema: c:ptCount.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Charts.PointCount? PointCount
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.PointCount>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<MultiLvlStrData>(deep);
    }

    /// <summary>
    /// <para>Defines the MultiLvlStrFilteredLiteralCache Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c16:filteredLitCache.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.Charts.MultiLvlStrData" /> <c>&lt;c16:multiLvlStrCache></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(82, "filteredLitCache")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class MultiLvlStrFilteredLiteralCache : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the MultiLvlStrFilteredLiteralCache class.
        /// </summary>
        public MultiLvlStrFilteredLiteralCache() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the MultiLvlStrFilteredLiteralCache class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public MultiLvlStrFilteredLiteralCache(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the MultiLvlStrFilteredLiteralCache class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public MultiLvlStrFilteredLiteralCache(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the MultiLvlStrFilteredLiteralCache class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public MultiLvlStrFilteredLiteralCache(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(82, "filteredLitCache");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.Charts.MultiLvlStrData>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.Charts.MultiLvlStrData), 1, 1, version: FileFormatVersions.Office2016)
            };
        }

        /// <summary>
        /// <para>MultiLvlStrData.</para>
        /// <para>Represents the following element tag in the schema: c16:multiLvlStrCache.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c16 = http://schemas.microsoft.com/office/drawing/2014/chart
        /// </remark>
        public MultiLvlStrData? MultiLvlStrData
        {
            get => GetElement<MultiLvlStrData>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<MultiLvlStrFilteredLiteralCache>(deep);
    }

    /// <summary>
    /// <para>Defines the LiteralDataChart Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c16:literalDataChart.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(82, "literalDataChart")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class LiteralDataChart : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the LiteralDataChart class.
        /// </summary>
        public LiteralDataChart() : base()
        {
        }

        /// <summary>
        /// <para>val, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: val</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "val")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? Val
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(82, "literalDataChart");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddElement<LiteralDataChart>()
.AddAttribute(0, "val", a => a.Val, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<LiteralDataChart>(deep);
    }

    /// <summary>
    /// <para>Defines the BooleanFalse Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c16:showExpandCollapseFieldButtons.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(82, "showExpandCollapseFieldButtons")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class BooleanFalse : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the BooleanFalse class.
        /// </summary>
        public BooleanFalse() : base()
        {
        }

        /// <summary>
        /// <para>val, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: val</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "val")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? Val
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(82, "showExpandCollapseFieldButtons");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddElement<BooleanFalse>()
.AddAttribute(0, "val", a => a.Val);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<BooleanFalse>(deep);
    }

    /// <summary>
    /// <para>Defines the XsdunsignedInt Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c16:ptidx.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(82, "ptidx")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class XsdunsignedInt : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the XsdunsignedInt class.
        /// </summary>
        public XsdunsignedInt() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the XsdunsignedInt class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public XsdunsignedInt(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new UInt32Value { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddValidator<UInt32Value>(NumberValidator.Instance);
            builder.SetSchema(82, "ptidx");
            builder.Availability = FileFormatVersions.Office2016;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<XsdunsignedInt>(deep);
    }

    /// <summary>
    /// <para>Defines the ChartDataPointUniqueIDMapEntry Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c16:ptentry.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.Charts.UniqueID" /> <c>&lt;c16:uniqueID></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.Charts.XsdunsignedInt" /> <c>&lt;c16:ptidx></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(82, "ptentry")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class ChartDataPointUniqueIDMapEntry : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ChartDataPointUniqueIDMapEntry class.
        /// </summary>
        public ChartDataPointUniqueIDMapEntry() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ChartDataPointUniqueIDMapEntry class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ChartDataPointUniqueIDMapEntry(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ChartDataPointUniqueIDMapEntry class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ChartDataPointUniqueIDMapEntry(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ChartDataPointUniqueIDMapEntry class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ChartDataPointUniqueIDMapEntry(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(82, "ptentry");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.Charts.UniqueID>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.Charts.XsdunsignedInt>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.Charts.XsdunsignedInt), 1, 1, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.Charts.UniqueID), 1, 1, version: FileFormatVersions.Office2016)
            };
        }

        /// <summary>
        /// <para>XsdunsignedInt.</para>
        /// <para>Represents the following element tag in the schema: c16:ptidx.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c16 = http://schemas.microsoft.com/office/drawing/2014/chart
        /// </remark>
        public XsdunsignedInt? XsdunsignedInt
        {
            get => GetElement<XsdunsignedInt>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>UniqueID.</para>
        /// <para>Represents the following element tag in the schema: c16:uniqueID.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c16 = http://schemas.microsoft.com/office/drawing/2014/chart
        /// </remark>
        public UniqueID? UniqueID
        {
            get => GetElement<UniqueID>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ChartDataPointUniqueIDMapEntry>(deep);
    }
}