﻿// <auto-generated/>

// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

#nullable enable

using DocumentFormat.OpenXml.Features;
using DocumentFormat.OpenXml.Framework;
using System;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Packaging
{
    /// <summary>
    /// Defines the RdRichValueTypesPart
    /// </summary>
    public partial class RdRichValueTypesPart : OpenXmlPart,
        IFixedContentTypePart
    {
        internal const string ContentTypeConstant = "application/vnd.ms-excel.rdrichvaluetypes+xml";
        internal const string RelationshipTypeConstant = "http://schemas.microsoft.com/office/2017/06/relationships/rdRichValueTypes";
        private DocumentFormat.OpenXml.Office2019.Excel.RichData2.RichValueTypesInfo? _rootElement;

        /// <summary>
        /// Creates an instance of the RdRichValueTypesPart OpenXmlType
        /// </summary>
        internal RdRichValueTypesPart()
        {
        }

        /// <inheritdoc/>
        public sealed override string ContentType => ContentTypeConstant;

        private protected override OpenXmlPartRootElement? InternalRootElement
        {
            get
            {
                return _rootElement;
            }

            set
            {
                _rootElement = value as DocumentFormat.OpenXml.Office2019.Excel.RichData2.RichValueTypesInfo;
            }
        }

        internal override OpenXmlPartRootElement? PartRootElement => RichValueTypesInfo;

        /// <inheritdoc/>
        public sealed override string RelationshipType => RelationshipTypeConstant;

        /// <summary>
        /// Gets or sets the root element of this part.
        /// </summary>
        public DocumentFormat.OpenXml.Office2019.Excel.RichData2.RichValueTypesInfo RichValueTypesInfo
        {
            get
            {
                if (_rootElement is null)
                {
                    LoadDomTree<DocumentFormat.OpenXml.Office2019.Excel.RichData2.RichValueTypesInfo>();
                }

                return _rootElement!;
            }

            set
            {
                if (value is null)
                {
                    throw new ArgumentNullException(nameof(value));
                }

                SetDomTree(value);
            }
        }

        internal override bool IsInVersion(FileFormatVersions version)
        {
            return version.AtLeast(FileFormatVersions.Office2019);
        }
        
        /// <inheritdoc/>
        public override IFeatureCollection Features => _features ??= new GeneratedFeatures(this);
        
        private sealed class GeneratedFeatures : TypedPartFeatureCollection, ITargetFeature
        {
            public GeneratedFeatures(OpenXmlPart part) : base(part) { }
            string ITargetFeature.Name => "rdRichValueTypes";
            string ITargetFeature.Path => "richData";
        }
    
    }
}