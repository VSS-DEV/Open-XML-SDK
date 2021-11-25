﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

#nullable enable

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Framework.Metadata;
using DocumentFormat.OpenXml.Office2019.Drawing.Diagram11;
using DocumentFormat.OpenXml.Office2019.Drawing.Diagram12;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Validation.Schema;
using DocumentFormat.OpenXml.Validation.Semantic;
using System;
using System.Collections.Generic;
using System.IO.Packaging;

namespace DocumentFormat.OpenXml.Drawing.Diagrams
{
    /// <summary>
    /// <para>Color Transform Definitions.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is dgm:colorsDef.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Diagrams.ExtensionList" /> <c>&lt;dgm:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Diagrams.ColorTransformCategories" /> <c>&lt;dgm:catLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Diagrams.ColorTransformDescription" /> <c>&lt;dgm:desc></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Diagrams.ColorDefinitionTitle" /> <c>&lt;dgm:title></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Diagrams.ColorTransformStyleLabel" /> <c>&lt;dgm:styleLbl></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("dgm:colorsDef")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class ColorsDefinition : OpenXmlPartRootElement
    {
        /// <summary>
        /// Initializes a new instance of the ColorsDefinition class.
        /// </summary>
        public ColorsDefinition() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ColorsDefinition class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ColorsDefinition(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ColorsDefinition class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ColorsDefinition(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ColorsDefinition class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ColorsDefinition(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Unique ID</para>
        /// <para>Represents the following attribute in the schema: uniqueId</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("uniqueId")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? UniqueId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Minimum Version</para>
        /// <para>Represents the following attribute in the schema: minVer</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("minVer")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? MinVersion
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("dgm:colorsDef");
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Diagrams.ExtensionList>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Diagrams.ColorTransformCategories>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Diagrams.ColorTransformDescription>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Diagrams.ColorDefinitionTitle>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Diagrams.ColorTransformStyleLabel>();
            builder.AddElement<ColorsDefinition>()
.AddAttribute("uniqueId", a => a.UniqueId)
.AddAttribute("minVer", a => a.MinVersion);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.ColorDefinitionTitle), 0, 0),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.ColorTransformDescription), 0, 0),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.ColorTransformCategories), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.ColorTransformStyleLabel), 0, 0),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.ExtensionList), 0, 1)
            };
            builder.AddConstraint(new AttributeValueSetConstraint(":minVer", true, new string[] { "12.0" }));
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ColorsDefinition>(deep);

        internal ColorsDefinition(DiagramColorsPart ownerPart) : base(ownerPart)
        {
        }

        /// <summary>
        /// Loads the DOM from the DiagramColorsPart
        /// </summary>
        /// <param name="openXmlPart">Specifies the part to be loaded.</param>
        public void Load(DiagramColorsPart openXmlPart)
        {
            LoadFromPart(openXmlPart);
        }

        /// <summary>
        /// Saves the DOM into the DiagramColorsPart.
        /// </summary>
        /// <param name="openXmlPart">Specifies the part to save to.</param>
        public void Save(DiagramColorsPart openXmlPart)
        {
            base.SaveToPart(openXmlPart);
        }

        /// <summary>
        /// Gets the DiagramColorsPart associated with this element.
        /// </summary>
        public DiagramColorsPart? DiagramColorsPart
        {
            get => OpenXmlPart as DiagramColorsPart;
            internal set => OpenXmlPart = value;
        }
    }

    /// <summary>
    /// <para>Color Transform Header.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is dgm:colorsDefHdr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Diagrams.ExtensionList" /> <c>&lt;dgm:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Diagrams.ColorTransformCategories" /> <c>&lt;dgm:catLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Diagrams.ColorTransformDescription" /> <c>&lt;dgm:desc></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Diagrams.ColorDefinitionTitle" /> <c>&lt;dgm:title></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("dgm:colorsDefHdr")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class ColorsDefinitionHeader : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ColorsDefinitionHeader class.
        /// </summary>
        public ColorsDefinitionHeader() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ColorsDefinitionHeader class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ColorsDefinitionHeader(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ColorsDefinitionHeader class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ColorsDefinitionHeader(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ColorsDefinitionHeader class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ColorsDefinitionHeader(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Unique ID</para>
        /// <para>Represents the following attribute in the schema: uniqueId</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("uniqueId")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? UniqueId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Minimum Version</para>
        /// <para>Represents the following attribute in the schema: minVer</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("minVer")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? MinVersion
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Resource ID</para>
        /// <para>Represents the following attribute in the schema: resId</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("resId")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int32Value? ResourceId
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("dgm:colorsDefHdr");
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Diagrams.ExtensionList>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Diagrams.ColorTransformCategories>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Diagrams.ColorTransformDescription>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Diagrams.ColorDefinitionTitle>();
            builder.AddElement<ColorsDefinitionHeader>()
.AddAttribute("uniqueId", a => a.UniqueId, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute("minVer", a => a.MinVersion)
.AddAttribute("resId", a => a.ResourceId);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.ColorDefinitionTitle), 1, 0),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.ColorTransformDescription), 1, 0),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.ColorTransformCategories), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.ExtensionList), 0, 1)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ColorsDefinitionHeader>(deep);
    }

    /// <summary>
    /// <para>Color Transform Header List.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is dgm:colorsDefHdrLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Diagrams.ColorsDefinitionHeader" /> <c>&lt;dgm:colorsDefHdr></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("dgm:colorsDefHdrLst")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class ColorsDefinitionHeaderList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ColorsDefinitionHeaderList class.
        /// </summary>
        public ColorsDefinitionHeaderList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ColorsDefinitionHeaderList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ColorsDefinitionHeaderList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ColorsDefinitionHeaderList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ColorsDefinitionHeaderList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ColorsDefinitionHeaderList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ColorsDefinitionHeaderList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("dgm:colorsDefHdrLst");
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Diagrams.ColorsDefinitionHeader>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.ColorsDefinitionHeader), 0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ColorsDefinitionHeaderList>(deep);
    }

    /// <summary>
    /// <para>Data Model.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is dgm:dataModel.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Diagrams.Background" /> <c>&lt;dgm:bg></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Diagrams.DataModelExtensionList" /> <c>&lt;dgm:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Diagrams.Whole" /> <c>&lt;dgm:whole></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Diagrams.ConnectionList" /> <c>&lt;dgm:cxnLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Diagrams.PointList" /> <c>&lt;dgm:ptLst></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("dgm:dataModel")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class DataModelRoot : OpenXmlPartRootElement
    {
        /// <summary>
        /// Initializes a new instance of the DataModelRoot class.
        /// </summary>
        public DataModelRoot() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the DataModelRoot class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DataModelRoot(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DataModelRoot class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DataModelRoot(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DataModelRoot class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public DataModelRoot(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("dgm:dataModel");
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Diagrams.Background>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Diagrams.DataModelExtensionList>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Diagrams.Whole>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Diagrams.ConnectionList>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Diagrams.PointList>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.PointList), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.ConnectionList), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.Background), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.Whole), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.DataModelExtensionList), 0, 1)
            };
        }

        /// <summary>
        /// <para>Point List.</para>
        /// <para>Represents the following element tag in the schema: dgm:ptLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:dgm = http://schemas.openxmlformats.org/drawingml/2006/diagram
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Diagrams.PointList? PointList
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Diagrams.PointList>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Connection List.</para>
        /// <para>Represents the following element tag in the schema: dgm:cxnLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:dgm = http://schemas.openxmlformats.org/drawingml/2006/diagram
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Diagrams.ConnectionList? ConnectionList
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Diagrams.ConnectionList>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Background Formatting.</para>
        /// <para>Represents the following element tag in the schema: dgm:bg.</para>
        /// </summary>
        /// <remark>
        /// xmlns:dgm = http://schemas.openxmlformats.org/drawingml/2006/diagram
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Diagrams.Background? Background
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Diagrams.Background>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Whole E2O Formatting.</para>
        /// <para>Represents the following element tag in the schema: dgm:whole.</para>
        /// </summary>
        /// <remark>
        /// xmlns:dgm = http://schemas.openxmlformats.org/drawingml/2006/diagram
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Diagrams.Whole? Whole
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Diagrams.Whole>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>DataModelExtensionList.</para>
        /// <para>Represents the following element tag in the schema: dgm:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:dgm = http://schemas.openxmlformats.org/drawingml/2006/diagram
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Diagrams.DataModelExtensionList? DataModelExtensionList
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Diagrams.DataModelExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DataModelRoot>(deep);

        internal DataModelRoot(DiagramDataPart ownerPart) : base(ownerPart)
        {
        }

        /// <summary>
        /// Loads the DOM from the DiagramDataPart
        /// </summary>
        /// <param name="openXmlPart">Specifies the part to be loaded.</param>
        public void Load(DiagramDataPart openXmlPart)
        {
            LoadFromPart(openXmlPart);
        }

        /// <summary>
        /// Saves the DOM into the DiagramDataPart.
        /// </summary>
        /// <param name="openXmlPart">Specifies the part to save to.</param>
        public void Save(DiagramDataPart openXmlPart)
        {
            base.SaveToPart(openXmlPart);
        }

        /// <summary>
        /// Gets the DiagramDataPart associated with this element.
        /// </summary>
        public DiagramDataPart? DiagramDataPart
        {
            get => OpenXmlPart as DiagramDataPart;
            internal set => OpenXmlPart = value;
        }
    }

    /// <summary>
    /// <para>Layout Definition.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is dgm:layoutDef.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Diagrams.CategoryList" /> <c>&lt;dgm:catLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Diagrams.Description" /> <c>&lt;dgm:desc></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Diagrams.DiagramDefinitionExtensionList" /> <c>&lt;dgm:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Diagrams.LayoutNode" /> <c>&lt;dgm:layoutNode></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Diagrams.Title" /> <c>&lt;dgm:title></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Diagrams.SampleData" /> <c>&lt;dgm:sampData></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Diagrams.StyleData" /> <c>&lt;dgm:styleData></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Diagrams.ColorData" /> <c>&lt;dgm:clrData></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("dgm:layoutDef")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class LayoutDefinition : OpenXmlPartRootElement
    {
        /// <summary>
        /// Initializes a new instance of the LayoutDefinition class.
        /// </summary>
        public LayoutDefinition() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the LayoutDefinition class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public LayoutDefinition(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the LayoutDefinition class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public LayoutDefinition(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the LayoutDefinition class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public LayoutDefinition(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>uniqueId</para>
        /// <para>Represents the following attribute in the schema: uniqueId</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("uniqueId")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? UniqueId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>minVer</para>
        /// <para>Represents the following attribute in the schema: minVer</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("minVer")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? MinVersion
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>defStyle</para>
        /// <para>Represents the following attribute in the schema: defStyle</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("defStyle")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? DefaultStyle
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("dgm:layoutDef");
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Diagrams.CategoryList>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Diagrams.Description>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Diagrams.DiagramDefinitionExtensionList>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Diagrams.LayoutNode>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Diagrams.Title>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Diagrams.SampleData>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Diagrams.StyleData>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Diagrams.ColorData>();
            builder.AddElement<LayoutDefinition>()
.AddAttribute("uniqueId", a => a.UniqueId)
.AddAttribute("minVer", a => a.MinVersion)
.AddAttribute("defStyle", a => a.DefaultStyle);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.Title), 0, 0),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.Description), 0, 0),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.CategoryList), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.SampleData), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.StyleData), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.ColorData), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.LayoutNode), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.DiagramDefinitionExtensionList), 0, 1)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<LayoutDefinition>(deep);

        internal LayoutDefinition(DiagramLayoutDefinitionPart ownerPart) : base(ownerPart)
        {
        }

        /// <summary>
        /// Loads the DOM from the DiagramLayoutDefinitionPart
        /// </summary>
        /// <param name="openXmlPart">Specifies the part to be loaded.</param>
        public void Load(DiagramLayoutDefinitionPart openXmlPart)
        {
            LoadFromPart(openXmlPart);
        }

        /// <summary>
        /// Saves the DOM into the DiagramLayoutDefinitionPart.
        /// </summary>
        /// <param name="openXmlPart">Specifies the part to save to.</param>
        public void Save(DiagramLayoutDefinitionPart openXmlPart)
        {
            base.SaveToPart(openXmlPart);
        }

        /// <summary>
        /// Gets the DiagramLayoutDefinitionPart associated with this element.
        /// </summary>
        public DiagramLayoutDefinitionPart? DiagramLayoutDefinitionPart
        {
            get => OpenXmlPart as DiagramLayoutDefinitionPart;
            internal set => OpenXmlPart = value;
        }
    }

    /// <summary>
    /// <para>Layout Definition Header.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is dgm:layoutDefHdr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Diagrams.ExtensionList" /> <c>&lt;dgm:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Diagrams.CategoryList" /> <c>&lt;dgm:catLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Diagrams.Description" /> <c>&lt;dgm:desc></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Diagrams.Title" /> <c>&lt;dgm:title></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("dgm:layoutDefHdr")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class LayoutDefinitionHeader : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the LayoutDefinitionHeader class.
        /// </summary>
        public LayoutDefinitionHeader() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the LayoutDefinitionHeader class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public LayoutDefinitionHeader(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the LayoutDefinitionHeader class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public LayoutDefinitionHeader(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the LayoutDefinitionHeader class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public LayoutDefinitionHeader(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Unique Identifier</para>
        /// <para>Represents the following attribute in the schema: uniqueId</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("uniqueId")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? UniqueId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Minimum Version</para>
        /// <para>Represents the following attribute in the schema: minVer</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("minVer")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? MinVersion
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Default Style</para>
        /// <para>Represents the following attribute in the schema: defStyle</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("defStyle")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? DefaultStyle
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Resource Identifier</para>
        /// <para>Represents the following attribute in the schema: resId</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("resId")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int32Value? ResourceId
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("dgm:layoutDefHdr");
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Diagrams.ExtensionList>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Diagrams.CategoryList>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Diagrams.Description>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Diagrams.Title>();
            builder.AddElement<LayoutDefinitionHeader>()
.AddAttribute("uniqueId", a => a.UniqueId, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute("minVer", a => a.MinVersion)
.AddAttribute("defStyle", a => a.DefaultStyle)
.AddAttribute("resId", a => a.ResourceId);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.Title), 1, 0),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.Description), 1, 0),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.CategoryList), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.ExtensionList), 0, 1)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<LayoutDefinitionHeader>(deep);
    }

    /// <summary>
    /// <para>Diagram Layout Header List.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is dgm:layoutDefHdrLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Diagrams.LayoutDefinitionHeader" /> <c>&lt;dgm:layoutDefHdr></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("dgm:layoutDefHdrLst")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class LayoutDefinitionHeaderList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the LayoutDefinitionHeaderList class.
        /// </summary>
        public LayoutDefinitionHeaderList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the LayoutDefinitionHeaderList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public LayoutDefinitionHeaderList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the LayoutDefinitionHeaderList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public LayoutDefinitionHeaderList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the LayoutDefinitionHeaderList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public LayoutDefinitionHeaderList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("dgm:layoutDefHdrLst");
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Diagrams.LayoutDefinitionHeader>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.LayoutDefinitionHeader), 0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<LayoutDefinitionHeaderList>(deep);
    }

    /// <summary>
    /// <para>Explicit Relationships to Diagram Parts.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is dgm:relIds.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("dgm:relIds")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class RelationshipIds : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the RelationshipIds class.
        /// </summary>
        public RelationshipIds() : base()
        {
        }

        /// <summary>
        /// <para>Explicit Relationship to Diagram Data Part</para>
        /// <para>Represents the following attribute in the schema: r:dm</para>
        /// </summary>
        /// <remark>
        /// xmlns:r=http://schemas.openxmlformats.org/officeDocument/2006/relationships
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("r:dm")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? DataPart
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Explicit Relationship to Diagram Layout Definition Part</para>
        /// <para>Represents the following attribute in the schema: r:lo</para>
        /// </summary>
        /// <remark>
        /// xmlns:r=http://schemas.openxmlformats.org/officeDocument/2006/relationships
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("r:lo")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? LayoutPart
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Explicit Relationship to Style Definition Part</para>
        /// <para>Represents the following attribute in the schema: r:qs</para>
        /// </summary>
        /// <remark>
        /// xmlns:r=http://schemas.openxmlformats.org/officeDocument/2006/relationships
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("r:qs")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? StylePart
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Explicit Relationship to Diagram Colors Part</para>
        /// <para>Represents the following attribute in the schema: r:cs</para>
        /// </summary>
        /// <remark>
        /// xmlns:r=http://schemas.openxmlformats.org/officeDocument/2006/relationships
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("r:cs")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? ColorPart
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("dgm:relIds");
            builder.AddElement<RelationshipIds>()
.AddAttribute("r:dm", a => a.DataPart, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute("r:lo", a => a.LayoutPart, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute("r:qs", a => a.StylePart, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute("r:cs", a => a.ColorPart, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
});
            builder.AddConstraint(new RelationshipTypeConstraint("r:cs", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/diagramColors"));
            builder.AddConstraint(new RelationshipTypeConstraint("r:dm", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/diagramData"));
            builder.AddConstraint(new RelationshipTypeConstraint("r:lo", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/diagramLayout"));
            builder.AddConstraint(new RelationshipTypeConstraint("r:qs", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/diagramQuickStyle"));
            builder.AddConstraint(new RelationshipExistConstraint("r:dm"));
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RelationshipIds>(deep);
    }

    /// <summary>
    /// <para>Style Definition.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is dgm:styleDef.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Diagrams.ExtensionList" /> <c>&lt;dgm:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Diagrams.Scene3D" /> <c>&lt;dgm:scene3d></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Diagrams.StyleDisplayCategories" /> <c>&lt;dgm:catLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Diagrams.StyleLabelDescription" /> <c>&lt;dgm:desc></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Diagrams.StyleDefinitionTitle" /> <c>&lt;dgm:title></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Diagrams.StyleLabel" /> <c>&lt;dgm:styleLbl></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("dgm:styleDef")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class StyleDefinition : OpenXmlPartRootElement
    {
        /// <summary>
        /// Initializes a new instance of the StyleDefinition class.
        /// </summary>
        public StyleDefinition() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the StyleDefinition class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public StyleDefinition(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the StyleDefinition class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public StyleDefinition(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the StyleDefinition class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public StyleDefinition(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Unique Style ID</para>
        /// <para>Represents the following attribute in the schema: uniqueId</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("uniqueId")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? UniqueId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Minimum Version</para>
        /// <para>Represents the following attribute in the schema: minVer</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("minVer")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? MinVersion
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("dgm:styleDef");
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Diagrams.ExtensionList>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Diagrams.Scene3D>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Diagrams.StyleDisplayCategories>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Diagrams.StyleLabelDescription>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Diagrams.StyleDefinitionTitle>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Diagrams.StyleLabel>();
            builder.AddElement<StyleDefinition>()
.AddAttribute("uniqueId", a => a.UniqueId)
.AddAttribute("minVer", a => a.MinVersion);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.StyleDefinitionTitle), 0, 0),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.StyleLabelDescription), 0, 0),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.StyleDisplayCategories), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.Scene3D), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.StyleLabel), 1, 0),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.ExtensionList), 0, 1)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<StyleDefinition>(deep);

        internal StyleDefinition(DiagramStylePart ownerPart) : base(ownerPart)
        {
        }

        /// <summary>
        /// Loads the DOM from the DiagramStylePart
        /// </summary>
        /// <param name="openXmlPart">Specifies the part to be loaded.</param>
        public void Load(DiagramStylePart openXmlPart)
        {
            LoadFromPart(openXmlPart);
        }

        /// <summary>
        /// Saves the DOM into the DiagramStylePart.
        /// </summary>
        /// <param name="openXmlPart">Specifies the part to save to.</param>
        public void Save(DiagramStylePart openXmlPart)
        {
            base.SaveToPart(openXmlPart);
        }

        /// <summary>
        /// Gets the DiagramStylePart associated with this element.
        /// </summary>
        public DiagramStylePart? DiagramStylePart
        {
            get => OpenXmlPart as DiagramStylePart;
            internal set => OpenXmlPart = value;
        }
    }

    /// <summary>
    /// <para>Style Definition Header.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is dgm:styleDefHdr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Diagrams.ExtensionList" /> <c>&lt;dgm:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Diagrams.StyleDisplayCategories" /> <c>&lt;dgm:catLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Diagrams.StyleLabelDescription" /> <c>&lt;dgm:desc></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Diagrams.StyleDefinitionTitle" /> <c>&lt;dgm:title></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("dgm:styleDefHdr")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class StyleDefinitionHeader : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the StyleDefinitionHeader class.
        /// </summary>
        public StyleDefinitionHeader() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the StyleDefinitionHeader class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public StyleDefinitionHeader(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the StyleDefinitionHeader class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public StyleDefinitionHeader(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the StyleDefinitionHeader class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public StyleDefinitionHeader(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Unique Style ID</para>
        /// <para>Represents the following attribute in the schema: uniqueId</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("uniqueId")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? UniqueId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Minimum Version</para>
        /// <para>Represents the following attribute in the schema: minVer</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("minVer")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? MinVersion
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Resource ID</para>
        /// <para>Represents the following attribute in the schema: resId</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("resId")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int32Value? ResourceId
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("dgm:styleDefHdr");
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Diagrams.ExtensionList>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Diagrams.StyleDisplayCategories>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Diagrams.StyleLabelDescription>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Diagrams.StyleDefinitionTitle>();
            builder.AddElement<StyleDefinitionHeader>()
.AddAttribute("uniqueId", a => a.UniqueId, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute("minVer", a => a.MinVersion)
.AddAttribute("resId", a => a.ResourceId);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.StyleDefinitionTitle), 1, 0),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.StyleLabelDescription), 1, 0),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.StyleDisplayCategories), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.ExtensionList), 0, 1)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<StyleDefinitionHeader>(deep);
    }

    /// <summary>
    /// <para>List of Style Definition Headers.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is dgm:styleDefHdrLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Diagrams.StyleDefinitionHeader" /> <c>&lt;dgm:styleDefHdr></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("dgm:styleDefHdrLst")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class StyleDefinitionHeaderList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the StyleDefinitionHeaderList class.
        /// </summary>
        public StyleDefinitionHeaderList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the StyleDefinitionHeaderList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public StyleDefinitionHeaderList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the StyleDefinitionHeaderList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public StyleDefinitionHeaderList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the StyleDefinitionHeaderList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public StyleDefinitionHeaderList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("dgm:styleDefHdrLst");
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Diagrams.StyleDefinitionHeader>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.StyleDefinitionHeader), 0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<StyleDefinitionHeaderList>(deep);
    }

    /// <summary>
    /// <para>Color Transform Category.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is dgm:cat.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("dgm:cat")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class ColorTransformCategory : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the ColorTransformCategory class.
        /// </summary>
        public ColorTransformCategory() : base()
        {
        }

        /// <summary>
        /// <para>Category Type</para>
        /// <para>Represents the following attribute in the schema: type</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("type")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Type
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Priority</para>
        /// <para>Represents the following attribute in the schema: pri</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("pri")]
#pragma warning restore CS0618 // Type or member is obsolete

        public UInt32Value? Priority
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("dgm:cat");
            builder.AddElement<ColorTransformCategory>()
.AddAttribute("type", a => a.Type, aBuilder =>
{
  aBuilder.AddValidator(RequiredValidator.Instance);
  aBuilder.AddValidator(new StringValidator() { IsUri = (true) });
})
.AddAttribute("pri", a => a.Priority, aBuilder =>
{
  aBuilder.AddValidator(RequiredValidator.Instance);
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ColorTransformCategory>(deep);
    }

    /// <summary>
    /// <para>Fill Color List.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is dgm:fillClrLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.HslColor" /> <c>&lt;a:hslClr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.PresetColor" /> <c>&lt;a:prstClr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.SchemeColor" /> <c>&lt;a:schemeClr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.RgbColorModelPercentage" /> <c>&lt;a:scrgbClr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.RgbColorModelHex" /> <c>&lt;a:srgbClr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.SystemColor" /> <c>&lt;a:sysClr></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("dgm:fillClrLst")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class FillColorList : ColorsType
    {
        /// <summary>
        /// Initializes a new instance of the FillColorList class.
        /// </summary>
        public FillColorList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the FillColorList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public FillColorList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the FillColorList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public FillColorList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the FillColorList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public FillColorList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("dgm:fillClrLst");
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle.Builder(ParticleType.Group, 0, 0)
                {
                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.RgbColorModelPercentage), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.RgbColorModelHex), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.HslColor), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.SystemColor), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.SchemeColor), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.PresetColor), 1, 1)
                    }
                }
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<FillColorList>(deep);
    }

    /// <summary>
    /// <para>Line Color List.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is dgm:linClrLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.HslColor" /> <c>&lt;a:hslClr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.PresetColor" /> <c>&lt;a:prstClr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.SchemeColor" /> <c>&lt;a:schemeClr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.RgbColorModelPercentage" /> <c>&lt;a:scrgbClr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.RgbColorModelHex" /> <c>&lt;a:srgbClr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.SystemColor" /> <c>&lt;a:sysClr></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("dgm:linClrLst")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class LineColorList : ColorsType
    {
        /// <summary>
        /// Initializes a new instance of the LineColorList class.
        /// </summary>
        public LineColorList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the LineColorList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public LineColorList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the LineColorList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public LineColorList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the LineColorList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public LineColorList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("dgm:linClrLst");
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle.Builder(ParticleType.Group, 0, 0)
                {
                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.RgbColorModelPercentage), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.RgbColorModelHex), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.HslColor), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.SystemColor), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.SchemeColor), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.PresetColor), 1, 1)
                    }
                }
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<LineColorList>(deep);
    }

    /// <summary>
    /// <para>Effect Color List.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is dgm:effectClrLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.HslColor" /> <c>&lt;a:hslClr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.PresetColor" /> <c>&lt;a:prstClr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.SchemeColor" /> <c>&lt;a:schemeClr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.RgbColorModelPercentage" /> <c>&lt;a:scrgbClr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.RgbColorModelHex" /> <c>&lt;a:srgbClr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.SystemColor" /> <c>&lt;a:sysClr></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("dgm:effectClrLst")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class EffectColorList : ColorsType
    {
        /// <summary>
        /// Initializes a new instance of the EffectColorList class.
        /// </summary>
        public EffectColorList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the EffectColorList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public EffectColorList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the EffectColorList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public EffectColorList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the EffectColorList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public EffectColorList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("dgm:effectClrLst");
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle.Builder(ParticleType.Group, 0, 0)
                {
                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.RgbColorModelPercentage), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.RgbColorModelHex), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.HslColor), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.SystemColor), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.SchemeColor), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.PresetColor), 1, 1)
                    }
                }
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<EffectColorList>(deep);
    }

    /// <summary>
    /// <para>Text Line Color List.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is dgm:txLinClrLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.HslColor" /> <c>&lt;a:hslClr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.PresetColor" /> <c>&lt;a:prstClr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.SchemeColor" /> <c>&lt;a:schemeClr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.RgbColorModelPercentage" /> <c>&lt;a:scrgbClr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.RgbColorModelHex" /> <c>&lt;a:srgbClr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.SystemColor" /> <c>&lt;a:sysClr></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("dgm:txLinClrLst")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class TextLineColorList : ColorsType
    {
        /// <summary>
        /// Initializes a new instance of the TextLineColorList class.
        /// </summary>
        public TextLineColorList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the TextLineColorList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TextLineColorList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TextLineColorList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TextLineColorList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TextLineColorList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public TextLineColorList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("dgm:txLinClrLst");
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle.Builder(ParticleType.Group, 0, 0)
                {
                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.RgbColorModelPercentage), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.RgbColorModelHex), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.HslColor), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.SystemColor), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.SchemeColor), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.PresetColor), 1, 1)
                    }
                }
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TextLineColorList>(deep);
    }

    /// <summary>
    /// <para>Text Fill Color List.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is dgm:txFillClrLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.HslColor" /> <c>&lt;a:hslClr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.PresetColor" /> <c>&lt;a:prstClr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.SchemeColor" /> <c>&lt;a:schemeClr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.RgbColorModelPercentage" /> <c>&lt;a:scrgbClr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.RgbColorModelHex" /> <c>&lt;a:srgbClr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.SystemColor" /> <c>&lt;a:sysClr></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("dgm:txFillClrLst")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class TextFillColorList : ColorsType
    {
        /// <summary>
        /// Initializes a new instance of the TextFillColorList class.
        /// </summary>
        public TextFillColorList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the TextFillColorList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TextFillColorList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TextFillColorList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TextFillColorList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TextFillColorList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public TextFillColorList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("dgm:txFillClrLst");
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle.Builder(ParticleType.Group, 0, 0)
                {
                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.RgbColorModelPercentage), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.RgbColorModelHex), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.HslColor), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.SystemColor), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.SchemeColor), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.PresetColor), 1, 1)
                    }
                }
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TextFillColorList>(deep);
    }

    /// <summary>
    /// <para>Text Effect Color List.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is dgm:txEffectClrLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.HslColor" /> <c>&lt;a:hslClr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.PresetColor" /> <c>&lt;a:prstClr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.SchemeColor" /> <c>&lt;a:schemeClr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.RgbColorModelPercentage" /> <c>&lt;a:scrgbClr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.RgbColorModelHex" /> <c>&lt;a:srgbClr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.SystemColor" /> <c>&lt;a:sysClr></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("dgm:txEffectClrLst")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class TextEffectColorList : ColorsType
    {
        /// <summary>
        /// Initializes a new instance of the TextEffectColorList class.
        /// </summary>
        public TextEffectColorList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the TextEffectColorList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TextEffectColorList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TextEffectColorList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TextEffectColorList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TextEffectColorList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public TextEffectColorList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("dgm:txEffectClrLst");
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle.Builder(ParticleType.Group, 0, 0)
                {
                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.RgbColorModelPercentage), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.RgbColorModelHex), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.HslColor), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.SystemColor), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.SchemeColor), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.PresetColor), 1, 1)
                    }
                }
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TextEffectColorList>(deep);
    }

    /// <summary>
    /// <para>Defines the ColorsType Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is :.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.HslColor" /> <c>&lt;a:hslClr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.PresetColor" /> <c>&lt;a:prstClr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.SchemeColor" /> <c>&lt;a:schemeClr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.RgbColorModelPercentage" /> <c>&lt;a:scrgbClr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.RgbColorModelHex" /> <c>&lt;a:srgbClr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.SystemColor" /> <c>&lt;a:sysClr></c></description></item>
    /// </list>
    /// </remark>
    public abstract partial class ColorsType : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ColorsType class.
        /// </summary>
        protected ColorsType() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ColorsType class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        protected ColorsType(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ColorsType class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        protected ColorsType(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ColorsType class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        protected ColorsType(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Color Application Method Type</para>
        /// <para>Represents the following attribute in the schema: meth</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("meth")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ColorApplicationMethodValues>? Method
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ColorApplicationMethodValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Hue Direction</para>
        /// <para>Represents the following attribute in the schema: hueDir</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("hueDir")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.HueDirectionValues>? HueDirection
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.HueDirectionValues>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddChild<DocumentFormat.OpenXml.Drawing.HslColor>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.PresetColor>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.SchemeColor>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.RgbColorModelPercentage>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.RgbColorModelHex>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.SystemColor>();
            builder.AddElement<ColorsType>()
.AddAttribute("meth", a => a.Method, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
})
.AddAttribute("hueDir", a => a.HueDirection, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
});
        }
    }

    /// <summary>
    /// <para>Defines the ExtensionList Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is dgm:extLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Extension" /> <c>&lt;a:ext></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("dgm:extLst")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class ExtensionList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ExtensionList class.
        /// </summary>
        public ExtensionList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ExtensionList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ExtensionList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ExtensionList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ExtensionList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ExtensionList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ExtensionList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("dgm:extLst");
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Extension>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle.Builder(ParticleType.Group, 1, 1)
                {
                    new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Extension), 0, 0)
                    }
                }
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ExtensionList>(deep);
    }

    /// <summary>
    /// <para>Title.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is dgm:title.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("dgm:title")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class ColorDefinitionTitle : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the ColorDefinitionTitle class.
        /// </summary>
        public ColorDefinitionTitle() : base()
        {
        }

        /// <summary>
        /// <para>Language</para>
        /// <para>Represents the following attribute in the schema: lang</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("lang")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Language
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Description Value</para>
        /// <para>Represents the following attribute in the schema: val</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("val")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Val
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("dgm:title");
            builder.AddElement<ColorDefinitionTitle>()
.AddAttribute("lang", a => a.Language)
.AddAttribute("val", a => a.Val, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ColorDefinitionTitle>(deep);
    }

    /// <summary>
    /// <para>Description.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is dgm:desc.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("dgm:desc")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class ColorTransformDescription : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the ColorTransformDescription class.
        /// </summary>
        public ColorTransformDescription() : base()
        {
        }

        /// <summary>
        /// <para>Language</para>
        /// <para>Represents the following attribute in the schema: lang</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("lang")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Language
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Description Value</para>
        /// <para>Represents the following attribute in the schema: val</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("val")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Val
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("dgm:desc");
            builder.AddElement<ColorTransformDescription>()
.AddAttribute("lang", a => a.Language)
.AddAttribute("val", a => a.Val, aBuilder =>
{
 aBuilder.AddValidator(RequiredValidator.Instance);
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ColorTransformDescription>(deep);
    }

    /// <summary>
    /// <para>Color Transform Category List.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is dgm:catLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Diagrams.ColorTransformCategory" /> <c>&lt;dgm:cat></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("dgm:catLst")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class ColorTransformCategories : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ColorTransformCategories class.
        /// </summary>
        public ColorTransformCategories() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ColorTransformCategories class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ColorTransformCategories(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ColorTransformCategories class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ColorTransformCategories(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ColorTransformCategories class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ColorTransformCategories(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("dgm:catLst");
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Diagrams.ColorTransformCategory>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 0, 0)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.ColorTransformCategory), 0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ColorTransformCategories>(deep);
    }

    /// <summary>
    /// <para>Style Label.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is dgm:styleLbl.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Diagrams.ExtensionList" /> <c>&lt;dgm:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Diagrams.FillColorList" /> <c>&lt;dgm:fillClrLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Diagrams.LineColorList" /> <c>&lt;dgm:linClrLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Diagrams.EffectColorList" /> <c>&lt;dgm:effectClrLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Diagrams.TextLineColorList" /> <c>&lt;dgm:txLinClrLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Diagrams.TextFillColorList" /> <c>&lt;dgm:txFillClrLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Diagrams.TextEffectColorList" /> <c>&lt;dgm:txEffectClrLst></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("dgm:styleLbl")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class ColorTransformStyleLabel : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ColorTransformStyleLabel class.
        /// </summary>
        public ColorTransformStyleLabel() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ColorTransformStyleLabel class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ColorTransformStyleLabel(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ColorTransformStyleLabel class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ColorTransformStyleLabel(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ColorTransformStyleLabel class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ColorTransformStyleLabel(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Name</para>
        /// <para>Represents the following attribute in the schema: name</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("name")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Name
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("dgm:styleLbl");
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Diagrams.ExtensionList>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Diagrams.FillColorList>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Diagrams.LineColorList>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Diagrams.EffectColorList>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Diagrams.TextLineColorList>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Diagrams.TextFillColorList>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Diagrams.TextEffectColorList>();
            builder.AddElement<ColorTransformStyleLabel>()
.AddAttribute("name", a => a.Name, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
});
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.FillColorList), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.LineColorList), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.EffectColorList), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.TextLineColorList), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.TextFillColorList), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.TextEffectColorList), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.ExtensionList), 0, 1)
            };
        }

        /// <summary>
        /// <para>Fill Color List.</para>
        /// <para>Represents the following element tag in the schema: dgm:fillClrLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:dgm = http://schemas.openxmlformats.org/drawingml/2006/diagram
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Diagrams.FillColorList? FillColorList
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Diagrams.FillColorList>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Line Color List.</para>
        /// <para>Represents the following element tag in the schema: dgm:linClrLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:dgm = http://schemas.openxmlformats.org/drawingml/2006/diagram
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Diagrams.LineColorList? LineColorList
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Diagrams.LineColorList>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Effect Color List.</para>
        /// <para>Represents the following element tag in the schema: dgm:effectClrLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:dgm = http://schemas.openxmlformats.org/drawingml/2006/diagram
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Diagrams.EffectColorList? EffectColorList
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Diagrams.EffectColorList>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Text Line Color List.</para>
        /// <para>Represents the following element tag in the schema: dgm:txLinClrLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:dgm = http://schemas.openxmlformats.org/drawingml/2006/diagram
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Diagrams.TextLineColorList? TextLineColorList
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Diagrams.TextLineColorList>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Text Fill Color List.</para>
        /// <para>Represents the following element tag in the schema: dgm:txFillClrLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:dgm = http://schemas.openxmlformats.org/drawingml/2006/diagram
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Diagrams.TextFillColorList? TextFillColorList
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Diagrams.TextFillColorList>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Text Effect Color List.</para>
        /// <para>Represents the following element tag in the schema: dgm:txEffectClrLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:dgm = http://schemas.openxmlformats.org/drawingml/2006/diagram
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Diagrams.TextEffectColorList? TextEffectColorList
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Diagrams.TextEffectColorList>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ExtensionList.</para>
        /// <para>Represents the following element tag in the schema: dgm:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:dgm = http://schemas.openxmlformats.org/drawingml/2006/diagram
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Diagrams.ExtensionList? ExtensionList
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Diagrams.ExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ColorTransformStyleLabel>(deep);
    }

    /// <summary>
    /// <para>Point.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is dgm:pt.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Diagrams.PtExtensionList" /> <c>&lt;dgm:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Diagrams.ShapeProperties" /> <c>&lt;dgm:spPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Diagrams.TextBody" /> <c>&lt;dgm:t></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Diagrams.PropertySet" /> <c>&lt;dgm:prSet></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("dgm:pt")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class Point : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Point class.
        /// </summary>
        public Point() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Point class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Point(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Point class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Point(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Point class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Point(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Model Identifier</para>
        /// <para>Represents the following attribute in the schema: modelId</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("modelId")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? ModelId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Point Type</para>
        /// <para>Represents the following attribute in the schema: type</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("type")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.PointValues>? Type
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.PointValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Connection Identifier</para>
        /// <para>Represents the following attribute in the schema: cxnId</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("cxnId")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? ConnectionId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("dgm:pt");
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Diagrams.PtExtensionList>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Diagrams.ShapeProperties>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Diagrams.TextBody>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Diagrams.PropertySet>();
            builder.AddElement<Point>()
.AddAttribute("modelId", a => a.ModelId, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddUnion(union =>
{
union.AddValidator<Int32Value>(NumberValidator.Instance);
union.AddValidator(new StringValidator() { Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
});
})
.AddAttribute("type", a => a.Type, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
})
.AddAttribute("cxnId", a => a.ConnectionId, aBuilder =>
{
aBuilder.AddUnion(union =>
{
union.AddValidator<Int32Value>(NumberValidator.Instance);
union.AddValidator(new StringValidator() { Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
});
});
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.PropertySet), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.ShapeProperties), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.TextBody), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.PtExtensionList), 0, 1)
            };
        }

        /// <summary>
        /// <para>Property Set.</para>
        /// <para>Represents the following element tag in the schema: dgm:prSet.</para>
        /// </summary>
        /// <remark>
        /// xmlns:dgm = http://schemas.openxmlformats.org/drawingml/2006/diagram
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Diagrams.PropertySet? PropertySet
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Diagrams.PropertySet>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Shape Properties.</para>
        /// <para>Represents the following element tag in the schema: dgm:spPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:dgm = http://schemas.openxmlformats.org/drawingml/2006/diagram
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Diagrams.ShapeProperties? ShapeProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Diagrams.ShapeProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Text Body.</para>
        /// <para>Represents the following element tag in the schema: dgm:t.</para>
        /// </summary>
        /// <remark>
        /// xmlns:dgm = http://schemas.openxmlformats.org/drawingml/2006/diagram
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Diagrams.TextBody? TextBody
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Diagrams.TextBody>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>PtExtensionList.</para>
        /// <para>Represents the following element tag in the schema: dgm:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:dgm = http://schemas.openxmlformats.org/drawingml/2006/diagram
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Diagrams.PtExtensionList? PtExtensionList
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Diagrams.PtExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Point>(deep);
    }

    /// <summary>
    /// <para>Connection.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is dgm:cxn.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Diagrams.ExtensionList" /> <c>&lt;dgm:extLst></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("dgm:cxn")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class Connection : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Connection class.
        /// </summary>
        public Connection() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Connection class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Connection(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Connection class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Connection(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Connection class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Connection(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Model Identifier</para>
        /// <para>Represents the following attribute in the schema: modelId</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("modelId")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? ModelId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Point Type</para>
        /// <para>Represents the following attribute in the schema: type</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("type")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ConnectionValues>? Type
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ConnectionValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Source Identifier</para>
        /// <para>Represents the following attribute in the schema: srcId</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("srcId")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? SourceId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Destination Identifier</para>
        /// <para>Represents the following attribute in the schema: destId</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("destId")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? DestinationId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Source Position</para>
        /// <para>Represents the following attribute in the schema: srcOrd</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("srcOrd")]
#pragma warning restore CS0618 // Type or member is obsolete

        public UInt32Value? SourcePosition
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Destination Position</para>
        /// <para>Represents the following attribute in the schema: destOrd</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("destOrd")]
#pragma warning restore CS0618 // Type or member is obsolete

        public UInt32Value? DestinationPosition
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Parent Transition Identifier</para>
        /// <para>Represents the following attribute in the schema: parTransId</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("parTransId")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? ParentTransitionId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Sibling Transition Identifier</para>
        /// <para>Represents the following attribute in the schema: sibTransId</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("sibTransId")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? SiblingTransitionId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Presentation Identifier</para>
        /// <para>Represents the following attribute in the schema: presId</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("presId")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? PresentationId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("dgm:cxn");
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Diagrams.ExtensionList>();
            builder.AddElement<Connection>()
.AddAttribute("modelId", a => a.ModelId, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddUnion(union =>
{
union.AddValidator<Int32Value>(NumberValidator.Instance);
union.AddValidator(new StringValidator() { Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
});
})
.AddAttribute("type", a => a.Type, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
})
.AddAttribute("srcId", a => a.SourceId, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddUnion(union =>
{
union.AddValidator<Int32Value>(NumberValidator.Instance);
union.AddValidator(new StringValidator() { Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
});
})
.AddAttribute("destId", a => a.DestinationId, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddUnion(union =>
{
union.AddValidator<Int32Value>(NumberValidator.Instance);
union.AddValidator(new StringValidator() { Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
});
})
.AddAttribute("srcOrd", a => a.SourcePosition, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute("destOrd", a => a.DestinationPosition, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute("parTransId", a => a.ParentTransitionId, aBuilder =>
{
aBuilder.AddUnion(union =>
{
union.AddValidator<Int32Value>(NumberValidator.Instance);
union.AddValidator(new StringValidator() { Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
});
})
.AddAttribute("sibTransId", a => a.SiblingTransitionId, aBuilder =>
{
aBuilder.AddUnion(union =>
{
union.AddValidator<Int32Value>(NumberValidator.Instance);
union.AddValidator(new StringValidator() { Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
});
})
.AddAttribute("presId", a => a.PresentationId);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.ExtensionList), 0, 1)
            };
            builder.AddConstraint(new UniqueAttributeValueConstraint(":modelId", true, "dgm:cxnLst"));
            builder.AddConstraint(new UniqueAttributeValueConstraint(":parTransId", true, null));
        }

        /// <summary>
        /// <para>ExtensionList.</para>
        /// <para>Represents the following element tag in the schema: dgm:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:dgm = http://schemas.openxmlformats.org/drawingml/2006/diagram
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Diagrams.ExtensionList? ExtensionList
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Diagrams.ExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Connection>(deep);
    }

    /// <summary>
    /// <para>Constraint.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is dgm:constr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Diagrams.ExtensionList" /> <c>&lt;dgm:extLst></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("dgm:constr")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class Constraint : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Constraint class.
        /// </summary>
        public Constraint() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Constraint class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Constraint(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Constraint class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Constraint(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Constraint class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Constraint(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Constraint Type</para>
        /// <para>Represents the following attribute in the schema: type</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("type")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ConstraintValues>? Type
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ConstraintValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>For</para>
        /// <para>Represents the following attribute in the schema: for</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("for")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ConstraintRelationshipValues>? For
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ConstraintRelationshipValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>For Name</para>
        /// <para>Represents the following attribute in the schema: forName</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("forName")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? ForName
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Data Point Type</para>
        /// <para>Represents the following attribute in the schema: ptType</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("ptType")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ElementValues>? PointType
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ElementValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Reference Type</para>
        /// <para>Represents the following attribute in the schema: refType</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("refType")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ConstraintValues>? ReferenceType
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ConstraintValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Reference For</para>
        /// <para>Represents the following attribute in the schema: refFor</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("refFor")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ConstraintRelationshipValues>? ReferenceFor
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ConstraintRelationshipValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Reference For Name</para>
        /// <para>Represents the following attribute in the schema: refForName</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("refForName")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? ReferenceForName
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Reference Point Type</para>
        /// <para>Represents the following attribute in the schema: refPtType</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("refPtType")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ElementValues>? ReferencePointType
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ElementValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Operator</para>
        /// <para>Represents the following attribute in the schema: op</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("op")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.BoolOperatorValues>? Operator
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.BoolOperatorValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Value</para>
        /// <para>Represents the following attribute in the schema: val</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("val")]
#pragma warning restore CS0618 // Type or member is obsolete

        public DoubleValue? Val
        {
            get => GetAttribute<DoubleValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Factor</para>
        /// <para>Represents the following attribute in the schema: fact</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("fact")]
#pragma warning restore CS0618 // Type or member is obsolete

        public DoubleValue? Fact
        {
            get => GetAttribute<DoubleValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("dgm:constr");
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Diagrams.ExtensionList>();
            builder.AddElement<Constraint>()
.AddAttribute("type", a => a.Type, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
})
.AddAttribute("for", a => a.For, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
})
.AddAttribute("forName", a => a.ForName)
.AddAttribute("ptType", a => a.PointType, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
})
.AddAttribute("refType", a => a.ReferenceType, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
})
.AddAttribute("refFor", a => a.ReferenceFor, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
})
.AddAttribute("refForName", a => a.ReferenceForName)
.AddAttribute("refPtType", a => a.ReferencePointType, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
})
.AddAttribute("op", a => a.Operator, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
})
.AddAttribute("val", a => a.Val)
.AddAttribute("fact", a => a.Fact);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.ExtensionList), 0, 1)
            };
        }

        /// <summary>
        /// <para>ExtensionList.</para>
        /// <para>Represents the following element tag in the schema: dgm:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:dgm = http://schemas.openxmlformats.org/drawingml/2006/diagram
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Diagrams.ExtensionList? ExtensionList
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Diagrams.ExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Constraint>(deep);
    }

    /// <summary>
    /// <para>Rule.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is dgm:rule.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Diagrams.ExtensionList" /> <c>&lt;dgm:extLst></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("dgm:rule")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class Rule : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Rule class.
        /// </summary>
        public Rule() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Rule class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Rule(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Rule class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Rule(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Rule class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Rule(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Constraint Type</para>
        /// <para>Represents the following attribute in the schema: type</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("type")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ConstraintValues>? Type
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ConstraintValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>For</para>
        /// <para>Represents the following attribute in the schema: for</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("for")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ConstraintRelationshipValues>? For
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ConstraintRelationshipValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>For Name</para>
        /// <para>Represents the following attribute in the schema: forName</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("forName")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? ForName
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Data Point Type</para>
        /// <para>Represents the following attribute in the schema: ptType</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("ptType")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ElementValues>? PointType
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ElementValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Value</para>
        /// <para>Represents the following attribute in the schema: val</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("val")]
#pragma warning restore CS0618 // Type or member is obsolete

        public DoubleValue? Val
        {
            get => GetAttribute<DoubleValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Factor</para>
        /// <para>Represents the following attribute in the schema: fact</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("fact")]
#pragma warning restore CS0618 // Type or member is obsolete

        public DoubleValue? Fact
        {
            get => GetAttribute<DoubleValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Max Value</para>
        /// <para>Represents the following attribute in the schema: max</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("max")]
#pragma warning restore CS0618 // Type or member is obsolete

        public DoubleValue? Max
        {
            get => GetAttribute<DoubleValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("dgm:rule");
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Diagrams.ExtensionList>();
            builder.AddElement<Rule>()
.AddAttribute("type", a => a.Type, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
})
.AddAttribute("for", a => a.For, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
})
.AddAttribute("forName", a => a.ForName)
.AddAttribute("ptType", a => a.PointType, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
})
.AddAttribute("val", a => a.Val)
.AddAttribute("fact", a => a.Fact)
.AddAttribute("max", a => a.Max);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.ExtensionList), 0, 1)
            };
        }

        /// <summary>
        /// <para>ExtensionList.</para>
        /// <para>Represents the following element tag in the schema: dgm:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:dgm = http://schemas.openxmlformats.org/drawingml/2006/diagram
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Diagrams.ExtensionList? ExtensionList
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Diagrams.ExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Rule>(deep);
    }

    /// <summary>
    /// <para>Shape Adjust.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is dgm:adj.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("dgm:adj")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class Adjust : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the Adjust class.
        /// </summary>
        public Adjust() : base()
        {
        }

        /// <summary>
        /// <para>Adjust Handle Index</para>
        /// <para>Represents the following attribute in the schema: idx</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("idx")]
#pragma warning restore CS0618 // Type or member is obsolete

        public UInt32Value? Index
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Value</para>
        /// <para>Represents the following attribute in the schema: val</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("val")]
#pragma warning restore CS0618 // Type or member is obsolete

        public DoubleValue? Val
        {
            get => GetAttribute<DoubleValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("dgm:adj");
            builder.AddElement<Adjust>()
.AddAttribute("idx", a => a.Index, aBuilder =>
{
  aBuilder.AddValidator(RequiredValidator.Instance);
  aBuilder.AddValidator(new NumberValidator() { MinInclusive = (1L) });
})
.AddAttribute("val", a => a.Val, aBuilder =>
{
  aBuilder.AddValidator(RequiredValidator.Instance);
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Adjust>(deep);
    }

    /// <summary>
    /// <para>Shape Adjust List.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is dgm:adjLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Diagrams.Adjust" /> <c>&lt;dgm:adj></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("dgm:adjLst")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class AdjustList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the AdjustList class.
        /// </summary>
        public AdjustList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the AdjustList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public AdjustList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the AdjustList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public AdjustList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the AdjustList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public AdjustList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("dgm:adjLst");
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Diagrams.Adjust>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.Adjust), 0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<AdjustList>(deep);
    }

    /// <summary>
    /// <para>Parameter.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is dgm:param.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("dgm:param")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class Parameter : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the Parameter class.
        /// </summary>
        public Parameter() : base()
        {
        }

        /// <summary>
        /// <para>Parameter Type</para>
        /// <para>Represents the following attribute in the schema: type</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("type")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ParameterIdValues>? Type
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ParameterIdValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Value</para>
        /// <para>Represents the following attribute in the schema: val</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("val")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Val
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("dgm:param");
            builder.AddElement<Parameter>()
.AddAttribute("type", a => a.Type, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
})
.AddAttribute("val", a => a.Val, aBuilder =>
{
aBuilder.AddUnion(union =>
{
    union.AddValidator<EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.HorizontalAlignmentValues>>(EnumValidator.Instance);
    union.AddValidator<EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.VerticalAlignmentValues>>(EnumValidator.Instance);
    union.AddValidator<EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ChildDirectionValues>>(EnumValidator.Instance);
    union.AddValidator<EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ChildAlignmentValues>>(EnumValidator.Instance);
    union.AddValidator<EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.SecondaryChildAlignmentValues>>(EnumValidator.Instance);
    union.AddValidator<EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.LinearDirectionValues>>(EnumValidator.Instance);
    union.AddValidator<EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.SecondaryLinearDirectionValues>>(EnumValidator.Instance);
    union.AddValidator<EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.StartingElementValues>>(EnumValidator.Instance);
    union.AddValidator<EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.BendPointValues>>(EnumValidator.Instance);
    union.AddValidator<EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ConnectorRoutingValues>>(EnumValidator.Instance);
    union.AddValidator<EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ArrowheadStyleValues>>(EnumValidator.Instance);
    union.AddValidator<EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ConnectorDimensionValues>>(EnumValidator.Instance);
    union.AddValidator<EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.RotationPathValues>>(EnumValidator.Instance);
    union.AddValidator<EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.CenterShapeMappingValues>>(EnumValidator.Instance);
    union.AddValidator<EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.NodeHorizontalAlignmentValues>>(EnumValidator.Instance);
    union.AddValidator<EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.NodeVerticalAlignmentValues>>(EnumValidator.Instance);
    union.AddValidator<EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.FallbackDimensionValues>>(EnumValidator.Instance);
    union.AddValidator<EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.TextDirectionValues>>(EnumValidator.Instance);
    union.AddValidator<EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.PyramidAccentPositionValues>>(EnumValidator.Instance);
    union.AddValidator<EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.PyramidAccentTextMarginValues>>(EnumValidator.Instance);
    union.AddValidator<EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.TextBlockDirectionValues>>(EnumValidator.Instance);
    union.AddValidator<EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.TextAnchorHorizontalValues>>(EnumValidator.Instance);
    union.AddValidator<EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.TextAnchorVerticalValues>>(EnumValidator.Instance);
    union.AddValidator<EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.TextAlignmentValues>>(EnumValidator.Instance);
    union.AddValidator<EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.AutoTextRotationValues>>(EnumValidator.Instance);
    union.AddValidator<EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.GrowDirectionValues>>(EnumValidator.Instance);
    union.AddValidator<EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.FlowDirectionValues>>(EnumValidator.Instance);
    union.AddValidator<EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ContinueDirectionValues>>(EnumValidator.Instance);
    union.AddValidator<EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.BreakpointValues>>(EnumValidator.Instance);
    union.AddValidator<EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.OffsetValues>>(EnumValidator.Instance);
    union.AddValidator<EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.HierarchyAlignmentValues>>(EnumValidator.Instance);
    union.AddValidator<Int32Value>(NumberValidator.Instance);
    union.AddValidator<DoubleValue>(NumberValidator.Instance);
    union.AddValidator<BooleanValue>(NumberValidator.Instance);
    union.AddValidator(StringValidator.Instance);
    union.AddValidator<EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ConnectorPointValues>>(EnumValidator.Instance);
});
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Parameter>(deep);
    }

    /// <summary>
    /// <para>Algorithm.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is dgm:alg.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Diagrams.ExtensionList" /> <c>&lt;dgm:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Diagrams.Parameter" /> <c>&lt;dgm:param></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("dgm:alg")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class Algorithm : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Algorithm class.
        /// </summary>
        public Algorithm() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Algorithm class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Algorithm(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Algorithm class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Algorithm(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Algorithm class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Algorithm(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Algorithm Type</para>
        /// <para>Represents the following attribute in the schema: type</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("type")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.AlgorithmValues>? Type
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.AlgorithmValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Revision Number</para>
        /// <para>Represents the following attribute in the schema: rev</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("rev")]
#pragma warning restore CS0618 // Type or member is obsolete

        public UInt32Value? Revision
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("dgm:alg");
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Diagrams.ExtensionList>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Diagrams.Parameter>();
            builder.AddElement<Algorithm>()
.AddAttribute("type", a => a.Type, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
})
.AddAttribute("rev", a => a.Revision);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.Parameter), 0, 0),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.ExtensionList), 0, 1)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Algorithm>(deep);
    }

    /// <summary>
    /// <para>Shape.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is dgm:shape.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Diagrams.ExtensionList" /> <c>&lt;dgm:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Diagrams.AdjustList" /> <c>&lt;dgm:adjLst></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("dgm:shape")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class Shape : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Shape class.
        /// </summary>
        public Shape() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Shape class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Shape(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Shape class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Shape(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Shape class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Shape(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Rotation</para>
        /// <para>Represents the following attribute in the schema: rot</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("rot")]
#pragma warning restore CS0618 // Type or member is obsolete

        public DoubleValue? Rotation
        {
            get => GetAttribute<DoubleValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Type</para>
        /// <para>Represents the following attribute in the schema: type</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("type")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Type
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Relationship to Image Part</para>
        /// <para>Represents the following attribute in the schema: r:blip</para>
        /// </summary>
        /// <remark>
        /// xmlns:r=http://schemas.openxmlformats.org/officeDocument/2006/relationships
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("r:blip")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Blip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Z-Order Offset</para>
        /// <para>Represents the following attribute in the schema: zOrderOff</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("zOrderOff")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int32Value? ZOrderOffset
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Hide Geometry</para>
        /// <para>Represents the following attribute in the schema: hideGeom</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("hideGeom")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? HideGeometry
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Prevent Text Editing</para>
        /// <para>Represents the following attribute in the schema: lkTxEntry</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("lkTxEntry")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? LockedText
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Image Placeholder</para>
        /// <para>Represents the following attribute in the schema: blipPhldr</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("blipPhldr")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? BlipPlaceholder
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("dgm:shape");
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Diagrams.ExtensionList>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Diagrams.AdjustList>();
            builder.AddElement<Shape>()
.AddAttribute("rot", a => a.Rotation)
.AddAttribute("type", a => a.Type, aBuilder =>
{
aBuilder.AddUnion(union =>
{
union.AddValidator<EnumValue<DocumentFormat.OpenXml.Drawing.ShapeTypeValues>>(EnumValidator.Instance);
union.AddValidator<EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.OutputShapeValues>>(EnumValidator.Instance);
});
})
.AddAttribute("r:blip", a => a.Blip)
.AddAttribute("zOrderOff", a => a.ZOrderOffset)
.AddAttribute("hideGeom", a => a.HideGeometry)
.AddAttribute("lkTxEntry", a => a.LockedText)
.AddAttribute("blipPhldr", a => a.BlipPlaceholder);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.AdjustList), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.ExtensionList), 0, 1)
            };
            builder.AddConstraint(new RelationshipTypeConstraint("r:blip", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/image"));
            builder.AddConstraint(new RelationshipExistConstraint("r:blip"));
        }

        /// <summary>
        /// <para>Shape Adjust List.</para>
        /// <para>Represents the following element tag in the schema: dgm:adjLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:dgm = http://schemas.openxmlformats.org/drawingml/2006/diagram
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Diagrams.AdjustList? AdjustList
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Diagrams.AdjustList>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ExtensionList.</para>
        /// <para>Represents the following element tag in the schema: dgm:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:dgm = http://schemas.openxmlformats.org/drawingml/2006/diagram
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Diagrams.ExtensionList? ExtensionList
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Diagrams.ExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Shape>(deep);
    }

    /// <summary>
    /// <para>Presentation Of.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is dgm:presOf.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Diagrams.ExtensionList" /> <c>&lt;dgm:extLst></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("dgm:presOf")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class PresentationOf : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the PresentationOf class.
        /// </summary>
        public PresentationOf() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the PresentationOf class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public PresentationOf(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PresentationOf class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public PresentationOf(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PresentationOf class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public PresentationOf(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Axis</para>
        /// <para>Represents the following attribute in the schema: axis</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("axis")]
#pragma warning restore CS0618 // Type or member is obsolete

        public ListValue<EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.AxisValues>>? Axis
        {
            get => GetAttribute<ListValue<EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.AxisValues>>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Data Point Type</para>
        /// <para>Represents the following attribute in the schema: ptType</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("ptType")]
#pragma warning restore CS0618 // Type or member is obsolete

        public ListValue<EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ElementValues>>? PointType
        {
            get => GetAttribute<ListValue<EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ElementValues>>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Hide Last Transition</para>
        /// <para>Represents the following attribute in the schema: hideLastTrans</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("hideLastTrans")]
#pragma warning restore CS0618 // Type or member is obsolete

        public ListValue<BooleanValue>? HideLastTrans
        {
            get => GetAttribute<ListValue<BooleanValue>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Start</para>
        /// <para>Represents the following attribute in the schema: st</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("st")]
#pragma warning restore CS0618 // Type or member is obsolete

        public ListValue<Int32Value>? Start
        {
            get => GetAttribute<ListValue<Int32Value>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Count</para>
        /// <para>Represents the following attribute in the schema: cnt</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("cnt")]
#pragma warning restore CS0618 // Type or member is obsolete

        public ListValue<UInt32Value>? Count
        {
            get => GetAttribute<ListValue<UInt32Value>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Step</para>
        /// <para>Represents the following attribute in the schema: step</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("step")]
#pragma warning restore CS0618 // Type or member is obsolete

        public ListValue<Int32Value>? Step
        {
            get => GetAttribute<ListValue<Int32Value>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("dgm:presOf");
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Diagrams.ExtensionList>();
            builder.AddElement<PresentationOf>()
.AddAttribute("axis", a => a.Axis)
.AddAttribute("ptType", a => a.PointType)
.AddAttribute("hideLastTrans", a => a.HideLastTrans)
.AddAttribute("st", a => a.Start)
.AddAttribute("cnt", a => a.Count)
.AddAttribute("step", a => a.Step);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.ExtensionList), 0, 1)
            };
        }

        /// <summary>
        /// <para>ExtensionList.</para>
        /// <para>Represents the following element tag in the schema: dgm:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:dgm = http://schemas.openxmlformats.org/drawingml/2006/diagram
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Diagrams.ExtensionList? ExtensionList
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Diagrams.ExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<PresentationOf>(deep);
    }

    /// <summary>
    /// <para>Constraint List.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is dgm:constrLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Diagrams.Constraint" /> <c>&lt;dgm:constr></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("dgm:constrLst")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class Constraints : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Constraints class.
        /// </summary>
        public Constraints() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Constraints class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Constraints(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Constraints class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Constraints(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Constraints class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Constraints(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("dgm:constrLst");
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Diagrams.Constraint>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.Constraint), 0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Constraints>(deep);
    }

    /// <summary>
    /// <para>Rule List.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is dgm:ruleLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Diagrams.Rule" /> <c>&lt;dgm:rule></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("dgm:ruleLst")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class RuleList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the RuleList class.
        /// </summary>
        public RuleList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the RuleList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public RuleList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the RuleList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public RuleList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the RuleList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public RuleList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("dgm:ruleLst");
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Diagrams.Rule>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.Rule), 0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RuleList>(deep);
    }

    /// <summary>
    /// <para>Variable List.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is dgm:varLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Diagrams.AnimationLevel" /> <c>&lt;dgm:animLvl></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Diagrams.AnimateOneByOne" /> <c>&lt;dgm:animOne></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Diagrams.BulletEnabled" /> <c>&lt;dgm:bulletEnabled></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Diagrams.MaxNumberOfChildren" /> <c>&lt;dgm:chMax></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Diagrams.PreferredNumberOfChildren" /> <c>&lt;dgm:chPref></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Diagrams.Direction" /> <c>&lt;dgm:dir></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Diagrams.HierarchyBranch" /> <c>&lt;dgm:hierBranch></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Diagrams.OrganizationChart" /> <c>&lt;dgm:orgChart></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Diagrams.ResizeHandles" /> <c>&lt;dgm:resizeHandles></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("dgm:varLst")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class VariableList : LayoutVariablePropertySetType
    {
        /// <summary>
        /// Initializes a new instance of the VariableList class.
        /// </summary>
        public VariableList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the VariableList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public VariableList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the VariableList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public VariableList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the VariableList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public VariableList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("dgm:varLst");
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.OrganizationChart), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.MaxNumberOfChildren), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.PreferredNumberOfChildren), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.BulletEnabled), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.Direction), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.HierarchyBranch), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.AnimateOneByOne), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.AnimationLevel), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.ResizeHandles), 0, 1)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<VariableList>(deep);
    }

    /// <summary>
    /// <para>Presentation Layout Variables.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is dgm:presLayoutVars.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Diagrams.AnimationLevel" /> <c>&lt;dgm:animLvl></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Diagrams.AnimateOneByOne" /> <c>&lt;dgm:animOne></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Diagrams.BulletEnabled" /> <c>&lt;dgm:bulletEnabled></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Diagrams.MaxNumberOfChildren" /> <c>&lt;dgm:chMax></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Diagrams.PreferredNumberOfChildren" /> <c>&lt;dgm:chPref></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Diagrams.Direction" /> <c>&lt;dgm:dir></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Diagrams.HierarchyBranch" /> <c>&lt;dgm:hierBranch></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Diagrams.OrganizationChart" /> <c>&lt;dgm:orgChart></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Diagrams.ResizeHandles" /> <c>&lt;dgm:resizeHandles></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("dgm:presLayoutVars")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class PresentationLayoutVariables : LayoutVariablePropertySetType
    {
        /// <summary>
        /// Initializes a new instance of the PresentationLayoutVariables class.
        /// </summary>
        public PresentationLayoutVariables() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the PresentationLayoutVariables class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public PresentationLayoutVariables(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PresentationLayoutVariables class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public PresentationLayoutVariables(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PresentationLayoutVariables class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public PresentationLayoutVariables(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("dgm:presLayoutVars");
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.OrganizationChart), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.MaxNumberOfChildren), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.PreferredNumberOfChildren), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.BulletEnabled), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.Direction), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.HierarchyBranch), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.AnimateOneByOne), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.AnimationLevel), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.ResizeHandles), 0, 1)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<PresentationLayoutVariables>(deep);
    }

    /// <summary>
    /// <para>Defines the LayoutVariablePropertySetType Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is :.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Diagrams.AnimationLevel" /> <c>&lt;dgm:animLvl></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Diagrams.AnimateOneByOne" /> <c>&lt;dgm:animOne></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Diagrams.BulletEnabled" /> <c>&lt;dgm:bulletEnabled></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Diagrams.MaxNumberOfChildren" /> <c>&lt;dgm:chMax></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Diagrams.PreferredNumberOfChildren" /> <c>&lt;dgm:chPref></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Diagrams.Direction" /> <c>&lt;dgm:dir></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Diagrams.HierarchyBranch" /> <c>&lt;dgm:hierBranch></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Diagrams.OrganizationChart" /> <c>&lt;dgm:orgChart></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Diagrams.ResizeHandles" /> <c>&lt;dgm:resizeHandles></c></description></item>
    /// </list>
    /// </remark>
    public abstract partial class LayoutVariablePropertySetType : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the LayoutVariablePropertySetType class.
        /// </summary>
        protected LayoutVariablePropertySetType() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the LayoutVariablePropertySetType class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        protected LayoutVariablePropertySetType(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the LayoutVariablePropertySetType class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        protected LayoutVariablePropertySetType(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the LayoutVariablePropertySetType class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        protected LayoutVariablePropertySetType(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Diagrams.AnimationLevel>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Diagrams.AnimateOneByOne>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Diagrams.BulletEnabled>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Diagrams.MaxNumberOfChildren>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Diagrams.PreferredNumberOfChildren>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Diagrams.Direction>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Diagrams.HierarchyBranch>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Diagrams.OrganizationChart>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Diagrams.ResizeHandles>();
        }

        /// <summary>
        /// <para>Show Organization Chart User Interface.</para>
        /// <para>Represents the following element tag in the schema: dgm:orgChart.</para>
        /// </summary>
        /// <remark>
        /// xmlns:dgm = http://schemas.openxmlformats.org/drawingml/2006/diagram
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Diagrams.OrganizationChart? OrganizationChart
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Diagrams.OrganizationChart>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Maximum Children.</para>
        /// <para>Represents the following element tag in the schema: dgm:chMax.</para>
        /// </summary>
        /// <remark>
        /// xmlns:dgm = http://schemas.openxmlformats.org/drawingml/2006/diagram
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Diagrams.MaxNumberOfChildren? MaxNumberOfChildren
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Diagrams.MaxNumberOfChildren>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Preferred Number of Children.</para>
        /// <para>Represents the following element tag in the schema: dgm:chPref.</para>
        /// </summary>
        /// <remark>
        /// xmlns:dgm = http://schemas.openxmlformats.org/drawingml/2006/diagram
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Diagrams.PreferredNumberOfChildren? PreferredNumberOfChildren
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Diagrams.PreferredNumberOfChildren>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Show Insert Bullet.</para>
        /// <para>Represents the following element tag in the schema: dgm:bulletEnabled.</para>
        /// </summary>
        /// <remark>
        /// xmlns:dgm = http://schemas.openxmlformats.org/drawingml/2006/diagram
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Diagrams.BulletEnabled? BulletEnabled
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Diagrams.BulletEnabled>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Diagram Direction.</para>
        /// <para>Represents the following element tag in the schema: dgm:dir.</para>
        /// </summary>
        /// <remark>
        /// xmlns:dgm = http://schemas.openxmlformats.org/drawingml/2006/diagram
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Diagrams.Direction? Direction
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Diagrams.Direction>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Organization Chart Branch Style.</para>
        /// <para>Represents the following element tag in the schema: dgm:hierBranch.</para>
        /// </summary>
        /// <remark>
        /// xmlns:dgm = http://schemas.openxmlformats.org/drawingml/2006/diagram
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Diagrams.HierarchyBranch? HierarchyBranch
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Diagrams.HierarchyBranch>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>One by One Animation String.</para>
        /// <para>Represents the following element tag in the schema: dgm:animOne.</para>
        /// </summary>
        /// <remark>
        /// xmlns:dgm = http://schemas.openxmlformats.org/drawingml/2006/diagram
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Diagrams.AnimateOneByOne? AnimateOneByOne
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Diagrams.AnimateOneByOne>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Level Animation.</para>
        /// <para>Represents the following element tag in the schema: dgm:animLvl.</para>
        /// </summary>
        /// <remark>
        /// xmlns:dgm = http://schemas.openxmlformats.org/drawingml/2006/diagram
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Diagrams.AnimationLevel? AnimationLevel
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Diagrams.AnimationLevel>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Shape Resize Style.</para>
        /// <para>Represents the following element tag in the schema: dgm:resizeHandles.</para>
        /// </summary>
        /// <remark>
        /// xmlns:dgm = http://schemas.openxmlformats.org/drawingml/2006/diagram
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Diagrams.ResizeHandles? ResizeHandles
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Diagrams.ResizeHandles>();
            set => SetElement(value);
        }
    }

    /// <summary>
    /// <para>For Each.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is dgm:forEach.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Diagrams.ExtensionList" /> <c>&lt;dgm:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Diagrams.Algorithm" /> <c>&lt;dgm:alg></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Diagrams.Choose" /> <c>&lt;dgm:choose></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Diagrams.Constraints" /> <c>&lt;dgm:constrLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Diagrams.ForEach" /> <c>&lt;dgm:forEach></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Diagrams.LayoutNode" /> <c>&lt;dgm:layoutNode></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Diagrams.PresentationOf" /> <c>&lt;dgm:presOf></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Diagrams.RuleList" /> <c>&lt;dgm:ruleLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Diagrams.Shape" /> <c>&lt;dgm:shape></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("dgm:forEach")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class ForEach : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ForEach class.
        /// </summary>
        public ForEach() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ForEach class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ForEach(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ForEach class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ForEach(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ForEach class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ForEach(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Name</para>
        /// <para>Represents the following attribute in the schema: name</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("name")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Name
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Reference</para>
        /// <para>Represents the following attribute in the schema: ref</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("ref")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Reference
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Axis</para>
        /// <para>Represents the following attribute in the schema: axis</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("axis")]
#pragma warning restore CS0618 // Type or member is obsolete

        public ListValue<EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.AxisValues>>? Axis
        {
            get => GetAttribute<ListValue<EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.AxisValues>>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Data Point Type</para>
        /// <para>Represents the following attribute in the schema: ptType</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("ptType")]
#pragma warning restore CS0618 // Type or member is obsolete

        public ListValue<EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ElementValues>>? PointType
        {
            get => GetAttribute<ListValue<EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ElementValues>>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Hide Last Transition</para>
        /// <para>Represents the following attribute in the schema: hideLastTrans</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("hideLastTrans")]
#pragma warning restore CS0618 // Type or member is obsolete

        public ListValue<BooleanValue>? HideLastTrans
        {
            get => GetAttribute<ListValue<BooleanValue>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Start</para>
        /// <para>Represents the following attribute in the schema: st</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("st")]
#pragma warning restore CS0618 // Type or member is obsolete

        public ListValue<Int32Value>? Start
        {
            get => GetAttribute<ListValue<Int32Value>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Count</para>
        /// <para>Represents the following attribute in the schema: cnt</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("cnt")]
#pragma warning restore CS0618 // Type or member is obsolete

        public ListValue<UInt32Value>? Count
        {
            get => GetAttribute<ListValue<UInt32Value>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Step</para>
        /// <para>Represents the following attribute in the schema: step</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("step")]
#pragma warning restore CS0618 // Type or member is obsolete

        public ListValue<Int32Value>? Step
        {
            get => GetAttribute<ListValue<Int32Value>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("dgm:forEach");
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Diagrams.ExtensionList>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Diagrams.Algorithm>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Diagrams.Choose>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Diagrams.Constraints>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Diagrams.ForEach>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Diagrams.LayoutNode>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Diagrams.PresentationOf>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Diagrams.RuleList>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Diagrams.Shape>();
            builder.AddElement<ForEach>()
.AddAttribute("name", a => a.Name)
.AddAttribute("ref", a => a.Reference)
.AddAttribute("axis", a => a.Axis)
.AddAttribute("ptType", a => a.PointType)
.AddAttribute("hideLastTrans", a => a.HideLastTrans)
.AddAttribute("st", a => a.Start)
.AddAttribute("cnt", a => a.Count)
.AddAttribute("step", a => a.Step);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Choice, 0, 0)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.Algorithm), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.Shape), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.PresentationOf), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.Constraints), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.RuleList), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.ForEach), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.LayoutNode), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.Choose), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.ExtensionList), 0, 1)
            };
            builder.AddConstraint(new UniqueAttributeValueConstraint(":name", true, null));
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ForEach>(deep);
    }

    /// <summary>
    /// <para>Layout Node.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is dgm:layoutNode.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Diagrams.ExtensionList" /> <c>&lt;dgm:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Diagrams.Algorithm" /> <c>&lt;dgm:alg></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Diagrams.Choose" /> <c>&lt;dgm:choose></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Diagrams.Constraints" /> <c>&lt;dgm:constrLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Diagrams.ForEach" /> <c>&lt;dgm:forEach></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Diagrams.LayoutNode" /> <c>&lt;dgm:layoutNode></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Diagrams.VariableList" /> <c>&lt;dgm:varLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Diagrams.PresentationOf" /> <c>&lt;dgm:presOf></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Diagrams.RuleList" /> <c>&lt;dgm:ruleLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Diagrams.Shape" /> <c>&lt;dgm:shape></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("dgm:layoutNode")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class LayoutNode : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the LayoutNode class.
        /// </summary>
        public LayoutNode() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the LayoutNode class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public LayoutNode(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the LayoutNode class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public LayoutNode(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the LayoutNode class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public LayoutNode(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Name</para>
        /// <para>Represents the following attribute in the schema: name</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("name")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Name
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Style Label</para>
        /// <para>Represents the following attribute in the schema: styleLbl</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("styleLbl")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? StyleLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Child Order</para>
        /// <para>Represents the following attribute in the schema: chOrder</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("chOrder")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ChildOrderValues>? ChildOrder
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ChildOrderValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Move With</para>
        /// <para>Represents the following attribute in the schema: moveWith</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("moveWith")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? MoveWith
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("dgm:layoutNode");
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Diagrams.ExtensionList>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Diagrams.Algorithm>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Diagrams.Choose>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Diagrams.Constraints>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Diagrams.ForEach>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Diagrams.LayoutNode>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Diagrams.VariableList>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Diagrams.PresentationOf>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Diagrams.RuleList>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Diagrams.Shape>();
            builder.AddElement<LayoutNode>()
.AddAttribute("name", a => a.Name)
.AddAttribute("styleLbl", a => a.StyleLabel)
.AddAttribute("chOrder", a => a.ChildOrder, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
})
.AddAttribute("moveWith", a => a.MoveWith);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Choice, 0, 0)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.Algorithm), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.Shape), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.PresentationOf), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.Constraints), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.RuleList), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.VariableList), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.ForEach), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.LayoutNode), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.Choose), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.ExtensionList), 0, 1)
            };
            builder.AddConstraint(new UniqueAttributeValueConstraint(":name", true, null));
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<LayoutNode>(deep);
    }

    /// <summary>
    /// <para>Choose Element.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is dgm:choose.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Diagrams.DiagramChooseElse" /> <c>&lt;dgm:else></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Diagrams.DiagramChooseIf" /> <c>&lt;dgm:if></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("dgm:choose")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class Choose : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Choose class.
        /// </summary>
        public Choose() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Choose class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Choose(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Choose class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Choose(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Choose class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Choose(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Name</para>
        /// <para>Represents the following attribute in the schema: name</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("name")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Name
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("dgm:choose");
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Diagrams.DiagramChooseElse>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Diagrams.DiagramChooseIf>();
            builder.AddElement<Choose>()
.AddAttribute("name", a => a.Name);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.DiagramChooseIf), 1, 0),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.DiagramChooseElse), 0, 1)
            };
            builder.AddConstraint(new UniqueAttributeValueConstraint(":name", true, null));
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Choose>(deep);
    }

    /// <summary>
    /// <para>If.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is dgm:if.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Diagrams.ExtensionList" /> <c>&lt;dgm:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Diagrams.Algorithm" /> <c>&lt;dgm:alg></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Diagrams.Choose" /> <c>&lt;dgm:choose></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Diagrams.Constraints" /> <c>&lt;dgm:constrLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Diagrams.ForEach" /> <c>&lt;dgm:forEach></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Diagrams.LayoutNode" /> <c>&lt;dgm:layoutNode></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Diagrams.PresentationOf" /> <c>&lt;dgm:presOf></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Diagrams.RuleList" /> <c>&lt;dgm:ruleLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Diagrams.Shape" /> <c>&lt;dgm:shape></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("dgm:if")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class DiagramChooseIf : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the DiagramChooseIf class.
        /// </summary>
        public DiagramChooseIf() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the DiagramChooseIf class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DiagramChooseIf(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DiagramChooseIf class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DiagramChooseIf(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DiagramChooseIf class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public DiagramChooseIf(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Name</para>
        /// <para>Represents the following attribute in the schema: name</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("name")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Name
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Axis</para>
        /// <para>Represents the following attribute in the schema: axis</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("axis")]
#pragma warning restore CS0618 // Type or member is obsolete

        public ListValue<EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.AxisValues>>? Axis
        {
            get => GetAttribute<ListValue<EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.AxisValues>>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Data Point Type</para>
        /// <para>Represents the following attribute in the schema: ptType</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("ptType")]
#pragma warning restore CS0618 // Type or member is obsolete

        public ListValue<EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ElementValues>>? PointType
        {
            get => GetAttribute<ListValue<EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ElementValues>>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Hide Last Transition</para>
        /// <para>Represents the following attribute in the schema: hideLastTrans</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("hideLastTrans")]
#pragma warning restore CS0618 // Type or member is obsolete

        public ListValue<BooleanValue>? HideLastTrans
        {
            get => GetAttribute<ListValue<BooleanValue>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Start</para>
        /// <para>Represents the following attribute in the schema: st</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("st")]
#pragma warning restore CS0618 // Type or member is obsolete

        public ListValue<Int32Value>? Start
        {
            get => GetAttribute<ListValue<Int32Value>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Count</para>
        /// <para>Represents the following attribute in the schema: cnt</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("cnt")]
#pragma warning restore CS0618 // Type or member is obsolete

        public ListValue<UInt32Value>? Count
        {
            get => GetAttribute<ListValue<UInt32Value>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Step</para>
        /// <para>Represents the following attribute in the schema: step</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("step")]
#pragma warning restore CS0618 // Type or member is obsolete

        public ListValue<Int32Value>? Step
        {
            get => GetAttribute<ListValue<Int32Value>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Function</para>
        /// <para>Represents the following attribute in the schema: func</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("func")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.FunctionValues>? Function
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.FunctionValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Argument</para>
        /// <para>Represents the following attribute in the schema: arg</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("arg")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Argument
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Operator</para>
        /// <para>Represents the following attribute in the schema: op</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("op")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.FunctionOperatorValues>? Operator
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.FunctionOperatorValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Value</para>
        /// <para>Represents the following attribute in the schema: val</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("val")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Val
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("dgm:if");
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Diagrams.ExtensionList>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Diagrams.Algorithm>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Diagrams.Choose>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Diagrams.Constraints>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Diagrams.ForEach>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Diagrams.LayoutNode>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Diagrams.PresentationOf>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Diagrams.RuleList>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Diagrams.Shape>();
            builder.AddElement<DiagramChooseIf>()
.AddAttribute("name", a => a.Name)
.AddAttribute("axis", a => a.Axis)
.AddAttribute("ptType", a => a.PointType)
.AddAttribute("hideLastTrans", a => a.HideLastTrans)
.AddAttribute("st", a => a.Start)
.AddAttribute("cnt", a => a.Count)
.AddAttribute("step", a => a.Step)
.AddAttribute("func", a => a.Function, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
})
.AddAttribute("arg", a => a.Argument, aBuilder =>
{
aBuilder.AddUnion(union =>
{
union.AddValidator<EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.VariableValues>>(EnumValidator.Instance);
});
})
.AddAttribute("op", a => a.Operator, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
})
.AddAttribute("val", a => a.Val, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddUnion(union =>
{
union.AddValidator<Int32Value>(NumberValidator.Instance);
union.AddValidator<BooleanValue>(NumberValidator.Instance);
union.AddValidator<EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.DirectionValues>>(EnumValidator.Instance);
union.AddValidator<EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.HierarchyBranchStyleValues>>(EnumValidator.Instance);
union.AddValidator<EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.AnimateOneByOneValues>>(EnumValidator.Instance);
union.AddValidator<EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.AnimationLevelStringValues>>(EnumValidator.Instance);
union.AddValidator<EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ResizeHandlesStringValues>>(EnumValidator.Instance);
});
});
            builder.Particle = new CompositeParticle.Builder(ParticleType.Choice, 0, 0)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.Algorithm), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.Shape), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.PresentationOf), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.Constraints), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.RuleList), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.ForEach), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.LayoutNode), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.Choose), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.ExtensionList), 0, 1)
            };
            builder.AddConstraint(new UniqueAttributeValueConstraint(":name", true, null));
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DiagramChooseIf>(deep);
    }

    /// <summary>
    /// <para>Else.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is dgm:else.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Diagrams.ExtensionList" /> <c>&lt;dgm:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Diagrams.Algorithm" /> <c>&lt;dgm:alg></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Diagrams.Choose" /> <c>&lt;dgm:choose></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Diagrams.Constraints" /> <c>&lt;dgm:constrLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Diagrams.ForEach" /> <c>&lt;dgm:forEach></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Diagrams.LayoutNode" /> <c>&lt;dgm:layoutNode></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Diagrams.PresentationOf" /> <c>&lt;dgm:presOf></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Diagrams.RuleList" /> <c>&lt;dgm:ruleLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Diagrams.Shape" /> <c>&lt;dgm:shape></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("dgm:else")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class DiagramChooseElse : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the DiagramChooseElse class.
        /// </summary>
        public DiagramChooseElse() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the DiagramChooseElse class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DiagramChooseElse(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DiagramChooseElse class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DiagramChooseElse(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DiagramChooseElse class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public DiagramChooseElse(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Name</para>
        /// <para>Represents the following attribute in the schema: name</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("name")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Name
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("dgm:else");
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Diagrams.ExtensionList>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Diagrams.Algorithm>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Diagrams.Choose>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Diagrams.Constraints>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Diagrams.ForEach>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Diagrams.LayoutNode>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Diagrams.PresentationOf>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Diagrams.RuleList>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Diagrams.Shape>();
            builder.AddElement<DiagramChooseElse>()
.AddAttribute("name", a => a.Name);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Choice, 0, 0)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.Algorithm), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.Shape), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.PresentationOf), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.Constraints), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.RuleList), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.ForEach), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.LayoutNode), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.Choose), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.ExtensionList), 0, 1)
            };
            builder.AddConstraint(new UniqueAttributeValueConstraint(":name", true, null));
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DiagramChooseElse>(deep);
    }

    /// <summary>
    /// <para>Data Model.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is dgm:dataModel.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Diagrams.Background" /> <c>&lt;dgm:bg></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Diagrams.DataModelExtensionList" /> <c>&lt;dgm:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Diagrams.Whole" /> <c>&lt;dgm:whole></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Diagrams.ConnectionList" /> <c>&lt;dgm:cxnLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Diagrams.PointList" /> <c>&lt;dgm:ptLst></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("dgm:dataModel")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class DataModel : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the DataModel class.
        /// </summary>
        public DataModel() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the DataModel class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DataModel(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DataModel class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DataModel(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DataModel class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public DataModel(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("dgm:dataModel");
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Diagrams.Background>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Diagrams.DataModelExtensionList>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Diagrams.Whole>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Diagrams.ConnectionList>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Diagrams.PointList>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.PointList), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.ConnectionList), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.Background), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.Whole), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.DataModelExtensionList), 0, 1)
            };
        }

        /// <summary>
        /// <para>Point List.</para>
        /// <para>Represents the following element tag in the schema: dgm:ptLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:dgm = http://schemas.openxmlformats.org/drawingml/2006/diagram
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Diagrams.PointList? PointList
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Diagrams.PointList>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Connection List.</para>
        /// <para>Represents the following element tag in the schema: dgm:cxnLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:dgm = http://schemas.openxmlformats.org/drawingml/2006/diagram
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Diagrams.ConnectionList? ConnectionList
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Diagrams.ConnectionList>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Background Formatting.</para>
        /// <para>Represents the following element tag in the schema: dgm:bg.</para>
        /// </summary>
        /// <remark>
        /// xmlns:dgm = http://schemas.openxmlformats.org/drawingml/2006/diagram
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Diagrams.Background? Background
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Diagrams.Background>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Whole E2O Formatting.</para>
        /// <para>Represents the following element tag in the schema: dgm:whole.</para>
        /// </summary>
        /// <remark>
        /// xmlns:dgm = http://schemas.openxmlformats.org/drawingml/2006/diagram
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Diagrams.Whole? Whole
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Diagrams.Whole>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>DataModelExtensionList.</para>
        /// <para>Represents the following element tag in the schema: dgm:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:dgm = http://schemas.openxmlformats.org/drawingml/2006/diagram
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Diagrams.DataModelExtensionList? DataModelExtensionList
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Diagrams.DataModelExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DataModel>(deep);
    }

    /// <summary>
    /// <para>Category.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is dgm:cat.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("dgm:cat")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class Category : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the Category class.
        /// </summary>
        public Category() : base()
        {
        }

        /// <summary>
        /// <para>Category Type</para>
        /// <para>Represents the following attribute in the schema: type</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("type")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Type
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Priority</para>
        /// <para>Represents the following attribute in the schema: pri</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("pri")]
#pragma warning restore CS0618 // Type or member is obsolete

        public UInt32Value? Priority
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("dgm:cat");
            builder.AddElement<Category>()
.AddAttribute("type", a => a.Type, aBuilder =>
{
  aBuilder.AddValidator(RequiredValidator.Instance);
  aBuilder.AddValidator(new StringValidator() { IsUri = (true) });
})
.AddAttribute("pri", a => a.Priority, aBuilder =>
{
  aBuilder.AddValidator(RequiredValidator.Instance);
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Category>(deep);
    }

    /// <summary>
    /// <para>Title.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is dgm:title.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("dgm:title")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class Title : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the Title class.
        /// </summary>
        public Title() : base()
        {
        }

        /// <summary>
        /// <para>Language</para>
        /// <para>Represents the following attribute in the schema: lang</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("lang")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Language
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Value</para>
        /// <para>Represents the following attribute in the schema: val</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("val")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Val
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("dgm:title");
            builder.AddElement<Title>()
.AddAttribute("lang", a => a.Language)
.AddAttribute("val", a => a.Val, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Title>(deep);
    }

    /// <summary>
    /// <para>Description.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is dgm:desc.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("dgm:desc")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class Description : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the Description class.
        /// </summary>
        public Description() : base()
        {
        }

        /// <summary>
        /// <para>Language</para>
        /// <para>Represents the following attribute in the schema: lang</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("lang")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Language
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Value</para>
        /// <para>Represents the following attribute in the schema: val</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("val")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Val
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("dgm:desc");
            builder.AddElement<Description>()
.AddAttribute("lang", a => a.Language)
.AddAttribute("val", a => a.Val, aBuilder =>
{
 aBuilder.AddValidator(RequiredValidator.Instance);
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Description>(deep);
    }

    /// <summary>
    /// <para>Category List.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is dgm:catLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Diagrams.Category" /> <c>&lt;dgm:cat></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("dgm:catLst")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class CategoryList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the CategoryList class.
        /// </summary>
        public CategoryList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the CategoryList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public CategoryList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the CategoryList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public CategoryList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the CategoryList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public CategoryList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("dgm:catLst");
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Diagrams.Category>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.Category), 0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<CategoryList>(deep);
    }

    /// <summary>
    /// <para>Shape Style.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is dgm:style.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.FontReference" /> <c>&lt;a:fontRef></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.LineReference" /> <c>&lt;a:lnRef></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.FillReference" /> <c>&lt;a:fillRef></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.EffectReference" /> <c>&lt;a:effectRef></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("dgm:style")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class Style : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Style class.
        /// </summary>
        public Style() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Style class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Style(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Style class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Style(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Style class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Style(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("dgm:style");
            builder.AddChild<DocumentFormat.OpenXml.Drawing.FontReference>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.LineReference>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.FillReference>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.EffectReference>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.LineReference), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.FillReference), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.EffectReference), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.FontReference), 1, 1)
            };
        }

        /// <summary>
        /// <para>LineReference.</para>
        /// <para>Represents the following element tag in the schema: a:lnRef.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.LineReference? LineReference
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.LineReference>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>FillReference.</para>
        /// <para>Represents the following element tag in the schema: a:fillRef.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.FillReference? FillReference
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.FillReference>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>EffectReference.</para>
        /// <para>Represents the following element tag in the schema: a:effectRef.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.EffectReference? EffectReference
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.EffectReference>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Font Reference.</para>
        /// <para>Represents the following element tag in the schema: a:fontRef.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.FontReference? FontReference
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.FontReference>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Style>(deep);
    }

    /// <summary>
    /// <para>Show Organization Chart User Interface.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is dgm:orgChart.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("dgm:orgChart")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class OrganizationChart : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the OrganizationChart class.
        /// </summary>
        public OrganizationChart() : base()
        {
        }

        /// <summary>
        /// <para>Show Organization Chart User Interface Value</para>
        /// <para>Represents the following attribute in the schema: val</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("val")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? Val
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("dgm:orgChart");
            builder.AddElement<OrganizationChart>()
.AddAttribute("val", a => a.Val);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<OrganizationChart>(deep);
    }

    /// <summary>
    /// <para>Maximum Children.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is dgm:chMax.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("dgm:chMax")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class MaxNumberOfChildren : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the MaxNumberOfChildren class.
        /// </summary>
        public MaxNumberOfChildren() : base()
        {
        }

        /// <summary>
        /// <para>Maximum Children Value</para>
        /// <para>Represents the following attribute in the schema: val</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("val")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int32Value? Val
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("dgm:chMax");
            builder.AddElement<MaxNumberOfChildren>()
.AddAttribute("val", a => a.Val, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (-1L) });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<MaxNumberOfChildren>(deep);
    }

    /// <summary>
    /// <para>Preferred Number of Children.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is dgm:chPref.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("dgm:chPref")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class PreferredNumberOfChildren : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the PreferredNumberOfChildren class.
        /// </summary>
        public PreferredNumberOfChildren() : base()
        {
        }

        /// <summary>
        /// <para>Preferred Number of CHildren Value</para>
        /// <para>Represents the following attribute in the schema: val</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("val")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int32Value? Val
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("dgm:chPref");
            builder.AddElement<PreferredNumberOfChildren>()
.AddAttribute("val", a => a.Val, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (-1L) });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<PreferredNumberOfChildren>(deep);
    }

    /// <summary>
    /// <para>Show Insert Bullet.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is dgm:bulletEnabled.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("dgm:bulletEnabled")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class BulletEnabled : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the BulletEnabled class.
        /// </summary>
        public BulletEnabled() : base()
        {
        }

        /// <summary>
        /// <para>Show Insert Bullet Value</para>
        /// <para>Represents the following attribute in the schema: val</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("val")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? Val
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("dgm:bulletEnabled");
            builder.AddElement<BulletEnabled>()
.AddAttribute("val", a => a.Val);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<BulletEnabled>(deep);
    }

    /// <summary>
    /// <para>Diagram Direction.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is dgm:dir.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("dgm:dir")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class Direction : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the Direction class.
        /// </summary>
        public Direction() : base()
        {
        }

        /// <summary>
        /// <para>Diagram Direction Value</para>
        /// <para>Represents the following attribute in the schema: val</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("val")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.DirectionValues>? Val
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.DirectionValues>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("dgm:dir");
            builder.AddElement<Direction>()
.AddAttribute("val", a => a.Val, aBuilder =>
{
  aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Direction>(deep);
    }

    /// <summary>
    /// <para>Organization Chart Branch Style.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is dgm:hierBranch.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("dgm:hierBranch")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class HierarchyBranch : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the HierarchyBranch class.
        /// </summary>
        public HierarchyBranch() : base()
        {
        }

        /// <summary>
        /// <para>Organization Chart Branch Style Value</para>
        /// <para>Represents the following attribute in the schema: val</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("val")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.HierarchyBranchStyleValues>? Val
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.HierarchyBranchStyleValues>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("dgm:hierBranch");
            builder.AddElement<HierarchyBranch>()
.AddAttribute("val", a => a.Val, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<HierarchyBranch>(deep);
    }

    /// <summary>
    /// <para>One by One Animation String.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is dgm:animOne.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("dgm:animOne")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class AnimateOneByOne : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the AnimateOneByOne class.
        /// </summary>
        public AnimateOneByOne() : base()
        {
        }

        /// <summary>
        /// <para>One By One Animation Value</para>
        /// <para>Represents the following attribute in the schema: val</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("val")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.AnimateOneByOneValues>? Val
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.AnimateOneByOneValues>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("dgm:animOne");
            builder.AddElement<AnimateOneByOne>()
.AddAttribute("val", a => a.Val, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<AnimateOneByOne>(deep);
    }

    /// <summary>
    /// <para>Level Animation.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is dgm:animLvl.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("dgm:animLvl")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class AnimationLevel : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the AnimationLevel class.
        /// </summary>
        public AnimationLevel() : base()
        {
        }

        /// <summary>
        /// <para>Level Animation Value</para>
        /// <para>Represents the following attribute in the schema: val</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("val")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.AnimationLevelStringValues>? Val
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.AnimationLevelStringValues>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("dgm:animLvl");
            builder.AddElement<AnimationLevel>()
.AddAttribute("val", a => a.Val, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<AnimationLevel>(deep);
    }

    /// <summary>
    /// <para>Shape Resize Style.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is dgm:resizeHandles.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("dgm:resizeHandles")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class ResizeHandles : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the ResizeHandles class.
        /// </summary>
        public ResizeHandles() : base()
        {
        }

        /// <summary>
        /// <para>Shape Resize Style Type</para>
        /// <para>Represents the following attribute in the schema: val</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("val")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ResizeHandlesStringValues>? Val
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ResizeHandlesStringValues>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("dgm:resizeHandles");
            builder.AddElement<ResizeHandles>()
.AddAttribute("val", a => a.Val, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ResizeHandles>(deep);
    }

    /// <summary>
    /// <para>Category.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is dgm:cat.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("dgm:cat")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class StyleDisplayCategory : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the StyleDisplayCategory class.
        /// </summary>
        public StyleDisplayCategory() : base()
        {
        }

        /// <summary>
        /// <para>Category Type</para>
        /// <para>Represents the following attribute in the schema: type</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("type")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Type
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Priority</para>
        /// <para>Represents the following attribute in the schema: pri</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("pri")]
#pragma warning restore CS0618 // Type or member is obsolete

        public UInt32Value? Priority
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("dgm:cat");
            builder.AddElement<StyleDisplayCategory>()
.AddAttribute("type", a => a.Type, aBuilder =>
{
  aBuilder.AddValidator(RequiredValidator.Instance);
  aBuilder.AddValidator(new StringValidator() { IsUri = (true) });
})
.AddAttribute("pri", a => a.Priority, aBuilder =>
{
  aBuilder.AddValidator(RequiredValidator.Instance);
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<StyleDisplayCategory>(deep);
    }

    /// <summary>
    /// <para>3-D Scene.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is dgm:scene3d.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Backdrop" /> <c>&lt;a:backdrop></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Camera" /> <c>&lt;a:camera></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.LightRig" /> <c>&lt;a:lightRig></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.ExtensionList" /> <c>&lt;a:extLst></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("dgm:scene3d")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class Scene3D : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Scene3D class.
        /// </summary>
        public Scene3D() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Scene3D class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Scene3D(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Scene3D class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Scene3D(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Scene3D class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Scene3D(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("dgm:scene3d");
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Backdrop>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Camera>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.LightRig>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.ExtensionList>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Camera), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.LightRig), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Backdrop), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.ExtensionList), 0, 1)
            };
        }

        /// <summary>
        /// <para>Camera.</para>
        /// <para>Represents the following element tag in the schema: a:camera.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Camera? Camera
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Camera>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Light Rig.</para>
        /// <para>Represents the following element tag in the schema: a:lightRig.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.LightRig? LightRig
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.LightRig>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Backdrop Plane.</para>
        /// <para>Represents the following element tag in the schema: a:backdrop.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Backdrop? Backdrop
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Backdrop>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ExtensionList.</para>
        /// <para>Represents the following element tag in the schema: a:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.ExtensionList? ExtensionList
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.ExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Scene3D>(deep);
    }

    /// <summary>
    /// <para>3-D Shape Properties.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is dgm:sp3d.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.BevelTop" /> <c>&lt;a:bevelT></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.BevelBottom" /> <c>&lt;a:bevelB></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.ExtrusionColor" /> <c>&lt;a:extrusionClr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.ContourColor" /> <c>&lt;a:contourClr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.ExtensionList" /> <c>&lt;a:extLst></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("dgm:sp3d")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class Shape3D : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Shape3D class.
        /// </summary>
        public Shape3D() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Shape3D class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Shape3D(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Shape3D class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Shape3D(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Shape3D class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Shape3D(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Shape Depth</para>
        /// <para>Represents the following attribute in the schema: z</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("z")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int64Value? Z
        {
            get => GetAttribute<Int64Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Extrusion Height</para>
        /// <para>Represents the following attribute in the schema: extrusionH</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("extrusionH")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int64Value? ExtrusionHeight
        {
            get => GetAttribute<Int64Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Contour Width</para>
        /// <para>Represents the following attribute in the schema: contourW</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("contourW")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int64Value? ContourWidth
        {
            get => GetAttribute<Int64Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Preset Material Type</para>
        /// <para>Represents the following attribute in the schema: prstMaterial</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("prstMaterial")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Drawing.PresetMaterialTypeValues>? PresetMaterial
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.PresetMaterialTypeValues>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("dgm:sp3d");
            builder.AddChild<DocumentFormat.OpenXml.Drawing.BevelTop>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.BevelBottom>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.ExtrusionColor>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.ContourColor>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.ExtensionList>();
            builder.AddElement<Shape3D>()
.AddAttribute("z", a => a.Z, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (-27273042329600L), MaxInclusive = (27273042316900L) });
})
.AddAttribute("extrusionH", a => a.ExtrusionHeight, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (2147483647L) });
})
.AddAttribute("contourW", a => a.ContourWidth, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (2147483647L) });
})
.AddAttribute("prstMaterial", a => a.PresetMaterial, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
});
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.BevelTop), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.BevelBottom), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.ExtrusionColor), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.ContourColor), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.ExtensionList), 0, 1)
            };
        }

        /// <summary>
        /// <para>Top Bevel.</para>
        /// <para>Represents the following element tag in the schema: a:bevelT.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.BevelTop? BevelTop
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.BevelTop>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Bottom Bevel.</para>
        /// <para>Represents the following element tag in the schema: a:bevelB.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.BevelBottom? BevelBottom
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.BevelBottom>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Extrusion Color.</para>
        /// <para>Represents the following element tag in the schema: a:extrusionClr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.ExtrusionColor? ExtrusionColor
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.ExtrusionColor>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Contour Color.</para>
        /// <para>Represents the following element tag in the schema: a:contourClr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.ContourColor? ContourColor
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.ContourColor>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ExtensionList.</para>
        /// <para>Represents the following element tag in the schema: a:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.ExtensionList? ExtensionList
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.ExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Shape3D>(deep);
    }

    /// <summary>
    /// <para>Text Properties.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is dgm:txPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.FlatText" /> <c>&lt;a:flatTx></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Shape3DType" /> <c>&lt;a:sp3d></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("dgm:txPr")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class TextProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the TextProperties class.
        /// </summary>
        public TextProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the TextProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TextProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TextProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TextProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TextProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public TextProperties(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("dgm:txPr");
            builder.AddChild<DocumentFormat.OpenXml.Drawing.FlatText>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Shape3DType>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle.Builder(ParticleType.Group, 0, 1)
                {
                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Shape3DType), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.FlatText), 1, 1)
                    }
                }
            };
        }

        /// <summary>
        /// <para>Apply 3D shape properties.</para>
        /// <para>Represents the following element tag in the schema: a:sp3d.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Shape3DType? Shape3DType
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Shape3DType>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>No text in 3D scene.</para>
        /// <para>Represents the following element tag in the schema: a:flatTx.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.FlatText? FlatText
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.FlatText>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TextProperties>(deep);
    }

    /// <summary>
    /// <para>Title.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is dgm:title.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("dgm:title")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class StyleDefinitionTitle : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the StyleDefinitionTitle class.
        /// </summary>
        public StyleDefinitionTitle() : base()
        {
        }

        /// <summary>
        /// <para>Natural Language</para>
        /// <para>Represents the following attribute in the schema: lang</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("lang")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Language
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Description Value</para>
        /// <para>Represents the following attribute in the schema: val</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("val")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Val
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("dgm:title");
            builder.AddElement<StyleDefinitionTitle>()
.AddAttribute("lang", a => a.Language)
.AddAttribute("val", a => a.Val, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<StyleDefinitionTitle>(deep);
    }

    /// <summary>
    /// <para>Style Label Description.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is dgm:desc.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("dgm:desc")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class StyleLabelDescription : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the StyleLabelDescription class.
        /// </summary>
        public StyleLabelDescription() : base()
        {
        }

        /// <summary>
        /// <para>Natural Language</para>
        /// <para>Represents the following attribute in the schema: lang</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("lang")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Language
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Description Value</para>
        /// <para>Represents the following attribute in the schema: val</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("val")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Val
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("dgm:desc");
            builder.AddElement<StyleLabelDescription>()
.AddAttribute("lang", a => a.Language)
.AddAttribute("val", a => a.Val, aBuilder =>
{
 aBuilder.AddValidator(RequiredValidator.Instance);
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<StyleLabelDescription>(deep);
    }

    /// <summary>
    /// <para>Category List.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is dgm:catLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Diagrams.StyleDisplayCategory" /> <c>&lt;dgm:cat></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("dgm:catLst")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class StyleDisplayCategories : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the StyleDisplayCategories class.
        /// </summary>
        public StyleDisplayCategories() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the StyleDisplayCategories class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public StyleDisplayCategories(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the StyleDisplayCategories class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public StyleDisplayCategories(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the StyleDisplayCategories class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public StyleDisplayCategories(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("dgm:catLst");
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Diagrams.StyleDisplayCategory>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 0, 0)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.StyleDisplayCategory), 0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<StyleDisplayCategories>(deep);
    }

    /// <summary>
    /// <para>Style Label.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is dgm:styleLbl.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Diagrams.ExtensionList" /> <c>&lt;dgm:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Diagrams.Scene3D" /> <c>&lt;dgm:scene3d></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Diagrams.Shape3D" /> <c>&lt;dgm:sp3d></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Diagrams.Style" /> <c>&lt;dgm:style></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Diagrams.TextProperties" /> <c>&lt;dgm:txPr></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("dgm:styleLbl")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class StyleLabel : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the StyleLabel class.
        /// </summary>
        public StyleLabel() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the StyleLabel class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public StyleLabel(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the StyleLabel class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public StyleLabel(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the StyleLabel class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public StyleLabel(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Style Name</para>
        /// <para>Represents the following attribute in the schema: name</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("name")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Name
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("dgm:styleLbl");
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Diagrams.ExtensionList>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Diagrams.Scene3D>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Diagrams.Shape3D>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Diagrams.Style>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Diagrams.TextProperties>();
            builder.AddElement<StyleLabel>()
.AddAttribute("name", a => a.Name, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
});
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.Scene3D), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.Shape3D), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.TextProperties), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.Style), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.ExtensionList), 0, 1)
            };
        }

        /// <summary>
        /// <para>3-D Scene.</para>
        /// <para>Represents the following element tag in the schema: dgm:scene3d.</para>
        /// </summary>
        /// <remark>
        /// xmlns:dgm = http://schemas.openxmlformats.org/drawingml/2006/diagram
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Diagrams.Scene3D? Scene3D
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Diagrams.Scene3D>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>3-D Shape Properties.</para>
        /// <para>Represents the following element tag in the schema: dgm:sp3d.</para>
        /// </summary>
        /// <remark>
        /// xmlns:dgm = http://schemas.openxmlformats.org/drawingml/2006/diagram
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Diagrams.Shape3D? Shape3D
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Diagrams.Shape3D>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Text Properties.</para>
        /// <para>Represents the following element tag in the schema: dgm:txPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:dgm = http://schemas.openxmlformats.org/drawingml/2006/diagram
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Diagrams.TextProperties? TextProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Diagrams.TextProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Shape Style.</para>
        /// <para>Represents the following element tag in the schema: dgm:style.</para>
        /// </summary>
        /// <remark>
        /// xmlns:dgm = http://schemas.openxmlformats.org/drawingml/2006/diagram
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Diagrams.Style? Style
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Diagrams.Style>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ExtensionList.</para>
        /// <para>Represents the following element tag in the schema: dgm:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:dgm = http://schemas.openxmlformats.org/drawingml/2006/diagram
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Diagrams.ExtensionList? ExtensionList
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Diagrams.ExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<StyleLabel>(deep);
    }

    /// <summary>
    /// <para>Point List.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is dgm:ptLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Diagrams.Point" /> <c>&lt;dgm:pt></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("dgm:ptLst")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class PointList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the PointList class.
        /// </summary>
        public PointList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the PointList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public PointList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PointList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public PointList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PointList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public PointList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("dgm:ptLst");
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Diagrams.Point>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.Point), 0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<PointList>(deep);
    }

    /// <summary>
    /// <para>Connection List.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is dgm:cxnLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Diagrams.Connection" /> <c>&lt;dgm:cxn></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("dgm:cxnLst")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class ConnectionList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ConnectionList class.
        /// </summary>
        public ConnectionList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ConnectionList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ConnectionList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ConnectionList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ConnectionList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ConnectionList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ConnectionList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("dgm:cxnLst");
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Diagrams.Connection>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.Connection), 0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ConnectionList>(deep);
    }

    /// <summary>
    /// <para>Background Formatting.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is dgm:bg.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.BlipFill" /> <c>&lt;a:blipFill></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.EffectDag" /> <c>&lt;a:effectDag></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.EffectList" /> <c>&lt;a:effectLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.GradientFill" /> <c>&lt;a:gradFill></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.GroupFill" /> <c>&lt;a:grpFill></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.NoFill" /> <c>&lt;a:noFill></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.PatternFill" /> <c>&lt;a:pattFill></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.SolidFill" /> <c>&lt;a:solidFill></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("dgm:bg")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class Background : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Background class.
        /// </summary>
        public Background() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Background class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Background(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Background class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Background(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Background class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Background(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("dgm:bg");
            builder.AddChild<DocumentFormat.OpenXml.Drawing.BlipFill>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.EffectDag>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.EffectList>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.GradientFill>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.GroupFill>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.NoFill>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.PatternFill>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.SolidFill>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
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
                new CompositeParticle.Builder(ParticleType.Group, 0, 1)
                {
                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.EffectList), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.EffectDag), 1, 1)
                    }
                }
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Background>(deep);
    }

    /// <summary>
    /// <para>Whole E2O Formatting.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is dgm:whole.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.EffectDag" /> <c>&lt;a:effectDag></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.EffectList" /> <c>&lt;a:effectLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Outline" /> <c>&lt;a:ln></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("dgm:whole")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class Whole : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Whole class.
        /// </summary>
        public Whole() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Whole class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Whole(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Whole class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Whole(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Whole class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Whole(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("dgm:whole");
            builder.AddChild<DocumentFormat.OpenXml.Drawing.EffectDag>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.EffectList>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Outline>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Outline), 0, 1),
                new CompositeParticle.Builder(ParticleType.Group, 0, 1)
                {
                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.EffectList), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.EffectDag), 1, 1)
                    }
                }
            };
        }

        /// <summary>
        /// <para>Outline.</para>
        /// <para>Represents the following element tag in the schema: a:ln.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Outline? Outline
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Outline>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Whole>(deep);
    }

    /// <summary>
    /// <para>Defines the DataModelExtensionList Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is dgm:extLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.DataModelExtension" /> <c>&lt;a:ext></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("dgm:extLst")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class DataModelExtensionList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the DataModelExtensionList class.
        /// </summary>
        public DataModelExtensionList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the DataModelExtensionList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DataModelExtensionList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DataModelExtensionList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DataModelExtensionList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DataModelExtensionList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public DataModelExtensionList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("dgm:extLst");
            builder.AddChild<DocumentFormat.OpenXml.Drawing.DataModelExtension>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.DataModelExtension), 0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DataModelExtensionList>(deep);
    }

    /// <summary>
    /// <para>Property Set.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is dgm:prSet.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Diagrams.Style" /> <c>&lt;dgm:style></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Diagrams.PresentationLayoutVariables" /> <c>&lt;dgm:presLayoutVars></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("dgm:prSet")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class PropertySet : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the PropertySet class.
        /// </summary>
        public PropertySet() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the PropertySet class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public PropertySet(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PropertySet class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public PropertySet(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PropertySet class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public PropertySet(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Presentation Element Identifier</para>
        /// <para>Represents the following attribute in the schema: presAssocID</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("presAssocID")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? PresentationElementId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Presentation Name</para>
        /// <para>Represents the following attribute in the schema: presName</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("presName")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? PresentationName
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Presentation Style Label</para>
        /// <para>Represents the following attribute in the schema: presStyleLbl</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("presStyleLbl")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? PresentationStyleLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Presentation Style Index</para>
        /// <para>Represents the following attribute in the schema: presStyleIdx</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("presStyleIdx")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int32Value? PresentationStyleIndex
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Presentation Style Count</para>
        /// <para>Represents the following attribute in the schema: presStyleCnt</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("presStyleCnt")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int32Value? PresentationStyleCount
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Current Diagram Type</para>
        /// <para>Represents the following attribute in the schema: loTypeId</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("loTypeId")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? LayoutTypeId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Current Diagram Category</para>
        /// <para>Represents the following attribute in the schema: loCatId</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("loCatId")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? LayoutCategoryId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Current Style Type</para>
        /// <para>Represents the following attribute in the schema: qsTypeId</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("qsTypeId")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? QuickStyleTypeId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Current Style Category</para>
        /// <para>Represents the following attribute in the schema: qsCatId</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("qsCatId")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? QuickStyleCategoryId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Color Transform Type Identifier</para>
        /// <para>Represents the following attribute in the schema: csTypeId</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("csTypeId")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? ColorType
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Color Transform Category</para>
        /// <para>Represents the following attribute in the schema: csCatId</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("csCatId")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? ColorCategoryId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Coherent 3D Behavior</para>
        /// <para>Represents the following attribute in the schema: coherent3DOff</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("coherent3DOff")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? Coherent3D
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Placeholder Text</para>
        /// <para>Represents the following attribute in the schema: phldrT</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("phldrT")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? PlaceholderText
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Placeholder</para>
        /// <para>Represents the following attribute in the schema: phldr</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("phldr")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? Placeholder
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Custom Rotation</para>
        /// <para>Represents the following attribute in the schema: custAng</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("custAng")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int32Value? Rotation
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Custom Vertical Flip</para>
        /// <para>Represents the following attribute in the schema: custFlipVert</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("custFlipVert")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? VerticalFlip
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Custom Horizontal Flip</para>
        /// <para>Represents the following attribute in the schema: custFlipHor</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("custFlipHor")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? HorizontalFlip
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Fixed Width Override</para>
        /// <para>Represents the following attribute in the schema: custSzX</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("custSzX")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int32Value? FixedWidthOverride
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Fixed Height Override</para>
        /// <para>Represents the following attribute in the schema: custSzY</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("custSzY")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int32Value? FixedHeightOverride
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Width Scale</para>
        /// <para>Represents the following attribute in the schema: custScaleX</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("custScaleX")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int32Value? WidthScale
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Height Scale</para>
        /// <para>Represents the following attribute in the schema: custScaleY</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("custScaleY")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int32Value? HightScale
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Text Changed</para>
        /// <para>Represents the following attribute in the schema: custT</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("custT")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? TextChanged
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Custom Factor Width</para>
        /// <para>Represents the following attribute in the schema: custLinFactX</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("custLinFactX")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int32Value? FactorWidth
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Custom Factor Height</para>
        /// <para>Represents the following attribute in the schema: custLinFactY</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("custLinFactY")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int32Value? FactorHeight
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Neighbor Offset Width</para>
        /// <para>Represents the following attribute in the schema: custLinFactNeighborX</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("custLinFactNeighborX")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int32Value? NeighborOffsetWidth
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Neighbor Offset Height</para>
        /// <para>Represents the following attribute in the schema: custLinFactNeighborY</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("custLinFactNeighborY")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int32Value? NeighborOffsetHeight
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Radius Scale</para>
        /// <para>Represents the following attribute in the schema: custRadScaleRad</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("custRadScaleRad")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int32Value? RadiusScale
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Include Angle Scale</para>
        /// <para>Represents the following attribute in the schema: custRadScaleInc</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("custRadScaleInc")]
#pragma warning restore CS0618 // Type or member is obsolete

        public Int32Value? IncludeAngleScale
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("dgm:prSet");
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Diagrams.Style>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Diagrams.PresentationLayoutVariables>();
            builder.AddElement<PropertySet>()
.AddAttribute("presAssocID", a => a.PresentationElementId, aBuilder =>
{
aBuilder.AddUnion(union =>
{
union.AddValidator<Int32Value>(NumberValidator.Instance);
union.AddValidator(new StringValidator() { Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
});
})
.AddAttribute("presName", a => a.PresentationName)
.AddAttribute("presStyleLbl", a => a.PresentationStyleLabel)
.AddAttribute("presStyleIdx", a => a.PresentationStyleIndex)
.AddAttribute("presStyleCnt", a => a.PresentationStyleCount)
.AddAttribute("loTypeId", a => a.LayoutTypeId)
.AddAttribute("loCatId", a => a.LayoutCategoryId)
.AddAttribute("qsTypeId", a => a.QuickStyleTypeId)
.AddAttribute("qsCatId", a => a.QuickStyleCategoryId)
.AddAttribute("csTypeId", a => a.ColorType)
.AddAttribute("csCatId", a => a.ColorCategoryId)
.AddAttribute("coherent3DOff", a => a.Coherent3D)
.AddAttribute("phldrT", a => a.PlaceholderText)
.AddAttribute("phldr", a => a.Placeholder)
.AddAttribute("custAng", a => a.Rotation)
.AddAttribute("custFlipVert", a => a.VerticalFlip)
.AddAttribute("custFlipHor", a => a.HorizontalFlip)
.AddAttribute("custSzX", a => a.FixedWidthOverride)
.AddAttribute("custSzY", a => a.FixedHeightOverride)
.AddAttribute("custScaleX", a => a.WidthScale)
.AddAttribute("custScaleY", a => a.HightScale)
.AddAttribute("custT", a => a.TextChanged)
.AddAttribute("custLinFactX", a => a.FactorWidth)
.AddAttribute("custLinFactY", a => a.FactorHeight)
.AddAttribute("custLinFactNeighborX", a => a.NeighborOffsetWidth)
.AddAttribute("custLinFactNeighborY", a => a.NeighborOffsetHeight)
.AddAttribute("custRadScaleRad", a => a.RadiusScale)
.AddAttribute("custRadScaleInc", a => a.IncludeAngleScale);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.PresentationLayoutVariables), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.Style), 0, 1)
            };
        }

        /// <summary>
        /// <para>Presentation Layout Variables.</para>
        /// <para>Represents the following element tag in the schema: dgm:presLayoutVars.</para>
        /// </summary>
        /// <remark>
        /// xmlns:dgm = http://schemas.openxmlformats.org/drawingml/2006/diagram
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Diagrams.PresentationLayoutVariables? PresentationLayoutVariables
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Diagrams.PresentationLayoutVariables>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Shape Style.</para>
        /// <para>Represents the following element tag in the schema: dgm:style.</para>
        /// </summary>
        /// <remark>
        /// xmlns:dgm = http://schemas.openxmlformats.org/drawingml/2006/diagram
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Diagrams.Style? Style
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Diagrams.Style>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<PropertySet>(deep);
    }

    /// <summary>
    /// <para>Shape Properties.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is dgm:spPr.</para>
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
    [SchemaAttr("dgm:spPr")]
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

        [SchemaAttr("bwMode")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues>? BlackWhiteMode
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("dgm:spPr");
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
.AddAttribute("bwMode", a => a.BlackWhiteMode, aBuilder =>
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
    /// <para>Text Body.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is dgm:t.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.BodyProperties" /> <c>&lt;a:bodyPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.ListStyle" /> <c>&lt;a:lstStyle></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Paragraph" /> <c>&lt;a:p></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("dgm:t")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class TextBody : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the TextBody class.
        /// </summary>
        public TextBody() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the TextBody class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TextBody(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TextBody class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TextBody(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TextBody class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public TextBody(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("dgm:t");
            builder.AddChild<DocumentFormat.OpenXml.Drawing.BodyProperties>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.ListStyle>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Paragraph>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.BodyProperties), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.ListStyle), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Paragraph), 1, 0)
            };
        }

        /// <summary>
        /// <para>Body Properties.</para>
        /// <para>Represents the following element tag in the schema: a:bodyPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.BodyProperties? BodyProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.BodyProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Text List Styles.</para>
        /// <para>Represents the following element tag in the schema: a:lstStyle.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.ListStyle? ListStyle
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.ListStyle>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TextBody>(deep);
    }

    /// <summary>
    /// <para>Defines the PtExtensionList Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is dgm:extLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.PtExtension" /> <c>&lt;a:ext></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("dgm:extLst")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class PtExtensionList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the PtExtensionList class.
        /// </summary>
        public PtExtensionList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the PtExtensionList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public PtExtensionList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PtExtensionList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public PtExtensionList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PtExtensionList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public PtExtensionList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("dgm:extLst");
            builder.AddChild<DocumentFormat.OpenXml.Drawing.PtExtension>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.PtExtension), 0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<PtExtensionList>(deep);
    }

    /// <summary>
    /// <para>Defines the DiagramDefinitionExtension Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is dgm:ext.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2019.Drawing.Diagram12.TextListStyleType" /> <c>&lt;dgm1612:lstStyle></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2019.Drawing.Diagram11.NumberDiagramInfoList" /> <c>&lt;dgm1611:autoBuNodeInfoLst></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("dgm:ext")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class DiagramDefinitionExtension : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the DiagramDefinitionExtension class.
        /// </summary>
        public DiagramDefinitionExtension() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the DiagramDefinitionExtension class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DiagramDefinitionExtension(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DiagramDefinitionExtension class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DiagramDefinitionExtension(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DiagramDefinitionExtension class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public DiagramDefinitionExtension(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>URI</para>
        /// <para>Represents the following attribute in the schema: uri</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("uri")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? Uri
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("dgm:ext");
            builder.AddChild<DocumentFormat.OpenXml.Office2019.Drawing.Diagram12.TextListStyleType>();
            builder.AddChild<DocumentFormat.OpenXml.Office2019.Drawing.Diagram11.NumberDiagramInfoList>();
            builder.AddElement<DiagramDefinitionExtension>()
.AddAttribute("uri", a => a.Uri, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
});
            builder.Particle = new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Drawing.Diagram11.NumberDiagramInfoList), 1, 1, version: FileFormatVersions.Office2019),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Drawing.Diagram12.TextListStyleType), 1, 1, version: FileFormatVersions.Office2019),
                new AnyParticle(0, 1)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DiagramDefinitionExtension>(deep);
    }

    /// <summary>
    /// <para>Defines the SampleData Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is dgm:sampData.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Diagrams.DataModel" /> <c>&lt;dgm:dataModel></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("dgm:sampData")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class SampleData : SampleDataType
    {
        /// <summary>
        /// Initializes a new instance of the SampleData class.
        /// </summary>
        public SampleData() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the SampleData class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SampleData(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SampleData class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SampleData(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SampleData class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public SampleData(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("dgm:sampData");
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.DataModel), 0, 1)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SampleData>(deep);
    }

    /// <summary>
    /// <para>Defines the StyleData Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is dgm:styleData.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Diagrams.DataModel" /> <c>&lt;dgm:dataModel></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("dgm:styleData")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class StyleData : SampleDataType
    {
        /// <summary>
        /// Initializes a new instance of the StyleData class.
        /// </summary>
        public StyleData() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the StyleData class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public StyleData(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the StyleData class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public StyleData(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the StyleData class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public StyleData(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("dgm:styleData");
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.DataModel), 0, 1)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<StyleData>(deep);
    }

    /// <summary>
    /// <para>Defines the ColorData Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is dgm:clrData.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Diagrams.DataModel" /> <c>&lt;dgm:dataModel></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("dgm:clrData")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class ColorData : SampleDataType
    {
        /// <summary>
        /// Initializes a new instance of the ColorData class.
        /// </summary>
        public ColorData() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ColorData class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ColorData(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ColorData class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ColorData(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ColorData class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ColorData(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("dgm:clrData");
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.DataModel), 0, 1)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ColorData>(deep);
    }

    /// <summary>
    /// <para>Defines the SampleDataType Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is :.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Diagrams.DataModel" /> <c>&lt;dgm:dataModel></c></description></item>
    /// </list>
    /// </remark>
    public abstract partial class SampleDataType : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the SampleDataType class.
        /// </summary>
        protected SampleDataType() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the SampleDataType class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        protected SampleDataType(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SampleDataType class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        protected SampleDataType(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SampleDataType class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        protected SampleDataType(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Use Default</para>
        /// <para>Represents the following attribute in the schema: useDef</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("useDef")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? UseDefault
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Diagrams.DataModel>();
            builder.AddElement<SampleDataType>()
.AddAttribute("useDef", a => a.UseDefault);
        }

        /// <summary>
        /// <para>Data Model.</para>
        /// <para>Represents the following element tag in the schema: dgm:dataModel.</para>
        /// </summary>
        /// <remark>
        /// xmlns:dgm = http://schemas.openxmlformats.org/drawingml/2006/diagram
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Diagrams.DataModel? DataModel
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Diagrams.DataModel>();
            set => SetElement(value);
        }
    }

    /// <summary>
    /// <para>List of extensions to the CT_DiagramDefintions type..</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is dgm:extLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Diagrams.DiagramDefinitionExtension" /> <c>&lt;dgm:ext></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("dgm:extLst")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class DiagramDefinitionExtensionList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the DiagramDefinitionExtensionList class.
        /// </summary>
        public DiagramDefinitionExtensionList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the DiagramDefinitionExtensionList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DiagramDefinitionExtensionList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DiagramDefinitionExtensionList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DiagramDefinitionExtensionList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DiagramDefinitionExtensionList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public DiagramDefinitionExtensionList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("dgm:extLst");
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Diagrams.DiagramDefinitionExtension>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.DiagramDefinitionExtension), 0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DiagramDefinitionExtensionList>(deep);
    }

    /// <summary>
    /// Color Application Method Type
    /// </summary>
    public enum ColorApplicationMethodValues
    {
        /// <summary>
        /// Span.
        /// <para>When the item is serialized out as xml, its value is "span".</para>
        /// </summary>
        [EnumString("span")]
        Span,
        /// <summary>
        /// Cycle.
        /// <para>When the item is serialized out as xml, its value is "cycle".</para>
        /// </summary>
        [EnumString("cycle")]
        Cycle,
        /// <summary>
        /// Repeat.
        /// <para>When the item is serialized out as xml, its value is "repeat".</para>
        /// </summary>
        [EnumString("repeat")]
        Repeat
    }

    /// <summary>
    /// Hue Direction
    /// </summary>
    public enum HueDirectionValues
    {
        /// <summary>
        /// Clockwise Hue Direction.
        /// <para>When the item is serialized out as xml, its value is "cw".</para>
        /// </summary>
        [EnumString("cw")]
        Clockwise,
        /// <summary>
        /// Counterclockwise Hue Direction.
        /// <para>When the item is serialized out as xml, its value is "ccw".</para>
        /// </summary>
        [EnumString("ccw")]
        Counterclockwise
    }

    /// <summary>
    /// Point Type
    /// </summary>
    public enum PointValues
    {
        /// <summary>
        /// Node.
        /// <para>When the item is serialized out as xml, its value is "node".</para>
        /// </summary>
        [EnumString("node")]
        Node,
        /// <summary>
        /// Assistant Element.
        /// <para>When the item is serialized out as xml, its value is "asst".</para>
        /// </summary>
        [EnumString("asst")]
        Assistant,
        /// <summary>
        /// Document.
        /// <para>When the item is serialized out as xml, its value is "doc".</para>
        /// </summary>
        [EnumString("doc")]
        Document,
        /// <summary>
        /// Presentation.
        /// <para>When the item is serialized out as xml, its value is "pres".</para>
        /// </summary>
        [EnumString("pres")]
        Presentation,
        /// <summary>
        /// Parent Transition.
        /// <para>When the item is serialized out as xml, its value is "parTrans".</para>
        /// </summary>
        [EnumString("parTrans")]
        ParentTransition,
        /// <summary>
        /// Sibling Transition.
        /// <para>When the item is serialized out as xml, its value is "sibTrans".</para>
        /// </summary>
        [EnumString("sibTrans")]
        SiblingTransition
    }

    /// <summary>
    /// Connection Type
    /// </summary>
    public enum ConnectionValues
    {
        /// <summary>
        /// Parent Of.
        /// <para>When the item is serialized out as xml, its value is "parOf".</para>
        /// </summary>
        [EnumString("parOf")]
        ParentOf,
        /// <summary>
        /// Presentation Of.
        /// <para>When the item is serialized out as xml, its value is "presOf".</para>
        /// </summary>
        [EnumString("presOf")]
        PresentationOf,
        /// <summary>
        /// Presentation Parent Of.
        /// <para>When the item is serialized out as xml, its value is "presParOf".</para>
        /// </summary>
        [EnumString("presParOf")]
        PresentationParentOf,
        /// <summary>
        /// Unknown Relationship.
        /// <para>When the item is serialized out as xml, its value is "unknownRelationship".</para>
        /// </summary>
        [EnumString("unknownRelationship")]
        UnknownRelationship
    }

    /// <summary>
    /// Diagram Direction Definition
    /// </summary>
    public enum DirectionValues
    {
        /// <summary>
        /// Normal Direction.
        /// <para>When the item is serialized out as xml, its value is "norm".</para>
        /// </summary>
        [EnumString("norm")]
        Normal,
        /// <summary>
        /// Reversed Direction.
        /// <para>When the item is serialized out as xml, its value is "rev".</para>
        /// </summary>
        [EnumString("rev")]
        Reversed
    }

    /// <summary>
    /// Hierarchy Branch Style Definition
    /// </summary>
    public enum HierarchyBranchStyleValues
    {
        /// <summary>
        /// Left.
        /// <para>When the item is serialized out as xml, its value is "l".</para>
        /// </summary>
        [EnumString("l")]
        Left,
        /// <summary>
        /// Right.
        /// <para>When the item is serialized out as xml, its value is "r".</para>
        /// </summary>
        [EnumString("r")]
        Right,
        /// <summary>
        /// Hanging.
        /// <para>When the item is serialized out as xml, its value is "hang".</para>
        /// </summary>
        [EnumString("hang")]
        Hanging,
        /// <summary>
        /// Standard.
        /// <para>When the item is serialized out as xml, its value is "std".</para>
        /// </summary>
        [EnumString("std")]
        Standard,
        /// <summary>
        /// Initial.
        /// <para>When the item is serialized out as xml, its value is "init".</para>
        /// </summary>
        [EnumString("init")]
        Initial
    }

    /// <summary>
    /// One by One Animation Value Definition
    /// </summary>
    public enum AnimateOneByOneValues
    {
        /// <summary>
        /// Disable One-by-One.
        /// <para>When the item is serialized out as xml, its value is "none".</para>
        /// </summary>
        [EnumString("none")]
        None,
        /// <summary>
        /// One By One.
        /// <para>When the item is serialized out as xml, its value is "one".</para>
        /// </summary>
        [EnumString("one")]
        One,
        /// <summary>
        /// By Branch One By One.
        /// <para>When the item is serialized out as xml, its value is "branch".</para>
        /// </summary>
        [EnumString("branch")]
        Branch
    }

    /// <summary>
    /// Animation Level String Definition
    /// </summary>
    public enum AnimationLevelStringValues
    {
        /// <summary>
        /// Disable Level At Once.
        /// <para>When the item is serialized out as xml, its value is "none".</para>
        /// </summary>
        [EnumString("none")]
        None,
        /// <summary>
        /// By Level Animation.
        /// <para>When the item is serialized out as xml, its value is "lvl".</para>
        /// </summary>
        [EnumString("lvl")]
        Level,
        /// <summary>
        /// From Center Animation.
        /// <para>When the item is serialized out as xml, its value is "ctr".</para>
        /// </summary>
        [EnumString("ctr")]
        Center
    }

    /// <summary>
    /// Resize Handle
    /// </summary>
    public enum ResizeHandlesStringValues
    {
        /// <summary>
        /// Exact.
        /// <para>When the item is serialized out as xml, its value is "exact".</para>
        /// </summary>
        [EnumString("exact")]
        Exact,
        /// <summary>
        /// Relative.
        /// <para>When the item is serialized out as xml, its value is "rel".</para>
        /// </summary>
        [EnumString("rel")]
        Relative
    }

    /// <summary>
    /// Algorithm Types
    /// </summary>
    public enum AlgorithmValues
    {
        /// <summary>
        /// Composite.
        /// <para>When the item is serialized out as xml, its value is "composite".</para>
        /// </summary>
        [EnumString("composite")]
        Composite,
        /// <summary>
        /// Connector Algorithm.
        /// <para>When the item is serialized out as xml, its value is "conn".</para>
        /// </summary>
        [EnumString("conn")]
        Connector,
        /// <summary>
        /// Cycle Algorithm.
        /// <para>When the item is serialized out as xml, its value is "cycle".</para>
        /// </summary>
        [EnumString("cycle")]
        Cycle,
        /// <summary>
        /// Hierarchy Child Algorithm.
        /// <para>When the item is serialized out as xml, its value is "hierChild".</para>
        /// </summary>
        [EnumString("hierChild")]
        HierarchyChild,
        /// <summary>
        /// Hierarchy Root Algorithm.
        /// <para>When the item is serialized out as xml, its value is "hierRoot".</para>
        /// </summary>
        [EnumString("hierRoot")]
        HierarchyRoot,
        /// <summary>
        /// Pyramid Algorithm.
        /// <para>When the item is serialized out as xml, its value is "pyra".</para>
        /// </summary>
        [EnumString("pyra")]
        Pyramid,
        /// <summary>
        /// Linear Algorithm.
        /// <para>When the item is serialized out as xml, its value is "lin".</para>
        /// </summary>
        [EnumString("lin")]
        Linear,
        /// <summary>
        /// Space Algorithm.
        /// <para>When the item is serialized out as xml, its value is "sp".</para>
        /// </summary>
        [EnumString("sp")]
        Space,
        /// <summary>
        /// Text Algorithm.
        /// <para>When the item is serialized out as xml, its value is "tx".</para>
        /// </summary>
        [EnumString("tx")]
        Text,
        /// <summary>
        /// Snake Algorithm.
        /// <para>When the item is serialized out as xml, its value is "snake".</para>
        /// </summary>
        [EnumString("snake")]
        Snake
    }

    /// <summary>
    /// Axis Type
    /// </summary>
    public enum AxisValues
    {
        /// <summary>
        /// Self.
        /// <para>When the item is serialized out as xml, its value is "self".</para>
        /// </summary>
        [EnumString("self")]
        Self,
        /// <summary>
        /// Child.
        /// <para>When the item is serialized out as xml, its value is "ch".</para>
        /// </summary>
        [EnumString("ch")]
        Child,
        /// <summary>
        /// Descendant.
        /// <para>When the item is serialized out as xml, its value is "des".</para>
        /// </summary>
        [EnumString("des")]
        Descendant,
        /// <summary>
        /// Descendant or Self.
        /// <para>When the item is serialized out as xml, its value is "desOrSelf".</para>
        /// </summary>
        [EnumString("desOrSelf")]
        DescendantOrSelf,
        /// <summary>
        /// Parent.
        /// <para>When the item is serialized out as xml, its value is "par".</para>
        /// </summary>
        [EnumString("par")]
        Parent,
        /// <summary>
        /// Ancestor.
        /// <para>When the item is serialized out as xml, its value is "ancst".</para>
        /// </summary>
        [EnumString("ancst")]
        Ancestor,
        /// <summary>
        /// Ancestor or Self.
        /// <para>When the item is serialized out as xml, its value is "ancstOrSelf".</para>
        /// </summary>
        [EnumString("ancstOrSelf")]
        AncestorOrSelf,
        /// <summary>
        /// Follow Sibling.
        /// <para>When the item is serialized out as xml, its value is "followSib".</para>
        /// </summary>
        [EnumString("followSib")]
        FollowSibling,
        /// <summary>
        /// Preceding Sibling.
        /// <para>When the item is serialized out as xml, its value is "precedSib".</para>
        /// </summary>
        [EnumString("precedSib")]
        PrecedingSibling,
        /// <summary>
        /// Follow.
        /// <para>When the item is serialized out as xml, its value is "follow".</para>
        /// </summary>
        [EnumString("follow")]
        Follow,
        /// <summary>
        /// Preceding.
        /// <para>When the item is serialized out as xml, its value is "preced".</para>
        /// </summary>
        [EnumString("preced")]
        Preceding,
        /// <summary>
        /// Root.
        /// <para>When the item is serialized out as xml, its value is "root".</para>
        /// </summary>
        [EnumString("root")]
        Root,
        /// <summary>
        /// None.
        /// <para>When the item is serialized out as xml, its value is "none".</para>
        /// </summary>
        [EnumString("none")]
        None
    }

    /// <summary>
    /// Boolean Constraint
    /// </summary>
    public enum BoolOperatorValues
    {
        /// <summary>
        /// None.
        /// <para>When the item is serialized out as xml, its value is "none".</para>
        /// </summary>
        [EnumString("none")]
        None,
        /// <summary>
        /// Equal.
        /// <para>When the item is serialized out as xml, its value is "equ".</para>
        /// </summary>
        [EnumString("equ")]
        Equal,
        /// <summary>
        /// Greater Than or Equal to.
        /// <para>When the item is serialized out as xml, its value is "gte".</para>
        /// </summary>
        [EnumString("gte")]
        GreaterThanOrEqualTo,
        /// <summary>
        /// Less Than or Equal to.
        /// <para>When the item is serialized out as xml, its value is "lte".</para>
        /// </summary>
        [EnumString("lte")]
        LessThanOrEqualTo
    }

    /// <summary>
    /// Child Order
    /// </summary>
    public enum ChildOrderValues
    {
        /// <summary>
        /// Bottom.
        /// <para>When the item is serialized out as xml, its value is "b".</para>
        /// </summary>
        [EnumString("b")]
        Bottom,
        /// <summary>
        /// Top.
        /// <para>When the item is serialized out as xml, its value is "t".</para>
        /// </summary>
        [EnumString("t")]
        Top
    }

    /// <summary>
    /// Constraint Type
    /// </summary>
    public enum ConstraintValues
    {
        /// <summary>
        /// Unknown.
        /// <para>When the item is serialized out as xml, its value is "none".</para>
        /// </summary>
        [EnumString("none")]
        None,
        /// <summary>
        /// Alignment Offset.
        /// <para>When the item is serialized out as xml, its value is "alignOff".</para>
        /// </summary>
        [EnumString("alignOff")]
        AlignmentOffset,
        /// <summary>
        /// Beginning Margin.
        /// <para>When the item is serialized out as xml, its value is "begMarg".</para>
        /// </summary>
        [EnumString("begMarg")]
        BeginningMargin,
        /// <summary>
        /// Bending Distance.
        /// <para>When the item is serialized out as xml, its value is "bendDist".</para>
        /// </summary>
        [EnumString("bendDist")]
        BendingDistance,
        /// <summary>
        /// Beginning Padding.
        /// <para>When the item is serialized out as xml, its value is "begPad".</para>
        /// </summary>
        [EnumString("begPad")]
        BeginningPadding,
        /// <summary>
        /// Bottom.
        /// <para>When the item is serialized out as xml, its value is "b".</para>
        /// </summary>
        [EnumString("b")]
        Bottom,
        /// <summary>
        /// Bottom Margin.
        /// <para>When the item is serialized out as xml, its value is "bMarg".</para>
        /// </summary>
        [EnumString("bMarg")]
        BottomMargin,
        /// <summary>
        /// Bottom Offset.
        /// <para>When the item is serialized out as xml, its value is "bOff".</para>
        /// </summary>
        [EnumString("bOff")]
        BottomOffset,
        /// <summary>
        /// Center Height.
        /// <para>When the item is serialized out as xml, its value is "ctrX".</para>
        /// </summary>
        [EnumString("ctrX")]
        CenterHeight,
        /// <summary>
        /// Center X Offset.
        /// <para>When the item is serialized out as xml, its value is "ctrXOff".</para>
        /// </summary>
        [EnumString("ctrXOff")]
        CenterXOffset,
        /// <summary>
        /// Center Width.
        /// <para>When the item is serialized out as xml, its value is "ctrY".</para>
        /// </summary>
        [EnumString("ctrY")]
        CenterWidth,
        /// <summary>
        /// Center Y Offset.
        /// <para>When the item is serialized out as xml, its value is "ctrYOff".</para>
        /// </summary>
        [EnumString("ctrYOff")]
        CenterYOffset,
        /// <summary>
        /// Connection Distance.
        /// <para>When the item is serialized out as xml, its value is "connDist".</para>
        /// </summary>
        [EnumString("connDist")]
        ConnectionDistance,
        /// <summary>
        /// Diameter.
        /// <para>When the item is serialized out as xml, its value is "diam".</para>
        /// </summary>
        [EnumString("diam")]
        Diameter,
        /// <summary>
        /// End Margin.
        /// <para>When the item is serialized out as xml, its value is "endMarg".</para>
        /// </summary>
        [EnumString("endMarg")]
        EndMargin,
        /// <summary>
        /// End Padding.
        /// <para>When the item is serialized out as xml, its value is "endPad".</para>
        /// </summary>
        [EnumString("endPad")]
        EndPadding,
        /// <summary>
        /// Height.
        /// <para>When the item is serialized out as xml, its value is "h".</para>
        /// </summary>
        [EnumString("h")]
        Height,
        /// <summary>
        /// Arrowhead Height.
        /// <para>When the item is serialized out as xml, its value is "hArH".</para>
        /// </summary>
        [EnumString("hArH")]
        ArrowheadHeight,
        /// <summary>
        /// Height Offset.
        /// <para>When the item is serialized out as xml, its value is "hOff".</para>
        /// </summary>
        [EnumString("hOff")]
        HeightOffset,
        /// <summary>
        /// Left.
        /// <para>When the item is serialized out as xml, its value is "l".</para>
        /// </summary>
        [EnumString("l")]
        Left,
        /// <summary>
        /// Left Margin.
        /// <para>When the item is serialized out as xml, its value is "lMarg".</para>
        /// </summary>
        [EnumString("lMarg")]
        LeftMargin,
        /// <summary>
        /// Left Offset.
        /// <para>When the item is serialized out as xml, its value is "lOff".</para>
        /// </summary>
        [EnumString("lOff")]
        LeftOffset,
        /// <summary>
        /// Right.
        /// <para>When the item is serialized out as xml, its value is "r".</para>
        /// </summary>
        [EnumString("r")]
        Right,
        /// <summary>
        /// Right Margin.
        /// <para>When the item is serialized out as xml, its value is "rMarg".</para>
        /// </summary>
        [EnumString("rMarg")]
        RightMargin,
        /// <summary>
        /// Right Offset.
        /// <para>When the item is serialized out as xml, its value is "rOff".</para>
        /// </summary>
        [EnumString("rOff")]
        RightOffset,
        /// <summary>
        /// Primary Font Size.
        /// <para>When the item is serialized out as xml, its value is "primFontSz".</para>
        /// </summary>
        [EnumString("primFontSz")]
        PrimaryFontSize,
        /// <summary>
        /// Pyramid Accent Ratio.
        /// <para>When the item is serialized out as xml, its value is "pyraAcctRatio".</para>
        /// </summary>
        [EnumString("pyraAcctRatio")]
        PyramidAccentRatio,
        /// <summary>
        /// Secondary Font Size.
        /// <para>When the item is serialized out as xml, its value is "secFontSz".</para>
        /// </summary>
        [EnumString("secFontSz")]
        SecondaryFontSize,
        /// <summary>
        /// Sibling Spacing.
        /// <para>When the item is serialized out as xml, its value is "sibSp".</para>
        /// </summary>
        [EnumString("sibSp")]
        SiblingSpacing,
        /// <summary>
        /// Secondary Sibling Spacing.
        /// <para>When the item is serialized out as xml, its value is "secSibSp".</para>
        /// </summary>
        [EnumString("secSibSp")]
        SecondarySiblingSpacing,
        /// <summary>
        /// Spacing.
        /// <para>When the item is serialized out as xml, its value is "sp".</para>
        /// </summary>
        [EnumString("sp")]
        Spacing,
        /// <summary>
        /// Stem Thickness.
        /// <para>When the item is serialized out as xml, its value is "stemThick".</para>
        /// </summary>
        [EnumString("stemThick")]
        StemThickness,
        /// <summary>
        /// Top.
        /// <para>When the item is serialized out as xml, its value is "t".</para>
        /// </summary>
        [EnumString("t")]
        Top,
        /// <summary>
        /// Top Margin.
        /// <para>When the item is serialized out as xml, its value is "tMarg".</para>
        /// </summary>
        [EnumString("tMarg")]
        TopMargin,
        /// <summary>
        /// Top Offset.
        /// <para>When the item is serialized out as xml, its value is "tOff".</para>
        /// </summary>
        [EnumString("tOff")]
        TopOffset,
        /// <summary>
        /// User Defined A.
        /// <para>When the item is serialized out as xml, its value is "userA".</para>
        /// </summary>
        [EnumString("userA")]
        UserDefinedA,
        /// <summary>
        /// User Defined B.
        /// <para>When the item is serialized out as xml, its value is "userB".</para>
        /// </summary>
        [EnumString("userB")]
        UserDefinedB,
        /// <summary>
        /// User Defined C.
        /// <para>When the item is serialized out as xml, its value is "userC".</para>
        /// </summary>
        [EnumString("userC")]
        UserDefinedC,
        /// <summary>
        /// User Defined D.
        /// <para>When the item is serialized out as xml, its value is "userD".</para>
        /// </summary>
        [EnumString("userD")]
        UserDefinedD,
        /// <summary>
        /// User Defined E.
        /// <para>When the item is serialized out as xml, its value is "userE".</para>
        /// </summary>
        [EnumString("userE")]
        UserDefinedE,
        /// <summary>
        /// User Defined F.
        /// <para>When the item is serialized out as xml, its value is "userF".</para>
        /// </summary>
        [EnumString("userF")]
        UserDefinedF,
        /// <summary>
        /// User Defined G.
        /// <para>When the item is serialized out as xml, its value is "userG".</para>
        /// </summary>
        [EnumString("userG")]
        UserDefinedG,
        /// <summary>
        /// User Defined H.
        /// <para>When the item is serialized out as xml, its value is "userH".</para>
        /// </summary>
        [EnumString("userH")]
        UserDefinedH,
        /// <summary>
        /// User Defined I.
        /// <para>When the item is serialized out as xml, its value is "userI".</para>
        /// </summary>
        [EnumString("userI")]
        UserDefinedI,
        /// <summary>
        /// User Defined J.
        /// <para>When the item is serialized out as xml, its value is "userJ".</para>
        /// </summary>
        [EnumString("userJ")]
        UserDefinedJ,
        /// <summary>
        /// User Defined K.
        /// <para>When the item is serialized out as xml, its value is "userK".</para>
        /// </summary>
        [EnumString("userK")]
        UserDefinedK,
        /// <summary>
        /// User Defined L.
        /// <para>When the item is serialized out as xml, its value is "userL".</para>
        /// </summary>
        [EnumString("userL")]
        UserDefinedL,
        /// <summary>
        /// User Defined M.
        /// <para>When the item is serialized out as xml, its value is "userM".</para>
        /// </summary>
        [EnumString("userM")]
        UserDefinedM,
        /// <summary>
        /// User Defined N.
        /// <para>When the item is serialized out as xml, its value is "userN".</para>
        /// </summary>
        [EnumString("userN")]
        UserDefinedN,
        /// <summary>
        /// User Defined O.
        /// <para>When the item is serialized out as xml, its value is "userO".</para>
        /// </summary>
        [EnumString("userO")]
        UserDefinedO,
        /// <summary>
        /// User Defined P.
        /// <para>When the item is serialized out as xml, its value is "userP".</para>
        /// </summary>
        [EnumString("userP")]
        UserDefinedP,
        /// <summary>
        /// User Defined Q.
        /// <para>When the item is serialized out as xml, its value is "userQ".</para>
        /// </summary>
        [EnumString("userQ")]
        UserDefinedQ,
        /// <summary>
        /// User Defined R.
        /// <para>When the item is serialized out as xml, its value is "userR".</para>
        /// </summary>
        [EnumString("userR")]
        UserDefinedR,
        /// <summary>
        /// User Defined S.
        /// <para>When the item is serialized out as xml, its value is "userS".</para>
        /// </summary>
        [EnumString("userS")]
        UserDefinedS,
        /// <summary>
        /// User Defined T.
        /// <para>When the item is serialized out as xml, its value is "userT".</para>
        /// </summary>
        [EnumString("userT")]
        UserDefinedT,
        /// <summary>
        /// User Defined U.
        /// <para>When the item is serialized out as xml, its value is "userU".</para>
        /// </summary>
        [EnumString("userU")]
        UserDefinedU,
        /// <summary>
        /// User Defined V.
        /// <para>When the item is serialized out as xml, its value is "userV".</para>
        /// </summary>
        [EnumString("userV")]
        UserDefinedV,
        /// <summary>
        /// User Defined W.
        /// <para>When the item is serialized out as xml, its value is "userW".</para>
        /// </summary>
        [EnumString("userW")]
        UserDefinedW,
        /// <summary>
        /// User Defined X.
        /// <para>When the item is serialized out as xml, its value is "userX".</para>
        /// </summary>
        [EnumString("userX")]
        UserDefinedX,
        /// <summary>
        /// User Defined Y.
        /// <para>When the item is serialized out as xml, its value is "userY".</para>
        /// </summary>
        [EnumString("userY")]
        UserDefinedY,
        /// <summary>
        /// User Defined Z.
        /// <para>When the item is serialized out as xml, its value is "userZ".</para>
        /// </summary>
        [EnumString("userZ")]
        UserDefinedZ,
        /// <summary>
        /// Width.
        /// <para>When the item is serialized out as xml, its value is "w".</para>
        /// </summary>
        [EnumString("w")]
        Width,
        /// <summary>
        /// Arrowhead Width.
        /// <para>When the item is serialized out as xml, its value is "wArH".</para>
        /// </summary>
        [EnumString("wArH")]
        ArrowheadWidth,
        /// <summary>
        /// Width Offset.
        /// <para>When the item is serialized out as xml, its value is "wOff".</para>
        /// </summary>
        [EnumString("wOff")]
        WidthOffset
    }

    /// <summary>
    /// Constraint Relationship
    /// </summary>
    public enum ConstraintRelationshipValues
    {
        /// <summary>
        /// Self.
        /// <para>When the item is serialized out as xml, its value is "self".</para>
        /// </summary>
        [EnumString("self")]
        Self,
        /// <summary>
        /// Child.
        /// <para>When the item is serialized out as xml, its value is "ch".</para>
        /// </summary>
        [EnumString("ch")]
        Child,
        /// <summary>
        /// Descendant.
        /// <para>When the item is serialized out as xml, its value is "des".</para>
        /// </summary>
        [EnumString("des")]
        Descendant
    }

    /// <summary>
    /// Element Type
    /// </summary>
    public enum ElementValues
    {
        /// <summary>
        /// All.
        /// <para>When the item is serialized out as xml, its value is "all".</para>
        /// </summary>
        [EnumString("all")]
        All,
        /// <summary>
        /// Document.
        /// <para>When the item is serialized out as xml, its value is "doc".</para>
        /// </summary>
        [EnumString("doc")]
        Document,
        /// <summary>
        /// Node.
        /// <para>When the item is serialized out as xml, its value is "node".</para>
        /// </summary>
        [EnumString("node")]
        Node,
        /// <summary>
        /// Normal.
        /// <para>When the item is serialized out as xml, its value is "norm".</para>
        /// </summary>
        [EnumString("norm")]
        Normal,
        /// <summary>
        /// Non Normal.
        /// <para>When the item is serialized out as xml, its value is "nonNorm".</para>
        /// </summary>
        [EnumString("nonNorm")]
        NonNormal,
        /// <summary>
        /// Assistant.
        /// <para>When the item is serialized out as xml, its value is "asst".</para>
        /// </summary>
        [EnumString("asst")]
        Assistant,
        /// <summary>
        /// Non Assistant.
        /// <para>When the item is serialized out as xml, its value is "nonAsst".</para>
        /// </summary>
        [EnumString("nonAsst")]
        NonAssistant,
        /// <summary>
        /// Parent Transition.
        /// <para>When the item is serialized out as xml, its value is "parTrans".</para>
        /// </summary>
        [EnumString("parTrans")]
        ParentTransition,
        /// <summary>
        /// Presentation.
        /// <para>When the item is serialized out as xml, its value is "pres".</para>
        /// </summary>
        [EnumString("pres")]
        Presentation,
        /// <summary>
        /// Sibling Transition.
        /// <para>When the item is serialized out as xml, its value is "sibTrans".</para>
        /// </summary>
        [EnumString("sibTrans")]
        SiblingTransition
    }

    /// <summary>
    /// Parameter Identifier
    /// </summary>
    public enum ParameterIdValues
    {
        /// <summary>
        /// Horizontal Alignment.
        /// <para>When the item is serialized out as xml, its value is "horzAlign".</para>
        /// </summary>
        [EnumString("horzAlign")]
        HorizontalAlignment,
        /// <summary>
        /// Vertical Alignment.
        /// <para>When the item is serialized out as xml, its value is "vertAlign".</para>
        /// </summary>
        [EnumString("vertAlign")]
        VerticalAlignment,
        /// <summary>
        /// Child Direction.
        /// <para>When the item is serialized out as xml, its value is "chDir".</para>
        /// </summary>
        [EnumString("chDir")]
        ChildDirection,
        /// <summary>
        /// Child Alignment.
        /// <para>When the item is serialized out as xml, its value is "chAlign".</para>
        /// </summary>
        [EnumString("chAlign")]
        ChildAlignment,
        /// <summary>
        /// Secondary Child Alignment.
        /// <para>When the item is serialized out as xml, its value is "secChAlign".</para>
        /// </summary>
        [EnumString("secChAlign")]
        SecondaryChildAlignment,
        /// <summary>
        /// Linear Direction.
        /// <para>When the item is serialized out as xml, its value is "linDir".</para>
        /// </summary>
        [EnumString("linDir")]
        LinearDirection,
        /// <summary>
        /// Secondary Linear Direction.
        /// <para>When the item is serialized out as xml, its value is "secLinDir".</para>
        /// </summary>
        [EnumString("secLinDir")]
        SecondaryLinearDirection,
        /// <summary>
        /// Start Element.
        /// <para>When the item is serialized out as xml, its value is "stElem".</para>
        /// </summary>
        [EnumString("stElem")]
        StartElement,
        /// <summary>
        /// Bend Point.
        /// <para>When the item is serialized out as xml, its value is "bendPt".</para>
        /// </summary>
        [EnumString("bendPt")]
        BendPoint,
        /// <summary>
        /// Connection Route.
        /// <para>When the item is serialized out as xml, its value is "connRout".</para>
        /// </summary>
        [EnumString("connRout")]
        ConnectionRoute,
        /// <summary>
        /// Beginning Arrowhead Style.
        /// <para>When the item is serialized out as xml, its value is "begSty".</para>
        /// </summary>
        [EnumString("begSty")]
        BeginningArrowheadStyle,
        /// <summary>
        /// End Style.
        /// <para>When the item is serialized out as xml, its value is "endSty".</para>
        /// </summary>
        [EnumString("endSty")]
        EndStyle,
        /// <summary>
        /// Connector Dimension.
        /// <para>When the item is serialized out as xml, its value is "dim".</para>
        /// </summary>
        [EnumString("dim")]
        ConnectorDimension,
        /// <summary>
        /// Rotation Path.
        /// <para>When the item is serialized out as xml, its value is "rotPath".</para>
        /// </summary>
        [EnumString("rotPath")]
        RotationPath,
        /// <summary>
        /// Center Shape Mapping.
        /// <para>When the item is serialized out as xml, its value is "ctrShpMap".</para>
        /// </summary>
        [EnumString("ctrShpMap")]
        CenterShapeMapping,
        /// <summary>
        /// Node Horizontal Alignment.
        /// <para>When the item is serialized out as xml, its value is "nodeHorzAlign".</para>
        /// </summary>
        [EnumString("nodeHorzAlign")]
        NodeHorizontalAlignment,
        /// <summary>
        /// Node Vertical Alignment.
        /// <para>When the item is serialized out as xml, its value is "nodeVertAlign".</para>
        /// </summary>
        [EnumString("nodeVertAlign")]
        NodeVerticalAlignment,
        /// <summary>
        /// Fallback Scale.
        /// <para>When the item is serialized out as xml, its value is "fallback".</para>
        /// </summary>
        [EnumString("fallback")]
        FallbackScale,
        /// <summary>
        /// Text Direction.
        /// <para>When the item is serialized out as xml, its value is "txDir".</para>
        /// </summary>
        [EnumString("txDir")]
        TextDirection,
        /// <summary>
        /// Pyramid Accent Position.
        /// <para>When the item is serialized out as xml, its value is "pyraAcctPos".</para>
        /// </summary>
        [EnumString("pyraAcctPos")]
        PyramidAccentPosition,
        /// <summary>
        /// Pyramid Accent Text Margin.
        /// <para>When the item is serialized out as xml, its value is "pyraAcctTxMar".</para>
        /// </summary>
        [EnumString("pyraAcctTxMar")]
        PyramidAccentTextMargin,
        /// <summary>
        /// Text Block Direction.
        /// <para>When the item is serialized out as xml, its value is "txBlDir".</para>
        /// </summary>
        [EnumString("txBlDir")]
        TextBlockDirection,
        /// <summary>
        /// Text Anchor Horizontal.
        /// <para>When the item is serialized out as xml, its value is "txAnchorHorz".</para>
        /// </summary>
        [EnumString("txAnchorHorz")]
        TextAnchorHorizontal,
        /// <summary>
        /// Text Anchor Vertical.
        /// <para>When the item is serialized out as xml, its value is "txAnchorVert".</para>
        /// </summary>
        [EnumString("txAnchorVert")]
        TextAnchorVertical,
        /// <summary>
        /// Text Anchor Horizontal With Children.
        /// <para>When the item is serialized out as xml, its value is "txAnchorHorzCh".</para>
        /// </summary>
        [EnumString("txAnchorHorzCh")]
        TextAnchorHorizontalWithChildren,
        /// <summary>
        /// Text Anchor Vertical With Children.
        /// <para>When the item is serialized out as xml, its value is "txAnchorVertCh".</para>
        /// </summary>
        [EnumString("txAnchorVertCh")]
        TextAnchorVerticalWithChildren,
        /// <summary>
        /// Parent Text Left-to-Right Alignment.
        /// <para>When the item is serialized out as xml, its value is "parTxLTRAlign".</para>
        /// </summary>
        [EnumString("parTxLTRAlign")]
        ParentTextLeftToRightAlignment,
        /// <summary>
        /// Parent Text Right-to-Left Alignment.
        /// <para>When the item is serialized out as xml, its value is "parTxRTLAlign".</para>
        /// </summary>
        [EnumString("parTxRTLAlign")]
        ParentTextRightToLeftAlignment,
        /// <summary>
        /// Shape Text Left-to-Right Alignment.
        /// <para>When the item is serialized out as xml, its value is "shpTxLTRAlignCh".</para>
        /// </summary>
        [EnumString("shpTxLTRAlignCh")]
        ShapeTextLeftToRightAlignment,
        /// <summary>
        /// Shape Text Right-to-Left Alignment.
        /// <para>When the item is serialized out as xml, its value is "shpTxRTLAlignCh".</para>
        /// </summary>
        [EnumString("shpTxRTLAlignCh")]
        ShapeTextRightToLeftAlignment,
        /// <summary>
        /// Auto Text Rotation.
        /// <para>When the item is serialized out as xml, its value is "autoTxRot".</para>
        /// </summary>
        [EnumString("autoTxRot")]
        AutoTextRotation,
        /// <summary>
        /// Grow Direction.
        /// <para>When the item is serialized out as xml, its value is "grDir".</para>
        /// </summary>
        [EnumString("grDir")]
        GrowDirection,
        /// <summary>
        /// Flow Direction.
        /// <para>When the item is serialized out as xml, its value is "flowDir".</para>
        /// </summary>
        [EnumString("flowDir")]
        FlowDirection,
        /// <summary>
        /// Continue Direction.
        /// <para>When the item is serialized out as xml, its value is "contDir".</para>
        /// </summary>
        [EnumString("contDir")]
        ContinueDirection,
        /// <summary>
        /// Breakpoint.
        /// <para>When the item is serialized out as xml, its value is "bkpt".</para>
        /// </summary>
        [EnumString("bkpt")]
        Breakpoint,
        /// <summary>
        /// Offset.
        /// <para>When the item is serialized out as xml, its value is "off".</para>
        /// </summary>
        [EnumString("off")]
        Offset,
        /// <summary>
        /// Hierarchy Alignment.
        /// <para>When the item is serialized out as xml, its value is "hierAlign".</para>
        /// </summary>
        [EnumString("hierAlign")]
        HierarchyAlignment,
        /// <summary>
        /// Breakpoint Fixed Value.
        /// <para>When the item is serialized out as xml, its value is "bkPtFixedVal".</para>
        /// </summary>
        [EnumString("bkPtFixedVal")]
        BreakpointFixedValue,
        /// <summary>
        /// Start Bullets At Level.
        /// <para>When the item is serialized out as xml, its value is "stBulletLvl".</para>
        /// </summary>
        [EnumString("stBulletLvl")]
        StartBulletsAtLevel,
        /// <summary>
        /// Start Angle.
        /// <para>When the item is serialized out as xml, its value is "stAng".</para>
        /// </summary>
        [EnumString("stAng")]
        StartAngle,
        /// <summary>
        /// Span Angle.
        /// <para>When the item is serialized out as xml, its value is "spanAng".</para>
        /// </summary>
        [EnumString("spanAng")]
        SpanAngle,
        /// <summary>
        /// Aspect Ratio.
        /// <para>When the item is serialized out as xml, its value is "ar".</para>
        /// </summary>
        [EnumString("ar")]
        AspectRatio,
        /// <summary>
        /// Line Spacing Parent.
        /// <para>When the item is serialized out as xml, its value is "lnSpPar".</para>
        /// </summary>
        [EnumString("lnSpPar")]
        LineSpacingParent,
        /// <summary>
        /// Line Spacing After Parent Paragraph.
        /// <para>When the item is serialized out as xml, its value is "lnSpAfParP".</para>
        /// </summary>
        [EnumString("lnSpAfParP")]
        LineSpacingAfterParentParagraph,
        /// <summary>
        /// Line Spacing Children.
        /// <para>When the item is serialized out as xml, its value is "lnSpCh".</para>
        /// </summary>
        [EnumString("lnSpCh")]
        LineSpacingChildren,
        /// <summary>
        /// Line Spacing After Children Paragraph.
        /// <para>When the item is serialized out as xml, its value is "lnSpAfChP".</para>
        /// </summary>
        [EnumString("lnSpAfChP")]
        LineSpacingAfterChildrenParagraph,
        /// <summary>
        /// Route Shortest Distance.
        /// <para>When the item is serialized out as xml, its value is "rtShortDist".</para>
        /// </summary>
        [EnumString("rtShortDist")]
        RouteShortestDistance,
        /// <summary>
        /// Text Alignment.
        /// <para>When the item is serialized out as xml, its value is "alignTx".</para>
        /// </summary>
        [EnumString("alignTx")]
        TextAlignment,
        /// <summary>
        /// Pyramid Level Node.
        /// <para>When the item is serialized out as xml, its value is "pyraLvlNode".</para>
        /// </summary>
        [EnumString("pyraLvlNode")]
        PyramidLevelNode,
        /// <summary>
        /// Pyramid Accent Background Node.
        /// <para>When the item is serialized out as xml, its value is "pyraAcctBkgdNode".</para>
        /// </summary>
        [EnumString("pyraAcctBkgdNode")]
        PyramidAccentBackgroundNode,
        /// <summary>
        /// Pyramid Accent Text Node.
        /// <para>When the item is serialized out as xml, its value is "pyraAcctTxNode".</para>
        /// </summary>
        [EnumString("pyraAcctTxNode")]
        PyramidAccentTextNode,
        /// <summary>
        /// Source Node.
        /// <para>When the item is serialized out as xml, its value is "srcNode".</para>
        /// </summary>
        [EnumString("srcNode")]
        SourceNode,
        /// <summary>
        /// Destination Node.
        /// <para>When the item is serialized out as xml, its value is "dstNode".</para>
        /// </summary>
        [EnumString("dstNode")]
        DestinationNode,
        /// <summary>
        /// Beginning Points.
        /// <para>When the item is serialized out as xml, its value is "begPts".</para>
        /// </summary>
        [EnumString("begPts")]
        BeginningPoints,
        /// <summary>
        /// End Points.
        /// <para>When the item is serialized out as xml, its value is "endPts".</para>
        /// </summary>
        [EnumString("endPts")]
        EndPoints
    }

    /// <summary>
    /// Function Type
    /// </summary>
    public enum FunctionValues
    {
        /// <summary>
        /// Count.
        /// <para>When the item is serialized out as xml, its value is "cnt".</para>
        /// </summary>
        [EnumString("cnt")]
        Count,
        /// <summary>
        /// Position.
        /// <para>When the item is serialized out as xml, its value is "pos".</para>
        /// </summary>
        [EnumString("pos")]
        Position,
        /// <summary>
        /// Reverse Position.
        /// <para>When the item is serialized out as xml, its value is "revPos".</para>
        /// </summary>
        [EnumString("revPos")]
        ReversePosition,
        /// <summary>
        /// Position Even.
        /// <para>When the item is serialized out as xml, its value is "posEven".</para>
        /// </summary>
        [EnumString("posEven")]
        PositionEven,
        /// <summary>
        /// Position Odd.
        /// <para>When the item is serialized out as xml, its value is "posOdd".</para>
        /// </summary>
        [EnumString("posOdd")]
        PositionOdd,
        /// <summary>
        /// Variable.
        /// <para>When the item is serialized out as xml, its value is "var".</para>
        /// </summary>
        [EnumString("var")]
        Variable,
        /// <summary>
        /// Depth.
        /// <para>When the item is serialized out as xml, its value is "depth".</para>
        /// </summary>
        [EnumString("depth")]
        Depth,
        /// <summary>
        /// Max Depth.
        /// <para>When the item is serialized out as xml, its value is "maxDepth".</para>
        /// </summary>
        [EnumString("maxDepth")]
        MaxDepth
    }

    /// <summary>
    /// Function Operator
    /// </summary>
    public enum FunctionOperatorValues
    {
        /// <summary>
        /// Equal.
        /// <para>When the item is serialized out as xml, its value is "equ".</para>
        /// </summary>
        [EnumString("equ")]
        Equal,
        /// <summary>
        /// Not Equal To.
        /// <para>When the item is serialized out as xml, its value is "neq".</para>
        /// </summary>
        [EnumString("neq")]
        NotEqualTo,
        /// <summary>
        /// Greater Than.
        /// <para>When the item is serialized out as xml, its value is "gt".</para>
        /// </summary>
        [EnumString("gt")]
        GreaterThan,
        /// <summary>
        /// Less Than.
        /// <para>When the item is serialized out as xml, its value is "lt".</para>
        /// </summary>
        [EnumString("lt")]
        LessThan,
        /// <summary>
        /// Greater Than or Equal to.
        /// <para>When the item is serialized out as xml, its value is "gte".</para>
        /// </summary>
        [EnumString("gte")]
        GreaterThanOrEqualTo,
        /// <summary>
        /// Less Than or Equal to.
        /// <para>When the item is serialized out as xml, its value is "lte".</para>
        /// </summary>
        [EnumString("lte")]
        LessThanOrEqualTo
    }

    /// <summary>
    /// Horizontal Alignment
    /// </summary>
    public enum HorizontalAlignmentValues
    {
        /// <summary>
        /// Left.
        /// <para>When the item is serialized out as xml, its value is "l".</para>
        /// </summary>
        [EnumString("l")]
        Left,
        /// <summary>
        /// Center.
        /// <para>When the item is serialized out as xml, its value is "ctr".</para>
        /// </summary>
        [EnumString("ctr")]
        Center,
        /// <summary>
        /// Right.
        /// <para>When the item is serialized out as xml, its value is "r".</para>
        /// </summary>
        [EnumString("r")]
        Right,
        /// <summary>
        /// None.
        /// <para>When the item is serialized out as xml, its value is "none".</para>
        /// </summary>
        [EnumString("none")]
        None
    }

    /// <summary>
    /// Child Direction
    /// </summary>
    public enum ChildDirectionValues
    {
        /// <summary>
        /// Horizontal.
        /// <para>When the item is serialized out as xml, its value is "horz".</para>
        /// </summary>
        [EnumString("horz")]
        Horizontal,
        /// <summary>
        /// Vertical.
        /// <para>When the item is serialized out as xml, its value is "vert".</para>
        /// </summary>
        [EnumString("vert")]
        Vertical
    }

    /// <summary>
    /// Child Alignment
    /// </summary>
    public enum ChildAlignmentValues
    {
        /// <summary>
        /// Top.
        /// <para>When the item is serialized out as xml, its value is "t".</para>
        /// </summary>
        [EnumString("t")]
        Top,
        /// <summary>
        /// Bottom.
        /// <para>When the item is serialized out as xml, its value is "b".</para>
        /// </summary>
        [EnumString("b")]
        Bottom,
        /// <summary>
        /// Left.
        /// <para>When the item is serialized out as xml, its value is "l".</para>
        /// </summary>
        [EnumString("l")]
        Left,
        /// <summary>
        /// Right.
        /// <para>When the item is serialized out as xml, its value is "r".</para>
        /// </summary>
        [EnumString("r")]
        Right
    }

    /// <summary>
    /// Secondary Child Alignment
    /// </summary>
    public enum SecondaryChildAlignmentValues
    {
        /// <summary>
        /// None.
        /// <para>When the item is serialized out as xml, its value is "none".</para>
        /// </summary>
        [EnumString("none")]
        None,
        /// <summary>
        /// Top.
        /// <para>When the item is serialized out as xml, its value is "t".</para>
        /// </summary>
        [EnumString("t")]
        Top,
        /// <summary>
        /// Bottom.
        /// <para>When the item is serialized out as xml, its value is "b".</para>
        /// </summary>
        [EnumString("b")]
        Bottom,
        /// <summary>
        /// Left.
        /// <para>When the item is serialized out as xml, its value is "l".</para>
        /// </summary>
        [EnumString("l")]
        Left,
        /// <summary>
        /// Right.
        /// <para>When the item is serialized out as xml, its value is "r".</para>
        /// </summary>
        [EnumString("r")]
        Right
    }

    /// <summary>
    /// Linear Direction
    /// </summary>
    public enum LinearDirectionValues
    {
        /// <summary>
        /// From Left.
        /// <para>When the item is serialized out as xml, its value is "fromL".</para>
        /// </summary>
        [EnumString("fromL")]
        FromLeft,
        /// <summary>
        /// From Right.
        /// <para>When the item is serialized out as xml, its value is "fromR".</para>
        /// </summary>
        [EnumString("fromR")]
        FromRight,
        /// <summary>
        /// From Top.
        /// <para>When the item is serialized out as xml, its value is "fromT".</para>
        /// </summary>
        [EnumString("fromT")]
        FromTop,
        /// <summary>
        /// From Bottom.
        /// <para>When the item is serialized out as xml, its value is "fromB".</para>
        /// </summary>
        [EnumString("fromB")]
        FromBottom
    }

    /// <summary>
    /// Secondary Linear Direction
    /// </summary>
    public enum SecondaryLinearDirectionValues
    {
        /// <summary>
        /// None.
        /// <para>When the item is serialized out as xml, its value is "none".</para>
        /// </summary>
        [EnumString("none")]
        None,
        /// <summary>
        /// From Left.
        /// <para>When the item is serialized out as xml, its value is "fromL".</para>
        /// </summary>
        [EnumString("fromL")]
        FromLeft,
        /// <summary>
        /// From Right.
        /// <para>When the item is serialized out as xml, its value is "fromR".</para>
        /// </summary>
        [EnumString("fromR")]
        FromRight,
        /// <summary>
        /// From Top.
        /// <para>When the item is serialized out as xml, its value is "fromT".</para>
        /// </summary>
        [EnumString("fromT")]
        FromTop,
        /// <summary>
        /// From Bottom.
        /// <para>When the item is serialized out as xml, its value is "fromB".</para>
        /// </summary>
        [EnumString("fromB")]
        FromBottom
    }

    /// <summary>
    /// Starting Element
    /// </summary>
    public enum StartingElementValues
    {
        /// <summary>
        /// Node.
        /// <para>When the item is serialized out as xml, its value is "node".</para>
        /// </summary>
        [EnumString("node")]
        Node,
        /// <summary>
        /// Transition.
        /// <para>When the item is serialized out as xml, its value is "trans".</para>
        /// </summary>
        [EnumString("trans")]
        Transition
    }

    /// <summary>
    /// Rotation Path
    /// </summary>
    public enum RotationPathValues
    {
        /// <summary>
        /// None.
        /// <para>When the item is serialized out as xml, its value is "none".</para>
        /// </summary>
        [EnumString("none")]
        None,
        /// <summary>
        /// Along Path.
        /// <para>When the item is serialized out as xml, its value is "alongPath".</para>
        /// </summary>
        [EnumString("alongPath")]
        AlongPath
    }

    /// <summary>
    /// Center Shape Mapping
    /// </summary>
    public enum CenterShapeMappingValues
    {
        /// <summary>
        /// None.
        /// <para>When the item is serialized out as xml, its value is "none".</para>
        /// </summary>
        [EnumString("none")]
        None,
        /// <summary>
        /// First Node.
        /// <para>When the item is serialized out as xml, its value is "fNode".</para>
        /// </summary>
        [EnumString("fNode")]
        FirstNode
    }

    /// <summary>
    /// Bend Point
    /// </summary>
    public enum BendPointValues
    {
        /// <summary>
        /// Beginning.
        /// <para>When the item is serialized out as xml, its value is "beg".</para>
        /// </summary>
        [EnumString("beg")]
        Beginning,
        /// <summary>
        /// Default.
        /// <para>When the item is serialized out as xml, its value is "def".</para>
        /// </summary>
        [EnumString("def")]
        Default,
        /// <summary>
        /// End.
        /// <para>When the item is serialized out as xml, its value is "end".</para>
        /// </summary>
        [EnumString("end")]
        End
    }

    /// <summary>
    /// Connector Routing
    /// </summary>
    public enum ConnectorRoutingValues
    {
        /// <summary>
        /// Straight.
        /// <para>When the item is serialized out as xml, its value is "stra".</para>
        /// </summary>
        [EnumString("stra")]
        Straight,
        /// <summary>
        /// Bending.
        /// <para>When the item is serialized out as xml, its value is "bend".</para>
        /// </summary>
        [EnumString("bend")]
        Bending,
        /// <summary>
        /// Curve.
        /// <para>When the item is serialized out as xml, its value is "curve".</para>
        /// </summary>
        [EnumString("curve")]
        Curve,
        /// <summary>
        /// Long Curve.
        /// <para>When the item is serialized out as xml, its value is "longCurve".</para>
        /// </summary>
        [EnumString("longCurve")]
        LongCurve
    }

    /// <summary>
    /// Arrowhead Styles
    /// </summary>
    public enum ArrowheadStyleValues
    {
        /// <summary>
        /// Auto.
        /// <para>When the item is serialized out as xml, its value is "auto".</para>
        /// </summary>
        [EnumString("auto")]
        Auto,
        /// <summary>
        /// Arrowhead Present.
        /// <para>When the item is serialized out as xml, its value is "arr".</para>
        /// </summary>
        [EnumString("arr")]
        Arrow,
        /// <summary>
        /// No Arrowhead.
        /// <para>When the item is serialized out as xml, its value is "noArr".</para>
        /// </summary>
        [EnumString("noArr")]
        NoArrow
    }

    /// <summary>
    /// Connector Dimension
    /// </summary>
    public enum ConnectorDimensionValues
    {
        /// <summary>
        /// 1 Dimension.
        /// <para>When the item is serialized out as xml, its value is "1D".</para>
        /// </summary>
        [EnumString("1D")]
        OneDimension,
        /// <summary>
        /// 2 Dimensions.
        /// <para>When the item is serialized out as xml, its value is "2D".</para>
        /// </summary>
        [EnumString("2D")]
        TwoDimension,
        /// <summary>
        /// Custom.
        /// <para>When the item is serialized out as xml, its value is "cust".</para>
        /// </summary>
        [EnumString("cust")]
        Custom
    }

    /// <summary>
    /// Connector Point
    /// </summary>
    public enum ConnectorPointValues
    {
        /// <summary>
        /// Auto.
        /// <para>When the item is serialized out as xml, its value is "auto".</para>
        /// </summary>
        [EnumString("auto")]
        Auto,
        /// <summary>
        /// Bottom Center.
        /// <para>When the item is serialized out as xml, its value is "bCtr".</para>
        /// </summary>
        [EnumString("bCtr")]
        BottomCenter,
        /// <summary>
        /// Center.
        /// <para>When the item is serialized out as xml, its value is "ctr".</para>
        /// </summary>
        [EnumString("ctr")]
        Center,
        /// <summary>
        /// Middle Left.
        /// <para>When the item is serialized out as xml, its value is "midL".</para>
        /// </summary>
        [EnumString("midL")]
        MiddleLeft,
        /// <summary>
        /// Middle Right.
        /// <para>When the item is serialized out as xml, its value is "midR".</para>
        /// </summary>
        [EnumString("midR")]
        MiddleRight,
        /// <summary>
        /// Top Center.
        /// <para>When the item is serialized out as xml, its value is "tCtr".</para>
        /// </summary>
        [EnumString("tCtr")]
        TopCenter,
        /// <summary>
        /// Bottom Left.
        /// <para>When the item is serialized out as xml, its value is "bL".</para>
        /// </summary>
        [EnumString("bL")]
        BottomLeft,
        /// <summary>
        /// Bottom Right.
        /// <para>When the item is serialized out as xml, its value is "bR".</para>
        /// </summary>
        [EnumString("bR")]
        BottomRight,
        /// <summary>
        /// Top Left.
        /// <para>When the item is serialized out as xml, its value is "tL".</para>
        /// </summary>
        [EnumString("tL")]
        TopLeft,
        /// <summary>
        /// Top Right.
        /// <para>When the item is serialized out as xml, its value is "tR".</para>
        /// </summary>
        [EnumString("tR")]
        TopRight,
        /// <summary>
        /// Radial.
        /// <para>When the item is serialized out as xml, its value is "radial".</para>
        /// </summary>
        [EnumString("radial")]
        Radial
    }

    /// <summary>
    /// Node Horizontal Alignment
    /// </summary>
    public enum NodeHorizontalAlignmentValues
    {
        /// <summary>
        /// Left.
        /// <para>When the item is serialized out as xml, its value is "l".</para>
        /// </summary>
        [EnumString("l")]
        Left,
        /// <summary>
        /// Center.
        /// <para>When the item is serialized out as xml, its value is "ctr".</para>
        /// </summary>
        [EnumString("ctr")]
        Center,
        /// <summary>
        /// Right.
        /// <para>When the item is serialized out as xml, its value is "r".</para>
        /// </summary>
        [EnumString("r")]
        Right
    }

    /// <summary>
    /// Node Vertical Alignment
    /// </summary>
    public enum NodeVerticalAlignmentValues
    {
        /// <summary>
        /// Top.
        /// <para>When the item is serialized out as xml, its value is "t".</para>
        /// </summary>
        [EnumString("t")]
        Top,
        /// <summary>
        /// Middle.
        /// <para>When the item is serialized out as xml, its value is "mid".</para>
        /// </summary>
        [EnumString("mid")]
        Middle,
        /// <summary>
        /// Bottom.
        /// <para>When the item is serialized out as xml, its value is "b".</para>
        /// </summary>
        [EnumString("b")]
        Bottom
    }

    /// <summary>
    /// Fallback Dimension
    /// </summary>
    public enum FallbackDimensionValues
    {
        /// <summary>
        /// 1 Dimension.
        /// <para>When the item is serialized out as xml, its value is "1D".</para>
        /// </summary>
        [EnumString("1D")]
        OneDimension,
        /// <summary>
        /// 2 Dimensions.
        /// <para>When the item is serialized out as xml, its value is "2D".</para>
        /// </summary>
        [EnumString("2D")]
        TwoDimension
    }

    /// <summary>
    /// Text Direction
    /// </summary>
    public enum TextDirectionValues
    {
        /// <summary>
        /// From Top.
        /// <para>When the item is serialized out as xml, its value is "fromT".</para>
        /// </summary>
        [EnumString("fromT")]
        FromTop,
        /// <summary>
        /// From Bottom.
        /// <para>When the item is serialized out as xml, its value is "fromB".</para>
        /// </summary>
        [EnumString("fromB")]
        FromBottom
    }

    /// <summary>
    /// Pyramid Accent Position
    /// </summary>
    public enum PyramidAccentPositionValues
    {
        /// <summary>
        /// Before.
        /// <para>When the item is serialized out as xml, its value is "bef".</para>
        /// </summary>
        [EnumString("bef")]
        Before,
        /// <summary>
        /// Pyramid Accent After.
        /// <para>When the item is serialized out as xml, its value is "aft".</para>
        /// </summary>
        [EnumString("aft")]
        After
    }

    /// <summary>
    /// Pyramid Accent Text Margin
    /// </summary>
    public enum PyramidAccentTextMarginValues
    {
        /// <summary>
        /// Step.
        /// <para>When the item is serialized out as xml, its value is "step".</para>
        /// </summary>
        [EnumString("step")]
        Step,
        /// <summary>
        /// Stack.
        /// <para>When the item is serialized out as xml, its value is "stack".</para>
        /// </summary>
        [EnumString("stack")]
        Stack
    }

    /// <summary>
    /// Text Block Direction
    /// </summary>
    public enum TextBlockDirectionValues
    {
        /// <summary>
        /// Horizontal.
        /// <para>When the item is serialized out as xml, its value is "horz".</para>
        /// </summary>
        [EnumString("horz")]
        Horizontal,
        /// <summary>
        /// Vertical Direction.
        /// <para>When the item is serialized out as xml, its value is "vert".</para>
        /// </summary>
        [EnumString("vert")]
        Vertical
    }

    /// <summary>
    /// Text Anchor Horizontal
    /// </summary>
    public enum TextAnchorHorizontalValues
    {
        /// <summary>
        /// None.
        /// <para>When the item is serialized out as xml, its value is "none".</para>
        /// </summary>
        [EnumString("none")]
        None,
        /// <summary>
        /// Center.
        /// <para>When the item is serialized out as xml, its value is "ctr".</para>
        /// </summary>
        [EnumString("ctr")]
        Center
    }

    /// <summary>
    /// Text Anchor Vertical
    /// </summary>
    public enum TextAnchorVerticalValues
    {
        /// <summary>
        /// Top.
        /// <para>When the item is serialized out as xml, its value is "t".</para>
        /// </summary>
        [EnumString("t")]
        Top,
        /// <summary>
        /// Middle.
        /// <para>When the item is serialized out as xml, its value is "mid".</para>
        /// </summary>
        [EnumString("mid")]
        Middle,
        /// <summary>
        /// Bottom.
        /// <para>When the item is serialized out as xml, its value is "b".</para>
        /// </summary>
        [EnumString("b")]
        Bottom
    }

    /// <summary>
    /// Text Alignment
    /// </summary>
    public enum TextAlignmentValues
    {
        /// <summary>
        /// Left.
        /// <para>When the item is serialized out as xml, its value is "l".</para>
        /// </summary>
        [EnumString("l")]
        Left,
        /// <summary>
        /// Center.
        /// <para>When the item is serialized out as xml, its value is "ctr".</para>
        /// </summary>
        [EnumString("ctr")]
        Center,
        /// <summary>
        /// Right.
        /// <para>When the item is serialized out as xml, its value is "r".</para>
        /// </summary>
        [EnumString("r")]
        Right
    }

    /// <summary>
    /// Auto Text Rotation
    /// </summary>
    public enum AutoTextRotationValues
    {
        /// <summary>
        /// None.
        /// <para>When the item is serialized out as xml, its value is "none".</para>
        /// </summary>
        [EnumString("none")]
        None,
        /// <summary>
        /// Upright.
        /// <para>When the item is serialized out as xml, its value is "upr".</para>
        /// </summary>
        [EnumString("upr")]
        Upright,
        /// <summary>
        /// Gravity.
        /// <para>When the item is serialized out as xml, its value is "grav".</para>
        /// </summary>
        [EnumString("grav")]
        Gravity
    }

    /// <summary>
    /// Grow Direction
    /// </summary>
    public enum GrowDirectionValues
    {
        /// <summary>
        /// Top Left.
        /// <para>When the item is serialized out as xml, its value is "tL".</para>
        /// </summary>
        [EnumString("tL")]
        TopLeft,
        /// <summary>
        /// Top Right.
        /// <para>When the item is serialized out as xml, its value is "tR".</para>
        /// </summary>
        [EnumString("tR")]
        TopRight,
        /// <summary>
        /// Bottom Left.
        /// <para>When the item is serialized out as xml, its value is "bL".</para>
        /// </summary>
        [EnumString("bL")]
        BottomLeft,
        /// <summary>
        /// Bottom Right.
        /// <para>When the item is serialized out as xml, its value is "bR".</para>
        /// </summary>
        [EnumString("bR")]
        BottomRight
    }

    /// <summary>
    /// Flow Direction
    /// </summary>
    public enum FlowDirectionValues
    {
        /// <summary>
        /// Row.
        /// <para>When the item is serialized out as xml, its value is "row".</para>
        /// </summary>
        [EnumString("row")]
        Row,
        /// <summary>
        /// Column.
        /// <para>When the item is serialized out as xml, its value is "col".</para>
        /// </summary>
        [EnumString("col")]
        Column
    }

    /// <summary>
    /// Continue Direction
    /// </summary>
    public enum ContinueDirectionValues
    {
        /// <summary>
        /// Reverse Direction.
        /// <para>When the item is serialized out as xml, its value is "revDir".</para>
        /// </summary>
        [EnumString("revDir")]
        ReverseDirection,
        /// <summary>
        /// Same Direction.
        /// <para>When the item is serialized out as xml, its value is "sameDir".</para>
        /// </summary>
        [EnumString("sameDir")]
        SameDirection
    }

    /// <summary>
    /// Breakpoint
    /// </summary>
    public enum BreakpointValues
    {
        /// <summary>
        /// End of Canvas.
        /// <para>When the item is serialized out as xml, its value is "endCnv".</para>
        /// </summary>
        [EnumString("endCnv")]
        EndCanvas,
        /// <summary>
        /// Balanced.
        /// <para>When the item is serialized out as xml, its value is "bal".</para>
        /// </summary>
        [EnumString("bal")]
        Balanced,
        /// <summary>
        /// Fixed.
        /// <para>When the item is serialized out as xml, its value is "fixed".</para>
        /// </summary>
        [EnumString("fixed")]
        Fixed
    }

    /// <summary>
    /// Offset
    /// </summary>
    public enum OffsetValues
    {
        /// <summary>
        /// Center.
        /// <para>When the item is serialized out as xml, its value is "ctr".</para>
        /// </summary>
        [EnumString("ctr")]
        Center,
        /// <summary>
        /// Offset.
        /// <para>When the item is serialized out as xml, its value is "off".</para>
        /// </summary>
        [EnumString("off")]
        Offset
    }

    /// <summary>
    /// Hierarchy Alignment
    /// </summary>
    public enum HierarchyAlignmentValues
    {
        /// <summary>
        /// Top Left.
        /// <para>When the item is serialized out as xml, its value is "tL".</para>
        /// </summary>
        [EnumString("tL")]
        TopLeft,
        /// <summary>
        /// Top Right.
        /// <para>When the item is serialized out as xml, its value is "tR".</para>
        /// </summary>
        [EnumString("tR")]
        TopRight,
        /// <summary>
        /// Top Center Children.
        /// <para>When the item is serialized out as xml, its value is "tCtrCh".</para>
        /// </summary>
        [EnumString("tCtrCh")]
        TopCenterChildren,
        /// <summary>
        /// Top Center Descendants.
        /// <para>When the item is serialized out as xml, its value is "tCtrDes".</para>
        /// </summary>
        [EnumString("tCtrDes")]
        TopCenterDescendants,
        /// <summary>
        /// Bottom Left.
        /// <para>When the item is serialized out as xml, its value is "bL".</para>
        /// </summary>
        [EnumString("bL")]
        BottomLeft,
        /// <summary>
        /// Bottom Right.
        /// <para>When the item is serialized out as xml, its value is "bR".</para>
        /// </summary>
        [EnumString("bR")]
        BottomRight,
        /// <summary>
        /// Bottom Center Child.
        /// <para>When the item is serialized out as xml, its value is "bCtrCh".</para>
        /// </summary>
        [EnumString("bCtrCh")]
        BottomCenterChild,
        /// <summary>
        /// Bottom Center Descendant.
        /// <para>When the item is serialized out as xml, its value is "bCtrDes".</para>
        /// </summary>
        [EnumString("bCtrDes")]
        BottomCenterDescendant,
        /// <summary>
        /// Left Top.
        /// <para>When the item is serialized out as xml, its value is "lT".</para>
        /// </summary>
        [EnumString("lT")]
        LeftTop,
        /// <summary>
        /// Left Bottom.
        /// <para>When the item is serialized out as xml, its value is "lB".</para>
        /// </summary>
        [EnumString("lB")]
        LeftBottom,
        /// <summary>
        /// Left Center Child.
        /// <para>When the item is serialized out as xml, its value is "lCtrCh".</para>
        /// </summary>
        [EnumString("lCtrCh")]
        LeftCenterChild,
        /// <summary>
        /// Left Center Descendant.
        /// <para>When the item is serialized out as xml, its value is "lCtrDes".</para>
        /// </summary>
        [EnumString("lCtrDes")]
        LeftCenterDescendant,
        /// <summary>
        /// Right Top.
        /// <para>When the item is serialized out as xml, its value is "rT".</para>
        /// </summary>
        [EnumString("rT")]
        RightTop,
        /// <summary>
        /// Right Bottom.
        /// <para>When the item is serialized out as xml, its value is "rB".</para>
        /// </summary>
        [EnumString("rB")]
        RightBottom,
        /// <summary>
        /// Right Center Children.
        /// <para>When the item is serialized out as xml, its value is "rCtrCh".</para>
        /// </summary>
        [EnumString("rCtrCh")]
        RightCenterChildren,
        /// <summary>
        /// Right Center Descendants.
        /// <para>When the item is serialized out as xml, its value is "rCtrDes".</para>
        /// </summary>
        [EnumString("rCtrDes")]
        RightCenterDescendants
    }

    /// <summary>
    /// Variable Type
    /// </summary>
    public enum VariableValues
    {
        /// <summary>
        /// Unknown.
        /// <para>When the item is serialized out as xml, its value is "none".</para>
        /// </summary>
        [EnumString("none")]
        None,
        /// <summary>
        /// Organizational Chart Algorithm.
        /// <para>When the item is serialized out as xml, its value is "orgChart".</para>
        /// </summary>
        [EnumString("orgChart")]
        OrganizationalChart,
        /// <summary>
        /// Child Max.
        /// <para>When the item is serialized out as xml, its value is "chMax".</para>
        /// </summary>
        [EnumString("chMax")]
        ChildMax,
        /// <summary>
        /// Child Preference.
        /// <para>When the item is serialized out as xml, its value is "chPref".</para>
        /// </summary>
        [EnumString("chPref")]
        ChildPreference,
        /// <summary>
        /// Bullets Enabled.
        /// <para>When the item is serialized out as xml, its value is "bulEnabled".</para>
        /// </summary>
        [EnumString("bulEnabled")]
        BulletsEnabled,
        /// <summary>
        /// Direction.
        /// <para>When the item is serialized out as xml, its value is "dir".</para>
        /// </summary>
        [EnumString("dir")]
        Direction,
        /// <summary>
        /// Hierarchy Branch.
        /// <para>When the item is serialized out as xml, its value is "hierBranch".</para>
        /// </summary>
        [EnumString("hierBranch")]
        HierarchyBranch,
        /// <summary>
        /// Animate One.
        /// <para>When the item is serialized out as xml, its value is "animOne".</para>
        /// </summary>
        [EnumString("animOne")]
        AnimateOne,
        /// <summary>
        /// Animation Level.
        /// <para>When the item is serialized out as xml, its value is "animLvl".</para>
        /// </summary>
        [EnumString("animLvl")]
        AnimationLevel,
        /// <summary>
        /// Resize Handles.
        /// <para>When the item is serialized out as xml, its value is "resizeHandles".</para>
        /// </summary>
        [EnumString("resizeHandles")]
        ResizeHandles
    }

    /// <summary>
    /// Output Shape Type
    /// </summary>
    public enum OutputShapeValues
    {
        /// <summary>
        /// None.
        /// <para>When the item is serialized out as xml, its value is "none".</para>
        /// </summary>
        [EnumString("none")]
        None,
        /// <summary>
        /// Connection.
        /// <para>When the item is serialized out as xml, its value is "conn".</para>
        /// </summary>
        [EnumString("conn")]
        Connection
    }

    /// <summary>
    /// Vertical Alignment
    /// </summary>
    public enum VerticalAlignmentValues
    {
        /// <summary>
        /// Top.
        /// <para>When the item is serialized out as xml, its value is "t".</para>
        /// </summary>
        [EnumString("t")]
        Top,
        /// <summary>
        /// Middle.
        /// <para>When the item is serialized out as xml, its value is "mid".</para>
        /// </summary>
        [EnumString("mid")]
        Middle,
        /// <summary>
        /// Bottom.
        /// <para>When the item is serialized out as xml, its value is "b".</para>
        /// </summary>
        [EnumString("b")]
        Bottom,
        /// <summary>
        /// None.
        /// <para>When the item is serialized out as xml, its value is "none".</para>
        /// </summary>
        [EnumString("none")]
        None,
        /// <summary>
        /// top.
        /// <para>When the item is serialized out as xml, its value is "top".</para>
        /// <para>This item is only available in Office 2010 and later.</para>
        /// </summary>
        [EnumString("top")]
        [OfficeAvailability(FileFormatVersions.Office2007)]
        Top2010,
        /// <summary>
        /// center.
        /// <para>When the item is serialized out as xml, its value is "center".</para>
        /// <para>This item is only available in Office 2010 and later.</para>
        /// </summary>
        [EnumString("center")]
        [OfficeAvailability(FileFormatVersions.Office2007)]
        Middle2010,
        /// <summary>
        /// bottom.
        /// <para>When the item is serialized out as xml, its value is "bottom".</para>
        /// <para>This item is only available in Office 2010 and later.</para>
        /// </summary>
        [EnumString("bottom")]
        [OfficeAvailability(FileFormatVersions.Office2007)]
        Bottom2010
    }
}