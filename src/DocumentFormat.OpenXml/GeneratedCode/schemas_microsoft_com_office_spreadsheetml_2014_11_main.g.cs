﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

#nullable enable

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Framework.Metadata;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml.Validation.Schema;
using System;
using System.Collections.Generic;
using System.IO.Packaging;

namespace DocumentFormat.OpenXml.Office2016.ExcelAc
{
    /// <summary>
    /// <para>Defines the ModelTimeGroupings Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x16:modelTimeGroupings.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.ExcelAc.ModelTimeGrouping" /> <c>&lt;x16:modelTimeGrouping></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("x16:modelTimeGroupings")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class ModelTimeGroupings : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ModelTimeGroupings class.
        /// </summary>
        public ModelTimeGroupings() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ModelTimeGroupings class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ModelTimeGroupings(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ModelTimeGroupings class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ModelTimeGroupings(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ModelTimeGroupings class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ModelTimeGroupings(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("x16:modelTimeGroupings");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddChild<DocumentFormat.OpenXml.Office2016.ExcelAc.ModelTimeGrouping>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.ExcelAc.ModelTimeGrouping), 1, 0, version: FileFormatVersions.Office2016)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ModelTimeGroupings>(deep);
    }

    /// <summary>
    /// <para>Defines the ModelTimeGrouping Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x16:modelTimeGrouping.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.ExcelAc.CalculatedTimeColumn" /> <c>&lt;x16:calculatedTimeColumn></c></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("x16:modelTimeGrouping")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class ModelTimeGrouping : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ModelTimeGrouping class.
        /// </summary>
        public ModelTimeGrouping() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ModelTimeGrouping class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ModelTimeGrouping(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ModelTimeGrouping class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ModelTimeGrouping(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ModelTimeGrouping class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ModelTimeGrouping(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>tableName, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: tableName</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("tableName")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? TableName
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>columnName, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: columnName</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("columnName")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? ColumnName
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>columnId, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: columnId</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("columnId")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? ColumnId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("x16:modelTimeGrouping");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddChild<DocumentFormat.OpenXml.Office2016.ExcelAc.CalculatedTimeColumn>();
            builder.AddElement<ModelTimeGrouping>()
.AddAttribute("tableName", a => a.TableName, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute("columnName", a => a.ColumnName, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute("columnId", a => a.ColumnId, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
});
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.ExcelAc.CalculatedTimeColumn), 1, 0, version: FileFormatVersions.Office2016)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ModelTimeGrouping>(deep);
    }

    /// <summary>
    /// <para>Defines the CalculatedTimeColumn Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x16:calculatedTimeColumn.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("x16:calculatedTimeColumn")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class CalculatedTimeColumn : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the CalculatedTimeColumn class.
        /// </summary>
        public CalculatedTimeColumn() : base()
        {
        }

        /// <summary>
        /// <para>columnName, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: columnName</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("columnName")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? ColumnName
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>columnId, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: columnId</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("columnId")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? ColumnId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>contentType, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: contentType</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("contentType")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Office2016.ExcelAc.ModelTimeGroupingContentType>? ContentType
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2016.ExcelAc.ModelTimeGroupingContentType>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>isSelected, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: isSelected</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("isSelected")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? IsSelected
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("x16:calculatedTimeColumn");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddElement<CalculatedTimeColumn>()
.AddAttribute("columnName", a => a.ColumnName, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute("columnId", a => a.ColumnId, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute("contentType", a => a.ContentType, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute("isSelected", a => a.IsSelected, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<CalculatedTimeColumn>(deep);
    }

    /// <summary>
    /// Defines the ModelTimeGroupingContentType enumeration.
    /// </summary>
    public enum ModelTimeGroupingContentType
    {
        /// <summary>
        /// years.
        /// <para>When the item is serialized out as xml, its value is "years".</para>
        /// </summary>
        [EnumString("years")]
        Years,
        /// <summary>
        /// quarters.
        /// <para>When the item is serialized out as xml, its value is "quarters".</para>
        /// </summary>
        [EnumString("quarters")]
        Quarters,
        /// <summary>
        /// monthsindex.
        /// <para>When the item is serialized out as xml, its value is "monthsindex".</para>
        /// </summary>
        [EnumString("monthsindex")]
        Monthsindex,
        /// <summary>
        /// months.
        /// <para>When the item is serialized out as xml, its value is "months".</para>
        /// </summary>
        [EnumString("months")]
        Months,
        /// <summary>
        /// daysindex.
        /// <para>When the item is serialized out as xml, its value is "daysindex".</para>
        /// </summary>
        [EnumString("daysindex")]
        Daysindex,
        /// <summary>
        /// days.
        /// <para>When the item is serialized out as xml, its value is "days".</para>
        /// </summary>
        [EnumString("days")]
        Days,
        /// <summary>
        /// hours.
        /// <para>When the item is serialized out as xml, its value is "hours".</para>
        /// </summary>
        [EnumString("hours")]
        Hours,
        /// <summary>
        /// minutes.
        /// <para>When the item is serialized out as xml, its value is "minutes".</para>
        /// </summary>
        [EnumString("minutes")]
        Minutes,
        /// <summary>
        /// seconds.
        /// <para>When the item is serialized out as xml, its value is "seconds".</para>
        /// </summary>
        [EnumString("seconds")]
        Seconds
    }
}